using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form4 : Form
    {
        private Form2 form2Reference;

        public Form4(Form2 form2)
        {
            InitializeComponent();
            form2Reference = form2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int billNo;
            if (int.TryParse(billNoTextBox.Text, out billNo))
            {

                using (SqlConnection connection = new SqlConnection(@"Data Source=....;Initial Catalog=DbCafe;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();

                        float totalAmount = 0;
                        using (SqlCommand totalAmountCommand = new SqlCommand("SELECT TotalAmount FROM BillTable WHERE BillId = @BillId", connection))
                        {
                            totalAmountCommand.Parameters.AddWithValue("@BillId", billNo);
                            object result = totalAmountCommand.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                totalAmount = Convert.ToSingle(result);
                            }
                        }

                        totalAmountLabel.Text = totalAmount.ToString("C");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (connection != null && connection.State != ConnectionState.Closed)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Bill No. Please enter a valid Bill No.");
            }
        }

        private void payButton2_Click(object sender, EventArgs e)
        {
            int billNo;
            if (int.TryParse(billNoTextBox.Text, out billNo))
            {
                using (SqlConnection connec4 = new SqlConnection(@"Data Source=DESKTOP-CTJE87C\SQLEXPRESS;Initial Catalog=DbCafe;Integrated Security=True"))
                {
                    try
                    {
                        connec4.Open();

                        int tableId = -1;
                        using (SqlCommand tableIdCommand = new SqlCommand("SELECT TableId FROM BillTable WHERE BillId = @BillId", connec4))
                        {
                            tableIdCommand.Parameters.AddWithValue("@BillId", billNo);
                            object result = tableIdCommand.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                tableId = Convert.ToInt32(result);
                            }
                        }

                        // Eğer TableId bulunduysa ve geçerli bir değere sahipse
                        if (tableId != -1)
                        {
                            // IsOpen özelliğini 0 yapmak için bir UPDATE sorgusu çalıştırın
                            using (SqlCommand updateIsOpenCommand = new SqlCommand("UPDATE TableTable SET IsOpen = 1 WHERE TableId = @TableId", connec4))
                            {
                                updateIsOpenCommand.Parameters.AddWithValue("@TableId", tableId);
                                updateIsOpenCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Bill has been paid.");
                        
                        }
                        else
                        {
                            MessageBox.Show("Invalid Bill No. Please enter a valid Bill No.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (connec4 != null && connec4.State != ConnectionState.Closed)
                        {
                            connec4.Close();                            
                        }
                        form2Reference.updateGreen();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Bill No. Please enter a valid Bill No.");
            }
        }

    }

}

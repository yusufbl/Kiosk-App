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
    public partial class Form3 : Form
    {

        private SqlConnection connec3;

        private string tableName;
        private int[] add = new int[5];
        private int[] price = new int[5];

        private int amount = 0;

        private int currentBillId = 1;
        private int columnNo = 1;

        private int tableId = -1;

        private Form2 form2Reference;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            form2Reference = form2;
        }

        private void add1Button_Click(object sender, EventArgs e)
        {
            int productIndex = 0;
            price[productIndex] = 10;
            add[productIndex]++;
            product1Label.Text = add[productIndex].ToString();
            amount += price[productIndex];
            amountOrderLabel.Text = amount.ToString();
        }

        private void add2Button_Click(object sender, EventArgs e)
        {
            int productIndex = 1;
            price[productIndex] = 20;
            add[productIndex]++;
            product2Label.Text = add[productIndex].ToString();
            amount += price[productIndex];
            amountOrderLabel.Text = amount.ToString();
        }

        private void add3Button_Click(object sender, EventArgs e)
        {
            int productIndex = 2;
            price[productIndex] = 30;
            add[productIndex]++;
            product3Label.Text = add[productIndex].ToString();
            amount += price[productIndex];
            amountOrderLabel.Text = amount.ToString();
        }

        private void add4Button_Click(object sender, EventArgs e)
        {
            int productIndex = 3;
            price[productIndex] = 40;
            add[productIndex]++;
            product4Label.Text = add[productIndex].ToString();
            amount += price[productIndex];
            amountOrderLabel.Text = amount.ToString();
        }

        private void add5Button_Click(object sender, EventArgs e)
        {
            int productIndex = 4;
            price[productIndex] = 50;
            add[productIndex]++;
            product5Label.Text = add[productIndex].ToString();
            amount += price[productIndex];
            amountOrderLabel.Text = amount.ToString();
        }
         
        private void orderButton2_Click(object sender, EventArgs e)
        {
            try
            {
                tableName = tableComboBox.SelectedItem.ToString();
                using (SqlConnection connec3 = new SqlConnection(@"Data Source=.....;Initial Catalog=DbCafe;Integrated Security=True"))
                {
                    connec3.Open();

                    using (SqlCommand tableCmd = new SqlCommand("SELECT TableId FROM TableTable WHERE TableName = @TableName", connec3))
                    {
                        tableCmd.Parameters.AddWithValue("@TableName", tableName);
                        object result = tableCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            tableId = Convert.ToInt32(result);
                        }
                    }

                    if (tableId != -1)
                    {
                        int newBillId = currentBillId;

                        for (int i = 0; i < 5; i++)
                        {
                            if (add[i] != 0)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO BillColumnTable (BillId, ColumnId, ProductId, Quantity, UnitPrice) VALUES (@BillId, @ColumnId, @ProductId, @Quantity, @UnitPrice)", connec3))
                                {
                                    cmd.Parameters.AddWithValue("@BillId", newBillId);
                                    cmd.Parameters.AddWithValue("@ColumnId", columnNo);
                                    cmd.Parameters.AddWithValue("@ProductId", i + 1);
                                    cmd.Parameters.AddWithValue("@Quantity", add[i]);
                                    cmd.Parameters.AddWithValue("@UnitPrice", price[i]);
                                    cmd.ExecuteNonQuery();
                                }

                                columnNo++;
                            }
                        }

                        using (SqlCommand billCmd = new SqlCommand("INSERT INTO BillTable (BillId, TableId, TotalAmount) VALUES (@BillId, @TableId, @TotalAmount)", connec3))
                        {
                            billCmd.Parameters.AddWithValue("@BillId", newBillId);
                            billCmd.Parameters.AddWithValue("@TableId", tableId);
                            billCmd.Parameters.AddWithValue("@TotalAmount", amount);
                            billCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand updateCmd = new SqlCommand("UPDATE TableTable SET IsOpen = 0 WHERE TableId = @TableId", connec3))
                        {
                            updateCmd.Parameters.AddWithValue("@TableId", tableId);
                            updateCmd.ExecuteNonQuery();
                        }

                        columnNo = 1;
                        currentBillId++;
                    }
                }

                amount = 0;
                for (int i = 0; i < 5; i++)
                {
                    add[i] = 0;
                }
                product1Label.Text = add[0].ToString();
                product2Label.Text = add[1].ToString();
                product3Label.Text = add[2].ToString();
                product4Label.Text = add[3].ToString();
                product5Label.Text = add[4].ToString();
                amountOrderLabel.Text = amount.ToString();
                tableName = null;

                MessageBox.Show("Ordered");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                if (connec3 != null && connec3.State != ConnectionState.Closed)
                {
                    connec3.Close();
                }
                form2Reference.updateGreen();
            }
        }

    }
}

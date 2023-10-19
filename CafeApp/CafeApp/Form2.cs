using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form2 : Form
    {
        private string userName;
        private SqlConnection connec2;

        public Form2(string userNameFromForm1)
        {
            InitializeComponent();
            userName = userNameFromForm1;

            connec2 = new SqlConnection(@"Data Source=....;Initial Catalog=DbCafe;Integrated Security=True");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = userName;

            updateGreen();
        }

        public void updateGreen()
        {
            try
            {
                connec2.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT TableId, IsOpen FROM TableTable", connec2))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("TableId")) && !reader.IsDBNull(reader.GetOrdinal("IsOpen")))
                        {
                            int tableId = reader.GetInt32(reader.GetOrdinal("TableId"));
                            bool isOpen = reader.GetBoolean(reader.GetOrdinal("IsOpen"));

                            Control[] controls = this.Controls.Find($"tablePanel{tableId}", true);
                            if (controls.Length > 0 && controls[0] is Panel tablePanel)
                            {
                                tablePanel.BackColor = isOpen ? Color.Green : Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından masa durumları alınamadı: " + ex.Message);
            }
            finally
            {
                connec2.Close();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

    }
}

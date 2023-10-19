using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        SqlConnection connec = new SqlConnection(@"Data Source=...;Initial Catalog=DbCafe;Integrated Security=True");
        private string userName;

        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton1_Click(object sender, EventArgs e)
        {
            try
            {
                connec.Open();

                // Kullanýcýnýn girdiði deðerleri al
                int userID;
                if (int.TryParse(idTextBox.Text, out userID))
                {
                    userName = userNameTextBox.Text;
                    string name = nameTextBox.Text;
                    string surname = surnameTextBox.Text;
                    string password = passwordTextBox.Text;

                    // SQL sorgusunu hazýrla
                    string sqlQuery = "SELECT COUNT(*) as CountMatch FROM UserTable WHERE UserId = @UserId AND UserName = @UserName AND Name = @Name AND Surname = @Surname AND Password = @Password;";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connec))
                    {
                        // Parametreleri ekleyin
                        cmd.Parameters.AddWithValue("@UserId", userID);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Surname", surname);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Sorguyu çalýþtýrýn ve sonucu alýn
                        int countMatch = (int)cmd.ExecuteScalar();

                        if (countMatch == 1)
                        {
                            // Eþleþme bulundu, iþlem yapabilirsiniz
                            this.Hide();
                            Form2 form2 = new Form2(userName);
                            form2.Show();
                        }
                        else
                        {
                            // Eþleþme yok, kullanýcýya bilgi verin
                            MessageBox.Show("Girilen bilgiler geçersiz.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanýcý ID'si geçerli bir sayý deðil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }
    }
}

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

                // Kullan�c�n�n girdi�i de�erleri al
                int userID;
                if (int.TryParse(idTextBox.Text, out userID))
                {
                    userName = userNameTextBox.Text;
                    string name = nameTextBox.Text;
                    string surname = surnameTextBox.Text;
                    string password = passwordTextBox.Text;

                    // SQL sorgusunu haz�rla
                    string sqlQuery = "SELECT COUNT(*) as CountMatch FROM UserTable WHERE UserId = @UserId AND UserName = @UserName AND Name = @Name AND Surname = @Surname AND Password = @Password;";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connec))
                    {
                        // Parametreleri ekleyin
                        cmd.Parameters.AddWithValue("@UserId", userID);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Surname", surname);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Sorguyu �al��t�r�n ve sonucu al�n
                        int countMatch = (int)cmd.ExecuteScalar();

                        if (countMatch == 1)
                        {
                            // E�le�me bulundu, i�lem yapabilirsiniz
                            this.Hide();
                            Form2 form2 = new Form2(userName);
                            form2.Show();
                        }
                        else
                        {
                            // E�le�me yok, kullan�c�ya bilgi verin
                            MessageBox.Show("Girilen bilgiler ge�ersiz.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullan�c� ID'si ge�erli bir say� de�il.");
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

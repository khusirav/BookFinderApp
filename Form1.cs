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

namespace BookFinderApp
{
    public partial class Form1 : Form
    {
        static String BookFinderConnectionString = "Data Source=localhost;Initial Catalog=BookFinder;Integrated Security=True";
            
        public Form1()
        {
            InitializeComponent();
        }
        private String Authentication(String Login, String Password)
        {
            String SqlExpression = "GetAcessLevel";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter LoginParameter = new SqlParameter
                    {
                        ParameterName = "@LOGIN",
                        Value = Login
                    };
                    SqlParameter PasswordParameter = new SqlParameter
                    {
                        ParameterName = "@PASSWORD",
                        Value = Password
                    };
                    command.Parameters.Add(LoginParameter);
                    command.Parameters.Add(PasswordParameter);
                    var ReturnValue = command.Parameters.Add("@LEVEL", SqlDbType.Int);
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    String Level = ReturnValue.Value.ToString();
                    if (Level != "1" & Level != "2" & Level != "3") { Level = "0";}
                    connection.Close();
                    return Level;
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
            return "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.Shops_sites_view". При необходимости она может быть перемещена или удалена.
            this.shops_sites_viewTableAdapter.Fill(this.bookFinderDataSet.Shops_sites_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.BooksAuthors_view". При необходимости она может быть перемещена или удалена.
            this.booksAuthors_viewTableAdapter.Fill(this.bookFinderDataSet.BooksAuthors_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int AcessLevel = Convert.ToInt32(Authentication(LoginTextBox.Text, PasswordTextBox.Text));
            if (AcessLevel == 1)
            {
                AcessLevel1_Form ManagerForm = new AcessLevel1_Form();
                ManagerForm.Show();
            }
            else if (AcessLevel == 2)
            {
                AcessLevel2_Form BossForm = new AcessLevel2_Form();
                BossForm.Show();
            }
            else if (AcessLevel == 3)
            {
                AcessLevel3_Form AdministratorForm = new AcessLevel3_Form();
                AdministratorForm.Show();
            }
            else { MessageBox.Show("Неверный логин или пароль", "Ошибка");}
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

    }
}

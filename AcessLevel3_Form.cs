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
    public partial class AcessLevel3_Form : Form
    {
        static String BookFinderConnectionString = "Data Source=localhost;Initial Catalog=BookFinder;Integrated Security=True";
        public AcessLevel3_Form()
        {
            InitializeComponent();
        }
        private void DeleteLoginData(int id) //метод удаления данных для входа работника
        {
            String SqlExpression = "DeleteLoginData";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter LDIDParameter = new SqlParameter
                    {
                        ParameterName = "@LDID",
                        Value = id
                    };
                    command.Parameters.Add(LDIDParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeLogin(int id, String NewLogin) //метод изменения логина работника
        {
            String SqlExpression = "UpdateLogin";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter LDIDParameter = new SqlParameter
                    {
                        ParameterName = "@LDID",
                        Value = id
                    };
                    SqlParameter NLOGINParameter = new SqlParameter
                    {
                        ParameterName = "@NLOGIN",
                        Value = NewLogin
                    };
                    command.Parameters.Add(LDIDParameter);
                    command.Parameters.Add(NLOGINParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangePassword(int id, String NewPassword) //метод изменения пароля работника
        {
            String SqlExpression = "UpdatePassword";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter LDIDParameter = new SqlParameter
                    {
                        ParameterName = "@LDID",
                        Value = id
                    };
                    SqlParameter NPASParameter = new SqlParameter
                    {
                        ParameterName = "@NPASSWORD",
                        Value = NewPassword
                    };
                    command.Parameters.Add(LDIDParameter);
                    command.Parameters.Add(NPASParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeAcessLevel(int id, int NewAcessLevel) //метод изменения уровня доступа работника
        {
            String SqlExpression = "UpdateAcessLevel";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter LDIDParameter = new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = id
                    };
                    SqlParameter NALParameter = new SqlParameter
                    {
                        ParameterName = "@NewAcessLevel",
                        Value = NewAcessLevel
                    };
                    command.Parameters.Add(LDIDParameter);
                    command.Parameters.Add(NALParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void AddLoginData(int id, String Login, String Password, int AcessLevel) //метод добавления данных для входа в систему
        {
            String SqlExpression = "AddLoginData";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter
                    {
                        ParameterName = "@EmloyeeId",
                        Value = id
                    };
                    SqlParameter LoginParameter = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = Login
                    };
                    SqlParameter PasswordParameter = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = Password
                    };
                    SqlParameter AcessLevelParameter = new SqlParameter
                    {
                        ParameterName = "@AcessLevel",
                        Value = AcessLevel
                    };
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(LoginParameter);
                    command.Parameters.Add(PasswordParameter);
                    command.Parameters.Add(AcessLevelParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void AddShop(String Name, String Site, String Type, String FirstName, String MiddleName, String LastName, String PhoneNumber) //метод добавления магазина с менеджером и его телефоном
        {
            String SqlExpression = "AddShopWithManagerWithPhone";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter NAMEParameter = new SqlParameter
                    {
                        ParameterName = "@NAME",
                        Value = Name
                    };
                    SqlParameter SITEParameter = new SqlParameter
                    {
                        ParameterName = "@SITE",
                        Value = Site
                    };
                    SqlParameter TYPEParameter = new SqlParameter
                    {
                        ParameterName = "@TYPE",
                        Value = Type
                    };
                    SqlParameter FNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@FNAME",
                        Value = FirstName
                    };
                    SqlParameter MNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@MNAME",
                        Value = MiddleName
                    };
                    SqlParameter LNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@LNAME",
                        Value = LastName
                    };
                    SqlParameter PNUMBERParameter = new SqlParameter
                    {
                        ParameterName = "@PNUMBER",
                        Value = PhoneNumber
                    };
                    command.Parameters.Add(NAMEParameter);
                    command.Parameters.Add(SITEParameter);
                    command.Parameters.Add(TYPEParameter);
                    command.Parameters.Add(FNAMEParameter);
                    command.Parameters.Add(MNAMEParameter); 
                    command.Parameters.Add(LNAMEParameter);
                    command.Parameters.Add(PNUMBERParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void DeleteShop(int id) //метод удаления данных Магазина
        {
            String SqlExpression = "DeleteShopWithManagerWithPhone";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter SIDParameter = new SqlParameter
                    {
                        ParameterName = "@SID",
                        Value = id
                    };
                    command.Parameters.Add(SIDParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeShopName(int id, String NewName) //метод изменения названия магазина
        {
            String SqlExpression = "UpdateShopName";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter SIDParameter = new SqlParameter
                    {
                        ParameterName = "@SID",
                        Value = id
                    };
                    SqlParameter NNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@NNAME",
                        Value = NewName
                    };
                    command.Parameters.Add(SIDParameter);
                    command.Parameters.Add(NNAMEParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeShopSite(int id, String NewSite) //метод изменения названия магазина
        {
            String SqlExpression = "UpdateShopSite";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter SIDParameter = new SqlParameter
                    {
                        ParameterName = "@SID",
                        Value = id
                    };
                    SqlParameter NSITEParameter = new SqlParameter
                    {
                        ParameterName = "@NSITE",
                        Value = NewSite
                    };
                    command.Parameters.Add(SIDParameter);
                    command.Parameters.Add(NSITEParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeShopType(int id, String NewType) //метод изменения названия магазина
        {
            String SqlExpression = "UpdateShopType";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter SIDParameter = new SqlParameter
                    {
                        ParameterName = "@SID",
                        Value = id
                    };
                    SqlParameter NTYPEParameter = new SqlParameter
                    {
                        ParameterName = "@NTYPE",
                        Value = NewType
                    };
                    command.Parameters.Add(SIDParameter);
                    command.Parameters.Add(NTYPEParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookFinderDataSet);

        }

        private void AcessLevel3_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet2.EmployeesWithoutLoginData_view". При необходимости она может быть перемещена или удалена.
            this.employeesWithoutLoginData_viewTableAdapter.Fill(this.bookFinderDataSet2.EmployeesWithoutLoginData_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.EmployeesPhones_view". При необходимости она может быть перемещена или удалена.
            this.employeesPhones_viewTableAdapter.Fill(this.bookFinderDataSet.EmployeesPhones_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.ShopsManagersPhones_view". При необходимости она может быть перемещена или удалена.
            this.shopsManagersPhones_viewTableAdapter.Fill(this.bookFinderDataSet.ShopsManagersPhones_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.LogindataEmployeesPhones_view". При необходимости она может быть перемещена или удалена.
            this.logindataEmployeesPhones_viewTableAdapter.Fill(this.bookFinderDataSet.LogindataEmployeesPhones_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.Phones". При необходимости она может быть перемещена или удалена.
            this.phonesTableAdapter.Fill(this.bookFinderDataSet.Phones);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// удалить данные для входа
        {
            try
            {
                DeleteLoginData(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Данные удалены", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e) //изменить логин
        {
            try
            {
                ChangeLogin(Convert.ToInt32(textBox2.Text), textBox3.Text);
                MessageBox.Show("Логин изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)//изменить пароль
        {
            try
            {
                ChangePassword(Convert.ToInt32(textBox4.Text), textBox5.Text);
                MessageBox.Show("Пароль изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)//изменить уровень доступа
        {
            try
            {
                ChangeAcessLevel(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text));
                MessageBox.Show("Уровень доступа изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)//добавить данные для входа
        {
            try
            {
                AddLoginData(Convert.ToInt32(textBox8.Text), textBox9.Text, textBox10.Text, Convert.ToInt32(textBox11.Text));
                MessageBox.Show("Данные добавлены", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button6_Click(object sender, EventArgs e)//переход в режим начальника
        {
            AcessLevel2_Form BossForm = new AcessLevel2_Form();
            BossForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)//добавить магазин и менеджера
        {
            try
            {
                AddShop(textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, textBox18.Text);
                MessageBox.Show("Данные добавлены", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e)//удалить магазин и менеджера И телефон
        {
            try
            {
                DeleteShop(Convert.ToInt32(textBox19.Text));
                MessageBox.Show("Данные удалены", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button9_Click(object sender, EventArgs e)//изменить название магазина
        {
            try
            {
                ChangeShopName(Convert.ToInt32(textBox20.Text), textBox21.Text);
                MessageBox.Show("Название изменено", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button10_Click(object sender, EventArgs e)//изменить сайт магазина
        {
            try
            {
                ChangeShopSite(Convert.ToInt32(textBox23.Text), textBox22.Text);
                MessageBox.Show("Сайт изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button11_Click(object sender, EventArgs e)//изменить тип магазина
        {
            try
            {
                ChangeShopType(Convert.ToInt32(textBox25.Text), textBox24.Text);
                MessageBox.Show("Тип изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }
    }
}

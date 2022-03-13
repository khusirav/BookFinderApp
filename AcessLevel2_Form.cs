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
    public partial class AcessLevel2_Form : Form
    {
        static String BookFinderConnectionString = "Data Source=localhost;Initial Catalog=BookFinder;Integrated Security=True";
        public AcessLevel2_Form()
        {
            InitializeComponent();
        }
        private void AddEmployee(String FirstName, String MiddleName, String LastName, Decimal Salary, String Position, String PhoneNumber) //метод добавления работника
        {
            String SqlExpression = "AddEmployeeWithPhone";
            try
            { 
            using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
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
                SqlParameter SALARYParameter = new SqlParameter
                {
                    ParameterName = "@SALARY",
                    Value = Salary
                };
                SqlParameter PNUMBERParameter = new SqlParameter
                {
                    ParameterName = "@PNUMBER",
                    Value = PhoneNumber
                };
                SqlParameter POSParameter = new SqlParameter
                {
                    ParameterName = "@POS",
                    Value = Position
                };
                command.Parameters.Add(FNAMEParameter);
                command.Parameters.Add(MNAMEParameter);
                command.Parameters.Add(LNAMEParameter);
                command.Parameters.Add(SALARYParameter);
                command.Parameters.Add(POSParameter);
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
        private void DeleteEmployee(int id) //метод удаления работника
        {
            String SqlExpression = "DeleteNonAdminEmployee";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter IDParameter = new SqlParameter
                    {
                        ParameterName = "@ID",
                        Value = id
                    };
                    command.Parameters.Add(IDParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeSalary(int id, decimal NewSalary) //метод изменения зарплаты
        {
            String SqlExpression = "UpdateSalary";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = id
                    };
                    SqlParameter NewSalaryParameter = new SqlParameter
                    {
                        ParameterName = "@NewSalary",
                        Value = NewSalary
                    };
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(NewSalaryParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangePosition(int id, String NewPosition) //метод изменения должности
        {
            String SqlExpression = "UpdatePosition";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter
                    {
                        ParameterName = "@id",
                        Value = id
                    };
                    SqlParameter NewPositionParameter = new SqlParameter
                    {
                        ParameterName = "@NewPosition",
                        Value = NewPosition
                    };
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(NewPositionParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeEmployeePhone(int id, String NewPhone) //метод изменения номера телефона работника
        {
            String SqlExpression = "UpdatePhoneByEmployeeId";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter EIDParameter = new SqlParameter
                    {
                        ParameterName = "@EID",
                        Value = id
                    };
                    SqlParameter PNUMBERParameter = new SqlParameter
                    {
                        ParameterName = "@PNUMBER",
                        Value = NewPhone
                    };
                    command.Parameters.Add(EIDParameter);
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
        private void AddAuthor(String FirstName, String MiddleName, String LastName, String PhoneNumber) //метод добавления автора
        {
            String SqlExpression = "AddAuthorWithPhone";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
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
        private void DeleteAuthor(int id) //метод удаления автора
        {
            String SqlExpression = "DeleteAuthor";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter AIDParameter = new SqlParameter
                    {
                        ParameterName = "@AID",
                        Value = id
                    };
                    command.Parameters.Add(AIDParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void AddBook(int id, String BookName) //метод добавления книги
        {
            String SqlExpression = "AddBook";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter
                    {
                        ParameterName = "@AuthorId",
                        Value = id
                    };
                    SqlParameter BookNameParameter = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = BookName
                    };
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(BookNameParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void UpdateBook(int id, String OldBookName, String NewBookName) //метод обновления книги
        {
            String SqlExpression = "UpdateBook";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter AIDParameter = new SqlParameter
                    {
                        ParameterName = "@AID",
                        Value = id
                    };
                    SqlParameter OBNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@OBNAME",
                        Value =OldBookName
                    };
                    SqlParameter NBNAMEParameter = new SqlParameter
                    {
                        ParameterName = "@NBNAME",
                        Value = NewBookName
                    };
                    command.Parameters.Add(AIDParameter);
                    command.Parameters.Add(OBNAMEParameter);
                    command.Parameters.Add(NBNAMEParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void DeleteBook(int id, String BookName) //метод удаления книги
        {
            String SqlExpression = "DeleteBook";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter idParameter = new SqlParameter
                    {
                        ParameterName = "@AID",
                        Value = id
                    };
                    SqlParameter BookNameParameter = new SqlParameter
                    {
                        ParameterName = "@BNAME",
                        Value = BookName
                    };
                    command.Parameters.Add(idParameter);
                    command.Parameters.Add(BookNameParameter);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException Exc)
            {
                MessageBox.Show(Exc.Message);
            }
        }
        private void ChangeAuthorPhone(int id, String NewPhone) //метод изменения номера телефона автора
        {
            String SqlExpression = "UpdatePhoneByAuthorId";
            try
            {
                using (SqlConnection connection = new SqlConnection(BookFinderConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter EIDParameter = new SqlParameter
                    {
                        ParameterName = "@AID",
                        Value = id
                    };
                    SqlParameter PNUMBERParameter = new SqlParameter
                    {
                        ParameterName = "@PNUMBER",
                        Value = NewPhone
                    };
                    command.Parameters.Add(EIDParameter);
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
        private void AcessLevel2_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.BooksAuthors_view". При необходимости она может быть перемещена или удалена.
            this.booksAuthors_viewTableAdapter.Fill(this.bookFinderDataSet.BooksAuthors_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet1.AuthorsPhones_view". При необходимости она может быть перемещена или удалена.
            this.authorsPhones_viewTableAdapter.Fill(this.bookFinderDataSet1.AuthorsPhones_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.AuthorsPhonesBooks_view". При необходимости она может быть перемещена или удалена.
            //this.authorsPhonesBooks_viewTableAdapter.Fill(this.bookFinderDataSet.AuthorsPhonesBooks_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bookFinderDataSet.EmployeesPhones_view". При необходимости она может быть перемещена или удалена.
            this.employeesPhones_viewTableAdapter.Fill(this.bookFinderDataSet.EmployeesPhones_view);

        }

        private void employeesPhones_viewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//уволить сотрудника
        {
            try
            {
                DeleteEmployee(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Сотрудник удалён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e)//добавить сотрудника
        {
            try
            {
                AddEmployee(textBox8.Text, textBox9.Text, textBox10.Text, Convert.ToDecimal(textBox11.Text),textBox12.Text, textBox13.Text);
                MessageBox.Show("Сотрудник добавлен", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода","Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e) // изменить зарплату
        {
            try
            {
                ChangeSalary(Convert.ToInt32(textBox2.Text), Convert.ToDecimal(textBox3.Text));
                MessageBox.Show("Зарплата изменена", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)// изменить должность
        {
            try
            {
                ChangePosition(Convert.ToInt32(textBox4.Text), textBox5.Text);
                MessageBox.Show("Должность изменена", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e)// изменить телефон сотрудника
        {
            try
            {
                ChangeEmployeePhone(Convert.ToInt32(textBox6.Text), textBox7.Text);
                MessageBox.Show("Телефон изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button9_Click(object sender, EventArgs e) //добавить автора
        {
            try
            {
                AddAuthor(textBox20.Text, textBox21.Text, textBox22.Text, textBox23.Text);
                MessageBox.Show("Автор добавлен", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }


        private void button6_Click(object sender, EventArgs e) //удалить автора
        {
            try
            {
                DeleteAuthor(Convert.ToInt32(textBox19.Text));
                MessageBox.Show("Автор удалён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button7_Click(object sender, EventArgs e) //добавить книгу
        {
            try
            {
                AddBook(Convert.ToInt32(textBox14.Text), textBox15.Text);
                MessageBox.Show("Книга добавлена", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e) //изменить книгу
        {
            try
            {
                UpdateBook(Convert.ToInt32(textBox16.Text),textBox17.Text, textBox18.Text);
                MessageBox.Show("Книга обновлена", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void button10_Click(object sender, EventArgs e) //изменить телефон автора
        {
            try
            {
                ChangeAuthorPhone(Convert.ToInt32(textBox25.Text), textBox26.Text);
                MessageBox.Show("Телефон изменён", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)//удалить книгу
        {
            try
            {
                DeleteBook(Convert.ToInt32(textBox24.Text), textBox27.Text);
                MessageBox.Show("Книга удалена", "Успешно");
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода", "Ошибка");
            }
        }
    }
}

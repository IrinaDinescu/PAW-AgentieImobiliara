using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WpfApp1
{
    public partial class Form_DateleMele : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Irina\Facultate anul II\PAW\Proiect02\WpfApp1\WpfApp1\bin\Debug\Database1.mdf; Integrated Security=True");


        int id;
        List<Class_DateleMele> dateleMele = new List<Class_DateleMele>();
        Class_DateleMele date = new Class_DateleMele();
        ErrorProvider er = new ErrorProvider();

        public Form_DateleMele(int _id)
        {
            InitializeComponent();
            //  id = Class_DateCont.Id;
            id = _id;
        }

        private void UserControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2 = id;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                er.SetError(textBox1, "Spatiul trebuie completat");
            else if (textBox2.Text == "")
            {
                er.SetError(textBox2, "Spatiul trebuie completat");
            }
            else if (textBox3.Text == "")
            {
                er.SetError(textBox3, "Spatiul trebuie completat");
            }
            else
            {
                Class_DateleMele date = new Class_DateleMele(textBox3.Text, textBox2.Text, textBox3.Text);
                this.date = date;
                dateleMele.Add(date);

                try
                {
                    if (con.State != ConnectionState.Open && con.State != ConnectionState.Connecting)
                    {
                        con.Open();

                    }
                    SqlCommand _cmd = new SqlCommand("UPDATE DATE_PERSONALE SET NUME=@a1, EMAIL=@a2, TELEFON=@a3 where Id='" + id.ToString() + "' ", con);
                    _cmd.Parameters.AddWithValue("a1", textBox1.Text);
                    _cmd.Parameters.AddWithValue("a2", textBox2.Text);
                    _cmd.Parameters.AddWithValue("a3", textBox3.Text);
                    _cmd.ExecuteNonQuery();

                    textBox1.Invalidate();
                    textBox2.Invalidate();
                    textBox3.Invalidate();

                    MessageBox.Show("Date Salvate!");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                
            }






        }

        private void Form_DateleMele_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select NUME, EMAIL, TELEFON from DATE_PERSONALE where Id='" + id.ToString() + "' ", con);
            DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            { 
                    string NUME = dt.Rows[0][0].ToString();
                    string EMAIL = dt.Rows[0][1].ToString();
                    string TELEFON = dt.Rows[0][2].ToString();

                Class_DateleMele date = new Class_DateleMele(NUME, EMAIL, TELEFON);
                this.date = date;

                textBox3.Text = NUME;
                textBox1.Text = EMAIL;
                textBox2.Text = TELEFON;
                textBox1.Invalidate();
                textBox2.Invalidate();
                textBox3.Invalidate();


            }
        }

        private void userControl32_Load(object sender, EventArgs e)
        {
            this.userControl32.Us3_id = id;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

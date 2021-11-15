using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Windows.Media.Media3D;
using System.IO;
using System.Linq.Expressions;

namespace WpfApp1
{
    public partial class UserControl1 : UserControl
    {
        private string id ;

        ErrorProvider er1 = new ErrorProvider();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Irina\Facultate anul II\PAW\Proiect02\WpfApp1\WpfApp1\bin\Debug\Database1.mdf; Integrated Security=True");



        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
                er1.SetError(tbPassword, "Compeltati Spatiul!");
            else
                if (tbUsername.Text == "")
                er1.SetError(tbUsername, "Comepltati Spatiul!");
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open && con.State != ConnectionState.Connecting)
                    {
                        con.Open();
                    }

                    SqlDataAdapter sda = new SqlDataAdapter("Select username from LOGIN where username ='" + tbUsername.Text + "' ", con);
                    DataTable dt = new System.Data.DataTable();

                    sda.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Acest username este luat, incercati altul");
                    }
                    else
                    {
             
                        SqlCommand _cmd = new SqlCommand("INSERT INTO LOGIN (username,password) VALUES (@username,@password)", con);
                        _cmd.Parameters.AddWithValue("username", tbUsername.Text);
                        _cmd.Parameters.AddWithValue("password", tbPassword.Text);
                        _cmd.ExecuteNonQuery();

                        MessageBox.Show("Cont creat cu succes!");

       
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    er1.Clear();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (con.State != ConnectionState.Open && con.State != ConnectionState.Connecting)
                {
                    con.Open();
                }


                SqlDataAdapter sda = new SqlDataAdapter("Select Id from LOGIN where username ='" + tbUsername.Text + "' and password='" + tbPassword.Text + "' ", con);
                DataTable dt = new System.Data.DataTable();


                if (con.State == ConnectionState.Open )
                {
                    con.Close();
                }



                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    id = dt.Rows[0][0].ToString();

                    Interfata2 frm = new Interfata2(Convert.ToInt32(id));

                    Form tmp = this.FindForm();
                    tmp.Hide();
                    frm.ShowDialog();
                    tmp.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                er1.Clear();
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                
            }

            
        }
            
            
            
           
        

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

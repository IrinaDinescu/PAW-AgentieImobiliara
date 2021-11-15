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
    public partial class Form_PlaseazaAnunt : Form
    {
      //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security=True");
        // SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Irina\Facultate anul II\PAW\Proiect\WpfApp1\WpfApp1\Database1.mdf; Integrated Security = True");
        List<Class_Anunt> anunturi = new List<Class_Anunt>();

        Class_Anunt anunt = new Class_Anunt();

       

        ErrorProvider ErrorProvider1 = new ErrorProvider();

        int id;

        public Form_PlaseazaAnunt(int _id)
        {
            InitializeComponent();
            id = _id;
            anunt.Tip_anunt = "Vanzare";
            anunt.Categorie = "Casa";
          //  MessageBox.Show(id.ToString());
            
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Categorie = "Teren";
        }

        //Suprafat Utilza
        private void Tb_SuprafataUtila_TextChanged(object sender, EventArgs e)
        {
            if (tb_SuprafataUtila.Text == "")
                ErrorProvider1.SetError(tb_SuprafataUtila, "Spatiul trebuie completat ");
            else
                try
                {
                    anunt.Suprafata_utila = Convert.ToSingle(tb_SuprafataUtila.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ErrorProvider1.Clear();
                }
        }

        //Pret
        private void Tb_Pret_TextChanged(object sender, EventArgs e)
        {
            if (tb_Pret.Text == "")
                ErrorProvider1.SetError(tb_Pret, "Spatiul trebuie completat");
            else
                try
                {
                    anunt.Pret = Convert.ToSingle(tb_Pret.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ErrorProvider1.Clear();
                }
        }

        private void Tb_Localizare_TextChanged(object sender, EventArgs e)
        {
            if (tb_Localizare.Text == "")
                ErrorProvider1.SetError(tb_Localizare, "Spatiul trebuie completat");
            else
                try
                {
                    anunt.Localizare = tb_Localizare.Text;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ErrorProvider1.Clear();
                }

        }

        private void RadioButton_Vanzare_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Tip_anunt = "Vanzare";
        }

        private void RadioButton_Inchiriere_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Tip_anunt = "Inchiriere";
        }

        private void RadioButton_Casa_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Categorie = "Casa";
        }

        private void RadioButton_Apartament_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Categorie = "Apartament";
        }

        private void RadioButton_SpatiuComercial_CheckedChanged(object sender, EventArgs e)
        {
            anunt.Categorie = "Spatiu Comercial";
        }

        private void Button_Salveaza_Click(object sender, EventArgs e)
        {
            if (tb_SuprafataUtila.Text == "")
                ErrorProvider1.SetError(tb_SuprafataUtila, "Spatiul trebuie completat");
            else if (tb_Pret.Text == "")
            {
                ErrorProvider1.SetError(tb_Pret, "Spatiul trebuie completat");
            }
            else if (tb_Localizare.Text == "")
            {
                ErrorProvider1.SetError(tb_Localizare, "Spatiul trebuie completat");
            }
            else
            {
                anunt.Id_cont = id;
                anunturi.Add(anunt);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Irina\Facultate anul II\PAW\Proiect02\WpfApp1\WpfApp1\bin\Debug\Database1.mdf; Integrated Security=True");

                if (con.State != ConnectionState.Open && con.State != ConnectionState.Connecting)
                {
                    con.Open();
                }
                
                SqlCommand _cmd = new SqlCommand("INSERT INTO ANUNTURI (Id,categorie,tip_anunt,suprafata,pret,localizare) VALUES (@Id,@categorie,@tip_anunt,@suprafata,@pret,@localizare)", con);
                _cmd.Parameters.AddWithValue("Id", anunt.Id_cont);
                _cmd.Parameters.AddWithValue("categorie", anunt.Categorie);
                _cmd.Parameters.AddWithValue("tip_anunt", anunt.Tip_anunt);
                _cmd.Parameters.AddWithValue("suprafata", anunt.Suprafata_utila);
                _cmd.Parameters.AddWithValue("pret", anunt.Pret);
                _cmd.Parameters.AddWithValue("localizare", anunt.Localizare);
                _cmd.ExecuteNonQuery();
                

                MessageBox.Show(" Anunt salvat cu succes! ");
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                this.Close();
            }
            
        }

        private void Form_PlaseazaAnunt_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.Alt && e.KeyCode.ToString() == "S")
            {
                button_Salveaza.PerformClick();
                MessageBox.Show("Anunt Salvat");

            }

        }

        private void SalveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tb_SuprafataUtila.Text == "")
                ErrorProvider1.SetError(tb_SuprafataUtila, "Spatiul trebuie completat");
            else if (tb_Pret.Text == "")
            {
                ErrorProvider1.SetError(tb_Pret, "Spatiul trebuie completat");
            }
            else if (tb_Localizare.Text == "")
            {
                ErrorProvider1.SetError(tb_Localizare, "Spatiul trebuie completat");
            }
            else
            {
                anunt.Id_cont = id;
                anunturi.Add(anunt);
                MessageBox.Show(" Anunt salvat cu succes! ");
            }
        }

        private void Form_PlaseazaAnunt_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

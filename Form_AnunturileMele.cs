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
    public partial class Form_AnunturileMele : Form
    {

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Irina\Facultate anul II\PAW\Proiect02\WpfApp1\WpfApp1\bin\Debug\Database1.mdf; Integrated Security=True");

        int id;
        List<Class_Anunt> anunturi = new List<Class_Anunt>();
        List<Class_Anunt> anunturil_mele = new List<Class_Anunt>();
        List<Class_Anunt> anunturi_baza = new List<Class_Anunt>();

        List<int> cheie = new List<int>();

        public Form_AnunturileMele(int _id, List<Class_Anunt> _anunturi)
        {
            InitializeComponent();
            anunturi = _anunturi;
            id = _id;
           // MessageBox.Show(id.ToString());
          
        }

        private void Form_AnunturileMele_Load(object sender, EventArgs e)
        {
            foreach(Class_Anunt anunt in anunturi)
            {
                if(anunt.Id_cont == id)
                {
                    anunturil_mele.Add(anunt);
                }

            }


            for(int i =0; i < anunturil_mele.Count(); i++)
            {
                ListViewItem itm = new ListViewItem(anunturil_mele[i].Categorie);
                itm.SubItems.Add(anunturil_mele[i].Tip_anunt);
                itm.SubItems.Add(anunturil_mele[i].Suprafata_utila.ToString());
                itm.SubItems.Add(anunturil_mele[i].Pret.ToString());
                itm.SubItems.Add(anunturil_mele[i].Localizare.ToString());

                listView1.Items.Add(itm);
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                int index;
                int _cheie;
                index = item.Index;
               // MessageBox.Show("Index:" + index.ToString());
               // MessageBox.Show("----" + (anunturil_mele.Count - anunturi_baza.Count).ToString());
                if (index < (anunturil_mele.Count-anunturi_baza.Count))
                {
                    anunturil_mele.Remove(anunturil_mele[index]);
                    item.ListView.Items.Remove(item);
                    MessageBox.Show("Anunt sters cu succes!");
                }
                else
                {
                    _cheie = cheie[index-(anunturil_mele.Count - anunturi_baza.Count)];
                    MessageBox.Show(Convert.ToString(_cheie));
                 //   MessageBox.Show("Cheie" + _cheie.ToString());
                    cheie.Remove(_cheie);
                    item.ListView.Items.Remove(item);
                    anunturi_baza.Remove(anunturil_mele[index]);
                    anunturil_mele.Remove(anunturil_mele[index]);

                    // item.ListView.Items.Remove(item);

                    // SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Irina\Facultate anul II\PAW\Proiect\WpfApp1\WpfApp1\Database1.mdf; Integrated Security = True");
 /*                   SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
                    connectionString.DataSource = "(LocalDB)\\MSSQLLocalDB";
                    connectionString.AttachDBFilename = "|DataDirectory|\\Database1.mdf";
                    connectionString.IntegratedSecurity = true;
                    string connectString = connectionString.ConnectionString;

                    SqlConnection con = new SqlConnection(connectString);*/
                    con.Open();
                    SqlCommand _cmd = new SqlCommand("DELETE FROM ANUNTURI where cheie=  @_cheie", con);
                    _cmd.Parameters.AddWithValue("_cheie", _cheie);
                    try
                    {
                        _cmd.ExecuteNonQuery();
                        MessageBox.Show("Anunt sters cu succes!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anunturil_mele.Clear();

/*            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "(LocalDB)\\MSSQLLocalDB";
            connectionString.AttachDBFilename = "|DataDirectory|\\Database1.mdf";
            connectionString.IntegratedSecurity = true;
            string connectString = connectionString.ConnectionString;
            SqlConnection con = new SqlConnection(connectString);*/

            //  SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Irina\Facultate anul II\PAW\Proiect\WpfApp1\WpfApp1\Database1.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select categorie, tip_anunt, suprafata,pret,localizare,cheie from ANUNTURI where Id='" + id.ToString() + "' ", con);
            DataTable dt = new System.Data.DataTable();

            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                List<int> vector_cheie = new List<int>();
                for (int i = 0; i < dt.Rows.Count; i++) {

                    string categorie = dt.Rows[i][0].ToString();
                    string tip_anunt = dt.Rows[i][1].ToString();
                    float suprafata = Convert.ToSingle(dt.Rows[i][2]);
                    float pret = Convert.ToSingle(dt.Rows[i][3]);
                    string localizare = dt.Rows[i][4].ToString();

                    vector_cheie.Add(Convert.ToInt32(dt.Rows[i][5]));

                    Class_Anunt anunt = new Class_Anunt(categorie, tip_anunt, suprafata, pret, localizare, id);

                   // anunturi_baza.Add(anunt);
                    anunturil_mele.Add(anunt);
                }
                cheie = vector_cheie;
                MessageBox.Show("Anunturi incarcate din baza de date");

                if (con!=null)
                {
                    con.Close();
                }

                
            }
            else
            {
                MessageBox.Show("Cont invalid!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int i = 0; i < anunturil_mele.Count(); i++)
            {
                ListViewItem itm = new ListViewItem(anunturil_mele[i].Categorie);
                itm.SubItems.Add(anunturil_mele[i].Tip_anunt);
                itm.SubItems.Add(anunturil_mele[i].Suprafata_utila.ToString());
                itm.SubItems.Add(anunturil_mele[i].Pret.ToString());
                itm.SubItems.Add(anunturil_mele[i].Localizare.ToString());

              //  MessageBox.Show(cheie[i].ToString());
                listView1.Items.Add(itm);
            }

          

        }

        private void userControl31_Load(object sender, EventArgs e)
        {
            this.userControl31.Us3_id = id;
        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2 = id;
        }
    }
}

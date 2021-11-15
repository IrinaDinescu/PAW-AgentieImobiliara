using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Controls;
using System.Linq.Expressions;

using System.Drawing.Printing;
using System.Data.SqlClient;


namespace WpfApp1
{
    public partial class Form_AfisareAnunturi : Form
    {
        int id;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Irina\Facultate anul II\PAW\Proiect02\WpfApp1\WpfApp1\bin\Debug\Database1.mdf; Integrated Security=True");

        List<Class_Anunt> anunturi = new List<Class_Anunt>();
        List<Class_Anunt> anunturi_baza = new List<Class_Anunt>();
        List<Class_Anunt> anunturi_salvate = new List<Class_Anunt>();


        Class_Anunt anunt1 = new Class_Anunt();
        Class_Anunt anunt2 = new Class_Anunt("Casa", "Vanzare",340,120000,"Pipera",0);
        Class_Anunt anunt3 = new Class_Anunt("Casa", "Inchiriere", 100, 1500, "Bucuresti",0);
        Class_Anunt anunt4 = new Class_Anunt("Spatiu Comercial", "Inchiriere", 500, 5000, "Timisoara",0);
        Class_Anunt anunt5 = new Class_Anunt("Casa", "Vanzare", 240, 150000, "Snagov",0);
        Class_Anunt anunt6 = new Class_Anunt("Apartament", "Vanzare", 85, 70000, "Cluj",0);
        Class_Anunt anunt7 = new Class_Anunt("Teren", "Vanzare", 100, 90000, "Bucuresti",0);

        List<string> orase = new List<string>();
        List<string> orase2 = new List<string>();
        List<float> preturi_medii = new List<float>();

        bool inchirieri;


        int nrElem = 0;
        const int marg = 20;

        bool vb = false;

        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        Brush[] brushes = new Brush[]
        {
            Brushes.Blue,
            Brushes.Yellow,
            Brushes.Green,
            Brushes.Red,
            Brushes.Purple,
            Brushes.MediumPurple,
            Brushes.Violet,
        };


        public Form_AfisareAnunturi(bool inchirieri1, int _id)
        {
            InitializeComponent();
            id = _id;
            incarcaDate();

        

/*            anunturi.Add(anunt1); 
            anunturi.Add(anunt5);
            anunturi.Add(anunt3);
            anunturi.Add(anunt4);
            anunturi.Add(anunt6);
            anunturi.Add(anunt7);
            anunturi.Add(anunt2);
            anunturi.Add(anunt3);*/
           
            inchirieri = inchirieri1;

            //anunturi2 = anunt;

           // incarcaDate();


        }

        private void incarcaDate()
        {
            StreamReader sr = new StreamReader("anunturi.txt");
            string linie = null;

            int nr = 1;
            int k = 0;

            nr = Convert.ToInt32(sr.ReadLine());

            while (((linie = sr.ReadLine()) != null) && (k < nr))
            {
                try
                {
                    k++;

                    string categorie = linie.Split(',')[0];
                    string tip_anunt = linie.Split(',')[1];
                    float suprafata_utila = Convert.ToSingle(linie.Split(',')[2]);
                    float pret = Convert.ToSingle(linie.Split(',')[3]);
                    string localizare = linie.Split(',')[4];

                    //sa inlocuiesti aici id-ul
                    Class_Anunt anunt_fisier = new Class_Anunt(categorie, tip_anunt, suprafata_utila, pret, localizare,0);
                    anunturi.Add(anunt_fisier);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Date incarcate din fisier!");
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_AfisareAnunturi_Load(object sender, EventArgs e)
        {
            
         
        }

        

       


        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void UserControl21_Load(object sender, EventArgs e)
        {
            this.userControl21.Id_us2 = id;
        }

        private void UserControl31_Load(object sender, EventArgs e)
        {
            this.userControl31.Us3_id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = false;

            foreach(System.Windows.Forms.ListViewItem itm in listView1.Items)
            {
                if (itm.Checked == true)
                    ok = true;
            }

            if (ok == true)
            {
                foreach(System.Windows.Forms.ListViewItem itm in listView1.Items)
                {
                    if (itm.Checked)
                    {

                        string categorie = itm.SubItems[0].Text;
                        string tip = itm.SubItems[1].Text;
                        string linie = itm.SubItems[2].Text;
                        linie = linie.Split(' ')[0];
                        float suprafata = Convert.ToSingle(linie);
                        linie = itm.SubItems[3].Text.Split(' ')[0];
                        float pret = Convert.ToSingle(linie);
                        string localizare = itm.SubItems[4].Text;

                        Class_Anunt anunt = new Class_Anunt(categorie, tip, suprafata, pret, localizare, 0);

                        anunturi_salvate.Add(anunt);
                        
                    }
                }
            }

            if (ok)
            {
                Form_SalvareAnunturi dlg = new Form_SalvareAnunturi(anunturi_salvate, id);
                dlg.ShowDialog();
              //  this.Hide();

            }
            else MessageBox.Show("Nu ati selectat niciun anunt!!!");
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nrElem = 0;
            foreach(string oras  in checkedListBox1.CheckedItems)
            {
                orase.Add(oras);
            }

            float pret_mediu;

            for(int i = 0; i < orase.Count; i++)
            {
                
                foreach(System.Windows.Forms.ListViewItem itm in listView1.Items)
                {
                    if (itm.SubItems[4].Text == orase[i])
                    {
                        pret_mediu = 0;
                        pret_mediu = anunt1.calculeaza_pret_mediu_oras(anunturi, orase[i]);
                        if (pret_mediu != 0)
                        {
                            vb = true;
                            preturi_medii.Add(pret_mediu);
                            nrElem++;
                            orase2.Add(orase[i]);
                        }
                    }
                }
            }
            panel1.Invalidate();
            if(nrElem==0)
            MessageBox.Show("Nu ati selectat niciun oras sau nu exista niciun anunt disponibil!");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nrElem = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Random rnd = new Random();
             //   Brush brush;



                
                Graphics g = e.Graphics;         
                Rectangle rect = new Rectangle(panel1.ClientRectangle.X + marg, panel1.ClientRectangle.Y + marg,
                    panel1.ClientRectangle.Width - 2 * marg, panel1.ClientRectangle.Height - 2 * marg);
                Pen pen = new Pen(Color.Black, 1);
                g.DrawRectangle(pen, rect);

                double latime = rect.Width / nrElem / 6;
                double distanta = (rect.Width - nrElem * latime) / (nrElem + 1);
                double vMax = preturi_medii.Max() + 5*marg;

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rect.Location.Y + rect.Height - preturi_medii[i] / vMax * rect.Height ),
                        (int)latime,
                        (int)(preturi_medii[i] / vMax * rect.Height));
                        g.DrawString(preturi_medii[i].ToString() + " " + orase2[i].ToString(), font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - font.Height)));

                }
                for (int i = 0; i < nrElem; i++)
                {
                  //  brush = brushes[rnd.Next(brushes.Length)];
                    g.FillRectangle(brushes[i], recs[i]);
                }
                nrElem = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anunturi_baza.Clear();
            try
            {
                if (con.State != ConnectionState.Open && con.State != ConnectionState.Connecting)
                {
                    con.Open();
                }

                SqlDataAdapter sda = new SqlDataAdapter("Select Id, categorie, tip_anunt, suprafata,pret,localizare,cheie from ANUNTURI ", con);
                DataTable dt = new System.Data.DataTable();

                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    List<int> vector_cheie = new List<int>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int id = Convert.ToInt32(dt.Rows[i][0]);
                        string categorie = dt.Rows[i][1].ToString();
                        string tip_anunt = dt.Rows[i][2].ToString();
                        float suprafata = Convert.ToSingle(dt.Rows[i][3]);
                        float pret = Convert.ToSingle(dt.Rows[i][4]);
                        string localizare = dt.Rows[i][5].ToString();

                        vector_cheie.Add(Convert.ToInt32(dt.Rows[i][6]));

                        Class_Anunt anunt = new Class_Anunt(categorie, tip_anunt, suprafata, pret, localizare, id);

                        anunturi_baza.Add(anunt);
                    }
                    MessageBox.Show("Anunturi incarcate din baza de date! ");
                }
                else
                {
                    MessageBox.Show("Nu exista niciun anunt disponibil ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }


           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Class_Anunt anunt in anunturi)
            {
                if ((inchirieri == true) && (anunt.Tip_anunt == "Inchiriere"))
                {

                    System.Windows.Forms.ListViewItem itm = new System.Windows.Forms.ListViewItem(anunt.Categorie);
                    itm.SubItems.Add(anunt.Tip_anunt);
                    itm.SubItems.Add(anunt.Suprafata_utila.ToString() + " mp2"); ;
                    itm.SubItems.Add(anunt.Pret.ToString() + " EUR");
                    itm.SubItems.Add(anunt.Localizare);

                    listView1.Items.Add(itm);
                }

                if ((inchirieri == false) && (anunt.Tip_anunt == "Vanzare"))
                {
                    System.Windows.Forms.ListViewItem itm = new System.Windows.Forms.ListViewItem(anunt.Categorie);
                    itm.SubItems.Add(anunt.Tip_anunt);
                    itm.SubItems.Add(anunt.Suprafata_utila.ToString() + " mp2"); ;
                    itm.SubItems.Add(anunt.Pret.ToString() + " EUR");
                    itm.SubItems.Add(anunt.Localizare);

                    listView1.Items.Add(itm);
                }
            }

            foreach (Class_Anunt anunt in anunturi_baza)
            {
                if ((inchirieri == true) && (anunt.Tip_anunt == "Inchiriere"))
                {

                    System.Windows.Forms.ListViewItem itm = new System.Windows.Forms.ListViewItem(anunt.Categorie);
                    itm.SubItems.Add(anunt.Tip_anunt);
                    itm.SubItems.Add(anunt.Suprafata_utila.ToString() + " mp2"); ;
                    itm.SubItems.Add(anunt.Pret.ToString() + " EUR");
                    itm.SubItems.Add(anunt.Localizare);

                    listView1.Items.Add(itm);
                }

                if ((inchirieri == false) && (anunt.Tip_anunt == "Vanzare"))
                {
                    System.Windows.Forms.ListViewItem itm = new System.Windows.Forms.ListViewItem(anunt.Categorie);
                    itm.SubItems.Add(anunt.Tip_anunt);
                    itm.SubItems.Add(anunt.Suprafata_utila.ToString() + " mp2"); ;
                    itm.SubItems.Add(anunt.Pret.ToString() + " EUR");
                    itm.SubItems.Add(anunt.Localizare);

                    listView1.Items.Add(itm);
                }
            }
        }
    }
}

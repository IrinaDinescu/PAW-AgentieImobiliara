using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class Class_Anunt
    {
        private int id_cont;
        private string categorie;
        private string tip_anunt;
        private float suprafata_utila;
        private float pret;
        private string localizare;

        public Class_Anunt()
        {
            this.Id_cont = 0;
            this.categorie = "indisponibil";
            this.tip_anunt = "indisponibil";
            this.suprafata_utila = 0;
            this.pret = 0;
            this.localizare = "indisponibil";
        }


        public Class_Anunt(string categ, string tip, float suprafata, float pret, string loc, int _id)
        {
            this.Id_cont = _id;
            this.categorie = categ;
            this.tip_anunt = tip;
            this.suprafata_utila = suprafata;
            this.pret = pret;
            this.localizare = loc;
        }

        public override string ToString()
        {

            string sir = base.ToString();
            sir = "Categorie: " + categorie + " Tip anunt: " + tip_anunt + "Suprafata: " + Convert.ToString(suprafata_utila) + " m2 ";
            sir += " Pret: " + Convert.ToString(pret) + " Localizare: " + localizare;
            return sir; ;
        }

        public float calculeaza_pret_mediu_oras(List<Class_Anunt> anuturi,string localizare)
        {
            
            float preturi_totale = 0;
            float suprafete_totale = 0;
            for(int i = 0; i < anuturi.Count; i++)
            {
                if (anuturi[i].localizare == localizare)
                {
                    preturi_totale += anuturi[i].pret;
                    suprafete_totale += anuturi[i].suprafata_utila;
                }
            }
            return preturi_totale/suprafete_totale;
        }

       


        public string Categorie { get => categorie; set => categorie = value; }
        public string Tip_anunt { get => tip_anunt; set => tip_anunt = value; }
        public float Suprafata_utila { get => suprafata_utila; set => suprafata_utila = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Localizare { get => localizare; set => localizare = value; }
        public int Id_cont { get => id_cont; set => id_cont = value; }
    }
}

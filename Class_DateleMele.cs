using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   

   public class Class_DateleMele
    {
        static int nr = 0;

        private int id;
        private string nume;
        private string email;
        private string telefon;

        public Class_DateleMele()
        {
            id = -1;
            Nume = "indisponibil";
            email = "indisponibil";
            telefon = "indisponibil";
        }

        public Class_DateleMele(string _nume, string _email, string _telefon)
        {
            this.id = nr;
            this.Nume = _nume;
            this.email = _email;
            this.telefon = _telefon;
            nr++;

        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Nume { get => nume; set => nume = value; }
    }
}

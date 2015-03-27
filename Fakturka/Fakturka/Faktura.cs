using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturka
{
    public class Faktura
    {
        // osobowa
        public string nazwaSprzedawcy { get; set; }
        public string ulica { get; set; }
        public string kodPocztowy { get; set; }
        public string  miejscowosc { get; set; }
        
        public string NIP { get; set; }

        // naglowek
        public string nrFaktury { get; set; }
        public DateTime dataDostawy { get; set; }
        public DateTime dataWystawienia { get; set; }

        // pozycje
        public string pelnaNazwaTowaru { get; set; }
        public int  ilosc { get; set; }
        public string jednostkaMiary { get; set; }
        public string cenaSprzedazyNetto { get; set; }
        public string  cenaSprzedazyBrutto { get; set; }
        public  string  stawkaPodatkuVAT { get; set; }
        public string  wartoscNettoPozycji { get; set; }
        public string wartoscPodatkuVATPozycji { get; set; }

        // stopka

        public  string  tabelaZKwotamiVAT { get; set; }
        public string doZaplaty { get; set; }

    }

   
}

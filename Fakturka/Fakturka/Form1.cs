using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fakturka
{
    public partial class Form1 : Form
    {
        public List<Faktura> Fakturas = new List<Faktura>();
        
        
        public Form1()
        {
            InitializeComponent();
            Faktura faktura = new Faktura();
            

        }
        
        public void SerializeToXml(List<Faktura> f)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Faktura>));
            var textWriter = new StreamWriter(@"D:\faktura.xml");
            serializer.Serialize(textWriter, f);
            textWriter.Close();
        }

       
        

        

        

        

      
       

        

        


       private void CzyscPola()
        {
            nazwaSprzedawcy_tb.Text = "";
            /*ulica_tb.Text = "";
            kodPocztowy_tb.Text = "";
            miejscowosc_tb.Text = "";
            nip_tb.Text = "";*/
        }


        
    }
}

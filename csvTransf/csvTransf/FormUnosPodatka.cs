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

namespace csvTransf
{
    public partial class FormUnosPodatka : Form
    {
        
        List<Ucenik> listaUcenika = new List<Ucenik>();

        // definiranje putanje i dokumenta u koji cemo spremati podatke
   
        string putanja = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "csvTransformerPodaci");
        
        


        public FormUnosPodatka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailUnos.Text.Contains('@')) 
                {
                    Ucenik objUcenik = new Ucenik(txtImeUnos.Text, txtPrezimeUnos.Text, txtEmailUnos.Text, cmbRazredUnos.Text);

                    listaUcenika.Add(objUcenik);


                    txtImeUnos.Clear();
                    txtPrezimeUnos.Clear();
                    txtEmailUnos.Clear();
                    MessageBox.Show("Podaci su uneseni", "Unos OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                { 
                
                }

            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Greška");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(putanja))
            {
                Directory.CreateDirectory(putanja);
            }
            StreamWriter sw = new StreamWriter(putanja + "/podaci.csv");
            sw.WriteLine("Ime,Prezime,Email,Razred");
            foreach(Ucenik uc in listaUcenika)
            {
                sw.WriteLine(uc.Ispis());
            }
            sw.Close();

            this.Close();
        }
    }
}

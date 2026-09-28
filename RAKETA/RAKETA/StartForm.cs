using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAKETA
{
    public partial class StartForm : Form
    {

        Image pozadina = Properties.Resources.pozadina_nova;
        Image OdabranaBojaRakete;
        float BrzinaBroda;
        public StartForm()
        {
            InitializeComponent();
        }

        private void gumbPokreni_Click(object sender, EventArgs e)
        {
            Form1 formaZaIgru = new Form1(OdabranaBojaRakete, BrzinaBroda);
            Visible = false;
            formaZaIgru.ShowDialog();
            Visible = true;

        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbPostavke_Click(object sender, EventArgs e)
        {
            PostavkeForm formaZaPostavke = new PostavkeForm();

            Visible = false;
            formaZaPostavke.ShowDialog();
            
            if (formaZaPostavke.OdabranaBojaRakete != null)
                OdabranaBojaRakete = formaZaPostavke.OdabranaBojaRakete;

            if (formaZaPostavke.OdabranaBrzina > 0)
                BrzinaBroda = formaZaPostavke.OdabranaBrzina;
           
            Visible = true;
        }

        private void gumbPostavke_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void StartForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pozadina, 0, 0, ClientSize.Width, ClientSize.Height);
        }
    }
}

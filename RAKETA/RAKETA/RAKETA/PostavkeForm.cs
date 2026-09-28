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
    public partial class PostavkeForm : Form
    {
        Image pozadina = Properties.Resources.pozadina_nova;
        public Image OdabranaBojaRakete;
        public float OdabranaBrzina;

        public PostavkeForm()
        {
            InitializeComponent();
        }

        private void gumbZatvori_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void gumbPovratak_Click(object sender, EventArgs e)
        {
            
        }

        private void PostavkeForm_Load(object sender, EventArgs e)
        {

        }

        private void PostavkeForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(pozadina, 0, 0, ClientSize.Width, ClientSize.Height);
        }

        private void radioButtonZelena_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZelena.Checked)
                OdabranaBojaRakete = Properties.Resources.raketa_zelena;
        }

        private void radioButtonRoza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRoza.Checked)
                OdabranaBojaRakete = Properties.Resources.raketa_roza;
        }

        private void radioButtonCrvena_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrvena.Checked)
                OdabranaBojaRakete = Properties.Resources.raketa_original;
        }

        private void radioButtonLagano_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLagano.Checked)
                OdabranaBrzina = 5;
        }

        private void radioButtonSrednje_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSrednje.Checked)
                OdabranaBrzina = 10;
        }

        private void radioButtonTesko_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTesko.Checked)
                OdabranaBrzina = 15;
        }
    }
}

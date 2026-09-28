using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RAKETA
{
    public partial class Form1 : Form
    {
        float sirina, visina;
        Image pozadina = Properties.Resources.pozadina_nova;
        Image zid = Properties.Resources.zid;
        float brzinaPozadine, brzinaZida, brzinaBroda, brzinaPrepreke;
        int smjerPrepreka1, smjerPrepreka2;
        float[] koordPozadina, koordZid;
        bool kretanje;
        bool lijevo, desno;
        int bodovi;
        bool krajIgre;
        bool pauza = false;
        Random random = new Random();
        int brojZivota = 3;
        int cooldownStete = 0;




        public Form1(Image OdabranaBojaRakete, float BrzinaBroda)
        {
            
            InitializeComponent();
            sirina = ClientSize.Width;
            visina = ClientSize.Height;
            PocetnePostavke();
            timer1.Start();
            DoubleBuffered = true;
            labelaBodovi.Parent = prepreka1;
            labelaBodovi1.Parent = prepreka2;
            labelaBodovi.Location = new Point(2, 2);
            labelaBodovi1.Location = new Point(2, 2);
            if(OdabranaBojaRakete != null)
                brod.Image = OdabranaBojaRakete;
            if (BrzinaBroda != 0f)
                brzinaBroda = BrzinaBroda;
           
        }


        private void PocetnePostavke()
        {
            brzinaPozadine = 0.5f;
            brzinaZida = 4;
            brzinaBroda = 5;
            brzinaPrepreke = 2;
            smjerPrepreka1 = 1;
            smjerPrepreka2 = -1;
            koordPozadina = new float[] { -visina, 0 };
            koordZid = new float[] { -visina, 0 };
            brod.Location = new Point((int)sirina / 2 - brod.Size.Width / 2, (int)visina - brod.Size.Height - 10 - labelCrniDioDole.Height);
            kretanje = false;
            lijevo = desno = false;
            krajIgre = false;
            labelaRestartPoruka.Visible = false;
            prepreka1.Location = new Point(50, 300);
            prepreka2.Location = new Point(250, 50);
            labelaPauza.Visible = false;
            progressBar1.Value = 1000;
            bodovi = 0;
            povecajBodove(0);
            srce1.Visible = true;
            srce2.Visible = true;
            srce3.Visible = true;
        }

        void povecajBodove(int dobiveniBodovi)
        {
            bodovi += dobiveniBodovi;
            labelaBodovi.Text = "Bodovi: " + bodovi;
            labelaBodovi1.Text = "Bodovi: " + bodovi;
            labelaBodovi2.Text = "Bodovi: " + bodovi;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                labelaPauza.Visible = false;
                timer1.Start();
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (!krajIgre)
            {
                timer1.Stop();
                if (kretanje || lijevo || desno)
                    kretanje = lijevo = desno = false;
                labelaPauza.Visible = true;
            }
        }

        private void labelaBodovi_Click(object sender, EventArgs e)
        {

        }

        private void PomakniPozadinu()
        {
            for (int i = 0; i < 2; i++)
            {
                if (koordPozadina[i] > visina)
                    koordPozadina[i] -= 2 * visina;
                if (koordZid[i] > visina)
                    koordZid[i] -= 2 * visina;
                if (kretanje)
                {
                    koordPozadina[i] += brzinaPozadine;
                    koordZid[i] += brzinaZida;
                }

            }
        }

        private void StvoriKomet()
        {
            PictureBox komet = new PictureBox();
            komet.Size = new Size(20, 20);
            komet.BackColor = Color.Red;
            komet.BorderStyle = BorderStyle.FixedSingle;
            komet.Top = -komet.Height;
            komet.Left = (int)(0.1 * sirina + 1) + random.Next(0, (int)(0.8 * sirina - komet.Width));
            komet.Tag = "komet";
            Controls.Add(komet);
            komet.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StvoriBonusStvar()
        {
            PictureBox stvar = new PictureBox();
            stvar.Size = new Size(40, 40);
            stvar.BackColor = Color.Gold;
            stvar.BorderStyle = BorderStyle.FixedSingle;

            stvar.Left = random.Next(
                (int)(0.1f * sirina),
                (int)(0.9f * sirina - stvar.Width)
            );

            // stvori se iznad ekrana
            stvar.Top = -stvar.Height;

            stvar.Tag = "bonus";
            Controls.Add(stvar);
            stvar.BringToFront();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cooldownStete > 0)
                cooldownStete--;

            PomakniPozadinu();
            if (lijevo && !desno &&
                brod.Left - brzinaBroda >= 0.1 * sirina)
                brod.Left -= (int)brzinaBroda;
            if (desno && !lijevo &&
                brod.Right + brzinaBroda <= 0.9 * sirina)
                brod.Left += (int)brzinaBroda;

            prepreka2.Left += smjerPrepreka2 * (int)brzinaPrepreke;
            prepreka1.Left += smjerPrepreka1 * (int)brzinaPrepreke;

            int lijevaGranica = (int)(0.1f * sirina);
            int desnaGranica = (int)(0.9f * sirina) - prepreka1.Width;

            if (prepreka1.Left <= lijevaGranica)
            {
                prepreka1.Left = lijevaGranica;
                smjerPrepreka1 = 1;
            }
            else if (prepreka1.Left >= desnaGranica)
            {
                prepreka1.Left = desnaGranica;
                smjerPrepreka1 = -1;
            }

            if (prepreka2.Left <= 0.1 * sirina || prepreka2.Right >= 0.9 * sirina)
                smjerPrepreka2 *= -1;

            if (kretanje)
            {
                prepreka1.Top += (int)brzinaZida;
                prepreka2.Top += (int)brzinaZida;
                if (prepreka1.Top > visina)
                {
                    povecajBodove(1);
                    prepreka1.Top = -prepreka1.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }
                if (prepreka2.Top > visina)
                {
                    povecajBodove(1);
                    prepreka2.Top = -prepreka2.Height;
                    progressBar1.Value = Math.Min
                        (progressBar1.Value + 60, 1000);
                }
            }
            progressBar1.Value -= 1;

            if (random.Next() % 100 == 0)
                StvoriKomet();

            if (random.Next() % 100 == 0)
                StvoriBonusStvar();

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x && (string)x.Tag == "komet")
                {
                    x.Top += (int)(kretanje ? (brzinaZida + brzinaBroda) : brzinaZida);

                    if (x.Top > visina)
                    {
                        Controls.RemoveAt(i);
                        x.Dispose();
                        continue;
                    }

                    // sudar -> izgubi život + komet nestane
                    if (brod.Bounds.IntersectsWith(x.Bounds))
                    {
                        IzgubiZivot();
                        Controls.RemoveAt(i);
                        x.Dispose();
                        return; // prekini tick
                    }
                }
            }



            if (progressBar1.Value == 0)
            {
                GameOver();
                return;
            }
            if (brod.Bounds.IntersectsWith(prepreka1.Bounds))
            {
                IzgubiZivot();
                prepreka1.Top = -prepreka1.Height; // nestane odmah
                return; // prekini tick da se ne dogodi još nešto isti frame
            }

            if (brod.Bounds.IntersectsWith(prepreka2.Bounds))
            {
                IzgubiZivot();
                prepreka2.Top = -prepreka2.Height;
                return;
            }



            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x && (string)x.Tag == "bonus")
                {
                    if (kretanje)
                        x.Top += (int)brzinaZida;

                    if (brod.Bounds.IntersectsWith(x.Bounds))
                    {
                        povecajBodove(5);
                        progressBar1.Value = Math.Min(progressBar1.Value + 200, 1000);
                        Controls.RemoveAt(i);
                        x.Dispose();
                    }
                    else if (x.Top > visina)
                    {
                        Controls.RemoveAt(i);
                        x.Dispose();
                    }
                }
            }

            Invalidate();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && kretanje)
                kretanje = false;
            if (e.KeyCode == Keys.Left)
                lijevo = false;
            if (e.KeyCode == Keys.Right)
                desno = false;
            if (e.KeyCode == Keys.R && krajIgre)
            {
                PocetnePostavke();
                timer1.Start();
            }
            if (e.KeyCode == Keys.P)
            {
                pauza = !pauza;

                if (pauza)
                {
                    timer1.Stop();
                    labelaPauza.Visible = true;
                }
                else
                {
                    timer1.Start();
                    labelaPauza.Visible = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !kretanje)
                kretanje = true;
            if (e.KeyCode == Keys.Left)
                lijevo = true;
            if (e.KeyCode == Keys.Right)
                desno = true;
        }

        private void IzgubiZivot()
        {

            brojZivota--;

            if (srce1.Visible) srce1.Visible = false;
            else if (srce2.Visible) srce2.Visible = false;
            else if (srce3.Visible) srce3.Visible = false;

            if (brojZivota == 0)
            {
                GameOver();
                return;
            }
        }


        private void GameOver()
        {
            timer1.Stop();
            krajIgre = true;
            labelaRestartPoruka.Visible = true;
            MessageBox.Show("Osvojeni bodovi: " + bodovi,
                "Igra je završila!");

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox x && (string)x.Tag == "komet")
                {
                    x.Visible = false;
                    Controls.Remove(Controls[i]);
                    x.Dispose();
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                e.Graphics.DrawImage(pozadina, 0, koordPozadina[i], sirina, visina);
            }
            for (int i = 0; i < 2; i++)
            {
                e.Graphics.DrawImage(zid, 0, koordZid[i], 0.1f * sirina, visina);
                e.Graphics.DrawImage(zid, 0.9f * sirina, koordZid[i],
                    0.1f * sirina, visina);
            }
        }
    }
}

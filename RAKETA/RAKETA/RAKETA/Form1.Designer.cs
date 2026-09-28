namespace RAKETA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelaBodovi = new System.Windows.Forms.Label();
            this.labelaRestartPoruka = new System.Windows.Forms.Label();
            this.labelaPauza = new System.Windows.Forms.Label();
            this.labelaBodovi1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.srce3 = new System.Windows.Forms.PictureBox();
            this.srce2 = new System.Windows.Forms.PictureBox();
            this.srce1 = new System.Windows.Forms.PictureBox();
            this.prepreka2 = new System.Windows.Forms.PictureBox();
            this.prepreka1 = new System.Windows.Forms.PictureBox();
            this.brod = new System.Windows.Forms.PictureBox();
            this.labelaBodovi2 = new System.Windows.Forms.Label();
            this.labelCrniDioDole = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelaBodovi
            // 
            this.labelaBodovi.AutoSize = true;
            this.labelaBodovi.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi.ForeColor = System.Drawing.Color.White;
            this.labelaBodovi.Location = new System.Drawing.Point(12, 27);
            this.labelaBodovi.Name = "labelaBodovi";
            this.labelaBodovi.Size = new System.Drawing.Size(141, 32);
            this.labelaBodovi.TabIndex = 1;
            this.labelaBodovi.Text = "Bodovi: 0";
            this.labelaBodovi.Click += new System.EventHandler(this.labelaBodovi_Click);
            // 
            // labelaRestartPoruka
            // 
            this.labelaRestartPoruka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelaRestartPoruka.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaRestartPoruka.Location = new System.Drawing.Point(141, 246);
            this.labelaRestartPoruka.Name = "labelaRestartPoruka";
            this.labelaRestartPoruka.Size = new System.Drawing.Size(207, 70);
            this.labelaRestartPoruka.TabIndex = 4;
            this.labelaRestartPoruka.Text = "Pritisnite R za ponovnu igru.";
            // 
            // labelaPauza
            // 
            this.labelaPauza.AutoSize = true;
            this.labelaPauza.BackColor = System.Drawing.Color.Red;
            this.labelaPauza.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaPauza.Location = new System.Drawing.Point(123, 336);
            this.labelaPauza.Name = "labelaPauza";
            this.labelaPauza.Size = new System.Drawing.Size(241, 32);
            this.labelaPauza.TabIndex = 5;
            this.labelaPauza.Text = "Igra je pauzirana!";
            // 
            // labelaBodovi1
            // 
            this.labelaBodovi1.AutoSize = true;
            this.labelaBodovi1.BackColor = System.Drawing.Color.Transparent;
            this.labelaBodovi1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi1.ForeColor = System.Drawing.Color.White;
            this.labelaBodovi1.Location = new System.Drawing.Point(173, 27);
            this.labelaBodovi1.Name = "labelaBodovi1";
            this.labelaBodovi1.Size = new System.Drawing.Size(141, 32);
            this.labelaBodovi1.TabIndex = 6;
            this.labelaBodovi1.Text = "Bodovi: 0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 27);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // srce3
            // 
            this.srce3.BackColor = System.Drawing.Color.Black;
            this.srce3.Image = global::RAKETA.Properties.Resources.srce;
            this.srce3.Location = new System.Drawing.Point(0, 504);
            this.srce3.Name = "srce3";
            this.srce3.Size = new System.Drawing.Size(57, 50);
            this.srce3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.srce3.TabIndex = 0;
            this.srce3.TabStop = false;
            this.srce3.Tag = "srce1";
            // 
            // srce2
            // 
            this.srce2.BackColor = System.Drawing.Color.Black;
            this.srce2.Image = global::RAKETA.Properties.Resources.srce;
            this.srce2.Location = new System.Drawing.Point(53, 504);
            this.srce2.Name = "srce2";
            this.srce2.Size = new System.Drawing.Size(59, 50);
            this.srce2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.srce2.TabIndex = 1;
            this.srce2.TabStop = false;
            this.srce2.Tag = "srce2";
            // 
            // srce1
            // 
            this.srce1.BackColor = System.Drawing.Color.Black;
            this.srce1.Image = global::RAKETA.Properties.Resources.srce;
            this.srce1.Location = new System.Drawing.Point(105, 504);
            this.srce1.Name = "srce1";
            this.srce1.Size = new System.Drawing.Size(57, 50);
            this.srce1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.srce1.TabIndex = 2;
            this.srce1.TabStop = false;
            this.srce1.Tag = "srce1";
            // 
            // prepreka2
            // 
            this.prepreka2.Image = global::RAKETA.Properties.Resources.prepreka;
            this.prepreka2.Location = new System.Drawing.Point(147, 148);
            this.prepreka2.Name = "prepreka2";
            this.prepreka2.Size = new System.Drawing.Size(217, 52);
            this.prepreka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka2.TabIndex = 3;
            this.prepreka2.TabStop = false;
            // 
            // prepreka1
            // 
            this.prepreka1.Image = global::RAKETA.Properties.Resources.prepreka;
            this.prepreka1.Location = new System.Drawing.Point(147, 77);
            this.prepreka1.Name = "prepreka1";
            this.prepreka1.Size = new System.Drawing.Size(217, 53);
            this.prepreka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prepreka1.TabIndex = 2;
            this.prepreka1.TabStop = false;
            // 
            // brod
            // 
            this.brod.BackColor = System.Drawing.Color.Transparent;
            this.brod.Image = global::RAKETA.Properties.Resources.raketa_original;
            this.brod.Location = new System.Drawing.Point(18, 77);
            this.brod.Name = "brod";
            this.brod.Size = new System.Drawing.Size(57, 93);
            this.brod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brod.TabIndex = 0;
            this.brod.TabStop = false;
            // 
            // labelaBodovi2
            // 
            this.labelaBodovi2.AutoSize = true;
            this.labelaBodovi2.BackColor = System.Drawing.Color.Black;
            this.labelaBodovi2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaBodovi2.ForeColor = System.Drawing.Color.White;
            this.labelaBodovi2.Location = new System.Drawing.Point(349, 513);
            this.labelaBodovi2.Name = "labelaBodovi2";
            this.labelaBodovi2.Size = new System.Drawing.Size(173, 41);
            this.labelaBodovi2.TabIndex = 9;
            this.labelaBodovi2.Text = "Bodovi: 0";
            // 
            // labelCrniDioDole
            // 
            this.labelCrniDioDole.BackColor = System.Drawing.Color.Black;
            this.labelCrniDioDole.Location = new System.Drawing.Point(-3, 504);
            this.labelCrniDioDole.Name = "labelCrniDioDole";
            this.labelCrniDioDole.Size = new System.Drawing.Size(543, 57);
            this.labelCrniDioDole.TabIndex = 10;
            this.labelCrniDioDole.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.labelaBodovi2);
            this.Controls.Add(this.srce1);
            this.Controls.Add(this.srce2);
            this.Controls.Add(this.srce3);
            this.Controls.Add(this.labelCrniDioDole);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelaBodovi1);
            this.Controls.Add(this.labelaPauza);
            this.Controls.Add(this.labelaRestartPoruka);
            this.Controls.Add(this.labelaBodovi);
            this.Controls.Add(this.prepreka2);
            this.Controls.Add(this.prepreka1);
            this.Controls.Add(this.brod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raketa";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.srce3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srce1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepreka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox brod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelaBodovi;
        private System.Windows.Forms.PictureBox prepreka1;
        private System.Windows.Forms.PictureBox prepreka2;
        private System.Windows.Forms.Label labelaRestartPoruka;
        private System.Windows.Forms.Label labelaPauza;
        private System.Windows.Forms.Label labelaBodovi1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox srce3;
        private System.Windows.Forms.PictureBox srce2;
        private System.Windows.Forms.PictureBox srce1;
        private System.Windows.Forms.Label labelaBodovi2;
        private System.Windows.Forms.Label labelCrniDioDole;
    }
}


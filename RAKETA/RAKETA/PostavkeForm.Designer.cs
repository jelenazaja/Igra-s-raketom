namespace RAKETA
{
    partial class PostavkeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostavkeForm));
            this.gumbZatvori = new System.Windows.Forms.Button();
            this.labelaTezine = new System.Windows.Forms.Label();
            this.radioButtonLagano = new System.Windows.Forms.RadioButton();
            this.labelaIzgledRakete = new System.Windows.Forms.Label();
            this.radioButtonSrednje = new System.Windows.Forms.RadioButton();
            this.radioButtonTesko = new System.Windows.Forms.RadioButton();
            this.radioButtonZelena = new System.Windows.Forms.RadioButton();
            this.radioButtonRoza = new System.Windows.Forms.RadioButton();
            this.radioButtonCrvena = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gumbZatvori
            // 
            this.gumbZatvori.BackColor = System.Drawing.Color.Crimson;
            this.gumbZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gumbZatvori.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gumbZatvori.ForeColor = System.Drawing.Color.White;
            this.gumbZatvori.Location = new System.Drawing.Point(161, 420);
            this.gumbZatvori.Name = "gumbZatvori";
            this.gumbZatvori.Size = new System.Drawing.Size(207, 51);
            this.gumbZatvori.TabIndex = 2;
            this.gumbZatvori.Text = "Zatvori";
            this.gumbZatvori.UseVisualStyleBackColor = false;
            this.gumbZatvori.Click += new System.EventHandler(this.gumbZatvori_Click);
            // 
            // labelaTezine
            // 
            this.labelaTezine.AutoSize = true;
            this.labelaTezine.BackColor = System.Drawing.Color.Crimson;
            this.labelaTezine.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaTezine.ForeColor = System.Drawing.Color.White;
            this.labelaTezine.Location = new System.Drawing.Point(125, 55);
            this.labelaTezine.Name = "labelaTezine";
            this.labelaTezine.Size = new System.Drawing.Size(275, 32);
            this.labelaTezine.TabIndex = 4;
            this.labelaTezine.Text = "Odaberi tezinu igre:";
            // 
            // radioButtonLagano
            // 
            this.radioButtonLagano.AutoSize = true;
            this.radioButtonLagano.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonLagano.ForeColor = System.Drawing.Color.White;
            this.radioButtonLagano.Location = new System.Drawing.Point(26, 25);
            this.radioButtonLagano.Name = "radioButtonLagano";
            this.radioButtonLagano.Size = new System.Drawing.Size(104, 28);
            this.radioButtonLagano.TabIndex = 5;
            this.radioButtonLagano.TabStop = true;
            this.radioButtonLagano.Text = "Lagano";
            this.radioButtonLagano.UseVisualStyleBackColor = true;
            this.radioButtonLagano.CheckedChanged += new System.EventHandler(this.radioButtonLagano_CheckedChanged);
            // 
            // labelaIzgledRakete
            // 
            this.labelaIzgledRakete.AutoSize = true;
            this.labelaIzgledRakete.BackColor = System.Drawing.Color.Crimson;
            this.labelaIzgledRakete.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelaIzgledRakete.ForeColor = System.Drawing.Color.White;
            this.labelaIzgledRakete.Location = new System.Drawing.Point(125, 185);
            this.labelaIzgledRakete.Name = "labelaIzgledRakete";
            this.labelaIzgledRakete.Size = new System.Drawing.Size(283, 32);
            this.labelaIzgledRakete.TabIndex = 6;
            this.labelaIzgledRakete.Text = "Odaberi boju rakete:";
            // 
            // radioButtonSrednje
            // 
            this.radioButtonSrednje.AutoSize = true;
            this.radioButtonSrednje.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSrednje.ForeColor = System.Drawing.Color.White;
            this.radioButtonSrednje.Location = new System.Drawing.Point(170, 25);
            this.radioButtonSrednje.Name = "radioButtonSrednje";
            this.radioButtonSrednje.Size = new System.Drawing.Size(105, 28);
            this.radioButtonSrednje.TabIndex = 7;
            this.radioButtonSrednje.TabStop = true;
            this.radioButtonSrednje.Text = "Srednje";
            this.radioButtonSrednje.UseVisualStyleBackColor = true;
            this.radioButtonSrednje.CheckedChanged += new System.EventHandler(this.radioButtonSrednje_CheckedChanged);
            // 
            // radioButtonTesko
            // 
            this.radioButtonTesko.AutoSize = true;
            this.radioButtonTesko.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonTesko.ForeColor = System.Drawing.Color.White;
            this.radioButtonTesko.Location = new System.Drawing.Point(318, 25);
            this.radioButtonTesko.Name = "radioButtonTesko";
            this.radioButtonTesko.Size = new System.Drawing.Size(88, 28);
            this.radioButtonTesko.TabIndex = 8;
            this.radioButtonTesko.TabStop = true;
            this.radioButtonTesko.Text = "Tesko";
            this.radioButtonTesko.UseVisualStyleBackColor = true;
            this.radioButtonTesko.CheckedChanged += new System.EventHandler(this.radioButtonTesko_CheckedChanged);
            // 
            // radioButtonZelena
            // 
            this.radioButtonZelena.AutoSize = true;
            this.radioButtonZelena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonZelena.ForeColor = System.Drawing.Color.White;
            this.radioButtonZelena.Location = new System.Drawing.Point(327, 14);
            this.radioButtonZelena.Name = "radioButtonZelena";
            this.radioButtonZelena.Size = new System.Drawing.Size(94, 28);
            this.radioButtonZelena.TabIndex = 11;
            this.radioButtonZelena.TabStop = true;
            this.radioButtonZelena.Text = "Zelena";
            this.radioButtonZelena.UseVisualStyleBackColor = true;
            this.radioButtonZelena.CheckedChanged += new System.EventHandler(this.radioButtonZelena_CheckedChanged);
            // 
            // radioButtonRoza
            // 
            this.radioButtonRoza.AutoSize = true;
            this.radioButtonRoza.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonRoza.ForeColor = System.Drawing.Color.White;
            this.radioButtonRoza.Location = new System.Drawing.Point(179, 14);
            this.radioButtonRoza.Name = "radioButtonRoza";
            this.radioButtonRoza.Size = new System.Drawing.Size(79, 28);
            this.radioButtonRoza.TabIndex = 10;
            this.radioButtonRoza.TabStop = true;
            this.radioButtonRoza.Text = "Roza";
            this.radioButtonRoza.UseVisualStyleBackColor = true;
            this.radioButtonRoza.CheckedChanged += new System.EventHandler(this.radioButtonRoza_CheckedChanged);
            // 
            // radioButtonCrvena
            // 
            this.radioButtonCrvena.AutoSize = true;
            this.radioButtonCrvena.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonCrvena.ForeColor = System.Drawing.Color.White;
            this.radioButtonCrvena.Location = new System.Drawing.Point(35, 14);
            this.radioButtonCrvena.Name = "radioButtonCrvena";
            this.radioButtonCrvena.Size = new System.Drawing.Size(101, 28);
            this.radioButtonCrvena.TabIndex = 9;
            this.radioButtonCrvena.TabStop = true;
            this.radioButtonCrvena.Text = "Crvena";
            this.radioButtonCrvena.UseVisualStyleBackColor = true;
            this.radioButtonCrvena.CheckedChanged += new System.EventHandler(this.radioButtonCrvena_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonTesko);
            this.panel1.Controls.Add(this.radioButtonSrednje);
            this.panel1.Controls.Add(this.radioButtonLagano);
            this.panel1.Location = new System.Drawing.Point(37, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 75);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonZelena);
            this.panel2.Controls.Add(this.radioButtonRoza);
            this.panel2.Controls.Add(this.radioButtonCrvena);
            this.panel2.Location = new System.Drawing.Point(42, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 63);
            this.panel2.TabIndex = 13;
            // 
            // PostavkeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::RAKETA.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelaIzgledRakete);
            this.Controls.Add(this.labelaTezine);
            this.Controls.Add(this.gumbZatvori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PostavkeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostavkeForm";
            this.Load += new System.EventHandler(this.PostavkeForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PostavkeForm_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbZatvori;
        private System.Windows.Forms.Label labelaTezine;
        private System.Windows.Forms.RadioButton radioButtonLagano;
        private System.Windows.Forms.Label labelaIzgledRakete;
        private System.Windows.Forms.RadioButton radioButtonSrednje;
        private System.Windows.Forms.RadioButton radioButtonTesko;
        private System.Windows.Forms.RadioButton radioButtonZelena;
        private System.Windows.Forms.RadioButton radioButtonRoza;
        private System.Windows.Forms.RadioButton radioButtonCrvena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
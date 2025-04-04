namespace Cw_1a_Kalkulator_walutowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iloscpln = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.waluta = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.Label();
            this.podglad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ile chcesz wymienić złotych:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(33, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Liczymy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iloscpln
            // 
            this.iloscpln.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscpln.Location = new System.Drawing.Point(33, 59);
            this.iloscpln.Name = "iloscpln";
            this.iloscpln.Size = new System.Drawing.Size(229, 40);
            this.iloscpln.TabIndex = 2;
            this.iloscpln.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Na co chcesz wymienić:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(400, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 75);
            this.label3.TabIndex = 4;
            this.label3.Text = "1. EUR 4,18 zł (Euro)\r\n2. CHF 4,38 zł (Frank Szwajcarski)\r\n3. GBP 5,01 zł (Funt B" +
    "rytyjski)";
            // 
            // waluta
            // 
            this.waluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waluta.Location = new System.Drawing.Point(33, 163);
            this.waluta.Name = "waluta";
            this.waluta.Size = new System.Drawing.Size(229, 40);
            this.waluta.TabIndex = 5;
            this.waluta.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(52, 345);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(103, 33);
            this.wynik.TabIndex = 6;
            this.wynik.Text = "Wynik:";
            // 
            // podglad
            // 
            this.podglad.AutoSize = true;
            this.podglad.Location = new System.Drawing.Point(444, 266);
            this.podglad.Name = "podglad";
            this.podglad.Size = new System.Drawing.Size(0, 13);
            this.podglad.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(837, 497);
            this.Controls.Add(this.podglad);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.waluta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iloscpln);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator Walutowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox iloscpln;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox waluta;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label podglad;
    }
}


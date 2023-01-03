namespace ApartmanYönetimSistemi
{
    partial class AnaForm
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
            this.btndaireler = new System.Windows.Forms.Button();
            this.btnveriler = new System.Windows.Forms.Button();
            this.btnkayit = new System.Windows.Forms.Button();
            this.btnfoto = new System.Windows.Forms.Button();
            this.btnhakkimizda = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndaireler
            // 
            this.btndaireler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndaireler.Location = new System.Drawing.Point(95, 42);
            this.btndaireler.Name = "btndaireler";
            this.btndaireler.Size = new System.Drawing.Size(183, 71);
            this.btndaireler.TabIndex = 0;
            this.btndaireler.Text = "Daireler";
            this.btndaireler.UseVisualStyleBackColor = true;
            this.btndaireler.Click += new System.EventHandler(this.btndaireler_Click);
            // 
            // btnveriler
            // 
            this.btnveriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnveriler.Location = new System.Drawing.Point(457, 39);
            this.btnveriler.Name = "btnveriler";
            this.btnveriler.Size = new System.Drawing.Size(183, 74);
            this.btnveriler.TabIndex = 1;
            this.btnveriler.Text = "Borçlar";
            this.btnveriler.UseVisualStyleBackColor = true;
            this.btnveriler.Click += new System.EventHandler(this.btnveriler_Click);
            // 
            // btnkayit
            // 
            this.btnkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayit.Location = new System.Drawing.Point(95, 183);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(183, 74);
            this.btnkayit.TabIndex = 2;
            this.btnkayit.Text = "Kayıt İşlemleri";
            this.btnkayit.UseVisualStyleBackColor = true;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // btnfoto
            // 
            this.btnfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfoto.Location = new System.Drawing.Point(457, 183);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(183, 74);
            this.btnfoto.TabIndex = 3;
            this.btnfoto.Text = "Ödemeler";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // btnhakkimizda
            // 
            this.btnhakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhakkimizda.Location = new System.Drawing.Point(95, 331);
            this.btnhakkimizda.Name = "btnhakkimizda";
            this.btnhakkimizda.Size = new System.Drawing.Size(183, 74);
            this.btnhakkimizda.TabIndex = 4;
            this.btnhakkimizda.Text = "KUR";
            this.btnhakkimizda.UseVisualStyleBackColor = true;
            this.btnhakkimizda.Click += new System.EventHandler(this.btnhakkimizda_Click);
            // 
            // btncikis
            // 
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(457, 331);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(183, 74);
            this.btncikis.TabIndex = 5;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnhakkimizda);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.btnveriler);
            this.Controls.Add(this.btndaireler);
            this.Name = "AnaForm";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndaireler;
        private System.Windows.Forms.Button btnveriler;
        private System.Windows.Forms.Button btnkayit;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.Button btnhakkimizda;
        private System.Windows.Forms.Button btncikis;
    }
}
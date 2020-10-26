namespace veri_madenciligi_odev
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.sayi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDizi = new System.Windows.Forms.Label();
            this.btnSirala = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSiraliDizi = new System.Windows.Forms.Label();
            this.btnOrtDuzg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrtDuzgn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(152, 20);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(128, 23);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Random Dizi Oluştur";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // sayi
            // 
            this.sayi.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sayi.Location = new System.Drawing.Point(78, 23);
            this.sayi.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.sayi.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(68, 20);
            this.sayi.TabIndex = 3;
            this.sayi.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dizi Boyutu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oluşan Dizi";
            // 
            // lblDizi
            // 
            this.lblDizi.AutoSize = true;
            this.lblDizi.Location = new System.Drawing.Point(406, 25);
            this.lblDizi.Name = "lblDizi";
            this.lblDizi.Size = new System.Drawing.Size(0, 13);
            this.lblDizi.TabIndex = 6;
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(152, 49);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(128, 23);
            this.btnSirala.TabIndex = 7;
            this.btnSirala.Text = "Diziyi Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sıralanmış Dizi";
            // 
            // lblSiraliDizi
            // 
            this.lblSiraliDizi.AutoSize = true;
            this.lblSiraliDizi.Location = new System.Drawing.Point(406, 54);
            this.lblSiraliDizi.Name = "lblSiraliDizi";
            this.lblSiraliDizi.Size = new System.Drawing.Size(0, 13);
            this.lblSiraliDizi.TabIndex = 6;
            // 
            // btnOrtDuzg
            // 
            this.btnOrtDuzg.Location = new System.Drawing.Point(152, 79);
            this.btnOrtDuzg.Name = "btnOrtDuzg";
            this.btnOrtDuzg.Size = new System.Drawing.Size(128, 23);
            this.btnOrtDuzg.TabIndex = 8;
            this.btnOrtDuzg.Text = "Ort. ile Düzgünleştir";
            this.btnOrtDuzg.UseVisualStyleBackColor = true;
            this.btnOrtDuzg.Click += new System.EventHandler(this.btnOrtDuzg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Düzgünleşmiş Dizi";
            // 
            // lblOrtDuzgn
            // 
            this.lblOrtDuzgn.AutoSize = true;
            this.lblOrtDuzgn.Location = new System.Drawing.Point(422, 84);
            this.lblOrtDuzgn.Name = "lblOrtDuzgn";
            this.lblOrtDuzgn.Size = new System.Drawing.Size(0, 13);
            this.lblOrtDuzgn.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 450);
            this.Controls.Add(this.btnOrtDuzg);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.lblOrtDuzgn);
            this.Controls.Add(this.lblSiraliDizi);
            this.Controls.Add(this.lblDizi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Veri Madenciliği Ödev";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDizi;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSiraliDizi;
        private System.Windows.Forms.Button btnOrtDuzg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrtDuzgn;
    }
}


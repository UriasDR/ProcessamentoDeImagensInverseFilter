namespace ProcessamentoDeImagensWienerInverso
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btLoad_A = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btFiltro = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txVariance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(535, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 239);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btLoad_A
            // 
            this.btLoad_A.BackColor = System.Drawing.SystemColors.Window;
            this.btLoad_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoad_A.Location = new System.Drawing.Point(77, 299);
            this.btLoad_A.Name = "btLoad_A";
            this.btLoad_A.Size = new System.Drawing.Size(153, 31);
            this.btLoad_A.TabIndex = 2;
            this.btLoad_A.Text = "Carregar Imagem";
            this.btLoad_A.UseVisualStyleBackColor = false;
            this.btLoad_A.Click += new System.EventHandler(this.btLoad_A_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btFiltro
            // 
            this.btFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltro.Location = new System.Drawing.Point(357, 138);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(153, 31);
            this.btFiltro.TabIndex = 5;
            this.btFiltro.Text = "Filtro Inverso";
            this.btFiltro.UseVisualStyleBackColor = false;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(632, 290);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(153, 31);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar Imagem";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txVariance
            // 
            this.txVariance.Location = new System.Drawing.Point(357, 102);
            this.txVariance.Name = "txVariance";
            this.txVariance.Size = new System.Drawing.Size(153, 20);
            this.txVariance.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(861, 351);
            this.Controls.Add(this.txVariance);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.btLoad_A);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btLoad_A;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txVariance;
    }
}
namespace RichTextBoxKontrola
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
            this.citaj = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.spremi = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // citaj
            // 
            this.citaj.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.citaj.Location = new System.Drawing.Point(166, 24);
            this.citaj.Name = "citaj";
            this.citaj.Size = new System.Drawing.Size(118, 31);
            this.citaj.TabIndex = 1;
            this.citaj.Text = "Citaj";
            this.citaj.UseVisualStyleBackColor = true;
            this.citaj.Click += new System.EventHandler(this.citaj_Click);
            // 
            // brisi
            // 
            this.brisi.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brisi.Location = new System.Drawing.Point(320, 24);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(118, 31);
            this.brisi.TabIndex = 2;
            this.brisi.Text = "Briši";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // spremi
            // 
            this.spremi.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spremi.Location = new System.Drawing.Point(166, 276);
            this.spremi.Name = "spremi";
            this.spremi.Size = new System.Drawing.Size(118, 31);
            this.spremi.TabIndex = 3;
            this.spremi.Text = "Spremi";
            this.spremi.UseVisualStyleBackColor = true;
            this.spremi.Click += new System.EventHandler(this.spremi_Click);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(167, 91);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(279, 148);
            this.ispis.TabIndex = 4;
            this.ispis.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.spremi);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.citaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button citaj;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button spremi;
        private System.Windows.Forms.RichTextBox ispis;
    }
}


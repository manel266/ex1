namespace ex1
{
    partial class valider
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
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.vlr1 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.vlr2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(121, 12);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(100, 20);
            this.txtval1.TabIndex = 0;
            // 
            // vlr1
            // 
            this.vlr1.AutoSize = true;
            this.vlr1.Location = new System.Drawing.Point(23, 19);
            this.vlr1.MaximumSize = new System.Drawing.Size(500, 500);
            this.vlr1.Name = "vlr1";
            this.vlr1.Size = new System.Drawing.Size(48, 13);
            this.vlr1.TabIndex = 1;
            this.vlr1.Text = "valeur 1:";
            this.vlr1.Click += new System.EventHandler(this.vlr_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(52, 109);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "somme\r\n";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(121, 48);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(100, 20);
            this.txtval2.TabIndex = 3;
            // 
            // vlr2
            // 
            this.vlr2.AutoSize = true;
            this.vlr2.Location = new System.Drawing.Point(24, 55);
            this.vlr2.Name = "vlr2";
            this.vlr2.Size = new System.Drawing.Size(48, 13);
            this.vlr2.TabIndex = 4;
            this.vlr2.Text = "valeur 2:";
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Location = new System.Drawing.Point(75, 189);
            this.res.MaximumSize = new System.Drawing.Size(500, 500);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(49, 13);
            this.res.TabIndex = 5;
            this.res.Text = "Resultat:";
            this.res.Click += new System.EventHandler(this.label2_Click);
            // 
            // valider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.vlr2);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.vlr1);
            this.Controls.Add(this.txtval1);
            this.Name = "valider";
            this.Text = "valider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.Label vlr1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.Label vlr2;
        private System.Windows.Forms.Label res;
    }
}


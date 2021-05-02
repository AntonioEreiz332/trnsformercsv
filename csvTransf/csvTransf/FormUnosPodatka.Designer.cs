namespace csvTransf
{
    partial class FormUnosPodatka
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImeUnos = new System.Windows.Forms.TextBox();
            this.txtPrezimeUnos = new System.Windows.Forms.TextBox();
            this.txtEmailUnos = new System.Windows.Forms.TextBox();
            this.cmbRazredUnos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Razred";
            // 
            // txtImeUnos
            // 
            this.txtImeUnos.Location = new System.Drawing.Point(16, 29);
            this.txtImeUnos.Name = "txtImeUnos";
            this.txtImeUnos.Size = new System.Drawing.Size(354, 20);
            this.txtImeUnos.TabIndex = 1;
            // 
            // txtPrezimeUnos
            // 
            this.txtPrezimeUnos.Location = new System.Drawing.Point(16, 85);
            this.txtPrezimeUnos.Name = "txtPrezimeUnos";
            this.txtPrezimeUnos.Size = new System.Drawing.Size(354, 20);
            this.txtPrezimeUnos.TabIndex = 2;
            // 
            // txtEmailUnos
            // 
            this.txtEmailUnos.Location = new System.Drawing.Point(16, 141);
            this.txtEmailUnos.Name = "txtEmailUnos";
            this.txtEmailUnos.Size = new System.Drawing.Size(354, 20);
            this.txtEmailUnos.TabIndex = 3;
            // 
            // cmbRazredUnos
            // 
            this.cmbRazredUnos.FormattingEnabled = true;
            this.cmbRazredUnos.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d"});
            this.cmbRazredUnos.Location = new System.Drawing.Point(16, 205);
            this.cmbRazredUnos.Name = "cmbRazredUnos";
            this.cmbRazredUnos.Size = new System.Drawing.Size(354, 21);
            this.cmbRazredUnos.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Unos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Završi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormUnosPodatka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbRazredUnos);
            this.Controls.Add(this.txtEmailUnos);
            this.Controls.Add(this.txtPrezimeUnos);
            this.Controls.Add(this.txtImeUnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUnosPodatka";
            this.Text = "FormUnosPodatka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImeUnos;
        private System.Windows.Forms.TextBox txtPrezimeUnos;
        private System.Windows.Forms.TextBox txtEmailUnos;
        private System.Windows.Forms.ComboBox cmbRazredUnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
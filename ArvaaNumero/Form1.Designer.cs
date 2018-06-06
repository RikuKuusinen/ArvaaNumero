namespace ArvaaNumero
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
            this.arvauksiaJaljella = new System.Windows.Forms.Label();
            this.arvaus = new System.Windows.Forms.TextBox();
            this.arvaa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arvauksiaJaljella
            // 
            this.arvauksiaJaljella.AutoSize = true;
            this.arvauksiaJaljella.Location = new System.Drawing.Point(13, 13);
            this.arvauksiaJaljella.Name = "arvauksiaJaljella";
            this.arvauksiaJaljella.Size = new System.Drawing.Size(129, 17);
            this.arvauksiaJaljella.TabIndex = 0;
            this.arvauksiaJaljella.Text = "Arvauksia jäljellä: 0";
            // 
            // arvaus
            // 
            this.arvaus.Location = new System.Drawing.Point(13, 34);
            this.arvaus.Name = "arvaus";
            this.arvaus.Size = new System.Drawing.Size(100, 22);
            this.arvaus.TabIndex = 1;
            // 
            // arvaa
            // 
            this.arvaa.Location = new System.Drawing.Point(119, 34);
            this.arvaa.Name = "arvaa";
            this.arvaa.Size = new System.Drawing.Size(75, 23);
            this.arvaa.TabIndex = 2;
            this.arvaa.Text = "Arvaa";
            this.arvaa.UseVisualStyleBackColor = true;
            this.arvaa.Click += new System.EventHandler(this.arvaa_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 185);
            this.Controls.Add(this.arvaa);
            this.Controls.Add(this.arvaus);
            this.Controls.Add(this.arvauksiaJaljella);
            this.Name = "Form1";
            this.Text = "Arvaa Numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arvauksiaJaljella;
        private System.Windows.Forms.TextBox arvaus;
        private System.Windows.Forms.Button arvaa;
    }
}


namespace CatalogoFilme.View
{
    partial class Home
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
            this.btnFilme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(291, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que vai assistir?";
            // 
            // btnFilme
            // 
            this.btnFilme.AutoSize = true;
            this.btnFilme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilme.Location = new System.Drawing.Point(98, 268);
            this.btnFilme.Name = "btnFilme";
            this.btnFilme.Size = new System.Drawing.Size(167, 95);
            this.btnFilme.TabIndex = 1;
            this.btnFilme.Text = "Filme";
            this.btnFilme.UseVisualStyleBackColor = true;
            this.btnFilme.Click += new System.EventHandler(this.btnFilme_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(499, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 102);
            this.button1.TabIndex = 2;
            this.button1.Text = "Série";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFilme);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnFilme;
        private Button btnSerie;
        private Button button1;
    }
}
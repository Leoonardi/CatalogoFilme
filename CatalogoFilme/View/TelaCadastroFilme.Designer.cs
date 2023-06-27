namespace CatalogoFilme.View
{
    partial class TelaCadastroFilme
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
            this.label5 = new System.Windows.Forms.Label();
            this.txBoxFilme = new System.Windows.Forms.TextBox();
            this.txBoxEstreia = new System.Windows.Forms.TextBox();
            this.txBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txBoxDuracao = new System.Windows.Forms.TextBox();
            this.txBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro do Filme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estreia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(478, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(478, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // txBoxFilme
            // 
            this.txBoxFilme.Location = new System.Drawing.Point(83, 132);
            this.txBoxFilme.Name = "txBoxFilme";
            this.txBoxFilme.Size = new System.Drawing.Size(231, 23);
            this.txBoxFilme.TabIndex = 5;
            // 
            // txBoxEstreia
            // 
            this.txBoxEstreia.Location = new System.Drawing.Point(83, 206);
            this.txBoxEstreia.Name = "txBoxEstreia";
            this.txBoxEstreia.Size = new System.Drawing.Size(231, 23);
            this.txBoxEstreia.TabIndex = 6;
            // 
            // txBoxCategoria
            // 
            this.txBoxCategoria.FormattingEnabled = true;
            this.txBoxCategoria.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção",
            "Animação",
            "Ação",
            "Suspense",
            "Drama"});
            this.txBoxCategoria.Location = new System.Drawing.Point(478, 132);
            this.txBoxCategoria.Name = "txBoxCategoria";
            this.txBoxCategoria.Size = new System.Drawing.Size(231, 23);
            this.txBoxCategoria.TabIndex = 7;
            // 
            // txBoxDuracao
            // 
            this.txBoxDuracao.Location = new System.Drawing.Point(478, 206);
            this.txBoxDuracao.Name = "txBoxDuracao";
            this.txBoxDuracao.Size = new System.Drawing.Size(231, 23);
            this.txBoxDuracao.TabIndex = 8;
            // 
            // txBox
            // 
            this.txBox.AutoSize = true;
            this.txBox.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.txBox.Image = global::CatalogoFilme.Properties.Resources.film_projector_cinema_icon_icons_com_66132;
            this.txBox.Location = new System.Drawing.Point(524, 309);
            this.txBox.Name = "txBox";
            this.txBox.Size = new System.Drawing.Size(162, 102);
            this.txBox.TabIndex = 9;
            this.txBox.Text = "button1";
            this.txBox.UseVisualStyleBackColor = true;
            this.txBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txBox);
            this.Controls.Add(this.txBoxDuracao);
            this.Controls.Add(this.txBoxCategoria);
            this.Controls.Add(this.txBoxEstreia);
            this.Controls.Add(this.txBoxFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastroFilme";
            this.ShowIcon = false;
            this.Text = "sistema de catalago de filmes - SCF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txBoxFilme;
        private TextBox txBoxEstreia;
        private ComboBox txBoxCategoria;
        private TextBox txBoxDuracao;
        private Button txBox;
    }
}
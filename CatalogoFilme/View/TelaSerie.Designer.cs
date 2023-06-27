namespace CatalogoFilme.View
{
    partial class TelaSerie
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
            this.label7 = new System.Windows.Forms.Label();
            this.txBoxSerie = new System.Windows.Forms.TextBox();
            this.txBoxDuracao = new System.Windows.Forms.TextBox();
            this.txBoxTemporada = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxgenero = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metflix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Série";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(444, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temporadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(249, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duraçâo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(23, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Genêro";
            // 
            // txBoxSerie
            // 
            this.txBoxSerie.Location = new System.Drawing.Point(97, 127);
            this.txBoxSerie.Name = "txBoxSerie";
            this.txBoxSerie.Size = new System.Drawing.Size(100, 23);
            this.txBoxSerie.TabIndex = 7;
            // 
            // txBoxDuracao
            // 
            this.txBoxDuracao.Location = new System.Drawing.Point(325, 127);
            this.txBoxDuracao.Name = "txBoxDuracao";
            this.txBoxDuracao.Size = new System.Drawing.Size(100, 23);
            this.txBoxDuracao.TabIndex = 8;
            // 
            // txBoxTemporada
            // 
            this.txBoxTemporada.Location = new System.Drawing.Point(558, 130);
            this.txBoxTemporada.Name = "txBoxTemporada";
            this.txBoxTemporada.Size = new System.Drawing.Size(100, 23);
            this.txBoxTemporada.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = global::CatalogoFilme.Properties.Resources.pokemon_go_play_game_cinema_film_movie_icon_icons_com_69163;
            this.button1.Location = new System.Drawing.Point(398, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 97);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(259, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cadastro de Série";
            // 
            // txtboxgenero
            // 
            this.txtboxgenero.FormattingEnabled = true;
            this.txtboxgenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Drama",
            "Terror",
            "Suspense",
            "Desenho"});
            this.txtboxgenero.Location = new System.Drawing.Point(97, 204);
            this.txtboxgenero.Name = "txtboxgenero";
            this.txtboxgenero.Size = new System.Drawing.Size(121, 23);
            this.txtboxgenero.TabIndex = 13;
            // 
            // TelaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxgenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txBoxTemporada);
            this.Controls.Add(this.txBoxDuracao);
            this.Controls.Add(this.txBoxSerie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaSerie";
            this.Text = "TelaSerie";
            this.Load += new System.EventHandler(this.TelaSerie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txBoxSerie;
        private TextBox txBoxDuracao;
        private TextBox txBoxTemporada;
        private Button button1;
        private Label label5;
        private ComboBox txtboxgenero;
    }
}
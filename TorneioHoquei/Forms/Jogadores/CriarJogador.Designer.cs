namespace TorneioHoquei.Forms.Jogadores
{
    partial class CriarJogador
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
            label4 = new Label();
            label3 = new Label();
            textNome = new TextBox();
            label2 = new Label();
            textCC = new TextBox();
            button1 = new Button();
            label1 = new Label();
            nCamisola = new TextBox();
            label5 = new Label();
            dataNascimento = new DateTimePicker();
            pCampo = new TextBox();
            comboEquipa = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 16;
            label4.Text = "Posição no Campo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 14;
            label3.Text = "Data de Nascimento";
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 81);
            textNome.Name = "textNome";
            textNome.Size = new Size(153, 23);
            textNome.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // textCC
            // 
            textCC.Location = new Point(12, 28);
            textCC.Name = "textCC";
            textCC.Size = new Size(153, 23);
            textCC.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(51, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 9;
            label1.Text = "Cartão de Cidadão";
            // 
            // nCamisola
            // 
            nCamisola.Location = new Point(12, 238);
            nCamisola.Name = "nCamisola";
            nCamisola.Size = new Size(153, 23);
            nCamisola.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 18;
            label5.Text = "Número da Camisola";
            // 
            // dataNascimento
            // 
            dataNascimento.Location = new Point(12, 139);
            dataNascimento.Name = "dataNascimento";
            dataNascimento.Size = new Size(153, 23);
            dataNascimento.TabIndex = 20;
            // 
            // pCampo
            // 
            pCampo.Location = new Point(12, 194);
            pCampo.Name = "pCampo";
            pCampo.Size = new Size(153, 23);
            pCampo.TabIndex = 21;
            // 
            // comboEquipa
            // 
            comboEquipa.FormattingEnabled = true;
            comboEquipa.Location = new Point(12, 287);
            comboEquipa.Name = "comboEquipa";
            comboEquipa.Size = new Size(153, 23);
            comboEquipa.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 23;
            label6.Text = "Equipa";
            // 
            // CriarJogador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 354);
            Controls.Add(label6);
            Controls.Add(comboEquipa);
            Controls.Add(pCampo);
            Controls.Add(dataNascimento);
            Controls.Add(nCamisola);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textNome);
            Controls.Add(label2);
            Controls.Add(textCC);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CriarJogador";
            Text = "CriarJogador";
            Load += CriarJogador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAnosEx;
        private Label label4;
        private TextBox textNacio;
        private Label label3;
        private TextBox textNome;
        private Label label2;
        private TextBox textCC;
        private Button button1;
        private Label label1;
        private TextBox nCamisola;
        private Label label5;
        private DateTimePicker dataNascimento;
        private TextBox pCampo;
        private ComboBox comboEquipa;
        private Label label6;
    }
}
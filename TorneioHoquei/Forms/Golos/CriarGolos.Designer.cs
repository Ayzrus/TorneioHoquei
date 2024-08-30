namespace TorneioHoquei.Forms.Golos
{
    partial class CriarGolos
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
            textOrdem = new TextBox();
            label5 = new Label();
            label4 = new Label();
            comboJogador = new ComboBox();
            label1 = new Label();
            comboJogo = new ComboBox();
            button1 = new Button();
            title = new Label();
            textTempo = new DateTimePicker();
            SuspendLayout();
            // 
            // textOrdem
            // 
            textOrdem.Location = new Point(12, 78);
            textOrdem.Name = "textOrdem";
            textOrdem.Size = new Size(153, 23);
            textOrdem.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 60);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 32;
            label5.Text = "Ordem";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 31;
            label4.Text = "Jogador";
            // 
            // comboJogador
            // 
            comboJogador.FormattingEnabled = true;
            comboJogador.Location = new Point(12, 188);
            comboJogador.Name = "comboJogador";
            comboJogador.Size = new Size(153, 23);
            comboJogador.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 29;
            label1.Text = "Jogo";
            // 
            // comboJogo
            // 
            comboJogo.FormattingEnabled = true;
            comboJogo.Location = new Point(12, 135);
            comboJogo.Name = "comboJogo";
            comboJogo.Size = new Size(153, 23);
            comboJogo.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(46, 217);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(12, 8);
            title.Name = "title";
            title.Size = new Size(86, 15);
            title.TabIndex = 25;
            title.Text = "Tempo de jogo";
            // 
            // textTempo
            // 
            textTempo.Location = new Point(12, 26);
            textTempo.Name = "textTempo";
            textTempo.Size = new Size(153, 23);
            textTempo.TabIndex = 34;
            // 
            // CriarGolos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 253);
            Controls.Add(textTempo);
            Controls.Add(textOrdem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboJogador);
            Controls.Add(label1);
            Controls.Add(comboJogo);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "CriarGolos";
            Text = "CriarGolos";
            Load += CriarGolos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textOrdem;
        private Label label5;
        private Label label4;
        private ComboBox comboJogador;
        private Label label1;
        private ComboBox comboJogo;
        private Button button1;
        private Label title;
        private DateTimePicker textTempo;
    }
}
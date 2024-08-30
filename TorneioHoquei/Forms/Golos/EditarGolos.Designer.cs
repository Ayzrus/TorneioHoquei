namespace TorneioHoquei.Forms.Golos
{
    partial class EditarGolos : Form
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
            GoloId = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textOrdem
            // 
            textOrdem.Location = new Point(13, 126);
            textOrdem.Name = "textOrdem";
            textOrdem.Size = new Size(153, 23);
            textOrdem.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 108);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 32;
            label5.Text = "Ordem";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 218);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 31;
            label4.Text = "Jogador";
            // 
            // comboJogador
            // 
            comboJogador.FormattingEnabled = true;
            comboJogador.Location = new Point(13, 236);
            comboJogador.Name = "comboJogador";
            comboJogador.Size = new Size(153, 23);
            comboJogador.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 165);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 29;
            label1.Text = "Jogo";
            // 
            // comboJogo
            // 
            comboJogo.FormattingEnabled = true;
            comboJogo.Location = new Point(13, 183);
            comboJogo.Name = "comboJogo";
            comboJogo.Size = new Size(153, 23);
            comboJogo.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(47, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(13, 56);
            title.Name = "title";
            title.Size = new Size(86, 15);
            title.TabIndex = 25;
            title.Text = "Tempo de jogo";
            // 
            // textTempo
            // 
            textTempo.Location = new Point(13, 74);
            textTempo.Name = "textTempo";
            textTempo.Size = new Size(153, 23);
            textTempo.TabIndex = 34;
            // 
            // GoloId
            // 
            GoloId.Location = new Point(12, 30);
            GoloId.Name = "GoloId";
            GoloId.Size = new Size(153, 23);
            GoloId.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 35;
            label2.Text = "Golo Id";
            // 
            // EditarGolos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 302);
            Controls.Add(GoloId);
            Controls.Add(label2);
            Controls.Add(textTempo);
            Controls.Add(textOrdem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboJogador);
            Controls.Add(label1);
            Controls.Add(comboJogo);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "EditarGolos";
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
        private TextBox GoloId;
        private Label label2;
    }
}
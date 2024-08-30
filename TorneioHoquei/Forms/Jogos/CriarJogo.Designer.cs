namespace TorneioHoquei.Forms.Jogos
{
    partial class CriarJogo
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
            label2 = new Label();
            comboEquipaCasa = new ComboBox();
            textLocal = new TextBox();
            button1 = new Button();
            title = new Label();
            label1 = new Label();
            comboEquipaFora = new ComboBox();
            label4 = new Label();
            comboFase = new ComboBox();
            dataJogoPicker = new DateTimePicker();
            label3 = new Label();
            textResultado = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 12;
            label2.Text = "Equipa da Casa";
            // 
            // comboEquipaCasa
            // 
            comboEquipaCasa.FormattingEnabled = true;
            comboEquipaCasa.Location = new Point(12, 180);
            comboEquipaCasa.Name = "comboEquipaCasa";
            comboEquipaCasa.Size = new Size(153, 23);
            comboEquipaCasa.TabIndex = 11;
            // 
            // textLocal
            // 
            textLocal.Location = new Point(12, 71);
            textLocal.Name = "textLocal";
            textLocal.Size = new Size(153, 23);
            textLocal.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(49, 322);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(12, 53);
            title.Name = "title";
            title.Size = new Size(35, 15);
            title.TabIndex = 8;
            title.Text = "Local";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 222);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 14;
            label1.Text = "Equipa de Fora";
            // 
            // comboEquipaFora
            // 
            comboEquipaFora.FormattingEnabled = true;
            comboEquipaFora.Location = new Point(12, 240);
            comboEquipaFora.Name = "comboEquipaFora";
            comboEquipaFora.Size = new Size(153, 23);
            comboEquipaFora.TabIndex = 13;
            comboEquipaFora.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 275);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 18;
            label4.Text = "Fase ";
            // 
            // comboFase
            // 
            comboFase.FormattingEnabled = true;
            comboFase.Location = new Point(12, 293);
            comboFase.Name = "comboFase";
            comboFase.Size = new Size(153, 23);
            comboFase.TabIndex = 17;
            // 
            // dataJogoPicker
            // 
            dataJogoPicker.Location = new Point(12, 22);
            dataJogoPicker.Name = "dataJogoPicker";
            dataJogoPicker.Size = new Size(153, 23);
            dataJogoPicker.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 4);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 21;
            label3.Text = "Data do Jogo";
            // 
            // textResultado
            // 
            textResultado.Location = new Point(12, 123);
            textResultado.Name = "textResultado";
            textResultado.Size = new Size(153, 23);
            textResultado.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 23;
            label5.Text = "Resultado";
            // 
            // CriarJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 354);
            Controls.Add(textResultado);
            Controls.Add(label5);
            Controls.Add(dataJogoPicker);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(comboFase);
            Controls.Add(label1);
            Controls.Add(comboEquipaFora);
            Controls.Add(label2);
            Controls.Add(comboEquipaCasa);
            Controls.Add(textLocal);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "CriarJogo";
            Text = "CriarJogo";
            Load += CriarJogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboEquipaCasa;
        private TextBox textLocal;
        private Button button1;
        private Label title;
        private Label label1;
        private ComboBox comboEquipaFora;
        private Label label4;
        private ComboBox comboFase;
        private DateTimePicker dataJogoPicker;
        private Label label3;
        private TextBox textResultado;
        private Label label5;
    }
}
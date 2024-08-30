namespace TorneioHoquei.Forms.Equipas
{
    partial class CriarEquip
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
            textNome = new TextBox();
            button1 = new Button();
            title = new Label();
            comboTreina = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 28);
            textNome.Name = "textNome";
            textNome.Size = new Size(153, 23);
            textNome.TabIndex = 5;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(45, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(12, 10);
            title.Name = "title";
            title.Size = new Size(95, 15);
            title.TabIndex = 3;
            title.Text = "Nome da Equipa";
            // 
            // comboTreina
            // 
            comboTreina.FormattingEnabled = true;
            comboTreina.Location = new Point(12, 80);
            comboTreina.Name = "comboTreina";
            comboTreina.Size = new Size(153, 23);
            comboTreina.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Treinador";
            // 
            // CriarEquip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 149);
            Controls.Add(label2);
            Controls.Add(comboTreina);
            Controls.Add(textNome);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "CriarEquip";
            Text = "CriarEquipa";
            Load += CriarEquip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private Button button1;
        private Label title;
        private ComboBox comboTreina;
        private Label label2;
    }
}
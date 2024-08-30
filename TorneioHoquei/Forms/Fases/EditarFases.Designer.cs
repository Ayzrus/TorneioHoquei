namespace TorneioHoquei.Forms.Fases
{
    partial class EditarFases : Form
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
            comboTorneio = new ComboBox();
            textNome = new TextBox();
            button1 = new Button();
            title = new Label();
            FaseId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 12;
            label2.Text = "Torneio";
            // 
            // comboTorneio
            // 
            comboTorneio.FormattingEnabled = true;
            comboTorneio.Location = new Point(12, 128);
            comboTorneio.Name = "comboTorneio";
            comboTorneio.Size = new Size(153, 23);
            comboTorneio.TabIndex = 11;
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 71);
            textNome.Name = "textNome";
            textNome.Size = new Size(153, 23);
            textNome.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(51, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(12, 53);
            title.Name = "title";
            title.Size = new Size(72, 15);
            title.TabIndex = 8;
            title.Text = "Tipo de Fase";
            // 
            // FaseId
            // 
            FaseId.Location = new Point(12, 27);
            FaseId.Name = "FaseId";
            FaseId.Size = new Size(153, 23);
            FaseId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 13;
            label1.Text = "Fase Id";
            // 
            // EditarFases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(180, 206);
            Controls.Add(FaseId);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboTorneio);
            Controls.Add(textNome);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "EditarFases";
            Text = "Fases";
            Load += Fases_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboTorneio;
        private TextBox textNome;
        private Button button1;
        private Label title;
        private TextBox FaseId;
        private Label label1;
    }
}
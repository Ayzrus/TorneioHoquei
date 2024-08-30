namespace TorneioHoquei.Forms.Torneio
{
    partial class EditarTorneio : Form
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
            TorneioId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 81);
            textNome.Name = "textNome";
            textNome.Size = new Size(153, 23);
            textNome.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(49, 110);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(12, 63);
            title.Name = "title";
            title.Size = new Size(99, 15);
            title.TabIndex = 6;
            title.Text = "Nome do Torneio";
            // 
            // TorneioId
            // 
            TorneioId.Location = new Point(12, 22);
            TorneioId.Name = "TorneioId";
            TorneioId.Size = new Size(153, 23);
            TorneioId.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Torneio Id";
            // 
            // EditarTorneio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(174, 140);
            Controls.Add(TorneioId);
            Controls.Add(label1);
            Controls.Add(textNome);
            Controls.Add(button1);
            Controls.Add(title);
            Name = "EditarTorneio";
            Text = "CriarTorneio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private Button button1;
        private Label title;
        private TextBox TorneioId;
        private Label label1;
    }
}
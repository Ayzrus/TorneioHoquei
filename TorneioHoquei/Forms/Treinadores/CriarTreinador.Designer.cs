namespace TorneioHoquei.Forms.Treinadores
{
    partial class CriarTreinador
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
            label1 = new Label();
            button1 = new Button();
            textCC = new TextBox();
            textNome = new TextBox();
            label2 = new Label();
            textNacio = new TextBox();
            label3 = new Label();
            textAnosEx = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Cartão de Cidadão";
            // 
            // button1
            // 
            button1.Location = new Point(50, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Criar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textCC
            // 
            textCC.Location = new Point(12, 41);
            textCC.Name = "textCC";
            textCC.Size = new Size(153, 23);
            textCC.TabIndex = 2;
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 94);
            textNome.Name = "textNome";
            textNome.Size = new Size(153, 23);
            textNome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // textNacio
            // 
            textNacio.Location = new Point(12, 152);
            textNacio.Name = "textNacio";
            textNacio.Size = new Size(153, 23);
            textNacio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Nacionalidade";
            // 
            // textAnosEx
            // 
            textAnosEx.Location = new Point(12, 204);
            textAnosEx.Name = "textAnosEx";
            textAnosEx.Size = new Size(153, 23);
            textAnosEx.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 7;
            label4.Text = "Anos de experiência";
            // 
            // CriarTreinador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(171, 273);
            Controls.Add(textAnosEx);
            Controls.Add(label4);
            Controls.Add(textNacio);
            Controls.Add(label3);
            Controls.Add(textNome);
            Controls.Add(label2);
            Controls.Add(textCC);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CriarTreinador";
            Text = "CriarTreinador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textCC;
        private TextBox textNome;
        private Label label2;
        private TextBox textNacio;
        private Label label3;
        private TextBox textAnosEx;
        private Label label4;
    }
}
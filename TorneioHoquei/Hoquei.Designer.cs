namespace TorneioHoquei
{
    partial class Hoquei
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            visualizacao1 = new UserControls.Visualizacao();
            gestaoTreinadores1 = new UserControls.GestaoTreinadores();
            gestaoTorneio1 = new UserControls.GestaoTorneio();
            gestaoEquipaJogadores1 = new UserControls.GestaoEquipaJogadores();
            GestaoEquipJog = new Button();
            GestaoTorneio = new Button();
            Info = new Button();
            GestaoTreina = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(visualizacao1);
            panel1.Controls.Add(gestaoTreinadores1);
            panel1.Controls.Add(gestaoTorneio1);
            panel1.Controls.Add(gestaoEquipaJogadores1);
            panel1.Location = new Point(147, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 596);
            panel1.TabIndex = 0;
            // 
            // visualizacao1
            // 
            visualizacao1.Location = new Point(0, 3);
            visualizacao1.Name = "visualizacao1";
            visualizacao1.Size = new Size(997, 596);
            visualizacao1.TabIndex = 3;
            // 
            // gestaoTreinadores1
            // 
            gestaoTreinadores1.Location = new Point(3, 3);
            gestaoTreinadores1.Name = "gestaoTreinadores1";
            gestaoTreinadores1.Size = new Size(997, 596);
            gestaoTreinadores1.TabIndex = 2;
            // 
            // gestaoTorneio1
            // 
            gestaoTorneio1.Location = new Point(3, 3);
            gestaoTorneio1.Name = "gestaoTorneio1";
            gestaoTorneio1.Size = new Size(997, 596);
            gestaoTorneio1.TabIndex = 1;
            // 
            // gestaoEquipaJogadores1
            // 
            gestaoEquipaJogadores1.Location = new Point(0, 0);
            gestaoEquipaJogadores1.Name = "gestaoEquipaJogadores1";
            gestaoEquipaJogadores1.Size = new Size(997, 596);
            gestaoEquipaJogadores1.TabIndex = 0;
            // 
            // GestaoEquipJog
            // 
            GestaoEquipJog.Location = new Point(12, 12);
            GestaoEquipJog.Name = "GestaoEquipJog";
            GestaoEquipJog.Size = new Size(121, 46);
            GestaoEquipJog.TabIndex = 1;
            GestaoEquipJog.Text = "Gestão de Equipas e Jogadores";
            GestaoEquipJog.UseVisualStyleBackColor = true;
            GestaoEquipJog.Click += GestaoEquipJog_Click;
            // 
            // GestaoTorneio
            // 
            GestaoTorneio.Location = new Point(12, 64);
            GestaoTorneio.Name = "GestaoTorneio";
            GestaoTorneio.Size = new Size(121, 46);
            GestaoTorneio.TabIndex = 2;
            GestaoTorneio.Text = "Gestão do Torneio";
            GestaoTorneio.UseVisualStyleBackColor = true;
            GestaoTorneio.Click += GestaoTorneio_Click;
            // 
            // Info
            // 
            Info.Location = new Point(12, 116);
            Info.Name = "Info";
            Info.Size = new Size(121, 46);
            Info.TabIndex = 3;
            Info.Text = "Visualização de Informações";
            Info.UseVisualStyleBackColor = true;
            Info.Click += Info_Click;
            // 
            // GestaoTreina
            // 
            GestaoTreina.Location = new Point(12, 168);
            GestaoTreina.Name = "GestaoTreina";
            GestaoTreina.Size = new Size(121, 46);
            GestaoTreina.TabIndex = 4;
            GestaoTreina.Text = "Gestão de Treinadores";
            GestaoTreina.UseVisualStyleBackColor = true;
            GestaoTreina.Click += GestaoTreina_Click;
            // 
            // Hoquei
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1156, 620);
            Controls.Add(GestaoTreina);
            Controls.Add(Info);
            Controls.Add(GestaoTorneio);
            Controls.Add(GestaoEquipJog);
            Controls.Add(panel1);
            Name = "Hoquei";
            Text = "Hoquei";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button GestaoEquipJog;
        private Button GestaoTorneio;
        private Button Info;
        private Button GestaoTreina;
        private UserControls.Visualizacao visualizacao1;
        private UserControls.GestaoTreinadores gestaoTreinadores1;
        private UserControls.GestaoTorneio gestaoTorneio1;
        private UserControls.GestaoEquipaJogadores gestaoEquipaJogadores1;
    }
}

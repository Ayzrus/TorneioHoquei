namespace TorneioHoquei.UserControls
{
    partial class GestaoEquipaJogadores
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            dataEquipas = new DataGridView();
            TitleData = new Label();
            dataJogadores = new DataGridView();
            TitleDataJog = new Label();
            RegistarEquipa = new Button();
            RegistarJogador = new Button();
            editarEquipa = new Button();
            EditarJogador = new Button();
            ((System.ComponentModel.ISupportInitialize)dataEquipas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataJogadores).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(389, 10);
            Title.Name = "Title";
            Title.Size = new Size(168, 15);
            Title.TabIndex = 0;
            Title.Text = "Gestão de Equipas e Jogadores";
            // 
            // dataEquipas
            // 
            dataEquipas.BackgroundColor = Color.White;
            dataEquipas.BorderStyle = BorderStyle.None;
            dataEquipas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEquipas.Location = new Point(3, 204);
            dataEquipas.Name = "dataEquipas";
            dataEquipas.Size = new Size(491, 389);
            dataEquipas.TabIndex = 1;
            dataEquipas.CellDoubleClick += dataEquipas_CellDoubleClick;
            // 
            // TitleData
            // 
            TitleData.AutoSize = true;
            TitleData.Location = new Point(13, 179);
            TitleData.Name = "TitleData";
            TitleData.Size = new Size(48, 15);
            TitleData.TabIndex = 2;
            TitleData.Text = "Equipas";
            // 
            // dataJogadores
            // 
            dataJogadores.BackgroundColor = Color.White;
            dataJogadores.BorderStyle = BorderStyle.None;
            dataJogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataJogadores.Location = new Point(503, 204);
            dataJogadores.Name = "dataJogadores";
            dataJogadores.Size = new Size(491, 389);
            dataJogadores.TabIndex = 3;
            dataJogadores.CellDoubleClick += dataJogadores_CellDoubleClick;
            // 
            // TitleDataJog
            // 
            TitleDataJog.AutoSize = true;
            TitleDataJog.Location = new Point(503, 179);
            TitleDataJog.Name = "TitleDataJog";
            TitleDataJog.Size = new Size(60, 15);
            TitleDataJog.TabIndex = 4;
            TitleDataJog.Text = "Jogadores";
            // 
            // RegistarEquipa
            // 
            RegistarEquipa.Location = new Point(378, 171);
            RegistarEquipa.Name = "RegistarEquipa";
            RegistarEquipa.Size = new Size(116, 23);
            RegistarEquipa.TabIndex = 6;
            RegistarEquipa.Text = "Registar Equipa";
            RegistarEquipa.UseVisualStyleBackColor = true;
            RegistarEquipa.Click += RegistarEquipa_Click;
            // 
            // RegistarJogador
            // 
            RegistarJogador.Location = new Point(878, 171);
            RegistarJogador.Name = "RegistarJogador";
            RegistarJogador.Size = new Size(116, 23);
            RegistarJogador.TabIndex = 7;
            RegistarJogador.Text = "Registar Jogador";
            RegistarJogador.UseVisualStyleBackColor = true;
            RegistarJogador.Click += RegistarJogador_Click;
            // 
            // editarEquipa
            // 
            editarEquipa.Location = new Point(256, 171);
            editarEquipa.Name = "editarEquipa";
            editarEquipa.Size = new Size(116, 23);
            editarEquipa.TabIndex = 8;
            editarEquipa.Text = "Editar Equipa";
            editarEquipa.UseVisualStyleBackColor = true;
            editarEquipa.Click += editarEquipa_Click;
            // 
            // EditarJogador
            // 
            EditarJogador.Location = new Point(756, 171);
            EditarJogador.Name = "EditarJogador";
            EditarJogador.Size = new Size(116, 23);
            EditarJogador.TabIndex = 9;
            EditarJogador.Text = "Editar Jogador";
            EditarJogador.UseVisualStyleBackColor = true;
            EditarJogador.Click += EditarJogador_Click;
            // 
            // GestaoEquipaJogadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(EditarJogador);
            Controls.Add(editarEquipa);
            Controls.Add(RegistarJogador);
            Controls.Add(RegistarEquipa);
            Controls.Add(TitleDataJog);
            Controls.Add(dataJogadores);
            Controls.Add(TitleData);
            Controls.Add(dataEquipas);
            Controls.Add(Title);
            Name = "GestaoEquipaJogadores";
            Size = new Size(997, 596);
            Load += GestaoEquipaJogadores_Load;
            ((System.ComponentModel.ISupportInitialize)dataEquipas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataJogadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataEquipas;
        private Label TitleData;
        private DataGridView dataJogadores;
        private Label TitleDataJog;
        private Button RegistarEquipa;
        private Button RegistarJogador;
        private Button editarEquipa;
        private Button EditarJogador;
    }
}

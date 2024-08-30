namespace TorneioHoquei.UserControls
{
    partial class Visualizacao
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
            TitleDataJog = new Label();
            dataJogadores = new DataGridView();
            TitleData = new Label();
            dataCalendario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataJogadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataCalendario).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(400, 13);
            Title.Name = "Title";
            Title.Size = new Size(156, 15);
            Title.TabIndex = 2;
            Title.Text = "Visualização de Informações";
            // 
            // TitleDataJog
            // 
            TitleDataJog.AutoSize = true;
            TitleDataJog.Location = new Point(503, 179);
            TitleDataJog.Name = "TitleDataJog";
            TitleDataJog.Size = new Size(136, 15);
            TitleDataJog.TabIndex = 8;
            TitleDataJog.Text = "Estatisticas de Jogadores";
            // 
            // dataJogadores
            // 
            dataJogadores.BackgroundColor = Color.White;
            dataJogadores.BorderStyle = BorderStyle.None;
            dataJogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataJogadores.Location = new Point(503, 204);
            dataJogadores.Name = "dataJogadores";
            dataJogadores.Size = new Size(491, 389);
            dataJogadores.TabIndex = 7;
            // 
            // TitleData
            // 
            TitleData.AutoSize = true;
            TitleData.Location = new Point(13, 179);
            TitleData.Name = "TitleData";
            TitleData.Size = new Size(113, 15);
            TitleData.TabIndex = 6;
            TitleData.Text = "Calendario de Jogos";
            // 
            // dataCalendario
            // 
            dataCalendario.BackgroundColor = Color.White;
            dataCalendario.BorderStyle = BorderStyle.None;
            dataCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCalendario.Location = new Point(3, 204);
            dataCalendario.Name = "dataCalendario";
            dataCalendario.Size = new Size(491, 389);
            dataCalendario.TabIndex = 5;
            // 
            // Visualizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(TitleDataJog);
            Controls.Add(dataJogadores);
            Controls.Add(TitleData);
            Controls.Add(dataCalendario);
            Controls.Add(Title);
            Name = "Visualizacao";
            Size = new Size(997, 596);
            Load += Visualizacao_Load;
            ((System.ComponentModel.ISupportInitialize)dataJogadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label TitleDataJog;
        private DataGridView dataJogadores;
        private Label TitleData;
        private DataGridView dataCalendario;
    }
}

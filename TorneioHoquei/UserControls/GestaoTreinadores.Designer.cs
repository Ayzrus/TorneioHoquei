namespace TorneioHoquei.UserControls
{
    partial class GestaoTreinadores
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
            dataTreinadores = new DataGridView();
            TitleData = new Label();
            RegistarTreinador = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataTreinadores).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(413, 11);
            Title.Name = "Title";
            Title.Size = new Size(122, 15);
            Title.TabIndex = 2;
            Title.Text = "Gestão de Treinadores";
            // 
            // dataTreinadores
            // 
            dataTreinadores.BackgroundColor = Color.White;
            dataTreinadores.BorderStyle = BorderStyle.None;
            dataTreinadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTreinadores.Location = new Point(3, 204);
            dataTreinadores.Name = "dataTreinadores";
            dataTreinadores.Size = new Size(991, 389);
            dataTreinadores.TabIndex = 3;
            dataTreinadores.CellDoubleClick += dataTreinadores_CellDoubleClick;
            // 
            // TitleData
            // 
            TitleData.AutoSize = true;
            TitleData.Location = new Point(3, 186);
            TitleData.Name = "TitleData";
            TitleData.Size = new Size(67, 15);
            TitleData.TabIndex = 4;
            TitleData.Text = "Treinadores";
            // 
            // RegistarTreinador
            // 
            RegistarTreinador.Location = new Point(878, 182);
            RegistarTreinador.Name = "RegistarTreinador";
            RegistarTreinador.Size = new Size(116, 23);
            RegistarTreinador.TabIndex = 5;
            RegistarTreinador.Text = "Registar Treinador";
            RegistarTreinador.UseVisualStyleBackColor = true;
            RegistarTreinador.Click += RegistarTreinador_Click;
            // 
            // button1
            // 
            button1.Location = new Point(746, 182);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 6;
            button1.Text = "Editar Treinador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GestaoTreinadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(RegistarTreinador);
            Controls.Add(TitleData);
            Controls.Add(dataTreinadores);
            Controls.Add(Title);
            Name = "GestaoTreinadores";
            Size = new Size(997, 596);
            Load += GestaoTreinadores_Load;
            ((System.ComponentModel.ISupportInitialize)dataTreinadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataTreinadores;
        private Label TitleData;
        private Button RegistarTreinador;
        private Button button1;
    }
}

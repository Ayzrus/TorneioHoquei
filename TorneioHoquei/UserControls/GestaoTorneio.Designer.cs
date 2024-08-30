namespace TorneioHoquei.UserControls
{
    partial class GestaoTorneio
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
            dataTorneio = new DataGridView();
            TitleData = new Label();
            RegistarTorneio = new Button();
            RegistarFases = new Button();
            label1 = new Label();
            dataFases = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            dataJogos = new DataGridView();
            button2 = new Button();
            label3 = new Label();
            dataGolos = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataTorneio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataFases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataJogos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGolos).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(432, 9);
            Title.Name = "Title";
            Title.Size = new Size(102, 15);
            Title.TabIndex = 1;
            Title.Text = "Gestão do Torneio";
            // 
            // dataTorneio
            // 
            dataTorneio.BackgroundColor = Color.White;
            dataTorneio.BorderStyle = BorderStyle.None;
            dataTorneio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTorneio.Location = new Point(3, 204);
            dataTorneio.Name = "dataTorneio";
            dataTorneio.Size = new Size(168, 389);
            dataTorneio.TabIndex = 2;
            dataTorneio.CellDoubleClick += dataTorneio_CellDoubleClick;
            // 
            // TitleData
            // 
            TitleData.AutoSize = true;
            TitleData.Location = new Point(3, 186);
            TitleData.Name = "TitleData";
            TitleData.Size = new Size(46, 15);
            TitleData.TabIndex = 3;
            TitleData.Text = "Torneio";
            // 
            // RegistarTorneio
            // 
            RegistarTorneio.Location = new Point(55, 178);
            RegistarTorneio.Name = "RegistarTorneio";
            RegistarTorneio.Size = new Size(116, 23);
            RegistarTorneio.TabIndex = 7;
            RegistarTorneio.Text = "Registar Torneio";
            RegistarTorneio.UseVisualStyleBackColor = true;
            RegistarTorneio.Click += RegistarTorneio_Click;
            // 
            // RegistarFases
            // 
            RegistarFases.Location = new Point(310, 178);
            RegistarFases.Name = "RegistarFases";
            RegistarFases.Size = new Size(116, 23);
            RegistarFases.TabIndex = 10;
            RegistarFases.Text = "Registar Fases";
            RegistarFases.UseVisualStyleBackColor = true;
            RegistarFases.Click += RegistarFases_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 186);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 9;
            label1.Text = "Fases";
            // 
            // dataFases
            // 
            dataFases.BackgroundColor = Color.White;
            dataFases.BorderStyle = BorderStyle.None;
            dataFases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFases.Location = new Point(177, 204);
            dataFases.Name = "dataFases";
            dataFases.Size = new Size(249, 389);
            dataFases.TabIndex = 8;
            dataFases.CellDoubleClick += dataFases_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(613, 178);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 13;
            button1.Text = "Registar Jogos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 186);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 12;
            label2.Text = "Jogos";
            // 
            // dataJogos
            // 
            dataJogos.BackgroundColor = Color.White;
            dataJogos.BorderStyle = BorderStyle.None;
            dataJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataJogos.Location = new Point(432, 204);
            dataJogos.Name = "dataJogos";
            dataJogos.Size = new Size(297, 389);
            dataJogos.TabIndex = 11;
            dataJogos.CellDoubleClick += dataJogos_CellDoubleClick;
            // 
            // button2
            // 
            button2.Location = new Point(878, 178);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 16;
            button2.Text = "Registar Golos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(745, 186);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 15;
            label3.Text = "Golos";
            // 
            // dataGolos
            // 
            dataGolos.BackgroundColor = Color.White;
            dataGolos.BorderStyle = BorderStyle.None;
            dataGolos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGolos.Location = new Point(745, 204);
            dataGolos.Name = "dataGolos";
            dataGolos.Size = new Size(249, 389);
            dataGolos.TabIndex = 14;
            dataGolos.CellDoubleClick += dataGolos_CellDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(55, 149);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 17;
            button3.Text = "Editar Torneio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(310, 149);
            button4.Name = "button4";
            button4.Size = new Size(116, 23);
            button4.TabIndex = 18;
            button4.Text = "Editar Fases";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(613, 149);
            button5.Name = "button5";
            button5.Size = new Size(116, 23);
            button5.TabIndex = 19;
            button5.Text = "Editar Jogos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(878, 149);
            button6.Name = "button6";
            button6.Size = new Size(116, 23);
            button6.TabIndex = 20;
            button6.Text = "Editar Golos";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // GestaoTorneio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dataGolos);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataJogos);
            Controls.Add(RegistarFases);
            Controls.Add(label1);
            Controls.Add(dataFases);
            Controls.Add(RegistarTorneio);
            Controls.Add(TitleData);
            Controls.Add(dataTorneio);
            Controls.Add(Title);
            Name = "GestaoTorneio";
            Size = new Size(997, 596);
            Load += GestaoTorneio_Load;
            ((System.ComponentModel.ISupportInitialize)dataTorneio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataFases).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataJogos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGolos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataTorneio;
        private Label TitleData;
        private Button RegistarTorneio;
        private Button RegistarFases;
        private Label label1;
        private DataGridView dataFases;
        private Button button1;
        private Label label2;
        private DataGridView dataJogos;
        private Button button2;
        private Label label3;
        private DataGridView dataGolos;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}

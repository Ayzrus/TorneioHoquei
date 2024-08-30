using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneioHoquei.Models;

namespace TorneioHoquei.Forms.Fases
{
    public partial class EditarFases : Form
    {

        public event EventHandler? FaseInserida;

        public EditarFases()
        {
            InitializeComponent();
        }

        private void CarregarTorneios()
        {
            try
            {
                List<Torneios> torneios = Torneios.GetTorneios();
                comboTorneio.DataSource = torneios;
                comboTorneio.DisplayMember = "Nome";
                comboTorneio.ValueMember = "TorneioID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os torneios: " + ex.Message);
            }
        }

        private void Fases_Load(object sender, EventArgs e)
        {
            CarregarTorneios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Coletar dados do formulário
            string nomeFase = textNome.Text;

            // Validar os dados inseridos
            if (string.IsNullOrWhiteSpace(nomeFase))
            {
                MessageBox.Show("Por favor, insira o nome da fase.");
                return;
            }

            if (comboTorneio.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um torneio.");
                return;
            }

            int torneioId = (int)comboTorneio.SelectedValue;

            // Criar o objeto Fase
            var fase = new Fase
            {
                FaseID = int.Parse(FaseId.Text),
                Tipo = nomeFase,
                TorneioID = torneioId
            };

            try
            {
                Fase.AtualizarFase(fase);
                FaseInserida?.Invoke(this, EventArgs.Empty);
                Close();
                MessageBox.Show("Fase editada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a fase: " + ex.Message);
            }
        }

    }
}

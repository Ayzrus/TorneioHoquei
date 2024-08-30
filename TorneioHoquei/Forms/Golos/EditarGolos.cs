using Org.BouncyCastle.Asn1.Cms;
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

namespace TorneioHoquei.Forms.Golos
{
    public partial class EditarGolos : Form
    {

        public event EventHandler? GolosInserido;

        public EditarGolos()
        {
            InitializeComponent();
            textTempo.Format = DateTimePickerFormat.Custom;
            textTempo.CustomFormat = "HH:mm";
        }

        private void CarregarJogos()
        {
            try
            {
                List<Jogo> jogos = Jogo.GetJogos();
                comboJogo.DataSource = jogos;
                comboJogo.DisplayMember = "Local";
                comboJogo.ValueMember = "JogoID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os jogos: " + ex.Message);
            }
        }

        private void CarregarJogadores()
        {
            try
            {
                List<Jogador> jogadores = Jogador.GetJogadores();
                comboJogador.DataSource = jogadores;
                comboJogador.DisplayMember = "Nome";
                comboJogador.ValueMember = "CartaoCidadao";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os jogadores: " + ex.Message);
            }
        }

        private void CriarGolos_Load(object sender, EventArgs e)
        {
            CarregarJogos();
            CarregarJogadores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tempo = textTempo.Value;
            int ordem = int.Parse(textOrdem.Text);

            if (string.IsNullOrWhiteSpace(textOrdem.Text))
            {
                MessageBox.Show("Por favor, insira a ordem do gol.");
                return;
            }

            if (comboJogo.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um jogo.");
                return;
            }

            if (comboJogador.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um jogador.");
                return;
            }

            int jogoId = (int)comboJogo.SelectedValue;
            string jogadorId = (string)comboJogador.SelectedValue;

            Golo gol = new()
            {
                GoloID = int.Parse(GoloId.Text),
                TempoJogo = tempo,
                Ordem = ordem,
                JogoID = jogoId,
                JogadorID = jogadorId
            };

            try
            {
                Golo.AtualizarGolo(gol);
                GolosInserido?.Invoke(this, EventArgs.Empty);
                Close();
                MessageBox.Show("Gol editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar o gol: " + ex.Message);
            }
        }
    }
}

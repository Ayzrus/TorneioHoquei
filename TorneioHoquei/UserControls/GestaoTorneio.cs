using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneioHoquei.Forms.Equipas;
using TorneioHoquei.Forms.Fases;
using TorneioHoquei.Forms.Geral;
using TorneioHoquei.Forms.Golos;
using TorneioHoquei.Forms.Jogos;
using TorneioHoquei.Forms.Torneio;
using TorneioHoquei.Models;

namespace TorneioHoquei.UserControls
{
    public partial class GestaoTorneio : UserControl
    {
        public GestaoTorneio()
        {
            InitializeComponent();
        }

        private void CarregarTorneio()
        {
            try
            {
                var listaTorneios = Torneios.GetTorneios();

                dataTorneio.DataSource = listaTorneios;

                if (dataTorneio is DataGridView gridView)
                {
                    gridView.Columns["TorneioID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Torneios: " + ex.Message);
            }
        }

        private void CarregarFases()
        {
            try
            {
                var listaFases = Fase.GetFases();

                dataFases.DataSource = listaFases;

                if (dataFases is DataGridView gridView)
                {
                    gridView.Columns["TorneioID"].Visible = false;
                    gridView.Columns["FaseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as Fases: " + ex.Message);
            }
        }

        private void CarregarJogos()
        {
            try
            {
                var listaJogos = Jogo.GetJogos();

                dataJogos.DataSource = listaJogos;

                if (dataJogos is DataGridView gridView)
                {
                    gridView.Columns["EquipeCasa"].Visible = false;
                    gridView.Columns["EquipeFora"].Visible = false;
                    gridView.Columns["FaseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Jogos: " + ex.Message);
            }
        }

        private void CarregarGolos()
        {
            try
            {
                var listaGolos = Golo.GetGolos();

                dataGolos.DataSource = listaGolos;

                if (dataGolos is DataGridView gridView)
                {
                    gridView.Columns["GoloID"].Visible = false;
                    gridView.Columns["JogoID"].Visible = false;
                    gridView.Columns["JogadorID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Golos: " + ex.Message);
            }
        }

        private void GestaoTorneio_Load(object sender, EventArgs e)
        {
            CarregarTorneio();
            CarregarFases();
            CarregarJogos();
            CarregarGolos();
        }

        private void RegistarTorneio_Click(object sender, EventArgs e)
        {
            CriarTorneio criarTorneio = new();
            criarTorneio.TorneioInserido += TorneioInserido;
            criarTorneio.Show();
        }

        private void TorneioInserido(object sender, EventArgs e)
        {
            CarregarTorneio();
        }

        private void FaseInserida(object sender, EventArgs e)
        {
            CarregarFases();
        }

        private void JogoInserido(object sender, EventArgs e)
        {
            CarregarJogos();
        }

        private void GolosInserido(object sender, EventArgs e)
        {
            CarregarGolos();
        }

        private void RegistarFases_Click(object sender, EventArgs e)
        {
            CriarFases criarFases = new();
            criarFases.FaseInserida += FaseInserida;
            criarFases.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CriarJogo criarJogo = new();
            criarJogo.JogoInserido += JogoInserido;
            criarJogo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriarGolos criarGolos = new();
            criarGolos.GolosInserido += GolosInserido;
            criarGolos.Show();
        }

        private void dataTorneio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataTorneio.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Torneios.ExcluirTorneio(int.Parse(selectedId));
                    CarregarTorneio();
                }
            }
        }

        private void dataFases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataFases.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Fase.ExcluirFase(int.Parse(selectedId));
                    CarregarFases();
                }
            }
        }

        private void dataJogos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataJogos.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Jogo.ExcluirJogo(int.Parse(selectedId));
                    CarregarJogos();
                }
            }
        }

        private void dataGolos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataGolos.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Golo.ExcluirGolo(int.Parse(selectedId));
                    CarregarGolos();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarTorneio editarTorneio = new();
            editarTorneio.TorneioInserido += TorneioInserido;
            editarTorneio.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditarFases editarFases = new();
            editarFases.FaseInserida += FaseInserida;
            editarFases.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EditarJogo editarJogo = new();
            editarJogo.JogoInserido += JogoInserido;
            editarJogo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditarGolos editarGolos = new();
            editarGolos.GolosInserido += GolosInserido;
            editarGolos.Show();
        }
    }
}

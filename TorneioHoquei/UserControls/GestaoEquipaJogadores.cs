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
using TorneioHoquei.Forms.Geral;
using TorneioHoquei.Forms.Jogadores;
using TorneioHoquei.Models;

namespace TorneioHoquei.UserControls
{
    public partial class GestaoEquipaJogadores : UserControl
    {
        public GestaoEquipaJogadores()
        {
            InitializeComponent();
        }

        private void RegistarEquipa_Click(object sender, EventArgs e)
        {
            CriarEquip criarEquip = new();
            criarEquip.EquipaInserida += EquipaInserida;
            criarEquip.Show();
        }

        private void CarregarEquipa()
        {
            try
            {
                var listaEquipas = Equipa.GetEquipas();

                dataEquipas.DataSource = listaEquipas;

                if (dataEquipas is DataGridView gridView)
                {
                    gridView.Columns["EquipeID"].Visible = false;
                    gridView.Columns["TreinadorID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as Equipas: " + ex.Message);
            }
        }

        private void CarregarJogador()
        {
            try
            {
                var listaJogadores = Jogador.GetJogadores();

                dataJogadores.DataSource = listaJogadores;

                if (dataJogadores is DataGridView gridView)
                {
                    gridView.Columns["EquipeID"].Visible = false;
                    gridView.Columns["CartaoCidadaoAntigo"].Visible = false;
                    gridView.Columns["DatasJogos"].Visible = false;
                    gridView.Columns["LocaisJogos"].Visible = false;
                    gridView.Columns["TotalGols"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os Jogadores: " + ex.Message);
            }
        }

        private void EquipaInserida(object sender, EventArgs e)
        {
            CarregarEquipa();
        }

        private void JogadorInserido(object sender, EventArgs e)
        {
            CarregarJogador();
        }

        private void GestaoEquipaJogadores_Load(object sender, EventArgs e)
        {
            CarregarEquipa();
            CarregarJogador();
        }

        private void RegistarJogador_Click(object sender, EventArgs e)
        {
            CriarJogador criarJogador = new();
            criarJogador.JogadorInserido += JogadorInserido;
            criarJogador.Show();
        }

        private void dataJogadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string? id = dataJogadores.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Jogador.ExcluirJogador(id);
                    CarregarJogador();
                }
            }
        }

        private void dataEquipas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataEquipas.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Equipa.ExcluirEquipa(int.Parse(selectedId));
                    CarregarEquipa();
                }
            }
        }

        private void editarEquipa_Click(object sender, EventArgs e)
        {
            EditarEquipa editarEquipa = new();
            editarEquipa.EquipaInserida += EquipaInserida;
            editarEquipa.Show();
        }

        private void EditarJogador_Click(object sender, EventArgs e)
        {
            EditarJogador editarJogador = new();
            editarJogador.JogadorInserido += JogadorInserido;
            editarJogador.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneioHoquei.Forms.Geral;
using TorneioHoquei.Forms.Treinadores;
using TorneioHoquei.Models;

namespace TorneioHoquei.UserControls
{
    public partial class GestaoTreinadores : UserControl
    {
        public GestaoTreinadores()
        {
            InitializeComponent();
        }

        private void RegistarTreinador_Click(object sender, EventArgs e)
        {
            CriarTreinador criarTreinador = new();
            criarTreinador.TreinadorInserido += TreinadorCriado;
            criarTreinador.Show();
        }

        private void CarregarTreinadores()
        {
            try
            {
                var listaTreinadores = Treinador.GetTreinadores();

                dataTreinadores.DataSource = listaTreinadores;

                if (dataTreinadores is DataGridView gridView)
                {
                    gridView.Columns["TreinadorId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os treinadores: " + ex.Message);
            }
        }

        private void TreinadorCriado(object sender, EventArgs e)
        {
            CarregarTreinadores();
        }

        private void GestaoTreinadores_Load(object sender, EventArgs e)
        {
            CarregarTreinadores();
        }

        private void dataTreinadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? selectedId = dataTreinadores.Rows[e.RowIndex].Cells[0].Value.ToString();

                Apagar apagarForm = new();
                if (apagarForm.ShowDialog() == DialogResult.OK)
                {
                    Treinador.ExcluirTreinador(int.Parse(selectedId));
                    CarregarTreinadores();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarTreinador editarTreinador = new();
            editarTreinador.TreinadorInserido += TreinadorCriado;
            editarTreinador.Show();
        }
    }
}

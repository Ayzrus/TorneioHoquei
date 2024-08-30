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

namespace TorneioHoquei.UserControls
{
    public partial class Visualizacao : UserControl
    {
        public Visualizacao()
        {
            InitializeComponent();
        }

        private void CarregarCalendario()
        {
            try
            {
                var listaJogos = Jogo.GetJogos();

                var jogosFuturos = listaJogos.Where(jogo => jogo.Data > DateTime.Now).ToList();

                dataCalendario.DataSource = jogosFuturos;

                if (dataCalendario is DataGridView gridView)
                {
                    gridView.Columns["EquipeCasa"].Visible = false;
                    gridView.Columns["EquipeFora"].Visible = false;
                    gridView.Columns["FaseID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o Calendario: " + ex.Message);
            }
        }       
        
        private void CarregarEstatisticas()
        {
            try
            {
                var listaJogadores = Jogador.GetJogadoresAll();

                dataJogadores.DataSource = listaJogadores; 
                if (dataJogadores is DataGridView gridView)
                {
                    gridView.Columns["EquipeId"].Visible = false;

                    gridView.Columns["CartaoCidadaoAntigo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as Estatisticas: " + ex.Message);
            }
        }


        private void Visualizacao_Load(object sender, EventArgs e)
        {
            CarregarCalendario();
            CarregarEstatisticas();
        }
    }
}

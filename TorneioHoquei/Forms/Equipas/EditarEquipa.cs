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

namespace TorneioHoquei.Forms.Equipas
{
    public partial class EditarEquipa : Form
    {

        public event EventHandler? EquipaInserida;

        public EditarEquipa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboTreina.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um treinador.");
                return;
            }

            int treinadorId = (int)comboTreina.SelectedValue;

            string nomeEquipe = textNome.Text;
            if (string.IsNullOrWhiteSpace(nomeEquipe))
            {
                MessageBox.Show("Por favor, insira o nome da equipa.");
                return;
            }            
            string equipeID = EquipeID.Text;
            int equipeID2 = int.Parse(EquipeID.Text);
            if (string.IsNullOrWhiteSpace(equipeID))
            {
                MessageBox.Show("Por favor, insira o id da equipa.");
                return;
            }

            Equipa novaEquipa = new()
            {
                EquipeID = equipeID2,
                Nome = nomeEquipe,
                TreinadorID = treinadorId
            };

            try
            {
                Equipa.AtualizarEquipa(novaEquipa);
                Close();
                EquipaInserida?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Equipa editada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a equipe: " + ex.Message);
            }
        }

        private void CarregarTreinadores()
        {
            try
            {
                List<Treinador> treinadores = Treinador.GetTreinadores();
                comboTreina.DataSource = treinadores;
                comboTreina.DisplayMember = "Nome";
                comboTreina.ValueMember = "TreinadorId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar treinadores: " + ex.Message);
            }
        }

        private void CriarEquip_Load(object sender, EventArgs e)
        {
            CarregarTreinadores();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

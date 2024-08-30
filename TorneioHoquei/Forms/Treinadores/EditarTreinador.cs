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

namespace TorneioHoquei.Forms.Treinadores
{
    public partial class EditarTreinador : Form
    {

        public event EventHandler? TreinadorInserido;

        public EditarTreinador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textCC.Text))
            {
                MessageBox.Show("Por favor, insira o Cartão de Cidadão.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show("Por favor, insira o nome.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textNacio.Text))
            {
                MessageBox.Show("Por favor, insira a nacionalidade.");
                return;
            }
            if (!int.TryParse(textAnosEx.Text, out int anosExperiencia))
            {
                MessageBox.Show("Por favor, insira um número válido para os anos de experiência.");
                return;
            }

            var treinador = new Treinador
            {
                TreinadorID = int.Parse(TreinadorId.Text),
                CartaoCidadao = textCC.Text,
                Nome = textNome.Text,
                Nacionalidade = textNacio.Text,
                AnosExperiencia = anosExperiencia
            };

            try
            {
                Treinador.AtualizarTreinador(treinador);
                Close();
                TreinadorInserido?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Treinador editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o treinador: " + ex.Message);
            }
        }
    }
}

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

namespace TorneioHoquei.Forms.Jogadores
{
    public partial class EditarJogador : Form
    {

        public event EventHandler? JogadorInserido;

        public EditarJogador()
        {
            InitializeComponent();
            dataNascimento.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";

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
            if (dataNascimento.Value > DateTime.Now)
            {
                MessageBox.Show("Por favor, insira uma data de nascimento válida.");
                return;
            }
            if (string.IsNullOrWhiteSpace(pCampo.Text))
            {
                MessageBox.Show("Por favor, insira a posição no campo.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nCamisola.Text))
            {
                MessageBox.Show("Por favor, insira o número da camisola.");
                return;
            }
            if (comboEquipa.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione uma equipa.");
                return;
            }

            int equipaId = (int)comboEquipa.SelectedValue;

            try
            {
                var jogador = new Jogador
                {
                    CartaoCidadao = textCC.Text,
                    CartaoCidadaoAntigo = textAntigo.Text,
                    Nome = textNome.Text,
                    DataNascimento = dataNascimento.Value,
                    PosicaoCampo = pCampo.Text,
                    NumeroCamisola = int.Parse(nCamisola.Text),
                    EquipeID = equipaId,
                };

                Jogador.AtualizarJogador(jogador);
                Close();
                JogadorInserido?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Jogador editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o jogador: " + ex.Message);
            }
        }

        private void CarregarEquipa()
        {
            try
            {
                List<Equipa> equipa = Equipa.GetEquipas();
                comboEquipa.DataSource = equipa;
                comboEquipa.DisplayMember = "Nome";
                comboEquipa.ValueMember = "EquipeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar treinadores: " + ex.Message);
            }
        }

        private void CriarJogador_Load(object sender, EventArgs e)
        {
            CarregarEquipa();
        }
    }
}

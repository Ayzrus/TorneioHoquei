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

namespace TorneioHoquei.Forms.Jogos
{
    public partial class EditarJogo : Form
    {

        public event EventHandler? JogoInserido;

        public EditarJogo()
        {
            InitializeComponent();
            dataJogoPicker.Format = DateTimePickerFormat.Custom;
            dataJogoPicker.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarEquipasCasa()
        {
            try
            {
                List<Equipa> equipas = Equipa.GetEquipas();
                comboEquipaCasa.DataSource = equipas;
                comboEquipaCasa.DisplayMember = "Nome";
                comboEquipaCasa.ValueMember = "EquipeID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar equipas casa: " + ex.Message);
            }
        }        
        
        private void CarregarEquipasFora()
        {
            try
            {
                List<Equipa> equipas = Equipa.GetEquipas();
                comboEquipaFora.DataSource = equipas;
                comboEquipaFora.DisplayMember = "Nome";
                comboEquipaFora.ValueMember = "EquipeID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar equipas fora: " + ex.Message);
            }
        }

        private void CarregarFases()
        {
            try
            {
                List<Fase> fases = Fase.GetFases();
                comboFase.DataSource = fases;
                comboFase.DisplayMember = "Tipo";
                comboFase.ValueMember = "FaseID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fases: " + ex.Message);
            }
        }

        private void CriarJogo_Load(object sender, EventArgs e)
        {
            CarregarEquipasCasa();
            CarregarEquipasFora();
            CarregarFases();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataGame = dataJogoPicker.Value;
            string localJogo = textLocal.Text;
            string resultadoJogo = textResultado.Text;

            if (string.IsNullOrWhiteSpace(localJogo))
            {
                MessageBox.Show("Por favor, insira o local do jogo.");
                return;
            }

            if (comboEquipaCasa.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione a equipe da casa.");
                return;
            }

            if (comboEquipaFora.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione a equipe visitante.");
                return;
            }

            if (comboFase.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione a fase do jogo.");
                return;
            }

            int equipaCasaId = (int)comboEquipaCasa.SelectedValue;
            int equipaForaId = (int)comboEquipaFora.SelectedValue;
            int faseId = (int)comboFase.SelectedValue;

            var jogo = new Jogo
            {
                JogoID = int.Parse(JogoId.Text),
                Data = dataGame,
                Local = localJogo,
                ResultadoFinal = resultadoJogo,
                EquipeCasa = equipaCasaId,
                EquipeFora = equipaForaId,
                FaseID = faseId
            };

            try
            {
                Jogo.AtualizarJogo(jogo);
                JogoInserido?.Invoke(this, EventArgs.Empty);
                Close();
                MessageBox.Show("Jogo editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o jogo: " + ex.Message);
            }
        }
    }
}

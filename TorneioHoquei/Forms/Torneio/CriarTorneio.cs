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

namespace TorneioHoquei.Forms.Torneio
{
    public partial class CriarTorneio : Form
    {

        public event EventHandler? TorneioInserido;

        public CriarTorneio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nomeTorneio = textNome.Text;
            if (string.IsNullOrWhiteSpace(nomeTorneio))
            {
                MessageBox.Show("Por favor, insira o nome do torneio.");
                return;
            }

            Torneios torneio = new()
            {
                Nome = nomeTorneio,
            };

            try
            {
                Torneios.InserirTorneio(torneio);
                TorneioInserido?.Invoke(this, EventArgs.Empty);
                Close();
                MessageBox.Show("Torneio criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o torneio: " + ex.Message);
            }

        }
    }
}

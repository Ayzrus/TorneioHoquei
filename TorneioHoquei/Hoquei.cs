using System.Windows.Forms;
using TorneioHoquei.UserControls;

namespace TorneioHoquei
{
    public partial class Hoquei : Form
    {
        public Hoquei()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void GestaoEquipJog_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GestaoEquipaJogadores());
        }

        private void GestaoTorneio_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GestaoTorneio());
        }

        private void Info_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Visualizacao());
        }

        private void GestaoTreina_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GestaoTreinadores());
        }
    }
}

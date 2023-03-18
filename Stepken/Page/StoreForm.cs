using Domain.GameCharacter;
using Stepken.UserController;

namespace Stepken.Page
{
    public partial class StoreForm : Form
    {
        private Character _player { get; set; }

        public StoreForm(Character player)
        {
            _player = player;
            InitializeComponent();
        }

        public void EquipmentForm_Load(object sender, EventArgs e)
        {
            var uc = new UCStore();
            uc.Dock = DockStyle.Fill;
            uc.Btn_exit.Click += (s, e) => { this.Close(); };
            this.Controls.Add(uc);
        }
    }
}

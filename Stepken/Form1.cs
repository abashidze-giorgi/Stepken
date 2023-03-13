using Domain.Models;
using Domain.Characters;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player player; 
        public Form1()
        {
            InitializeComponent();
            GetPlayer();
        }

        private void GetPlayer()
        {
            player = new Player();
        }
    }
}
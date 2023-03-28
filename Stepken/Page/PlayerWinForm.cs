using Domain.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Stepken.Page
{
    public partial class PlayerWinForm : Form
    {
        public PlayerWinForm()
        {
            InitializeComponent();
            DeleteUser();
        }
        private void DeleteUser()
        {
            var delete = new DeleteUser();
            delete.DeleteUserSave(GameList.Player.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerWinForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

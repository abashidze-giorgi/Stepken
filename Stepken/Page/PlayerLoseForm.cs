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

namespace Stepken.Page
{
    public partial class PlayerLoseForm : Form
    {
        public PlayerLoseForm()
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

        private void PlayerLoseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

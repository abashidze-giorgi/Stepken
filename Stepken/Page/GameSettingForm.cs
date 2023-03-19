using Domain.Service;
using Stepken.Page;
using Stepken.UserController;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepken
{
    public partial class GameSettingForm : Form
    {
        private string userName = "";
        public GameSettingForm()
        {
            InitializeComponent();
            LoadUserList();
            LoadGame();
        }

        private void LoadGame()
        {
            var lg = new LoadGameEnvironment();
            lg.LoadGame();
        }

        private void LoadUserList()
        {
            var gu = new GetUserList();
            var list = gu.GetUsers();
            if (list.Count > 0)
            {
                foreach (var u in list)
                {
                    var uc = new UCLoadGameUsedrs();
                    uc.UserName = u;
                    uc.btn_UserName.Click += (s, e) => { userName = uc.UserName; };
                    UserPanel.Controls.Add(uc);
                }
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Game not selected");
            }
            else
            {
                LoadGame();
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            var nf = new NewUser();
            nf.Show();
            this.Hide();
            nf.FormClosing += ShowThis;
        }

        private void ShowThis(object? sender, FormClosingEventArgs e)
        {
            if(GameList.UnitList.Count > 0)
            {

            }
            else
            {
                this.Show();
            }
        }
    }
}

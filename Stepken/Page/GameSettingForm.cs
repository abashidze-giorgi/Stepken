﻿using Domain.Service;
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
            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            PlayerPanel.Controls.Clear();
            var gu = new GetUserList();
            var list = gu.GetUsers();
            if (list.Count > 0)
            {
                foreach (var u in list)
                {
                    var uc = new UCLoadGameUsedrs();
                    uc.UserName = u;
                    uc.btn_UserName.Click += (s, e) => { userName = uc.UserName; };
                    PlayerPanel.Controls.Add(uc);
                }
            }
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadGame(string userName)
        {
            var battleProcess = new LoadGame();
            battleProcess.LoadFight(userName);

            var nf = new Form1();
            nf.Show();
            this.Hide();
            nf.FormClosing += Form1Closing;
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
            if (GameList.Player != null)
            {
                GameList.battleRound = 1;
                LoadGame(GameList.Player.Name);
            }
            else
            {
                this.Show();
            }
        }
        private void Form1Closing(object? sender, FormClosingEventArgs e)
        {
            LoadPlayerList();
            this.Show();
        }
        private void Btn_load_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                LoadGame(userName);
            }
        }
        private void Btn_delete_Click_1(object sender, EventArgs e)
        {
            var delete = new DeleteUser();
            delete.DeleteUserSave(userName);
            LoadPlayerList();
        }
    }
}

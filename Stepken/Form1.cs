using Domain.GameCharacter;
using Domain.Interface;
using Domain.Model.HitPointModel;
using Domain.Models;
using Domain.Service;
using Stepken.Page;
using Player = Domain.Service.GameList;
using System;
using System.Collections;
using System.Numerics;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Character player = Player.Player;
        public Character currentEnemy { get; set; }

        private Battle battle;
        private string playerName = "YourNameHere";
        private int Gold = 10;
        public Form1()
        {
            InitializeComponent();
            SetLifeCount();
            GetShields();
        }
        private double getAttackAmount()
        {
            double atackePower = Math.Round(player.Attack + player.Weapon[0].AttackPower, 2);
            return atackePower;
        }
        private double getDefenceAmount()
        {
            double armorValue = 0;
            foreach (var arm in player.Armor)
            {
                armorValue += arm.Defence;
            }
            double defencePower = Math.Round(player.Defence + armorValue + player.Shield.Defence, 2);
            return defencePower;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void StoreColisng(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        private void Btn_Store_Click(object sender, EventArgs e)
        {
            var equipPanel = new StoreForm(player);
            equipPanel.Show();
            this.Hide();
            equipPanel.FormClosing += StoreColisng;
        }
        private void CheckAtacker()
        {
            // if its enemy turn
            if (battle.atacker == 1)
            {
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                Wait1000MillisecondsAsync();
            }
            else
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
        }
        public async Task Wait1000MillisecondsAsync()
        {
            await Task.Delay(1000);
            // code to be executed after the delay
            Battle(player, currentEnemy, battle.GetRandomAttackZone());
        }
        private void Battle(Character player, Character enemy, ZoneModel zone)
        {
            battle.StartBattle(player, enemy, zone);
            SetLifeCount();
            CheckAtacker();
        }
        private void Btn_StartBattle_Click(object sender, EventArgs e)
        {
            battle = new Battle();
            battle.SetAtacker();
            CheckAtacker();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Battle(player, currentEnemy, ZoneModel.Head);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Battle(player, currentEnemy, ZoneModel.Body);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Battle(player, currentEnemy, ZoneModel.Leg);
        }
        private void SetLifeCount()
        {
            try
            {
                if (GameList.FigterList[1].Life == 0)
                {
                }
                if (player.Life == 0)
                {
                    PlayerDead();
                    return;
                }
                Lbl_EnemyLife.Text = GameList.FigterList[1].Life.ToString();
                Lbl_PlayerLife.Text = player.Life.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        private void PlayerDead()
        {
            player = null;
            Lbl_PlayerLife.Text = 0.ToString();
            Image_Player.ImageLocation = null;
            Image_Weapon_Player.ImageLocation = null;
            Image_Shield_1.Visible = false;
            Image_Shield_2.Visible = false;
            Image_Shield_3.Visible = false;

        }

        private void GetShields()
        {
            Image_Shield_1.Visible = false;
            Image_Shield_2.Visible = false;
            Image_Shield_3.Visible = false;
            foreach (var sh in player.Shield.Zone)
            {
                if (sh == ZoneModel.Head)
                {
                    Image_Shield_1.Visible = true;
                    Image_Shield_1.ImageLocation = player.Shield.ImageAddress;
                }
                if (sh == ZoneModel.Body)
                {
                    Image_Shield_2.Visible = true;
                    Image_Shield_2.ImageLocation = player.Shield.ImageAddress;
                }
                if (sh == ZoneModel.Leg)
                {
                    Image_Shield_3.Visible = true;
                    Image_Shield_3.ImageLocation = player.Shield.ImageAddress;
                }
            }
        }
        private void SaveGame()
        {
            var saveUser = new SaveAndLoadGame();
            saveUser.Save(player);
        }
        private void LoadGame()
        {

        }
    }
}
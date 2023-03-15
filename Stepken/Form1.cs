using Domain.Models;
using Domain.Characters;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using Domain.Inventory.Weapons;
using Domain.Service;
using Stepken.Page;
using Domain.Character;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player? player;
        private string playerName = "YourNameHere";
        public Form1()
        {
            InitializeComponent();
            CreateWeapons();
            GetPlayer();
            GetEnemy();
        }

        private void GetPlayer()
        {
            player = new Player();
            player.Weapon.Add(CreateWeaponList.WeaponFullList[0]);
            Weapon_1.ImageLocation = player.Weapon[0].ImageAddress;
            Picture_1.ImageLocation = player.ImageAddress;
            Lbl_PlayerLife.Text = player.Life.ToString();
            Lbl_Gold.Text = player.Gold.ToString();
            Lbl_param_attack.Text = getAttackAmount(player).ToString();
            PlayerName_Text.Text = playerName;
        }

        private double getAttackAmount(UnitModel unit)
        {
            double atackAmount = Math.Round(unit.Attack + unit.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private double getGold()
        {
            double atackAmount = Math.Round(player.Attack + player.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private void GetEnemy()
        {
            var enemy = new Goblin();
            enemy.Weapon.Add(CreateWeaponList.WeaponFullList[1]);
            Weapon_2.ImageLocation = enemy.Weapon[0].ImageAddress;
            Picture_2.ImageLocation = enemy.ImageAddress;
            Lbl_EnemyLife.Text = enemy.Life.ToString();
            Lbl_param_attack_enemy.Text = getAttackAmount(enemy).ToString();
            EnemyName_Text.Text = enemy.Name.ToString();
        }

        private void CreateWeapons()
        {
            CreateWeaponList.CreateWeapon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_equip_Click(object sender, EventArgs e)
        {

        }

        private void equipClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void Btn_Store_Click(object sender, EventArgs e)
        {
            var equipPanel = new StoreForm(player);
            equipPanel.Show();
            this.Hide();
            equipPanel.FormClosing += equipClosing;
        }

        private void AddWeaponImageToPanelWhenEquiped(string path, PictureBox box)
        {

        }
    }
}
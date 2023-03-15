using Domain.Models;
using Domain.Characters;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using Domain.Inventory.Weapons;
using Domain.Service;
using Stepken.Page;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player? player;
        public Form1()
        {
            InitializeComponent();
            CreateWeapon();
            CreateWeaponList.CreateWeapons();
            GetPlayer();
        }

        private void GetPlayer()
        {
            player = new Player();
            player.Weapon.Add(CreateWeaponList.WeaponFullList[0]);
            Picture_1.ImageLocation = player.ImageAddress;
            Lbl_PlayerLife.Text = player.Life.ToString();
            Lbl_Gold.Text = player.Gold.ToString();
            Lbl_param_attack.Text = getAttackAmount().ToString();
        }

        private double getAttackAmount()
        {
            double atackAmount = Math.Round(player.Attack + player.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private double getGold()
        {
            double atackAmount = Math.Round(player.Attack + player.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private void GetEnemy()
        {

        }

        private void CreateWeapon()
        {
            CreateWeaponList.CreateWeapons();
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
    }
}
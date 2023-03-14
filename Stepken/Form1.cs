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
            GetPlayer();
            CreateWeapon();
        }

        private void GetPlayer()
        {
            player = new Player();
            Picture_1.ImageLocation = player.ImageAddress;
        }

        private void GetEnemy()
        {

        }

        private void CreateWeapon()
        {
            CreateAllEquipments.CreateWeapons();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_equip_Click(object sender, EventArgs e)
        {
            var equipPanel = new EquipmentForm(player);
            equipPanel.Show();
            this.Hide();
            equipPanel.FormClosing += equipClosing;
        }

        private void equipClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
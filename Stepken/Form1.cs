using Domain.Models;
using Domain.Characters;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using Domain.Inventory.Weapons;
using Domain.Service;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player player;
        public Form1()
        {
            InitializeComponent();
            GetPlayer();
            CreateWeapon();
        }

        private void GetPlayer()
        {
            player = new Player();
            Picture_1.ImageLocation = @"C:\Users\GFavaz\source\repos\Stepken\Domain\Lib\Image\human.jpg";
        }

        private void GetEnemy()
        {

        }

        private void CreateWeapon()
        {
            var cw = new CreateAllEquipments();
            cw.CreateWeapons();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
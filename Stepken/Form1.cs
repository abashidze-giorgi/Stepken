using Domain.Character;
using Domain.Characters;
using Domain.Models;
using Domain.Service;
using Stepken.Page;

namespace Stepken
{
    public partial class Form1 : Form
    {
        Player? player;
        private string playerName = "YourNameHere";
        public List<CharacterModel> characters = new List<CharacterModel>();
        public Form1()
        {
            InitializeComponent();
            CreateWeapons();
            CreateEnemy();
            GetPlayer();
            GetEnemy();
        }

        private void CreateEnemy()
        {
            CreateEnemyList.CreateEnemyes();
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
            Lbl_param_defence.Text = getDefenceAmount(player).ToString();
            PlayerName_Text.Text = playerName;
        }

        private double getAttackAmount(CharacterModel unit)
        {
            double atackAmount = Math.Round(unit.Attack + unit.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private double getDefenceAmount(CharacterModel unit)
        {
            double armorValue = 0;
            foreach (var arm in unit.Armor)
            {
                armorValue += arm.Defence;
            }
            double atackAmount = Math.Round(unit.Defence + armorValue + unit.Shield.Defence, 2);
            return atackAmount;
        }

        private double getGold()
        {
            double atackAmount = Math.Round(player.Attack + player.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private void GetEnemy()
        {
            var enemy = new CharacterModel();
            enemy.Weapon.Add(CreateWeaponList.WeaponFullList[1]);
            Weapon_2.ImageLocation = enemy.Weapon[0].ImageAddress;
            Picture_2.ImageLocation = enemy.ImageAddress;
            Lbl_EnemyLife.Text = enemy.Life.ToString();
            EnemyName_Text.Text = enemy.Name.ToString();
            Lbl_param_attack_enemy.Text = getAttackAmount(enemy).ToString();
            Lbl_param_defence_enemy.Text = getDefenceAmount(enemy).ToString();

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

        private void Btn_StartBattle_Click(object sender, EventArgs e)
        {
            var batlle = new Battle();
            double hitPower = batlle.GetHitPower(player);
            MessageBox.Show(hitPower.ToString());
        }
    }
}
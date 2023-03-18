using Domain.GameCharacter;
using Domain.Model.HitPointModel;
using Domain.Models;
using Domain.Service;
using Stepken.Page;
using System;
using System.Collections;
using System.Numerics;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Stepken
{
    public partial class Form1 : Form
    {

        private Character player { get; set; }
        public Character currentEnemy { get; set; }

        private Battle battle;
        private string playerName = "YourNameHere";
        private int Gold = 10;
        public Form1()
        {
            InitializeComponent();
            CreateWeapons();
            GetPlayer();
            CreateEnemy();
            GetEnemy();
            SetLifeCount();
            GetShields();
        }

        private void CreateEnemy()
        {
            Domain.Service.CreateEnemy.CreateEnemyes();
        }

        private void GetPlayer()
        {
            var cp = new CreatePlayer();
            cp.Player();
            player = GameList.UnitList.Where(u => u.CharacterRace == CharacterRaceEnum.Human).FirstOrDefault();
            player.Weapon[0] = GameList.WeaponList[GetRandomWeaponId()];
            Image_Weapon_Player.ImageLocation = player.Weapon[0].ImageAddress;
            Image_Player.ImageLocation = player.ImageAddress;
            Lbl_Gold.Text = Gold.ToString();
            Lbl_param_attack.Text = getAttackAmount(player).ToString();
            Lbl_param_defence.Text = getDefenceAmount(player).ToString();
            PlayerName_Text.Text = playerName;
        }

        private double getAttackAmount(Character unit)
        {
            double atackAmount = Math.Round(unit.Attack + unit.Weapon[0].AttackPower, 2);
            return atackAmount;
        }

        private double getDefenceAmount(Character unit)
        {
            double armorValue = 0;
            foreach (var arm in unit.Armor)
            {
                armorValue += arm.Defence;
            }
            double atackAmount = Math.Round(unit.Defence + armorValue + unit.Shield.Defence, 2);
            return atackAmount;
        }

        private void GetEnemy()
        {
            currentEnemy = GameList.UnitList[GetRandomEnemyId()];
            currentEnemy.Weapon.Add(GameList.WeaponList[GetRandomWeaponId()]);
            Weapon_2.ImageLocation = currentEnemy.Weapon[0].ImageAddress;
            Picture_2.ImageLocation = currentEnemy.ImageAddress;

            EnemyName_Text.Text = currentEnemy.Name.ToString();
            Lbl_param_attack_enemy.Text = getAttackAmount(currentEnemy).ToString();
            Lbl_param_defence_enemy.Text = getDefenceAmount(currentEnemy).ToString();
        }

        private void CreateWeapons()
        {
            var ca = new CreateAmmunition();
            ca.Create();
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


        private void CheckAtacker()
        {

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
            if (currentEnemy.Life == 0)
            {
                GetEnemy();
            }
            if (player.Life == 0)
            {
                PlayerDead();
                return;

            }
            Lbl_EnemyLife.Text = currentEnemy.Life.ToString();
            Lbl_PlayerLife.Text = player.Life.ToString();
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

        private int GetRandomEnemyId()
        {
            var random = new Random();
            int result = (int)random.Next(1, GameList.UnitList.Count);
            return result;
        }

        private int GetRandomWeaponId()
        {
            var random = new Random();
            int weaponId = (int)random.Next(0, GameList.WeaponList.Count);
            return weaponId;
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
    }
}
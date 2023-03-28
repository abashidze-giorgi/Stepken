using Domain.GameCharacter;
using Domain.Interface;
using Domain.Model.HitPointModel;
using Domain.Models;
using Domain.Service;
using Stepken.Page;
using Player = Domain.Service.GameList;
using Enemy = Domain.Service.GameList;
using System;
using System.Collections;
using System.Numerics;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Stepken
{
    public partial class Form1 : Form
    {
        public Character currentEnemy { get; set; }
        private Battle battle;
        private string playerName = "YourNameHere";
        private int Gold = 10;
        public Form1()
        {
            InitializeComponent();
            LoadCharacterValues();
            listBox1.Items.Clear();
        }

        private void LoadCharacterValues()
        {
            if (Player.Player != null)
            {
                Lbl_player_atack.Text = getAttackAmount(Player.Player).ToString();
                Lbl_player_defence.Text = getDefenceAmount(Player.Player).ToString();
                Lbl_user_name.Text = Player.Player.Name;
                Lbl_PlayerLife.Text = $"{Player.Player.CurrentLife.ToString()} / {Player.Player.MaxLife.ToString()}";
                Image_player.ImageLocation = Player.Player.ImageAddress;
                ImagePlayerShield();
            }
            if (Enemy.Enemy != null)
            {
                Lbl_enemy_atack.Text = getAttackAmount(Enemy.Enemy).ToString();
                Lbl_enemy_defence.Text = getDefenceAmount(Enemy.Enemy).ToString();
                Lbl_enemy_name.Text = Enemy.Enemy.Name;
                Lbl_EnemyLife.Text = Enemy.Enemy.CurrentLife.ToString();
                Image_enemy.ImageLocation = Enemy.Enemy.ImageAddress;
            }
            Lbl_level.Text = GameList.battleRound.ToString();
        }

        private double getAttackAmount(Character unit)
        {
            double atackePower = Math.Round(unit.Attack + unit.Weapon[0].AttackPower, 2);
            return atackePower;
        }
        private double getDefenceAmount(Character unit)
        {
            double armorValue = 0;
            foreach (var arm in unit.Armor)
            {
                armorValue += arm.Defence;
            }
            double defencePower = Math.Round(unit.Defence + armorValue + unit.Shield.Defence, 2);
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
            var equipPanel = new StoreForm(Player.Player);
            equipPanel.Show();
            this.Hide();
            equipPanel.FormClosing += StoreColisng;
        }
        private void CheckAtacker()
        {
            // if enemy turn
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
            Battle(battle.GetRandomAttackZone());
        }
        private void Battle(ZoneModel zone)
        {
            battle.StartBattle(zone);
            GetLife();
            ChangeCharacteerShield(GameList.Enemy);
            CheckAtacker();
            TextBattleResult();
        }

        private void TextBattleResult()
        {
            try
            {
                //if (GameList.hitResult.Atacker == GameList.Player.Name)
                //{
                //    listBox1.ForeColor = Color.Green;
                //}
                //else
                //{
                //    listBox1.ForeColor = Color.Orange;
                //}
                listBox1.Items.Add($"Atacker: {GameList.hitResult.Atacker}");
                listBox1.Items.Add($"Defender: {GameList.hitResult.Defender}");
                listBox1.Items.Add($"Attack power: {GameList.hitResult.AtackPower}");
                listBox1.Items.Add($"Defence power: {GameList.hitResult.DefencePower}");
                listBox1.Items.Add($"Atack zone: {GameList.hitResult.AtackZone}");
                listBox1.Items.Add($"Defence zone: {GameList.hitResult.DefenceShieldZone}");
                listBox1.Items.Add($"Life decrease: {GameList.hitResult.DecreaseLife}");
                listBox1.Items.Add($"Player life: {GameList.Player.CurrentLife}");
                listBox1.Items.Add($"Enemy life: {GameList.Enemy.CurrentLife}");
                listBox1.Items.Add("-----------------------------");
            }
            catch
            {

            }
        }

        private void Btn_StartBattle_Click(object sender, EventArgs e)
        {
            Btn_StartBattle.Visible = false;
            battle = new Battle();
            battle.SetAtacker();
            CheckAtacker();
        }

        private void GetLife()
        {
            try
            {
                if (Enemy.Enemy.CurrentLife == 0)
                {
                    var attempt = Convert.ToInt16(button1.Text);
                    attempt++;
                    button1.Text = attempt.ToString();
                    GameList.Enemy = null;
                    GameList.battleRound++;
                    ChangeCharacteerShield(GameList.Player);
                    SaveGame();
                    listBox1.Items.Clear();
                    if (GameList.battleRound < 5)
                    {
                        var createEnemy = new CreateEnemy();
                        createEnemy.CreateEnemye();
                        LoadCharacterValues();
                    }
                    else
                    {
                        var nf = new PlayerWinForm();
                        nf.Show();
                        this.Hide();
                    }
                }
                if (Player.Player.CurrentLife == 0)
                {
                    PlayerDead();
                    return;
                }
                LoadCharacterValues();
            }
            catch (Exception ex)
            {

            }
        }
        private void PlayerDead()
        {
            var nf = new PlayerLoseForm();
            nf.Show();
            this.Hide();
        }
        private void SaveGame()
        {
            var saveUser = new SaveAndLoadGame();
            saveUser.Save();
        }
        private void ImagePlayerShield()
        {
            Image_Shield_1.Visible = false;
            Image_Shield_2.Visible = false;
            Image_Shield_3.Visible = false;
            foreach (var sh in Player.Player.Shield.Zone)
            {
                if (sh == ZoneModel.Head)
                {
                    Image_Shield_1.Visible = true;
                    Image_Shield_1.ImageLocation = Player.Player.Shield.ImageAddress;
                }
                if (sh == ZoneModel.Body)
                {
                    Image_Shield_2.Visible = true;
                    Image_Shield_2.ImageLocation = Player.Player.Shield.ImageAddress;
                }
                if (sh == ZoneModel.Leg)
                {
                    Image_Shield_3.Visible = true;
                    Image_Shield_3.ImageLocation = Player.Player.Shield.ImageAddress;
                }
            }
        }

        #region BattleZone button click
        private void button4_Click(object sender, EventArgs e)
        {
            Battle(ZoneModel.Head);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Battle(ZoneModel.Body);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Battle(ZoneModel.Leg);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var attempt = Convert.ToInt16(button1.Text);
            if (attempt > 0)
            {
                attempt--;
                GameList.Player.CurrentLife = GameList.Player.MaxLife;
                button1.Text = attempt.ToString();
                LoadCharacterValues();
            }
        }

        private void ChangeCharacteerShield(Character chara)
        {
            try
            {
                chara.Shield = (ShieldModel)CreateAmmunition.CreateShield(RandomShieldId());

            }
            catch
            {

            }
        }
        private int RandomShieldId()
        {
            var random = new Random();
            return random.Next(1, 6);
        }
    }
}
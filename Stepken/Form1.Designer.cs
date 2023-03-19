namespace Stepken
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Image_Player = new PictureBox();
            Picture_2 = new PictureBox();
            button2 = new Button();
            Btn_StartBattle = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            Lbl_PlayerLife = new Label();
            label3 = new Label();
            Lbl_param_attack = new Label();
            label7 = new Label();
            Lbl_param_defence = new Label();
            label29 = new Label();
            Lbl_Gold = new Label();
            label5 = new Label();
            Lbl_EnemyLife = new Label();
            label17 = new Label();
            label18 = new Label();
            Lbl_param_attack_enemy = new Label();
            Lbl_param_defence_enemy = new Label();
            Btn_Store = new Button();
            label37 = new Label();
            PlayerName_Text = new Label();
            EnemyName_Text = new Label();
            Image_Weapon_Player = new PictureBox();
            label4 = new Label();
            Weapon_2 = new PictureBox();
            Image_Shield_2 = new PictureBox();
            Image_Shield_1 = new PictureBox();
            Image_Shield_3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Image_Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Weapon_Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Weapon_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_3).BeginInit();
            SuspendLayout();
            // 
            // Image_Player
            // 
            Image_Player.Location = new Point(122, 180);
            Image_Player.Name = "Image_Player";
            Image_Player.Size = new Size(147, 322);
            Image_Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_Player.TabIndex = 0;
            Image_Player.TabStop = false;
            // 
            // Picture_2
            // 
            Picture_2.Location = new Point(585, 196);
            Picture_2.Name = "Picture_2";
            Picture_2.Size = new Size(147, 322);
            Picture_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_2.TabIndex = 0;
            Picture_2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(799, 587);
            button2.Name = "button2";
            button2.Size = new Size(138, 44);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Btn_StartBattle
            // 
            Btn_StartBattle.Location = new Point(355, 568);
            Btn_StartBattle.Name = "Btn_StartBattle";
            Btn_StartBattle.Size = new Size(211, 60);
            Btn_StartBattle.TabIndex = 1;
            Btn_StartBattle.Text = "Start Battle";
            Btn_StartBattle.UseVisualStyleBackColor = true;
            Btn_StartBattle.Click += Btn_StartBattle_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(467, 213);
            button4.Name = "button4";
            button4.Size = new Size(99, 27);
            button4.TabIndex = 1;
            button4.Text = "Hit --->";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(467, 343);
            button5.Name = "button5";
            button5.Size = new Size(99, 27);
            button5.TabIndex = 1;
            button5.Text = "Hit --->";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(467, 475);
            button6.Name = "button6";
            button6.Size = new Size(99, 27);
            button6.TabIndex = 1;
            button6.Text = "Hit --->";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(155, 46);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 3;
            label1.Text = "Life:";
            // 
            // Lbl_PlayerLife
            // 
            Lbl_PlayerLife.AutoSize = true;
            Lbl_PlayerLife.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_PlayerLife.ForeColor = Color.FromArgb(0, 192, 0);
            Lbl_PlayerLife.Location = new Point(217, 46);
            Lbl_PlayerLife.Name = "Lbl_PlayerLife";
            Lbl_PlayerLife.Size = new Size(26, 30);
            Lbl_PlayerLife.TabIndex = 3;
            Lbl_PlayerLife.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 97);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "Attack:";
            // 
            // Lbl_param_attack
            // 
            Lbl_param_attack.AutoSize = true;
            Lbl_param_attack.Location = new Point(256, 97);
            Lbl_param_attack.Name = "Lbl_param_attack";
            Lbl_param_attack.Size = new Size(13, 15);
            Lbl_param_attack.TabIndex = 3;
            Lbl_param_attack.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 138);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 3;
            label7.Text = "Defence:";
            // 
            // Lbl_param_defence
            // 
            Lbl_param_defence.AutoSize = true;
            Lbl_param_defence.Location = new Point(256, 138);
            Lbl_param_defence.Name = "Lbl_param_defence";
            Lbl_param_defence.Size = new Size(13, 15);
            Lbl_param_defence.TabIndex = 3;
            Lbl_param_defence.Text = "0";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label29.ForeColor = Color.FromArgb(255, 128, 0);
            label29.Location = new Point(12, 46);
            label29.Name = "label29";
            label29.Size = new Size(68, 30);
            label29.TabIndex = 3;
            label29.Text = "Gold:";
            // 
            // Lbl_Gold
            // 
            Lbl_Gold.AutoSize = true;
            Lbl_Gold.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Gold.ForeColor = Color.FromArgb(255, 128, 0);
            Lbl_Gold.Location = new Point(86, 46);
            Lbl_Gold.Name = "Lbl_Gold";
            Lbl_Gold.Size = new Size(26, 30);
            Lbl_Gold.TabIndex = 3;
            Lbl_Gold.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(612, 46);
            label5.Name = "label5";
            label5.Size = new Size(56, 30);
            label5.TabIndex = 3;
            label5.Text = "Life:";
            // 
            // Lbl_EnemyLife
            // 
            Lbl_EnemyLife.AutoSize = true;
            Lbl_EnemyLife.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_EnemyLife.ForeColor = Color.FromArgb(192, 0, 0);
            Lbl_EnemyLife.Location = new Point(674, 46);
            Lbl_EnemyLife.Name = "Lbl_EnemyLife";
            Lbl_EnemyLife.Size = new Size(26, 30);
            Lbl_EnemyLife.TabIndex = 3;
            Lbl_EnemyLife.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(585, 113);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 3;
            label17.Text = "Attack:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(585, 154);
            label18.Name = "label18";
            label18.Size = new Size(53, 15);
            label18.TabIndex = 3;
            label18.Text = "Defence:";
            // 
            // Lbl_param_attack_enemy
            // 
            Lbl_param_attack_enemy.AutoSize = true;
            Lbl_param_attack_enemy.Location = new Point(719, 113);
            Lbl_param_attack_enemy.Name = "Lbl_param_attack_enemy";
            Lbl_param_attack_enemy.Size = new Size(13, 15);
            Lbl_param_attack_enemy.TabIndex = 3;
            Lbl_param_attack_enemy.Text = "0";
            // 
            // Lbl_param_defence_enemy
            // 
            Lbl_param_defence_enemy.AutoSize = true;
            Lbl_param_defence_enemy.Location = new Point(719, 154);
            Lbl_param_defence_enemy.Name = "Lbl_param_defence_enemy";
            Lbl_param_defence_enemy.Size = new Size(13, 15);
            Lbl_param_defence_enemy.TabIndex = 3;
            Lbl_param_defence_enemy.Text = "0";
            // 
            // Btn_Store
            // 
            Btn_Store.BackColor = Color.FromArgb(255, 128, 0);
            Btn_Store.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Store.ForeColor = Color.White;
            Btn_Store.Location = new Point(122, 521);
            Btn_Store.Name = "Btn_Store";
            Btn_Store.Size = new Size(147, 44);
            Btn_Store.TabIndex = 1;
            Btn_Store.Text = "Store";
            Btn_Store.UseVisualStyleBackColor = false;
            Btn_Store.Click += Btn_Store_Click;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(29, 201);
            label37.Name = "label37";
            label37.Size = new Size(51, 15);
            label37.TabIndex = 3;
            label37.Text = "Weapon";
            // 
            // PlayerName_Text
            // 
            PlayerName_Text.AutoSize = true;
            PlayerName_Text.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerName_Text.Location = new Point(12, 9);
            PlayerName_Text.Name = "PlayerName_Text";
            PlayerName_Text.Size = new Size(28, 37);
            PlayerName_Text.TabIndex = 3;
            PlayerName_Text.Text = "-";
            // 
            // EnemyName_Text
            // 
            EnemyName_Text.AutoSize = true;
            EnemyName_Text.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            EnemyName_Text.Location = new Point(667, 86);
            EnemyName_Text.Name = "EnemyName_Text";
            EnemyName_Text.Size = new Size(33, 45);
            EnemyName_Text.TabIndex = 3;
            EnemyName_Text.Text = "-";
            // 
            // Image_Weapon_Player
            // 
            Image_Weapon_Player.Location = new Point(8, 219);
            Image_Weapon_Player.Name = "Image_Weapon_Player";
            Image_Weapon_Player.Size = new Size(108, 117);
            Image_Weapon_Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_Weapon_Player.TabIndex = 4;
            Image_Weapon_Player.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 217);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Weapon";
            // 
            // Weapon_2
            // 
            Weapon_2.Location = new Point(738, 235);
            Weapon_2.Name = "Weapon_2";
            Weapon_2.Size = new Size(108, 117);
            Weapon_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Weapon_2.TabIndex = 4;
            Weapon_2.TabStop = false;
            // 
            // Image_Shield_2
            // 
            Image_Shield_2.BackColor = Color.White;
            Image_Shield_2.Location = new Point(295, 287);
            Image_Shield_2.Name = "Image_Shield_2";
            Image_Shield_2.Size = new Size(86, 86);
            Image_Shield_2.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_Shield_2.TabIndex = 5;
            Image_Shield_2.TabStop = false;
            Image_Shield_2.Visible = false;
            // 
            // Image_Shield_1
            // 
            Image_Shield_1.BackColor = Color.White;
            Image_Shield_1.Location = new Point(295, 180);
            Image_Shield_1.Name = "Image_Shield_1";
            Image_Shield_1.Size = new Size(86, 86);
            Image_Shield_1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_Shield_1.TabIndex = 5;
            Image_Shield_1.TabStop = false;
            Image_Shield_1.Visible = false;
            // 
            // Image_Shield_3
            // 
            Image_Shield_3.BackColor = Color.White;
            Image_Shield_3.Location = new Point(295, 416);
            Image_Shield_3.Name = "Image_Shield_3";
            Image_Shield_3.Size = new Size(86, 86);
            Image_Shield_3.SizeMode = PictureBoxSizeMode.StretchImage;
            Image_Shield_3.TabIndex = 5;
            Image_Shield_3.TabStop = false;
            Image_Shield_3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 641);
            Controls.Add(Image_Shield_3);
            Controls.Add(Image_Shield_1);
            Controls.Add(Image_Shield_2);
            Controls.Add(Weapon_2);
            Controls.Add(Image_Weapon_Player);
            Controls.Add(Lbl_param_defence_enemy);
            Controls.Add(Lbl_param_defence);
            Controls.Add(Lbl_param_attack_enemy);
            Controls.Add(Lbl_param_attack);
            Controls.Add(Lbl_Gold);
            Controls.Add(Lbl_EnemyLife);
            Controls.Add(Lbl_PlayerLife);
            Controls.Add(label4);
            Controls.Add(label37);
            Controls.Add(EnemyName_Text);
            Controls.Add(PlayerName_Text);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label29);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(Btn_StartBattle);
            Controls.Add(button4);
            Controls.Add(Btn_Store);
            Controls.Add(button2);
            Controls.Add(Picture_2);
            Controls.Add(Image_Player);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Image_Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Weapon_Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Weapon_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Shield_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Image_Player;
        private PictureBox Picture_2;
        private Button button2;
        private Button Btn_StartBattle;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label Lbl_PlayerLife;
        private Label label3;
        private Label Lbl_param_attack;
        private Label label7;
        private Label Lbl_param_defence;
        private Label label29;
        private Label Lbl_Gold;
        private Label label5;
        private Label Lbl_EnemyLife;
        private Label label17;
        private Label label18;
        private Label Lbl_param_attack_enemy;
        private Label Lbl_param_defence_enemy;
        private Button Btn_Store;
        private Label label37;
        private Label PlayerName_Text;
        private Label EnemyName_Text;
        private PictureBox Image_Weapon_Player;
        private Label label4;
        private PictureBox Weapon_2;
        private PictureBox Image_Shield_2;
        private PictureBox Image_Shield_1;
        private PictureBox Image_Shield_3;
    }
}
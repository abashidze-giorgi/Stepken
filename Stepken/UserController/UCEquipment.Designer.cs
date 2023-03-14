namespace Stepken.UserController
{
    partial class UCEquipment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_exit = new Button();
            Btn_equip = new Button();
            Control_equipment = new TabControl();
            tabPage1 = new TabPage();
            Flow_weapon = new FlowLayoutPanel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            Pic_EquipedWeapon = new PictureBox();
            Pic_EquipedArmor = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Pic_EquipedShield = new PictureBox();
            Pic_EquipedMagicWeapon = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            Control_equipment.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedWeapon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedArmor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedMagicWeapon).BeginInit();
            SuspendLayout();
            // 
            // Btn_exit
            // 
            Btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            Btn_exit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_exit.ForeColor = Color.White;
            Btn_exit.Location = new Point(860, 507);
            Btn_exit.Name = "Btn_exit";
            Btn_exit.Size = new Size(117, 50);
            Btn_exit.TabIndex = 0;
            Btn_exit.Text = "Exit";
            Btn_exit.UseVisualStyleBackColor = false;
            Btn_exit.Click += Btn_exit_Click;
            // 
            // Btn_equip
            // 
            Btn_equip.BackColor = Color.Green;
            Btn_equip.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equip.ForeColor = Color.White;
            Btn_equip.Location = new Point(3, 507);
            Btn_equip.Name = "Btn_equip";
            Btn_equip.Size = new Size(117, 50);
            Btn_equip.TabIndex = 0;
            Btn_equip.Text = "Equip";
            Btn_equip.UseVisualStyleBackColor = false;
            // 
            // Control_equipment
            // 
            Control_equipment.Controls.Add(tabPage1);
            Control_equipment.Controls.Add(tabPage2);
            Control_equipment.Controls.Add(tabPage3);
            Control_equipment.Controls.Add(tabPage4);
            Control_equipment.Location = new Point(518, 3);
            Control_equipment.Name = "Control_equipment";
            Control_equipment.SelectedIndex = 0;
            Control_equipment.Size = new Size(459, 498);
            Control_equipment.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Flow_weapon);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(451, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Weapon";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Flow_weapon
            // 
            Flow_weapon.AutoScroll = true;
            Flow_weapon.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Flow_weapon.Dock = DockStyle.Fill;
            Flow_weapon.Location = new Point(3, 3);
            Flow_weapon.Name = "Flow_weapon";
            Flow_weapon.Size = new Size(445, 464);
            Flow_weapon.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(451, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Armor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(451, 470);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Shield";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(451, 470);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Magic Weapon";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Pic_EquipedWeapon
            // 
            Pic_EquipedWeapon.BorderStyle = BorderStyle.FixedSingle;
            Pic_EquipedWeapon.Location = new Point(20, 65);
            Pic_EquipedWeapon.Name = "Pic_EquipedWeapon";
            Pic_EquipedWeapon.Size = new Size(122, 121);
            Pic_EquipedWeapon.TabIndex = 2;
            Pic_EquipedWeapon.TabStop = false;
            // 
            // Pic_EquipedArmor
            // 
            Pic_EquipedArmor.BorderStyle = BorderStyle.FixedSingle;
            Pic_EquipedArmor.Location = new Point(274, 65);
            Pic_EquipedArmor.Name = "Pic_EquipedArmor";
            Pic_EquipedArmor.Size = new Size(122, 121);
            Pic_EquipedArmor.TabIndex = 2;
            Pic_EquipedArmor.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Weapon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 30);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Armor";
            // 
            // Pic_EquipedShield
            // 
            Pic_EquipedShield.BorderStyle = BorderStyle.FixedSingle;
            Pic_EquipedShield.Location = new Point(20, 250);
            Pic_EquipedShield.Name = "Pic_EquipedShield";
            Pic_EquipedShield.Size = new Size(122, 121);
            Pic_EquipedShield.TabIndex = 2;
            Pic_EquipedShield.TabStop = false;
            // 
            // Pic_EquipedMagicWeapon
            // 
            Pic_EquipedMagicWeapon.BorderStyle = BorderStyle.FixedSingle;
            Pic_EquipedMagicWeapon.Location = new Point(274, 250);
            Pic_EquipedMagicWeapon.Name = "Pic_EquipedMagicWeapon";
            Pic_EquipedMagicWeapon.Size = new Size(122, 121);
            Pic_EquipedMagicWeapon.TabIndex = 2;
            Pic_EquipedMagicWeapon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 215);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Shield";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 215);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Magic weapon";
            // 
            // UCEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(Pic_EquipedMagicWeapon);
            Controls.Add(label1);
            Controls.Add(Pic_EquipedShield);
            Controls.Add(Pic_EquipedArmor);
            Controls.Add(Pic_EquipedWeapon);
            Controls.Add(Control_equipment);
            Controls.Add(Btn_equip);
            Controls.Add(Btn_exit);
            Name = "UCEquipment";
            Size = new Size(980, 560);
            Load += UCEquipment_Load;
            Control_equipment.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedWeapon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedArmor).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedShield).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic_EquipedMagicWeapon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button Btn_exit;
        public Button Btn_equip;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabControl Control_equipment;
        private FlowLayoutPanel Flow_weapon;
        private PictureBox Pic_EquipedWeapon;
        private PictureBox Pic_EquipedArmor;
        private Label label1;
        private Label label2;
        private PictureBox Pic_EquipedShield;
        private PictureBox Pic_EquipedMagicWeapon;
        private Label label3;
        private Label label4;
    }
}

namespace Stepken
{
    partial class GameSettingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_New = new Button();
            Btn_exit = new Button();
            PlayerPanel = new FlowLayoutPanel();
            label1 = new Label();
            Btn_load = new Button();
            Btn_delete = new Button();
            SuspendLayout();
            // 
            // Btn_New
            // 
            Btn_New.BackColor = Color.FromArgb(0, 0, 64);
            Btn_New.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_New.ForeColor = Color.White;
            Btn_New.Location = new Point(605, 52);
            Btn_New.Name = "Btn_New";
            Btn_New.Size = new Size(300, 50);
            Btn_New.TabIndex = 0;
            Btn_New.Text = "New Game";
            Btn_New.UseVisualStyleBackColor = false;
            Btn_New.Click += Btn_New_Click;
            // 
            // Btn_exit
            // 
            Btn_exit.BackColor = Color.FromArgb(192, 0, 0);
            Btn_exit.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_exit.ForeColor = Color.White;
            Btn_exit.Location = new Point(605, 562);
            Btn_exit.Name = "Btn_exit";
            Btn_exit.Size = new Size(300, 50);
            Btn_exit.TabIndex = 0;
            Btn_exit.Text = "Exit";
            Btn_exit.UseVisualStyleBackColor = false;
            Btn_exit.Click += Btn_exit_Click;
            // 
            // PlayerPanel
            // 
            PlayerPanel.AutoScroll = true;
            PlayerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlayerPanel.BorderStyle = BorderStyle.FixedSingle;
            PlayerPanel.FlowDirection = FlowDirection.TopDown;
            PlayerPanel.Location = new Point(12, 52);
            PlayerPanel.Name = "PlayerPanel";
            PlayerPanel.Size = new Size(324, 457);
            PlayerPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 2;
            label1.Text = "Savegames";
            // 
            // Btn_load
            // 
            Btn_load.BackColor = Color.FromArgb(0, 0, 64);
            Btn_load.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_load.ForeColor = Color.White;
            Btn_load.Location = new Point(12, 515);
            Btn_load.Name = "Btn_load";
            Btn_load.Size = new Size(324, 50);
            Btn_load.TabIndex = 4;
            Btn_load.Text = "Load";
            Btn_load.UseVisualStyleBackColor = false;
            Btn_load.Click += Btn_load_Click_1;
            // 
            // Btn_delete
            // 
            Btn_delete.BackColor = Color.FromArgb(0, 0, 64);
            Btn_delete.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_delete.ForeColor = Color.White;
            Btn_delete.Location = new Point(12, 571);
            Btn_delete.Name = "Btn_delete";
            Btn_delete.Size = new Size(324, 50);
            Btn_delete.TabIndex = 4;
            Btn_delete.Text = "Delete";
            Btn_delete.UseVisualStyleBackColor = false;
            Btn_delete.Click += Btn_delete_Click_1;
            // 
            // GameSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(944, 641);
            Controls.Add(Btn_delete);
            Controls.Add(Btn_load);
            Controls.Add(label1);
            Controls.Add(PlayerPanel);
            Controls.Add(Btn_exit);
            Controls.Add(Btn_New);
            Name = "GameSettingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameSettingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_New;
        private Button Btn_exit;
        private FlowLayoutPanel PlayerPanel;
        private Label label1;
        private Button Btn_load;
        private Button Btn_delete;
    }
}
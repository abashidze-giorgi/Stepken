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
            SuspendLayout();
            // 
            // Btn_New
            // 
            Btn_New.BackColor = Color.FromArgb(0, 0, 64);
            Btn_New.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_New.ForeColor = Color.White;
            Btn_New.Location = new Point(12, 562);
            Btn_New.Name = "Btn_New";
            Btn_New.Size = new Size(324, 50);
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
            PlayerPanel.BorderStyle = BorderStyle.FixedSingle;
            PlayerPanel.FlowDirection = FlowDirection.TopDown;
            PlayerPanel.Location = new Point(12, 52);
            PlayerPanel.Name = "PlayerPanel";
            PlayerPanel.Size = new Size(324, 504);
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
            // GameSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(944, 641);
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
    }
}
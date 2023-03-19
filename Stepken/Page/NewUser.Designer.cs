namespace Stepken.Page
{
    partial class NewUser
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
            Btn_Exit = new Button();
            Btn_Save = new Button();
            txt_UserName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Btn_Exit
            // 
            Btn_Exit.BackColor = Color.FromArgb(192, 0, 0);
            Btn_Exit.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Exit.ForeColor = Color.White;
            Btn_Exit.Location = new Point(283, 544);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(362, 85);
            Btn_Exit.TabIndex = 1;
            Btn_Exit.Text = "Exit";
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.BackColor = Color.FromArgb(0, 0, 64);
            Btn_Save.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.ForeColor = Color.White;
            Btn_Save.Location = new Point(283, 286);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(362, 85);
            Btn_Save.TabIndex = 3;
            Btn_Save.Text = "Create";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(178, 200);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(594, 50);
            txt_UserName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(367, 157);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 5;
            label1.Text = "Enter Your Name";
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(944, 641);
            Controls.Add(label1);
            Controls.Add(txt_UserName);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_Save);
            Name = "NewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Exit;
        private Button Btn_Save;
        private TextBox txt_UserName;
        private Label label1;
    }
}
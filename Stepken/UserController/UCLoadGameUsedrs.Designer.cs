namespace Stepken.UserController
{
    partial class UCLoadGameUsedrs
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
            btn_UserName = new Button();
            SuspendLayout();
            // 
            // btn_UserName
            // 
            btn_UserName.BackColor = Color.Maroon;
            btn_UserName.Dock = DockStyle.Fill;
            btn_UserName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UserName.ForeColor = Color.White;
            btn_UserName.Location = new Point(0, 0);
            btn_UserName.Name = "btn_UserName";
            btn_UserName.Size = new Size(317, 45);
            btn_UserName.TabIndex = 0;
            btn_UserName.Text = "button1";
            btn_UserName.UseVisualStyleBackColor = false;
            // 
            // UCLoadGameUsedrs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_UserName);
            Name = "UCLoadGameUsedrs";
            Size = new Size(317, 45);
            ResumeLayout(false);
        }

        #endregion

        public Button btn_UserName;
    }
}

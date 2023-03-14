namespace Stepken.UserController
{
    partial class UCItem
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
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label14 = new Label();
            PropertyPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(401, 77);
            label13.Name = "label13";
            label13.Size = new Size(61, 25);
            label13.TabIndex = 1;
            label13.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(255, 128, 0);
            label14.Location = new Point(418, 118);
            label14.Name = "label14";
            label14.Size = new Size(23, 25);
            label14.TabIndex = 1;
            label14.Text = "0";
            // 
            // PropertyPanel
            // 
            PropertyPanel.FlowDirection = FlowDirection.TopDown;
            PropertyPanel.Location = new Point(217, 3);
            PropertyPanel.Name = "PropertyPanel";
            PropertyPanel.Size = new Size(178, 207);
            PropertyPanel.TabIndex = 2;
            // 
            // UCItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PropertyPanel);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Name = "UCItem";
            Size = new Size(508, 213);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label13;
        private Label label14;
        private FlowLayoutPanel PropertyPanel;
    }
}

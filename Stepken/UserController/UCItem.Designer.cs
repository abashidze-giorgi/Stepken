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
            Image_item = new PictureBox();
            label13 = new Label();
            Lbl_Price = new Label();
            PropertyPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Image_item).BeginInit();
            SuspendLayout();
            // 
            // Image_item
            // 
            Image_item.Location = new Point(3, 3);
            Image_item.Name = "Image_item";
            Image_item.Size = new Size(98, 104);
            Image_item.TabIndex = 0;
            Image_item.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(349, 20);
            label13.Name = "label13";
            label13.Size = new Size(61, 25);
            label13.TabIndex = 1;
            label13.Text = "Price:";
            // 
            // Lbl_Price
            // 
            Lbl_Price.AutoSize = true;
            Lbl_Price.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Price.ForeColor = Color.FromArgb(255, 128, 0);
            Lbl_Price.Location = new Point(366, 61);
            Lbl_Price.Name = "Lbl_Price";
            Lbl_Price.Size = new Size(23, 25);
            Lbl_Price.TabIndex = 1;
            Lbl_Price.Text = "0";
            // 
            // PropertyPanel
            // 
            PropertyPanel.FlowDirection = FlowDirection.TopDown;
            PropertyPanel.Location = new Point(107, 3);
            PropertyPanel.Name = "PropertyPanel";
            PropertyPanel.Size = new Size(236, 104);
            PropertyPanel.TabIndex = 2;
            // 
            // UCItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PropertyPanel);
            Controls.Add(Lbl_Price);
            Controls.Add(label13);
            Controls.Add(Image_item);
            Name = "UCItem";
            Size = new Size(420, 113);
            ((System.ComponentModel.ISupportInitialize)Image_item).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox Image_item;
        private Label label13;
        private Label Lbl_Price;
        public FlowLayoutPanel PropertyPanel;
    }
}

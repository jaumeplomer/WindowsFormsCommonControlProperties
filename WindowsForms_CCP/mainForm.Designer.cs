namespace WindowsForms_CCP
{
    partial class mainForm
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
            this.targetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.centerTargetButton = new System.Windows.Forms.Button();
            this.enableButton = new System.Windows.Forms.Button();
            this.visibilityButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formSizeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(0, 0);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(100, 100);
            this.targetButton.TabIndex = 0;
            this.targetButton.TabStop = false;
            this.targetButton.Text = "Target\r\nX = 0\r\nY = 0";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            this.targetButton.Move += new System.EventHandler(this.targetButton_Move);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.leftButton);
            this.groupBox1.Controls.Add(this.rightButton);
            this.groupBox1.Controls.Add(this.downButton);
            this.groupBox1.Controls.Add(this.upButton);
            this.groupBox1.Controls.Add(this.centerTargetButton);
            this.groupBox1.Controls.Add(this.enableButton);
            this.groupBox1.Controls.Add(this.visibilityButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(570, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(28, 404);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(46, 47);
            this.leftButton.TabIndex = 5;
            this.leftButton.Text = "◄";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(134, 404);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(47, 47);
            this.rightButton.TabIndex = 6;
            this.rightButton.Text = "►";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(80, 432);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(48, 46);
            this.downButton.TabIndex = 7;
            this.downButton.Text = "▼";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(80, 377);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 49);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // centerTargetButton
            // 
            this.centerTargetButton.Location = new System.Drawing.Point(19, 266);
            this.centerTargetButton.Name = "centerTargetButton";
            this.centerTargetButton.Size = new System.Drawing.Size(168, 43);
            this.centerTargetButton.TabIndex = 3;
            this.centerTargetButton.Text = "Center Target";
            this.centerTargetButton.UseVisualStyleBackColor = true;
            this.centerTargetButton.Click += new System.EventHandler(this.centerTargetButton_Click);
            // 
            // enableButton
            // 
            this.enableButton.Location = new System.Drawing.Point(19, 192);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(168, 43);
            this.enableButton.TabIndex = 2;
            this.enableButton.Text = "Enabled  = True";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // visibilityButton
            // 
            this.visibilityButton.Location = new System.Drawing.Point(19, 116);
            this.visibilityButton.Name = "visibilityButton";
            this.visibilityButton.Size = new System.Drawing.Size(168, 41);
            this.visibilityButton.TabIndex = 1;
            this.visibilityButton.Text = "Visible = True";
            this.visibilityButton.UseVisualStyleBackColor = true;
            this.visibilityButton.Click += new System.EventHandler(this.visibilityButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "FormBorderStyle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D",
            "FixedDialog",
            "Sizable",
            "FixedToolWindow",
            "SizableToolWindow"});
            this.comboBox1.Location = new System.Drawing.Point(17, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // formSizeLabel
            // 
            this.formSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formSizeLabel.AutoSize = true;
            this.formSizeLabel.Location = new System.Drawing.Point(20, 530);
            this.formSizeLabel.Name = "formSizeLabel";
            this.formSizeLabel.Size = new System.Drawing.Size(135, 17);
            this.formSizeLabel.TabIndex = 2;
            this.formSizeLabel.Text = "Form Size: 800, 600";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.formSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetButton);
            this.Name = "mainForm";
            this.Text = "(0, 0) Winforms Components - Common Controls";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Move += new System.EventHandler(this.mainForm_Move);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label formSizeLabel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button centerTargetButton;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button visibilityButton;
        private System.Windows.Forms.Label label1;
    }
}


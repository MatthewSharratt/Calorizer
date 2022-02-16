namespace Calorizer
{
    partial class MainForm
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
            this.CalorieOutput = new System.Windows.Forms.Label();
            this.CrunchBox = new Calorizer.unchBox();
            this.MunchBox = new Calorizer.unchBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalorieOutput
            // 
            this.CalorieOutput.AutoSize = true;
            this.CalorieOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalorieOutput.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CalorieOutput.Location = new System.Drawing.Point(122, 233);
            this.CalorieOutput.Name = "CalorieOutput";
            this.CalorieOutput.Size = new System.Drawing.Size(85, 24);
            this.CalorieOutput.TabIndex = 10;
            this.CalorieOutput.Text = "Bunch: 0";
            // 
            // CrunchBox
            // 
            this.CrunchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrunchBox.Location = new System.Drawing.Point(7, 117);
            this.CrunchBox.Name = "CrunchBox";
            this.CrunchBox.Size = new System.Drawing.Size(250, 111);
            this.CrunchBox.TabIndex = 19;
            this.CrunchBox.unchLabelText = "";
            // 
            // MunchBox
            // 
            this.MunchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MunchBox.Location = new System.Drawing.Point(7, 6);
            this.MunchBox.Name = "MunchBox";
            this.MunchBox.Size = new System.Drawing.Size(250, 111);
            this.MunchBox.TabIndex = 18;
            this.MunchBox.unchLabelText = "";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearAllButton.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.ClearAllButton.Location = new System.Drawing.Point(9, 234);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(111, 23);
            this.ClearAllButton.TabIndex = 17;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calorizer.Properties.Settings.Default.ApplicationBackColor;
            this.ClientSize = new System.Drawing.Size(262, 267);
            this.Controls.Add(this.CrunchBox);
            this.Controls.Add(this.MunchBox);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.CalorieOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calorizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CalorieOutput;
        private System.Windows.Forms.Button ClearAllButton;
        private unchBox MunchBox;
        private unchBox CrunchBox;
    }
}


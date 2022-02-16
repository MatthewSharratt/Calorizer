namespace Calorizer
{
    partial class unchBox
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
            this.CalorieClear = new System.Windows.Forms.Button();
            this.CalorieUpDown = new System.Windows.Forms.NumericUpDown();
            this.unchLabel = new System.Windows.Forms.Label();
            this.CalorieMinusButton = new System.Windows.Forms.Button();
            this.CaloriePlusButton = new System.Windows.Forms.Button();
            this.CalorieList = new System.Windows.Forms.ListView();
            this.FoodCalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FoodTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.CalorieUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CalorieClear
            // 
            this.CalorieClear.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.CalorieClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalorieClear.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CalorieClear.Location = new System.Drawing.Point(118, 85);
            this.CalorieClear.Name = "CalorieClear";
            this.CalorieClear.Size = new System.Drawing.Size(100, 23);
            this.CalorieClear.TabIndex = 21;
            this.CalorieClear.Text = "Clear";
            this.CalorieClear.UseVisualStyleBackColor = false;
            this.CalorieClear.Click += new System.EventHandler(this.CalorieClear_Click);
            // 
            // CalorieUpDown
            // 
            this.CalorieUpDown.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.CalorieUpDown.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CalorieUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CalorieUpDown.Location = new System.Drawing.Point(118, 30);
            this.CalorieUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.CalorieUpDown.Name = "CalorieUpDown";
            this.CalorieUpDown.Size = new System.Drawing.Size(100, 20);
            this.CalorieUpDown.TabIndex = 20;
            // 
            // unchLabel
            // 
            this.unchLabel.AutoSize = true;
            this.unchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unchLabel.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.unchLabel.Location = new System.Drawing.Point(114, 3);
            this.unchLabel.Name = "unchLabel";
            this.unchLabel.Size = new System.Drawing.Size(73, 24);
            this.unchLabel.TabIndex = 19;
            this.unchLabel.Text = "unch: 0";
            // 
            // CalorieMinusButton
            // 
            this.CalorieMinusButton.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.CalorieMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalorieMinusButton.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CalorieMinusButton.Location = new System.Drawing.Point(118, 56);
            this.CalorieMinusButton.Name = "CalorieMinusButton";
            this.CalorieMinusButton.Size = new System.Drawing.Size(100, 23);
            this.CalorieMinusButton.TabIndex = 18;
            this.CalorieMinusButton.Text = "Remove Selected";
            this.CalorieMinusButton.UseVisualStyleBackColor = false;
            this.CalorieMinusButton.Click += new System.EventHandler(this.CalorieMinusButton_Click);
            // 
            // CaloriePlusButton
            // 
            this.CaloriePlusButton.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.CaloriePlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CaloriePlusButton.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CaloriePlusButton.Location = new System.Drawing.Point(224, 27);
            this.CaloriePlusButton.Name = "CaloriePlusButton";
            this.CaloriePlusButton.Size = new System.Drawing.Size(23, 23);
            this.CaloriePlusButton.TabIndex = 17;
            this.CaloriePlusButton.Text = "+";
            this.CaloriePlusButton.UseVisualStyleBackColor = false;
            this.CaloriePlusButton.Click += new System.EventHandler(this.CaloriePlusButton_Click);
            // 
            // CalorieList
            // 
            this.CalorieList.BackColor = global::Calorizer.Properties.Settings.Default.ControlBackColor;
            this.CalorieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FoodCalories,
            this.FoodTime});
            this.CalorieList.ForeColor = global::Calorizer.Properties.Settings.Default.ControlForeColor;
            this.CalorieList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CalorieList.Location = new System.Drawing.Point(3, 3);
            this.CalorieList.Name = "CalorieList";
            this.CalorieList.Size = new System.Drawing.Size(109, 105);
            this.CalorieList.TabIndex = 16;
            this.CalorieList.UseCompatibleStateImageBehavior = false;
            this.CalorieList.View = System.Windows.Forms.View.Details;
            // 
            // FoodCalories
            // 
            this.FoodCalories.Text = "Calories";
            this.FoodCalories.Width = 49;
            // 
            // FoodTime
            // 
            this.FoodTime.Text = "Time";
            this.FoodTime.Width = 39;
            // 
            // unchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Calorizer.Properties.Settings.Default.ApplicationBackColor;
            this.Controls.Add(this.CalorieClear);
            this.Controls.Add(this.CalorieUpDown);
            this.Controls.Add(this.unchLabel);
            this.Controls.Add(this.CalorieMinusButton);
            this.Controls.Add(this.CaloriePlusButton);
            this.Controls.Add(this.CalorieList);
            this.Name = "unchBox";
            this.Size = new System.Drawing.Size(250, 111);
            ((System.ComponentModel.ISupportInitialize)(this.CalorieUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalorieClear;
        private System.Windows.Forms.NumericUpDown CalorieUpDown;
        private System.Windows.Forms.Label unchLabel;
        private System.Windows.Forms.Button CalorieMinusButton;
        private System.Windows.Forms.Button CaloriePlusButton;
        private System.Windows.Forms.ListView CalorieList;
        private System.Windows.Forms.ColumnHeader FoodCalories;
        private System.Windows.Forms.ColumnHeader FoodTime;
    }
}

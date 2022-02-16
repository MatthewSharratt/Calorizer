using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Calorizer
{
    public partial class MainForm : Form
    {
        private string unchLabelText = "";

        public MainForm()
        {
            InitializeComponent();

            MunchBox.unchLabelText = ConfigurationManager.AppSettings["CaloriesInString"];
            CrunchBox.unchLabelText = ConfigurationManager.AppSettings["CaloriesOutString"];
            unchLabelText = ConfigurationManager.AppSettings["CaloriesTotalString"];

            MunchBox.CaloriesUpdated += UpdateCalories;
            CrunchBox.CaloriesUpdated += UpdateCalories;
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear both lists?", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                UpdateCalories();
            }
        }

        private void UpdateCalories()
        {
            CalorieOutput.Text = $"{unchLabelText}: {MunchBox.Calories - CrunchBox.Calories}";
        }
    }
}

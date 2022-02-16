using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorizer
{
    public partial class unchBox : UserControl
    {
        private string m_unchLabelText = "";
        private int m_Calories = 0;

        public int Calories { get { return m_Calories; } }
        public string unchLabelText { get { return m_unchLabelText; } set { m_unchLabelText = value; UpdateLabel(); } }

        public delegate void CaloriesUpdatedEventHandler();
        public event CaloriesUpdatedEventHandler CaloriesUpdated;

        public unchBox()
        {
            InitializeComponent();
        }

        public void ClearCalorieList()
        {
            CalorieList.Items.Clear();
            UpdateCalories();
        }

        private void CaloriePlusButton_Click(object sender, EventArgs e)
        {
            if (CalorieUpDown.Text != "0")
            {
                ListViewItem item = new ListViewItem(CalorieUpDown.Text);
                item.SubItems.Add(DateTime.Now.ToString("H:mm"));
                CalorieList.Items.Add(item);
                UpdateCalories();
            }
        }

        private void CalorieMinusButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in CalorieList.SelectedItems)
            {
                CalorieList.Items.Remove(item);
            }
            UpdateCalories();
        }

        private void CalorieClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to clear the {m_unchLabelText} list?", "Are you sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClearCalorieList();
            }
        }

        private void UpdateCalories()
        {
            m_Calories = CalorieList.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[0].Text));

            UpdateLabel();
            CaloriesUpdated();
        }

        private void UpdateLabel()
        {
            unchLabel.Text = $"{m_unchLabelText}: {m_Calories}";
        }
    }
}


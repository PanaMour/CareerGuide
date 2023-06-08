using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareerGuide
{
    public partial class Questionnaire : Form
    {
        private bool isSubmitted = false;

        public Questionnaire()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Course().ShowDialog();
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Handle submit button click event
            if (IsRadioButtonSelected(groupBox1) &&
                IsRadioButtonSelected(groupBox2) &&
                IsRadioButtonSelected(groupBox3) &&
                IsRadioButtonSelected(groupBox4) &&
                IsRadioButtonSelected(groupBox5))
            {
                // All radio buttons are selected
                isSubmitted = true;
                MessageBox.Show("Questionnaire submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // At least one group has no radio button selected
                MessageBox.Show("Please answer all the questions.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsRadioButtonSelected(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }
    }
}

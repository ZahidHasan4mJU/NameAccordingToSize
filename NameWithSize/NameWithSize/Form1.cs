using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameWithSize
{
    public partial class NameWidSizeForm : Form
    {
        public NameWidSizeForm()
        {
            InitializeComponent();
        }
        int count = 0;
        List<string> name = new List<string>();
        int size = 0;

        private void setButton_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(employeeNoTextBox.Text);
            employeeNoTextBox.Text = "";
            setButton.Enabled = false;
            addButton.Enabled = true;
            resetButton.Enabled = false;
            showButton.Enabled = false;


            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            name.Add(employeeNameTextBox.Text);
            employeeNameTextBox.Text = "";
            count++;
            if (count >= size)
            {
                addButton.Enabled = false;
            }
            countTextBox.Text = count.ToString();
            showButton.Enabled = true;

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < name.Count; i++)
            {
                if (name[i] != null)
                    listBox.Items.Add((i + 1) + " -> " + name[i]);
            }
            resetButton.Enabled = true;
            addButton.Enabled = false;
            setButton.Enabled = false;



        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            countTextBox.Text = "0";
            count = 0;
            addButton.Enabled = false;
            setButton.Enabled = true;
            showButton.Enabled = false;
        }
    }
}

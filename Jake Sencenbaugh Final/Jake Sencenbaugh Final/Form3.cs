// Jake Sencenbaugh
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Jake_Sencenbaugh_Final
{
    public partial class Form3 : Form
    {
        public static ArrayList dogs = new ArrayList();
        public static Form mainForm;
        public Form3(ArrayList theDogs, Form aForm)
        {
            InitializeComponent();
            dogs = theDogs;
            mainForm = aForm;
            getTotalTime();
            fillComboBox();
        }

        private void enterWalk_MouseHover(object sender, EventArgs e)
        {
            enterWalk.BackColor = Color.White;
        }

        private void enterWalk_MouseLeave(object sender, EventArgs e)
        {
            enterWalk.BackColor = Color.Orange;
        }

        private void addTime_MouseHover(object sender, EventArgs e)
        {
            addTime.BackColor = Color.White;
        }

        private void addTime_MouseLeave(object sender, EventArgs e)
        {
            addTime.BackColor = Color.Orange;
        }

        private void report_MouseHover(object sender, EventArgs e)
        {
            report.BackColor = Color.White;
        }

        private void report_MouseLeave(object sender, EventArgs e)
        {
            report.BackColor = Color.Orange;
        }

        private void dogNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void enterWalk_Click(object sender, EventArgs e)
        {
            // Goes to the client page
            mainForm.Visible = true;
            this.Close();

        }

        private void submitInfoBtn_Click(object sender, EventArgs e)
        {

        }

        private void getTotalTime()
        {
            // Calculates the total time walked.
            float time =
                (from Dog d in dogs
                select d.WalkTime).Sum();

            totalTime.Text = time.ToString();
        }

        private void fillComboBox()
        {
            // Fills the combo box with dog and client names
            var theDogs =
                from Dog d in dogs
                select d;
            foreach (Dog d in theDogs)
            {
                comboBox1.Items.Add(d.DogName + " | " + d.OwnerName);
            }
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            // Goes to the add time page
            Form2 form2 = new Form2(dogs, mainForm);
            form2.Show();
            this.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exit button
            mainForm.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Generates a report based on the dog selected.
            var dog =
                from Dog d in dogs
                where (d.DogName + " | " + d.OwnerName) == comboBox1.SelectedItem.ToString()
                select d;
            label2.Text = "";
            foreach(Dog d in dog)
            {
                label2.Text += "Dog Name: " + d.DogName + "\n";
                label2.Text += "Dog Owner: " + d.OwnerName + "\n";
                label2.Text += "Address: " + d.Address + "\n";
                label2.Text += "Walk Time: " + d.WalkTime + "\n";
                label2.Text += "Notes: " + "\n" + d.Notes + "\n";

            }


                
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }

    }
}

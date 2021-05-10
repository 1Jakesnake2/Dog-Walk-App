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
    public partial class Form2 : Form
    {
        public static ArrayList dogs = new ArrayList();
        public static Form mainForm;
        public static Form prevForm;

        public Form2(ArrayList theDogs, Form pForm ,Form mForm)
        {
            InitializeComponent();
            
            mainForm = mForm;
            prevForm = pForm;
            dogs = theDogs;
            fillComboBox();
        }

        public Form2(ArrayList theDogs, Form mForm)
        {
            InitializeComponent();
            
            mainForm = mForm;
            dogs = theDogs;
            fillComboBox();
        }



        public Form2(ArrayList theDogs)
        {
            InitializeComponent();
            dogs = theDogs;
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

        private void fillComboBox()
        {
            //Fills the combobox with client and dog names
            var theDogs =
                from Dog d in dogs
                select d;
            foreach (Dog d in theDogs)
            {
                combobox.Items.Add(d.DogName + " | " + d.OwnerName);
            }
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
            // Goes to client page
            mainForm.Visible = true;
            this.Close();
            
        }

        private void submitInfoBtn_Click(object sender, EventArgs e)
        {
            // Allows you to add walking time to a dog
            var dog =
               from Dog d in dogs
               where combobox.SelectedItem.ToString().Equals((d.DogName + " | " + d.OwnerName))
               select d;

            foreach (Dog d in dog)
            {
                d.WalkTime += float.Parse(addTimeToWalk.Text);
            }
            combobox.ResetText();
            addTimeToWalk.ResetText();
        }

        private void report_Click(object sender, EventArgs e)
        {
            // Goes to the report page
            Form3 form = new Form3(dogs, mainForm);
            form.Show();
            this.Close();
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exit button
            mainForm.Close();
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

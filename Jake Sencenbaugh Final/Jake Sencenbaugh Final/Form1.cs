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
    public partial class Form1 : Form
    {
        public static ArrayList dogs = new ArrayList();
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
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
            
            
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            // Goes to add time page
            Form2 form2 = new Form2(dogs,this);
            form2.Show();
            this.Visible = false;
        }

        private void submitInfoBtn_Click(object sender, EventArgs e)
        {
            //Creates client
            if((dogName.Text != null) && (ownerName.Text != null) && (address.Text != null))
            {
                Dog dog = new Dog(dogName.Text.ToUpper(), ownerName.Text.ToUpper(), address.Text.ToUpper(), notes.Text.ToUpper(), float.Parse(totalTime.Text));
                dogs.Add(dog);
                notes.Clear();
                dogName.Clear();
                ownerName.Clear();
                address.Clear();
                totalTime.ResetText();
            }

        }

        private void report_Click(object sender, EventArgs e)
        {
            //Goes to the report page
            Form3 form2 = new Form3(dogs, this);
            form2.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exit button
            this.Close();
        }
    }
}

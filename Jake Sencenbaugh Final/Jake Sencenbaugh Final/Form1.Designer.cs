
namespace Jake_Sencenbaugh_Final
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterWalk = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.addTime = new System.Windows.Forms.Button();
            this.dogWalkForm = new System.Windows.Forms.GroupBox();
            this.submitInfoBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dogNameLbl = new System.Windows.Forms.Label();
            this.dogName = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dogWalkForm.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalTime)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(800, 70);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dog Walking";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterWalk
            // 
            this.enterWalk.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.enterWalk.BackColor = System.Drawing.Color.Orange;
            this.enterWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterWalk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterWalk.Location = new System.Drawing.Point(3, 12);
            this.enterWalk.Name = "enterWalk";
            this.enterWalk.Size = new System.Drawing.Size(115, 40);
            this.enterWalk.TabIndex = 1;
            this.enterWalk.Text = "Enter Walk";
            this.enterWalk.UseVisualStyleBackColor = false;
            this.enterWalk.Click += new System.EventHandler(this.enterWalk_Click);
            this.enterWalk.MouseLeave += new System.EventHandler(this.enterWalk_MouseLeave);
            this.enterWalk.MouseHover += new System.EventHandler(this.enterWalk_MouseHover);
            // 
            // report
            // 
            this.report.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.report.BackColor = System.Drawing.Color.Orange;
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(323, 12);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(115, 40);
            this.report.TabIndex = 2;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            this.report.MouseLeave += new System.EventHandler(this.report_MouseLeave);
            this.report.MouseHover += new System.EventHandler(this.report_MouseHover);
            // 
            // addTime
            // 
            this.addTime.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.addTime.BackColor = System.Drawing.Color.Orange;
            this.addTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTime.Location = new System.Drawing.Point(163, 12);
            this.addTime.Name = "addTime";
            this.addTime.Size = new System.Drawing.Size(115, 40);
            this.addTime.TabIndex = 3;
            this.addTime.Text = "Add Time";
            this.addTime.UseVisualStyleBackColor = false;
            this.addTime.Click += new System.EventHandler(this.addTime_Click);
            this.addTime.MouseLeave += new System.EventHandler(this.addTime_MouseLeave);
            this.addTime.MouseHover += new System.EventHandler(this.addTime_MouseHover);
            // 
            // dogWalkForm
            // 
            this.dogWalkForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dogWalkForm.Controls.Add(this.submitInfoBtn);
            this.dogWalkForm.Controls.Add(this.panel6);
            this.dogWalkForm.Controls.Add(this.panel5);
            this.dogWalkForm.Controls.Add(this.panel3);
            this.dogWalkForm.Controls.Add(this.panel4);
            this.dogWalkForm.Controls.Add(this.panel2);
            this.dogWalkForm.Location = new System.Drawing.Point(149, 177);
            this.dogWalkForm.Name = "dogWalkForm";
            this.dogWalkForm.Size = new System.Drawing.Size(504, 382);
            this.dogWalkForm.TabIndex = 5;
            this.dogWalkForm.TabStop = false;
            this.dogWalkForm.Text = "Create Client";
            // 
            // submitInfoBtn
            // 
            this.submitInfoBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.submitInfoBtn.BackColor = System.Drawing.Color.Orange;
            this.submitInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitInfoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInfoBtn.Location = new System.Drawing.Point(383, 336);
            this.submitInfoBtn.Name = "submitInfoBtn";
            this.submitInfoBtn.Size = new System.Drawing.Size(115, 40);
            this.submitInfoBtn.TabIndex = 6;
            this.submitInfoBtn.Text = "Submit";
            this.submitInfoBtn.UseVisualStyleBackColor = false;
            this.submitInfoBtn.Click += new System.EventHandler(this.submitInfoBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.notes);
            this.panel6.Location = new System.Drawing.Point(0, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 74);
            this.panel6.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(73, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Notes:";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(148, 13);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(313, 58);
            this.notes.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.totalTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 48);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(274, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "hrs";
            // 
            // totalTime
            // 
            this.totalTime.DecimalPlaces = 1;
            this.totalTime.Location = new System.Drawing.Point(148, 16);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(120, 22);
            this.totalTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Time:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ownerName);
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 48);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Name:";
            // 
            // ownerName
            // 
            this.ownerName.Location = new System.Drawing.Point(148, 15);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(313, 22);
            this.ownerName.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.address);
            this.panel4.Location = new System.Drawing.Point(0, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(504, 48);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(58, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(148, 15);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(313, 22);
            this.address.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dogNameLbl);
            this.panel2.Controls.Add(this.dogName);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 48);
            this.panel2.TabIndex = 2;
            // 
            // dogNameLbl
            // 
            this.dogNameLbl.AutoSize = true;
            this.dogNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dogNameLbl.Location = new System.Drawing.Point(35, 13);
            this.dogNameLbl.Name = "dogNameLbl";
            this.dogNameLbl.Size = new System.Drawing.Size(97, 23);
            this.dogNameLbl.TabIndex = 0;
            this.dogNameLbl.Text = "Dog Name:";
            this.dogNameLbl.Click += new System.EventHandler(this.dogNameLbl_Click);
            // 
            // dogName
            // 
            this.dogName.Location = new System.Drawing.Point(148, 14);
            this.dogName.Name = "dogName";
            this.dogName.Size = new System.Drawing.Size(313, 22);
            this.dogName.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.enterWalk);
            this.panel1.Controls.Add(this.addTime);
            this.panel1.Location = new System.Drawing.Point(180, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 59);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(762, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dogWalkForm);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dogWalkForm.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalTime)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button enterWalk;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button addTime;
        private System.Windows.Forms.GroupBox dogWalkForm;
        private System.Windows.Forms.TextBox dogName;
        private System.Windows.Forms.Label dogNameLbl;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.NumericUpDown totalTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitInfoBtn;
        private System.Windows.Forms.Button button1;
    }
}



namespace Jake_Sencenbaugh_Final
{
    partial class Form2
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitInfoBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addTimeToWalk = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTimeToWalk)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.combobox);
            this.groupBox1.Controls.Add(this.submitInfoBtn);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(147, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 289);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Time";
            // 
            // submitInfoBtn
            // 
            this.submitInfoBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.submitInfoBtn.BackColor = System.Drawing.Color.Orange;
            this.submitInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitInfoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInfoBtn.Location = new System.Drawing.Point(23, 105);
            this.submitInfoBtn.Name = "submitInfoBtn";
            this.submitInfoBtn.Size = new System.Drawing.Size(115, 40);
            this.submitInfoBtn.TabIndex = 7;
            this.submitInfoBtn.Text = "Submit";
            this.submitInfoBtn.UseVisualStyleBackColor = false;
            this.submitInfoBtn.Click += new System.EventHandler(this.submitInfoBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.addTimeToWalk);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(6, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 48);
            this.panel5.TabIndex = 5;
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
            // addTimeToWalk
            // 
            this.addTimeToWalk.DecimalPlaces = 1;
            this.addTimeToWalk.Location = new System.Drawing.Point(148, 16);
            this.addTimeToWalk.Name = "addTimeToWalk";
            this.addTimeToWalk.Size = new System.Drawing.Size(120, 22);
            this.addTimeToWalk.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(45, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Time:";
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
            // combobox
            // 
            this.combobox.FormattingEnabled = true;
            this.combobox.Location = new System.Drawing.Point(110, 21);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(258, 24);
            this.combobox.TabIndex = 8;
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form2";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTimeToWalk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button enterWalk;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button addTime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown addTimeToWalk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitInfoBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combobox;
    }
}


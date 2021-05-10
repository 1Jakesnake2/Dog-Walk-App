
namespace Jake_Sencenbaugh_Final
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.dogNameLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(112, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 344);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.totalTime);
            this.panel2.Controls.Add(this.dogNameLbl);
            this.panel2.Location = new System.Drawing.Point(105, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 48);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "hours";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.totalTime.Location = new System.Drawing.Point(223, 13);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(44, 23);
            this.totalTime.TabIndex = 1;
            this.totalTime.Text = "time";
            // 
            // dogNameLbl
            // 
            this.dogNameLbl.AutoSize = true;
            this.dogNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dogNameLbl.Location = new System.Drawing.Point(64, 13);
            this.dogNameLbl.Name = "dogNameLbl";
            this.dogNameLbl.Size = new System.Drawing.Size(153, 23);
            this.dogNameLbl.TabIndex = 0;
            this.dogNameLbl.Text = "Total Time Walked:";
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
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
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
            this.Name = "Form3";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label dogNameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}


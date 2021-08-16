
namespace CAN_monitor_app
{
    partial class Menu
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_global = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_can_transmit_frame = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send_frame = new System.Windows.Forms.Button();
            this.textBox_interval = new System.Windows.Forms.TextBox();
            this.groupBox_can_commands = new System.Windows.Forms.GroupBox();
            this.button_can_close = new System.Windows.Forms.Button();
            this.button_can_open = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_setup = new System.Windows.Forms.Button();
            this.comboBox_can_bitrate = new System.Windows.Forms.ComboBox();
            this.groupBox_com_ports = new System.Windows.Forms.GroupBox();
            this.button_com_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_com_open = new System.Windows.Forms.Button();
            this.comboBox_com_ports = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_com_baud_rate = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPage_global.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox_can_transmit_frame.SuspendLayout();
            this.groupBox_can_commands.SuspendLayout();
            this.groupBox_com_ports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_global);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(732, 653);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_global
            // 
            this.tabPage_global.Controls.Add(this.splitContainer);
            this.tabPage_global.Location = new System.Drawing.Point(4, 25);
            this.tabPage_global.Name = "tabPage_global";
            this.tabPage_global.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_global.Size = new System.Drawing.Size(724, 624);
            this.tabPage_global.TabIndex = 0;
            this.tabPage_global.Text = "Global";
            this.tabPage_global.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.MinimumSize = new System.Drawing.Size(631, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listView);
            this.splitContainer.Panel1MinSize = 351;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBox_can_transmit_frame);
            this.splitContainer.Panel2.Controls.Add(this.groupBox_can_commands);
            this.splitContainer.Panel2.Controls.Add(this.groupBox_com_ports);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(718, 618);
            this.splitContainer.SplitterDistance = 351;
            this.splitContainer.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(351, 618);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Port Name";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 116;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Counter";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 116;
            // 
            // groupBox_can_transmit_frame
            // 
            this.groupBox_can_transmit_frame.Controls.Add(this.label3);
            this.groupBox_can_transmit_frame.Controls.Add(this.button_send_frame);
            this.groupBox_can_transmit_frame.Controls.Add(this.textBox_interval);
            this.groupBox_can_transmit_frame.Location = new System.Drawing.Point(10, 283);
            this.groupBox_can_transmit_frame.Name = "groupBox_can_transmit_frame";
            this.groupBox_can_transmit_frame.Size = new System.Drawing.Size(225, 76);
            this.groupBox_can_transmit_frame.TabIndex = 20;
            this.groupBox_can_transmit_frame.TabStop = false;
            this.groupBox_can_transmit_frame.Text = "CAN Transmit Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval";
            // 
            // button_send_frame
            // 
            this.button_send_frame.Location = new System.Drawing.Point(6, 38);
            this.button_send_frame.Name = "button_send_frame";
            this.button_send_frame.Size = new System.Drawing.Size(100, 28);
            this.button_send_frame.TabIndex = 2;
            this.button_send_frame.Text = "Start";
            this.button_send_frame.UseVisualStyleBackColor = true;
            this.button_send_frame.Click += new System.EventHandler(this.button_send_frame_click);
            // 
            // textBox_interval
            // 
            this.textBox_interval.Location = new System.Drawing.Point(111, 40);
            this.textBox_interval.Name = "textBox_interval";
            this.textBox_interval.Size = new System.Drawing.Size(100, 22);
            this.textBox_interval.TabIndex = 3;
            this.textBox_interval.Text = "100";
            // 
            // groupBox_can_commands
            // 
            this.groupBox_can_commands.Controls.Add(this.button_can_close);
            this.groupBox_can_commands.Controls.Add(this.button_can_open);
            this.groupBox_can_commands.Controls.Add(this.label2);
            this.groupBox_can_commands.Controls.Add(this.button_setup);
            this.groupBox_can_commands.Controls.Add(this.comboBox_can_bitrate);
            this.groupBox_can_commands.Location = new System.Drawing.Point(10, 167);
            this.groupBox_can_commands.Name = "groupBox_can_commands";
            this.groupBox_can_commands.Size = new System.Drawing.Size(225, 109);
            this.groupBox_can_commands.TabIndex = 19;
            this.groupBox_can_commands.TabStop = false;
            this.groupBox_can_commands.Text = "CAN Commands";
            // 
            // button_can_close
            // 
            this.button_can_close.Location = new System.Drawing.Point(111, 71);
            this.button_can_close.Name = "button_can_close";
            this.button_can_close.Size = new System.Drawing.Size(100, 28);
            this.button_can_close.TabIndex = 21;
            this.button_can_close.Text = "Close";
            this.button_can_close.UseVisualStyleBackColor = true;
            this.button_can_close.Click += new System.EventHandler(this.button_can_close_click);
            // 
            // button_can_open
            // 
            this.button_can_open.Location = new System.Drawing.Point(6, 71);
            this.button_can_open.Name = "button_can_open";
            this.button_can_open.Size = new System.Drawing.Size(100, 28);
            this.button_can_open.TabIndex = 20;
            this.button_can_open.Text = "Open";
            this.button_can_open.UseVisualStyleBackColor = true;
            this.button_can_open.Click += new System.EventHandler(this.button_can_open_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bitrate";
            // 
            // button_setup
            // 
            this.button_setup.Location = new System.Drawing.Point(6, 38);
            this.button_setup.Name = "button_setup";
            this.button_setup.Size = new System.Drawing.Size(100, 28);
            this.button_setup.TabIndex = 18;
            this.button_setup.Text = "Setup";
            this.button_setup.UseVisualStyleBackColor = true;
            this.button_setup.Click += new System.EventHandler(this.button_setup_click);
            // 
            // comboBox_can_bitrate
            // 
            this.comboBox_can_bitrate.FormattingEnabled = true;
            this.comboBox_can_bitrate.Items.AddRange(new object[] {
            "10Kbit",
            "20Kbit",
            "50Kbit",
            "100Kbit",
            "125Kbit",
            "250Kbit",
            "500Kbit",
            "800Kbit",
            "1Mbit"});
            this.comboBox_can_bitrate.Location = new System.Drawing.Point(111, 40);
            this.comboBox_can_bitrate.Name = "comboBox_can_bitrate";
            this.comboBox_can_bitrate.Size = new System.Drawing.Size(99, 24);
            this.comboBox_can_bitrate.TabIndex = 17;
            // 
            // groupBox_com_ports
            // 
            this.groupBox_com_ports.Controls.Add(this.button_com_close);
            this.groupBox_com_ports.Controls.Add(this.label1);
            this.groupBox_com_ports.Controls.Add(this.button_com_open);
            this.groupBox_com_ports.Controls.Add(this.comboBox_com_ports);
            this.groupBox_com_ports.Controls.Add(this.button_add);
            this.groupBox_com_ports.Controls.Add(this.comboBox_com_baud_rate);
            this.groupBox_com_ports.Location = new System.Drawing.Point(10, 10);
            this.groupBox_com_ports.Name = "groupBox_com_ports";
            this.groupBox_com_ports.Size = new System.Drawing.Size(225, 142);
            this.groupBox_com_ports.TabIndex = 18;
            this.groupBox_com_ports.TabStop = false;
            this.groupBox_com_ports.Text = "COM Ports Settings";
            // 
            // button_com_close
            // 
            this.button_com_close.Location = new System.Drawing.Point(6, 104);
            this.button_com_close.Name = "button_com_close";
            this.button_com_close.Size = new System.Drawing.Size(100, 28);
            this.button_com_close.TabIndex = 18;
            this.button_com_close.Text = "Close";
            this.button_com_close.UseVisualStyleBackColor = true;
            this.button_com_close.Click += new System.EventHandler(this.button_com_close_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Baud rate";
            // 
            // button_com_open
            // 
            this.button_com_open.Location = new System.Drawing.Point(6, 71);
            this.button_com_open.Name = "button_com_open";
            this.button_com_open.Size = new System.Drawing.Size(100, 28);
            this.button_com_open.TabIndex = 16;
            this.button_com_open.Text = "Open";
            this.button_com_open.UseVisualStyleBackColor = true;
            this.button_com_open.Click += new System.EventHandler(this.button_com_open_click);
            // 
            // comboBox_com_ports
            // 
            this.comboBox_com_ports.DropDownWidth = 99;
            this.comboBox_com_ports.FormattingEnabled = true;
            this.comboBox_com_ports.Location = new System.Drawing.Point(111, 23);
            this.comboBox_com_ports.Name = "comboBox_com_ports";
            this.comboBox_com_ports.Size = new System.Drawing.Size(99, 24);
            this.comboBox_com_ports.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(6, 21);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 28);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add new port";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_click);
            // 
            // comboBox_com_baud_rate
            // 
            this.comboBox_com_baud_rate.FormattingEnabled = true;
            this.comboBox_com_baud_rate.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_com_baud_rate.Location = new System.Drawing.Point(111, 73);
            this.comboBox_com_baud_rate.Name = "comboBox_com_baud_rate";
            this.comboBox_com_baud_rate.Size = new System.Drawing.Size(99, 24);
            this.comboBox_com_baud_rate.TabIndex = 15;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 653);
            this.Controls.Add(this.tabControl);
            this.Name = "Menu";
            this.Text = "CAN Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_global.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox_can_transmit_frame.ResumeLayout(false);
            this.groupBox_can_transmit_frame.PerformLayout();
            this.groupBox_can_commands.ResumeLayout(false);
            this.groupBox_can_commands.PerformLayout();
            this.groupBox_com_ports.ResumeLayout(false);
            this.groupBox_com_ports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_global;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ComboBox comboBox_com_ports;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_interval;
        private System.Windows.Forms.Button button_send_frame;
        public System.Windows.Forms.ComboBox comboBox_com_baud_rate;
        public System.Windows.Forms.ComboBox comboBox_can_bitrate;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox_com_ports;
        private System.Windows.Forms.Button button_com_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_com_close;
        private System.Windows.Forms.GroupBox groupBox_can_commands;
        private System.Windows.Forms.Button button_setup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_can_close;
        private System.Windows.Forms.Button button_can_open;
        private System.Windows.Forms.GroupBox groupBox_can_transmit_frame;
        private System.Windows.Forms.Label label3;
    }
}


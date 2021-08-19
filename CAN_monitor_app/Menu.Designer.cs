
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tab_page_global = new System.Windows.Forms.TabPage();
            this.split_container = new System.Windows.Forms.SplitContainer();
            this.list_view = new CAN_monitor_app.BufferedListView();
            this.column_header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_header3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_box_can_transmit_frame = new System.Windows.Forms.GroupBox();
            this.label_interval = new System.Windows.Forms.Label();
            this.button_send_frame = new System.Windows.Forms.Button();
            this.text_box_interval = new System.Windows.Forms.TextBox();
            this.group_box_can_commands = new System.Windows.Forms.GroupBox();
            this.button_can_close = new System.Windows.Forms.Button();
            this.button_can_open = new System.Windows.Forms.Button();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.button_can_setup = new System.Windows.Forms.Button();
            this.combo_box_can_bitrate = new System.Windows.Forms.ComboBox();
            this.group_box_com_ports = new System.Windows.Forms.GroupBox();
            this.button_com_close = new System.Windows.Forms.Button();
            this.label_baud_rate = new System.Windows.Forms.Label();
            this.button_com_open = new System.Windows.Forms.Button();
            this.combo_box_com_ports = new System.Windows.Forms.ComboBox();
            this.button_add_new_tab = new System.Windows.Forms.Button();
            this.combo_box_com_baud_rate = new System.Windows.Forms.ComboBox();
            this.tab_control.SuspendLayout();
            this.tab_page_global.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).BeginInit();
            this.split_container.Panel1.SuspendLayout();
            this.split_container.Panel2.SuspendLayout();
            this.split_container.SuspendLayout();
            this.group_box_can_transmit_frame.SuspendLayout();
            this.group_box_can_commands.SuspendLayout();
            this.group_box_com_ports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_page_global);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(732, 653);
            this.tab_control.TabIndex = 0;
            // 
            // tab_page_global
            // 
            this.tab_page_global.Controls.Add(this.split_container);
            this.tab_page_global.Location = new System.Drawing.Point(4, 25);
            this.tab_page_global.Name = "tab_page_global";
            this.tab_page_global.Padding = new System.Windows.Forms.Padding(3);
            this.tab_page_global.Size = new System.Drawing.Size(724, 624);
            this.tab_page_global.TabIndex = 0;
            this.tab_page_global.Text = "Global";
            this.tab_page_global.UseVisualStyleBackColor = true;
            // 
            // split_container
            // 
            this.split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split_container.Location = new System.Drawing.Point(3, 3);
            this.split_container.MinimumSize = new System.Drawing.Size(631, 0);
            this.split_container.Name = "split_container";
            // 
            // split_container.Panel1
            // 
            this.split_container.Panel1.Controls.Add(this.list_view);
            this.split_container.Panel1MinSize = 351;
            // 
            // split_container.Panel2
            // 
            this.split_container.Panel2.Controls.Add(this.group_box_can_transmit_frame);
            this.split_container.Panel2.Controls.Add(this.group_box_can_commands);
            this.split_container.Panel2.Controls.Add(this.group_box_com_ports);
            this.split_container.Panel2MinSize = 0;
            this.split_container.Size = new System.Drawing.Size(718, 618);
            this.split_container.SplitterDistance = 351;
            this.split_container.TabIndex = 0;
            // 
            // list_view
            // 
            this.list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_header1,
            this.column_header2,
            this.column_header3});
            this.list_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_view.GridLines = true;
            this.list_view.HideSelection = false;
            this.list_view.Location = new System.Drawing.Point(0, 0);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(351, 618);
            this.list_view.TabIndex = 0;
            this.list_view.UseCompatibleStateImageBehavior = false;
            this.list_view.View = System.Windows.Forms.View.Details;
            // 
            // column_header1
            // 
            this.column_header1.Text = "Port Name";
            this.column_header1.Width = 115;
            // 
            // column_header2
            // 
            this.column_header2.Text = "Status";
            this.column_header2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_header2.Width = 116;
            // 
            // column_header3
            // 
            this.column_header3.Text = "Counter";
            this.column_header3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_header3.Width = 116;
            // 
            // group_box_can_transmit_frame
            // 
            this.group_box_can_transmit_frame.Controls.Add(this.label_interval);
            this.group_box_can_transmit_frame.Controls.Add(this.button_send_frame);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_interval);
            this.group_box_can_transmit_frame.Location = new System.Drawing.Point(10, 283);
            this.group_box_can_transmit_frame.Name = "group_box_can_transmit_frame";
            this.group_box_can_transmit_frame.Size = new System.Drawing.Size(225, 76);
            this.group_box_can_transmit_frame.TabIndex = 20;
            this.group_box_can_transmit_frame.TabStop = false;
            this.group_box_can_transmit_frame.Text = "CAN Transmit Frame";
            // 
            // label_interval
            // 
            this.label_interval.AutoSize = true;
            this.label_interval.Location = new System.Drawing.Point(111, 21);
            this.label_interval.Name = "label_interval";
            this.label_interval.Size = new System.Drawing.Size(86, 17);
            this.label_interval.TabIndex = 4;
            this.label_interval.Text = "Interval (ms)";
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
            // text_box_interval
            // 
            this.text_box_interval.Location = new System.Drawing.Point(111, 40);
            this.text_box_interval.Name = "text_box_interval";
            this.text_box_interval.Size = new System.Drawing.Size(100, 22);
            this.text_box_interval.TabIndex = 3;
            this.text_box_interval.Text = "100";
            // 
            // group_box_can_commands
            // 
            this.group_box_can_commands.Controls.Add(this.button_can_close);
            this.group_box_can_commands.Controls.Add(this.button_can_open);
            this.group_box_can_commands.Controls.Add(this.label_bitrate);
            this.group_box_can_commands.Controls.Add(this.button_can_setup);
            this.group_box_can_commands.Controls.Add(this.combo_box_can_bitrate);
            this.group_box_can_commands.Location = new System.Drawing.Point(10, 167);
            this.group_box_can_commands.Name = "group_box_can_commands";
            this.group_box_can_commands.Size = new System.Drawing.Size(225, 109);
            this.group_box_can_commands.TabIndex = 19;
            this.group_box_can_commands.TabStop = false;
            this.group_box_can_commands.Text = "CAN Commands";
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
            // label_bitrate
            // 
            this.label_bitrate.AutoSize = true;
            this.label_bitrate.Location = new System.Drawing.Point(111, 21);
            this.label_bitrate.Name = "label_bitrate";
            this.label_bitrate.Size = new System.Drawing.Size(49, 17);
            this.label_bitrate.TabIndex = 19;
            this.label_bitrate.Text = "Bitrate";
            // 
            // button_can_setup
            // 
            this.button_can_setup.Location = new System.Drawing.Point(6, 38);
            this.button_can_setup.Name = "button_can_setup";
            this.button_can_setup.Size = new System.Drawing.Size(100, 28);
            this.button_can_setup.TabIndex = 18;
            this.button_can_setup.Text = "Setup";
            this.button_can_setup.UseVisualStyleBackColor = true;
            this.button_can_setup.Click += new System.EventHandler(this.button_can_setup_click);
            // 
            // combo_box_can_bitrate
            // 
            this.combo_box_can_bitrate.FormattingEnabled = true;
            this.combo_box_can_bitrate.Items.AddRange(new object[] {
            "10Kbit",
            "20Kbit",
            "50Kbit",
            "100Kbit",
            "125Kbit",
            "250Kbit",
            "500Kbit",
            "800Kbit",
            "1Mbit"});
            this.combo_box_can_bitrate.Location = new System.Drawing.Point(111, 40);
            this.combo_box_can_bitrate.Name = "combo_box_can_bitrate";
            this.combo_box_can_bitrate.Size = new System.Drawing.Size(99, 24);
            this.combo_box_can_bitrate.TabIndex = 17;
            // 
            // group_box_com_ports
            // 
            this.group_box_com_ports.Controls.Add(this.button_com_close);
            this.group_box_com_ports.Controls.Add(this.label_baud_rate);
            this.group_box_com_ports.Controls.Add(this.button_com_open);
            this.group_box_com_ports.Controls.Add(this.combo_box_com_ports);
            this.group_box_com_ports.Controls.Add(this.button_add_new_tab);
            this.group_box_com_ports.Controls.Add(this.combo_box_com_baud_rate);
            this.group_box_com_ports.Location = new System.Drawing.Point(10, 10);
            this.group_box_com_ports.Name = "group_box_com_ports";
            this.group_box_com_ports.Size = new System.Drawing.Size(225, 142);
            this.group_box_com_ports.TabIndex = 18;
            this.group_box_com_ports.TabStop = false;
            this.group_box_com_ports.Text = "COM Ports Settings";
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
            // label_baud_rate
            // 
            this.label_baud_rate.AutoSize = true;
            this.label_baud_rate.Location = new System.Drawing.Point(111, 54);
            this.label_baud_rate.Name = "label_baud_rate";
            this.label_baud_rate.Size = new System.Drawing.Size(70, 17);
            this.label_baud_rate.TabIndex = 17;
            this.label_baud_rate.Text = "Baud rate";
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
            // combo_box_com_ports
            // 
            this.combo_box_com_ports.DropDownWidth = 99;
            this.combo_box_com_ports.FormattingEnabled = true;
            this.combo_box_com_ports.Location = new System.Drawing.Point(111, 23);
            this.combo_box_com_ports.Name = "combo_box_com_ports";
            this.combo_box_com_ports.Size = new System.Drawing.Size(99, 24);
            this.combo_box_com_ports.TabIndex = 1;
            // 
            // button_add_new_tab
            // 
            this.button_add_new_tab.Location = new System.Drawing.Point(6, 21);
            this.button_add_new_tab.Name = "button_add_new_tab";
            this.button_add_new_tab.Size = new System.Drawing.Size(100, 28);
            this.button_add_new_tab.TabIndex = 0;
            this.button_add_new_tab.Text = "Add new port";
            this.button_add_new_tab.UseVisualStyleBackColor = true;
            this.button_add_new_tab.Click += new System.EventHandler(this.button_add_new_tab_click);
            // 
            // combo_box_com_baud_rate
            // 
            this.combo_box_com_baud_rate.FormattingEnabled = true;
            this.combo_box_com_baud_rate.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.combo_box_com_baud_rate.Location = new System.Drawing.Point(111, 73);
            this.combo_box_com_baud_rate.Name = "combo_box_com_baud_rate";
            this.combo_box_com_baud_rate.Size = new System.Drawing.Size(99, 24);
            this.combo_box_com_baud_rate.TabIndex = 15;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 653);
            this.Controls.Add(this.tab_control);
            this.Name = "Menu";
            this.Text = "CAN Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_form_closed);
            this.Load += new System.EventHandler(this.Menu_load);
            this.tab_control.ResumeLayout(false);
            this.tab_page_global.ResumeLayout(false);
            this.split_container.Panel1.ResumeLayout(false);
            this.split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split_container)).EndInit();
            this.split_container.ResumeLayout(false);
            this.group_box_can_transmit_frame.ResumeLayout(false);
            this.group_box_can_transmit_frame.PerformLayout();
            this.group_box_can_commands.ResumeLayout(false);
            this.group_box_can_commands.PerformLayout();
            this.group_box_com_ports.ResumeLayout(false);
            this.group_box_com_ports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tab_page_global;
        private System.Windows.Forms.SplitContainer split_container;
        private System.Windows.Forms.ComboBox combo_box_com_ports;
        private System.Windows.Forms.Button button_add_new_tab;
        private System.Windows.Forms.TextBox text_box_interval;
        private System.Windows.Forms.Button button_send_frame;
        public System.Windows.Forms.ComboBox combo_box_com_baud_rate;
        public System.Windows.Forms.ComboBox combo_box_can_bitrate;
        private BufferedListView list_view;
        private System.Windows.Forms.ColumnHeader column_header1;
        private System.Windows.Forms.ColumnHeader column_header2;
        private System.Windows.Forms.ColumnHeader column_header3;
        private System.Windows.Forms.GroupBox group_box_com_ports;
        private System.Windows.Forms.Button button_com_open;
        private System.Windows.Forms.Label label_baud_rate;
        private System.Windows.Forms.Button button_com_close;
        private System.Windows.Forms.GroupBox group_box_can_commands;
        private System.Windows.Forms.Button button_can_setup;
        private System.Windows.Forms.Label label_bitrate;
        private System.Windows.Forms.Button button_can_close;
        private System.Windows.Forms.Button button_can_open;
        private System.Windows.Forms.GroupBox group_box_can_transmit_frame;
        private System.Windows.Forms.Label label_interval;
    }
}


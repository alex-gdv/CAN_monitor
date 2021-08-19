namespace CAN_monitor_lib
{
    partial class CAN_monitor
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial_port = new System.IO.Ports.SerialPort(this.components);
            this.group_box_com_port = new System.Windows.Forms.GroupBox();
            this.button_com_close = new System.Windows.Forms.Button();
            this.button_com_open = new System.Windows.Forms.Button();
            this.label_com_baud_rate = new System.Windows.Forms.Label();
            this.combo_box_com_baud_rate = new System.Windows.Forms.ComboBox();
            this.group_box_can_commands = new System.Windows.Forms.GroupBox();
            this.button_auto_off = new System.Windows.Forms.Button();
            this.button_auto_on = new System.Windows.Forms.Button();
            this.button_time_stamp_off = new System.Windows.Forms.Button();
            this.button_time_stamp_on = new System.Windows.Forms.Button();
            this.button_poll_all = new System.Windows.Forms.Button();
            this.button_poll_one = new System.Windows.Forms.Button();
            this.button_serial_number = new System.Windows.Forms.Button();
            this.button_can_version = new System.Windows.Forms.Button();
            this.button_can_flags = new System.Windows.Forms.Button();
            this.button_can_close = new System.Windows.Forms.Button();
            this.button_can_open = new System.Windows.Forms.Button();
            this.button_can_setup = new System.Windows.Forms.Button();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.combo_box_can_bitrate = new System.Windows.Forms.ComboBox();
            this.group_box_can_transmit_frame = new System.Windows.Forms.GroupBox();
            this.label_data_bytes = new System.Windows.Forms.Label();
            this.label_dlc = new System.Windows.Forms.Label();
            this.label_can_id = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.text_box_id = new System.Windows.Forms.TextBox();
            this.button_send_frame = new System.Windows.Forms.Button();
            this.text_box_hex1 = new System.Windows.Forms.TextBox();
            this.check_box_rtr = new System.Windows.Forms.CheckBox();
            this.text_box_hex2 = new System.Windows.Forms.TextBox();
            this.check_box_ext = new System.Windows.Forms.CheckBox();
            this.numeric_up_down_dlc = new System.Windows.Forms.NumericUpDown();
            this.text_box_hex3 = new System.Windows.Forms.TextBox();
            this.text_box_hex8 = new System.Windows.Forms.TextBox();
            this.text_box_hex4 = new System.Windows.Forms.TextBox();
            this.text_box_hex7 = new System.Windows.Forms.TextBox();
            this.text_box_hex5 = new System.Windows.Forms.TextBox();
            this.text_box_hex6 = new System.Windows.Forms.TextBox();
            this.group_box_can_receive_frame = new System.Windows.Forms.GroupBox();
            this.richTextBox_receive = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_com_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_baud_rate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_msg_counter_received = new System.Windows.Forms.ToolStripStatusLabel();
            this.group_box_com_port.SuspendLayout();
            this.group_box_can_commands.SuspendLayout();
            this.group_box_can_transmit_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_dlc)).BeginInit();
            this.group_box_can_receive_frame.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_port
            // 
            this.serial_port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_port_data_received);
            // 
            // group_box_com_port
            // 
            this.group_box_com_port.Controls.Add(this.button_com_close);
            this.group_box_com_port.Controls.Add(this.button_com_open);
            this.group_box_com_port.Controls.Add(this.label_com_baud_rate);
            this.group_box_com_port.Controls.Add(this.combo_box_com_baud_rate);
            this.group_box_com_port.Location = new System.Drawing.Point(471, 15);
            this.group_box_com_port.Margin = new System.Windows.Forms.Padding(4);
            this.group_box_com_port.Name = "group_box_com_port";
            this.group_box_com_port.Padding = new System.Windows.Forms.Padding(4);
            this.group_box_com_port.Size = new System.Drawing.Size(231, 114);
            this.group_box_com_port.TabIndex = 1;
            this.group_box_com_port.TabStop = false;
            this.group_box_com_port.Text = "COM Port Settings";
            // 
            // button_com_close
            // 
            this.button_com_close.Enabled = false;
            this.button_com_close.Location = new System.Drawing.Point(123, 79);
            this.button_com_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_com_close.Name = "button_com_close";
            this.button_com_close.Size = new System.Drawing.Size(100, 28);
            this.button_com_close.TabIndex = 18;
            this.button_com_close.Text = "Close";
            this.button_com_close.UseVisualStyleBackColor = true;
            this.button_com_close.Click += new System.EventHandler(this.button_com_close_click);
            // 
            // button_com_open
            // 
            this.button_com_open.Location = new System.Drawing.Point(8, 79);
            this.button_com_open.Margin = new System.Windows.Forms.Padding(4);
            this.button_com_open.Name = "button_com_open";
            this.button_com_open.Size = new System.Drawing.Size(100, 28);
            this.button_com_open.TabIndex = 17;
            this.button_com_open.Text = "Open";
            this.button_com_open.UseVisualStyleBackColor = true;
            this.button_com_open.Click += new System.EventHandler(this.button_com_open_click);
            // 
            // label_com_baud_rate
            // 
            this.label_com_baud_rate.AutoSize = true;
            this.label_com_baud_rate.Location = new System.Drawing.Point(119, 26);
            this.label_com_baud_rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_com_baud_rate.Name = "label_com_baud_rate";
            this.label_com_baud_rate.Size = new System.Drawing.Size(70, 17);
            this.label_com_baud_rate.TabIndex = 16;
            this.label_com_baud_rate.Text = "Baud rate";
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
            this.combo_box_com_baud_rate.Location = new System.Drawing.Point(123, 46);
            this.combo_box_com_baud_rate.Margin = new System.Windows.Forms.Padding(4);
            this.combo_box_com_baud_rate.Name = "combo_box_com_baud_rate";
            this.combo_box_com_baud_rate.Size = new System.Drawing.Size(99, 24);
            this.combo_box_com_baud_rate.TabIndex = 14;
            this.combo_box_com_baud_rate.SelectedIndexChanged += new System.EventHandler(this.combo_box_com_baud_rate_selected_index_changed);
            // 
            // group_box_can_commands
            // 
            this.group_box_can_commands.Controls.Add(this.button_auto_off);
            this.group_box_can_commands.Controls.Add(this.button_auto_on);
            this.group_box_can_commands.Controls.Add(this.button_time_stamp_off);
            this.group_box_can_commands.Controls.Add(this.button_time_stamp_on);
            this.group_box_can_commands.Controls.Add(this.button_poll_all);
            this.group_box_can_commands.Controls.Add(this.button_poll_one);
            this.group_box_can_commands.Controls.Add(this.button_serial_number);
            this.group_box_can_commands.Controls.Add(this.button_can_version);
            this.group_box_can_commands.Controls.Add(this.button_can_flags);
            this.group_box_can_commands.Controls.Add(this.button_can_close);
            this.group_box_can_commands.Controls.Add(this.button_can_open);
            this.group_box_can_commands.Controls.Add(this.button_can_setup);
            this.group_box_can_commands.Controls.Add(this.label_bitrate);
            this.group_box_can_commands.Controls.Add(this.combo_box_can_bitrate);
            this.group_box_can_commands.Enabled = false;
            this.group_box_can_commands.Location = new System.Drawing.Point(471, 137);
            this.group_box_can_commands.Margin = new System.Windows.Forms.Padding(4);
            this.group_box_can_commands.Name = "group_box_can_commands";
            this.group_box_can_commands.Padding = new System.Windows.Forms.Padding(4);
            this.group_box_can_commands.Size = new System.Drawing.Size(231, 370);
            this.group_box_can_commands.TabIndex = 2;
            this.group_box_can_commands.TabStop = false;
            this.group_box_can_commands.Text = "CAN Commands";
            // 
            // button_auto_off
            // 
            this.button_auto_off.Location = new System.Drawing.Point(123, 329);
            this.button_auto_off.Margin = new System.Windows.Forms.Padding(4);
            this.button_auto_off.Name = "button_auto_off";
            this.button_auto_off.Size = new System.Drawing.Size(100, 28);
            this.button_auto_off.TabIndex = 29;
            this.button_auto_off.Text = "Auto Off";
            this.button_auto_off.UseVisualStyleBackColor = true;
            this.button_auto_off.Click += new System.EventHandler(this.button_auto_off_click);
            // 
            // button_auto_on
            // 
            this.button_auto_on.Location = new System.Drawing.Point(8, 329);
            this.button_auto_on.Margin = new System.Windows.Forms.Padding(4);
            this.button_auto_on.Name = "button_auto_on";
            this.button_auto_on.Size = new System.Drawing.Size(100, 28);
            this.button_auto_on.TabIndex = 28;
            this.button_auto_on.Text = "Auto On";
            this.button_auto_on.UseVisualStyleBackColor = true;
            this.button_auto_on.Click += new System.EventHandler(this.button_auto_on_click);
            // 
            // button_time_stamp_off
            // 
            this.button_time_stamp_off.Location = new System.Drawing.Point(123, 274);
            this.button_time_stamp_off.Margin = new System.Windows.Forms.Padding(4);
            this.button_time_stamp_off.Name = "button_time_stamp_off";
            this.button_time_stamp_off.Size = new System.Drawing.Size(100, 28);
            this.button_time_stamp_off.TabIndex = 27;
            this.button_time_stamp_off.Text = "Time Off";
            this.button_time_stamp_off.UseVisualStyleBackColor = true;
            this.button_time_stamp_off.Click += new System.EventHandler(this.button_time_stamp_off_click);
            // 
            // button_time_stamp_on
            // 
            this.button_time_stamp_on.Location = new System.Drawing.Point(8, 274);
            this.button_time_stamp_on.Margin = new System.Windows.Forms.Padding(4);
            this.button_time_stamp_on.Name = "button_time_stamp_on";
            this.button_time_stamp_on.Size = new System.Drawing.Size(100, 28);
            this.button_time_stamp_on.TabIndex = 26;
            this.button_time_stamp_on.Text = "Time On";
            this.button_time_stamp_on.UseVisualStyleBackColor = true;
            this.button_time_stamp_on.Click += new System.EventHandler(this.button_time_stamp_on_click);
            // 
            // button_poll_all
            // 
            this.button_poll_all.Location = new System.Drawing.Point(123, 222);
            this.button_poll_all.Margin = new System.Windows.Forms.Padding(4);
            this.button_poll_all.Name = "button_poll_all";
            this.button_poll_all.Size = new System.Drawing.Size(100, 28);
            this.button_poll_all.TabIndex = 25;
            this.button_poll_all.Text = "Poll All";
            this.button_poll_all.UseVisualStyleBackColor = true;
            this.button_poll_all.Click += new System.EventHandler(this.button_poll_all_click);
            // 
            // button_poll_one
            // 
            this.button_poll_one.Location = new System.Drawing.Point(8, 222);
            this.button_poll_one.Margin = new System.Windows.Forms.Padding(4);
            this.button_poll_one.Name = "button_poll_one";
            this.button_poll_one.Size = new System.Drawing.Size(100, 28);
            this.button_poll_one.TabIndex = 24;
            this.button_poll_one.Text = "Poll One";
            this.button_poll_one.UseVisualStyleBackColor = true;
            this.button_poll_one.Click += new System.EventHandler(this.button_poll_one_click);
            // 
            // button_serial_number
            // 
            this.button_serial_number.Location = new System.Drawing.Point(8, 167);
            this.button_serial_number.Margin = new System.Windows.Forms.Padding(4);
            this.button_serial_number.Name = "button_serial_number";
            this.button_serial_number.Size = new System.Drawing.Size(100, 28);
            this.button_serial_number.TabIndex = 23;
            this.button_serial_number.Text = "S/No";
            this.button_serial_number.UseVisualStyleBackColor = true;
            this.button_serial_number.Click += new System.EventHandler(this.button_serial_number_click);
            // 
            // button_can_version
            // 
            this.button_can_version.Location = new System.Drawing.Point(8, 132);
            this.button_can_version.Margin = new System.Windows.Forms.Padding(4);
            this.button_can_version.Name = "button_can_version";
            this.button_can_version.Size = new System.Drawing.Size(100, 28);
            this.button_can_version.TabIndex = 22;
            this.button_can_version.Text = "Version";
            this.button_can_version.UseVisualStyleBackColor = true;
            this.button_can_version.Click += new System.EventHandler(this.button_can_version_click);
            // 
            // button_can_flags
            // 
            this.button_can_flags.Location = new System.Drawing.Point(123, 167);
            this.button_can_flags.Margin = new System.Windows.Forms.Padding(4);
            this.button_can_flags.Name = "button_can_flags";
            this.button_can_flags.Size = new System.Drawing.Size(100, 28);
            this.button_can_flags.TabIndex = 21;
            this.button_can_flags.Text = "Flags";
            this.button_can_flags.UseVisualStyleBackColor = true;
            this.button_can_flags.Click += new System.EventHandler(this.button_can_flags_click);
            // 
            // button_can_close
            // 
            this.button_can_close.Location = new System.Drawing.Point(123, 78);
            this.button_can_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_can_close.Name = "button_can_close";
            this.button_can_close.Size = new System.Drawing.Size(100, 28);
            this.button_can_close.TabIndex = 20;
            this.button_can_close.Text = "Close";
            this.button_can_close.UseVisualStyleBackColor = true;
            this.button_can_close.Click += new System.EventHandler(this.button_can_close_click);
            // 
            // button_can_open
            // 
            this.button_can_open.Location = new System.Drawing.Point(8, 78);
            this.button_can_open.Margin = new System.Windows.Forms.Padding(4);
            this.button_can_open.Name = "button_can_open";
            this.button_can_open.Size = new System.Drawing.Size(100, 28);
            this.button_can_open.TabIndex = 19;
            this.button_can_open.Text = "Open";
            this.button_can_open.UseVisualStyleBackColor = true;
            this.button_can_open.Click += new System.EventHandler(this.button_can_open_click);
            // 
            // button_can_setup
            // 
            this.button_can_setup.Location = new System.Drawing.Point(123, 42);
            this.button_can_setup.Margin = new System.Windows.Forms.Padding(4);
            this.button_can_setup.Name = "button_can_setup";
            this.button_can_setup.Size = new System.Drawing.Size(100, 28);
            this.button_can_setup.TabIndex = 18;
            this.button_can_setup.Text = "Setup";
            this.button_can_setup.UseVisualStyleBackColor = true;
            this.button_can_setup.Click += new System.EventHandler(this.button_can_setup_click);
            // 
            // label_bitrate
            // 
            this.label_bitrate.AutoSize = true;
            this.label_bitrate.Location = new System.Drawing.Point(4, 25);
            this.label_bitrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_bitrate.Name = "label_bitrate";
            this.label_bitrate.Size = new System.Drawing.Size(49, 17);
            this.label_bitrate.TabIndex = 17;
            this.label_bitrate.Text = "Bitrate";
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
            this.combo_box_can_bitrate.Location = new System.Drawing.Point(8, 44);
            this.combo_box_can_bitrate.Margin = new System.Windows.Forms.Padding(4);
            this.combo_box_can_bitrate.Name = "combo_box_can_bitrate";
            this.combo_box_can_bitrate.Size = new System.Drawing.Size(99, 24);
            this.combo_box_can_bitrate.TabIndex = 16;
            this.combo_box_can_bitrate.SelectedIndexChanged += new System.EventHandler(this.combo_box_can_bitrate_selected_index_changed);
            // 
            // group_box_can_transmit_frame
            // 
            this.group_box_can_transmit_frame.Controls.Add(this.label_data_bytes);
            this.group_box_can_transmit_frame.Controls.Add(this.label_dlc);
            this.group_box_can_transmit_frame.Controls.Add(this.label_can_id);
            this.group_box_can_transmit_frame.Controls.Add(this.label_result);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_id);
            this.group_box_can_transmit_frame.Controls.Add(this.button_send_frame);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex1);
            this.group_box_can_transmit_frame.Controls.Add(this.check_box_rtr);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex2);
            this.group_box_can_transmit_frame.Controls.Add(this.check_box_ext);
            this.group_box_can_transmit_frame.Controls.Add(this.numeric_up_down_dlc);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex3);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex8);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex4);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex7);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex5);
            this.group_box_can_transmit_frame.Controls.Add(this.text_box_hex6);
            this.group_box_can_transmit_frame.Enabled = false;
            this.group_box_can_transmit_frame.Location = new System.Drawing.Point(16, 334);
            this.group_box_can_transmit_frame.Margin = new System.Windows.Forms.Padding(4);
            this.group_box_can_transmit_frame.Name = "group_box_can_transmit_frame";
            this.group_box_can_transmit_frame.Padding = new System.Windows.Forms.Padding(4);
            this.group_box_can_transmit_frame.Size = new System.Drawing.Size(447, 174);
            this.group_box_can_transmit_frame.TabIndex = 14;
            this.group_box_can_transmit_frame.TabStop = false;
            this.group_box_can_transmit_frame.Text = "CAN Transmit Frame (HEX)";
            // 
            // label_data_bytes
            // 
            this.label_data_bytes.AutoSize = true;
            this.label_data_bytes.Location = new System.Drawing.Point(141, 31);
            this.label_data_bytes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_data_bytes.Name = "label_data_bytes";
            this.label_data_bytes.Size = new System.Drawing.Size(111, 17);
            this.label_data_bytes.TabIndex = 16;
            this.label_data_bytes.Text = "Databytes (1-8):";
            // 
            // label_dlc
            // 
            this.label_dlc.AutoSize = true;
            this.label_dlc.Location = new System.Drawing.Point(92, 31);
            this.label_dlc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dlc.Name = "label_dlc";
            this.label_dlc.Size = new System.Drawing.Size(39, 17);
            this.label_dlc.TabIndex = 15;
            this.label_dlc.Text = "DLC:";
            // 
            // label_can_id
            // 
            this.label_can_id.AutoSize = true;
            this.label_can_id.Location = new System.Drawing.Point(8, 31);
            this.label_can_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_can_id.Name = "label_can_id";
            this.label_can_id.Size = new System.Drawing.Size(57, 17);
            this.label_can_id.TabIndex = 14;
            this.label_can_id.Text = "CAN ID:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(8, 148);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(331, 17);
            this.label_result.TabIndex = 13;
            this.label_result.Text = "Resulting command: t10080000000000000000[CR]";
            // 
            // text_box_id
            // 
            this.text_box_id.Location = new System.Drawing.Point(8, 50);
            this.text_box_id.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_id.Name = "text_box_id";
            this.text_box_id.Size = new System.Drawing.Size(79, 22);
            this.text_box_id.TabIndex = 0;
            this.text_box_id.Text = "100";
            this.text_box_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_id_key_press);
            this.text_box_id.Leave += new System.EventHandler(this.text_box_id_leave);
            // 
            // button_send_frame
            // 
            this.button_send_frame.Location = new System.Drawing.Point(335, 103);
            this.button_send_frame.Margin = new System.Windows.Forms.Padding(4);
            this.button_send_frame.Name = "button_send_frame";
            this.button_send_frame.Size = new System.Drawing.Size(100, 28);
            this.button_send_frame.TabIndex = 12;
            this.button_send_frame.Text = "Send Frame";
            this.button_send_frame.UseVisualStyleBackColor = true;
            this.button_send_frame.Click += new System.EventHandler(this.button_send_frame_click);
            // 
            // text_box_hex1
            // 
            this.text_box_hex1.Location = new System.Drawing.Point(144, 50);
            this.text_box_hex1.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex1.Name = "text_box_hex1";
            this.text_box_hex1.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex1.TabIndex = 2;
            this.text_box_hex1.Text = "00";
            this.text_box_hex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex1_key_press);
            this.text_box_hex1.Leave += new System.EventHandler(this.text_box_hex1_leave);
            // 
            // check_box_rtr
            // 
            this.check_box_rtr.AutoSize = true;
            this.check_box_rtr.Location = new System.Drawing.Point(8, 111);
            this.check_box_rtr.Margin = new System.Windows.Forms.Padding(4);
            this.check_box_rtr.Name = "check_box_rtr";
            this.check_box_rtr.Size = new System.Drawing.Size(103, 21);
            this.check_box_rtr.TabIndex = 11;
            this.check_box_rtr.Text = "RTR Frame";
            this.check_box_rtr.UseVisualStyleBackColor = true;
            this.check_box_rtr.CheckedChanged += new System.EventHandler(this.check_box_rtr_checked_changed);
            // 
            // text_box_hex2
            // 
            this.text_box_hex2.Location = new System.Drawing.Point(181, 50);
            this.text_box_hex2.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex2.Name = "text_box_hex2";
            this.text_box_hex2.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex2.TabIndex = 3;
            this.text_box_hex2.Text = "00";
            this.text_box_hex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex2_key_press);
            this.text_box_hex2.Leave += new System.EventHandler(this.text_box_hex2_leave);
            // 
            // check_box_ext
            // 
            this.check_box_ext.AutoSize = true;
            this.check_box_ext.Location = new System.Drawing.Point(8, 82);
            this.check_box_ext.Margin = new System.Windows.Forms.Padding(4);
            this.check_box_ext.Name = "check_box_ext";
            this.check_box_ext.Size = new System.Drawing.Size(155, 21);
            this.check_box_ext.TabIndex = 10;
            this.check_box_ext.Text = "Extended ID (29 bit)";
            this.check_box_ext.UseVisualStyleBackColor = true;
            this.check_box_ext.CheckedChanged += new System.EventHandler(this.check_box_ext_checked_changed);
            // 
            // numeric_up_down_dlc
            // 
            this.numeric_up_down_dlc.Location = new System.Drawing.Point(96, 52);
            this.numeric_up_down_dlc.Margin = new System.Windows.Forms.Padding(4);
            this.numeric_up_down_dlc.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeric_up_down_dlc.Name = "numeric_up_down_dlc";
            this.numeric_up_down_dlc.ReadOnly = true;
            this.numeric_up_down_dlc.Size = new System.Drawing.Size(40, 22);
            this.numeric_up_down_dlc.TabIndex = 1;
            this.numeric_up_down_dlc.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeric_up_down_dlc.ValueChanged += new System.EventHandler(this.numeric_up_down_dlc_value_changed);
            // 
            // text_box_hex3
            // 
            this.text_box_hex3.Location = new System.Drawing.Point(219, 50);
            this.text_box_hex3.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex3.Name = "text_box_hex3";
            this.text_box_hex3.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex3.TabIndex = 4;
            this.text_box_hex3.Text = "00";
            this.text_box_hex3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex3_key_press);
            this.text_box_hex3.Leave += new System.EventHandler(this.text_box_hex3_leave);
            // 
            // text_box_hex8
            // 
            this.text_box_hex8.Location = new System.Drawing.Point(405, 50);
            this.text_box_hex8.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex8.Name = "text_box_hex8";
            this.text_box_hex8.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex8.TabIndex = 9;
            this.text_box_hex8.Text = "00";
            this.text_box_hex8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex8_key_press);
            this.text_box_hex8.Leave += new System.EventHandler(this.text_box_hex8_leave);
            // 
            // text_box_hex4
            // 
            this.text_box_hex4.Location = new System.Drawing.Point(256, 50);
            this.text_box_hex4.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex4.Name = "text_box_hex4";
            this.text_box_hex4.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex4.TabIndex = 5;
            this.text_box_hex4.Text = "00";
            this.text_box_hex4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex4_key_press);
            this.text_box_hex4.Leave += new System.EventHandler(this.text_box_hex4_leave);
            // 
            // text_box_hex7
            // 
            this.text_box_hex7.Location = new System.Drawing.Point(368, 50);
            this.text_box_hex7.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex7.Name = "text_box_hex7";
            this.text_box_hex7.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex7.TabIndex = 8;
            this.text_box_hex7.Text = "00";
            this.text_box_hex7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex7_key_press);
            this.text_box_hex7.Leave += new System.EventHandler(this.text_box_hex7_leave);
            // 
            // text_box_hex5
            // 
            this.text_box_hex5.Location = new System.Drawing.Point(293, 50);
            this.text_box_hex5.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex5.Name = "text_box_hex5";
            this.text_box_hex5.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex5.TabIndex = 6;
            this.text_box_hex5.Text = "00";
            this.text_box_hex5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex5_key_press);
            this.text_box_hex5.Leave += new System.EventHandler(this.text_box_hex5_leave);
            // 
            // text_box_hex6
            // 
            this.text_box_hex6.Location = new System.Drawing.Point(331, 50);
            this.text_box_hex6.Margin = new System.Windows.Forms.Padding(4);
            this.text_box_hex6.Name = "text_box_hex6";
            this.text_box_hex6.Size = new System.Drawing.Size(28, 22);
            this.text_box_hex6.TabIndex = 7;
            this.text_box_hex6.Text = "00";
            this.text_box_hex6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_box_hex6_key_press);
            this.text_box_hex6.Leave += new System.EventHandler(this.text_box_hex6_leave);
            // 
            // group_box_can_receive_frame
            // 
            this.group_box_can_receive_frame.Controls.Add(this.richTextBox_receive);
            this.group_box_can_receive_frame.Location = new System.Drawing.Point(16, 15);
            this.group_box_can_receive_frame.Margin = new System.Windows.Forms.Padding(4);
            this.group_box_can_receive_frame.Name = "group_box_can_receive_frame";
            this.group_box_can_receive_frame.Padding = new System.Windows.Forms.Padding(4);
            this.group_box_can_receive_frame.Size = new System.Drawing.Size(447, 311);
            this.group_box_can_receive_frame.TabIndex = 15;
            this.group_box_can_receive_frame.TabStop = false;
            this.group_box_can_receive_frame.Text = "Port Status";
            // 
            // richTextBox_receive
            // 
            this.richTextBox_receive.Location = new System.Drawing.Point(8, 23);
            this.richTextBox_receive.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_receive.Name = "richTextBox_receive";
            this.richTextBox_receive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_receive.Size = new System.Drawing.Size(425, 277);
            this.richTextBox_receive.TabIndex = 1;
            this.richTextBox_receive.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_com_port,
            this.toolStripStatusLabel_baud_rate,
            this.toolStripStatusLabel_msg_counter_received});
            this.statusStrip.Location = new System.Drawing.Point(0, 528);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(719, 26);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel_com_port
            // 
            this.toolStripStatusLabel_com_port.AutoSize = false;
            this.toolStripStatusLabel_com_port.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_com_port.Name = "toolStripStatusLabel_com_port";
            this.toolStripStatusLabel_com_port.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel_com_port.Text = "Closed";
            this.toolStripStatusLabel_com_port.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_baud_rate
            // 
            this.toolStripStatusLabel_baud_rate.AutoSize = false;
            this.toolStripStatusLabel_baud_rate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_baud_rate.Name = "toolStripStatusLabel_baud_rate";
            this.toolStripStatusLabel_baud_rate.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel_baud_rate.Text = "-";
            this.toolStripStatusLabel_baud_rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel_msg_counter_received
            // 
            this.toolStripStatusLabel_msg_counter_received.Name = "toolStripStatusLabel_msg_counter_received";
            this.toolStripStatusLabel_msg_counter_received.Size = new System.Drawing.Size(123, 20);
            this.toolStripStatusLabel_msg_counter_received.Text = "Message Counter";
            // 
            // CAN_monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.group_box_can_receive_frame);
            this.Controls.Add(this.group_box_can_transmit_frame);
            this.Controls.Add(this.group_box_can_commands);
            this.Controls.Add(this.group_box_com_port);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CAN_monitor";
            this.Size = new System.Drawing.Size(719, 554);
            this.group_box_com_port.ResumeLayout(false);
            this.group_box_com_port.PerformLayout();
            this.group_box_can_commands.ResumeLayout(false);
            this.group_box_can_commands.PerformLayout();
            this.group_box_can_transmit_frame.ResumeLayout(false);
            this.group_box_can_transmit_frame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_up_down_dlc)).EndInit();
            this.group_box_can_receive_frame.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serial_port;
        private System.Windows.Forms.GroupBox group_box_com_port;
        private System.Windows.Forms.Button button_com_close;
        private System.Windows.Forms.Button button_com_open;
        private System.Windows.Forms.Label label_com_baud_rate;
        private System.Windows.Forms.ComboBox combo_box_com_baud_rate;
        private System.Windows.Forms.GroupBox group_box_can_commands;
        private System.Windows.Forms.Button button_can_close;
        private System.Windows.Forms.Button button_can_open;
        private System.Windows.Forms.Button button_can_setup;
        private System.Windows.Forms.Label label_bitrate;
        private System.Windows.Forms.ComboBox combo_box_can_bitrate;
        private System.Windows.Forms.GroupBox group_box_can_transmit_frame;
        private System.Windows.Forms.TextBox text_box_id;
        private System.Windows.Forms.Button button_send_frame;
        private System.Windows.Forms.TextBox text_box_hex1;
        private System.Windows.Forms.CheckBox check_box_rtr;
        private System.Windows.Forms.TextBox text_box_hex2;
        private System.Windows.Forms.CheckBox check_box_ext;
        private System.Windows.Forms.NumericUpDown numeric_up_down_dlc;
        private System.Windows.Forms.TextBox text_box_hex3;
        private System.Windows.Forms.TextBox text_box_hex8;
        private System.Windows.Forms.TextBox text_box_hex4;
        private System.Windows.Forms.TextBox text_box_hex7;
        private System.Windows.Forms.TextBox text_box_hex5;
        private System.Windows.Forms.TextBox text_box_hex6;
        private System.Windows.Forms.GroupBox group_box_can_receive_frame;
        private System.Windows.Forms.RichTextBox richTextBox_receive;
        private System.Windows.Forms.Button button_can_flags;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_com_port;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_baud_rate;
        private System.Windows.Forms.Button button_serial_number;
        private System.Windows.Forms.Button button_can_version;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_data_bytes;
        private System.Windows.Forms.Label label_dlc;
        private System.Windows.Forms.Label label_can_id;
        private System.Windows.Forms.Button button_time_stamp_off;
        private System.Windows.Forms.Button button_time_stamp_on;
        private System.Windows.Forms.Button button_poll_all;
        private System.Windows.Forms.Button button_poll_one;
        private System.Windows.Forms.Button button_auto_off;
        private System.Windows.Forms.Button button_auto_on;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_msg_counter_received;
    }
}

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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_com_port = new System.Windows.Forms.GroupBox();
            this.button_com_close = new System.Windows.Forms.Button();
            this.button_com_open = new System.Windows.Forms.Button();
            this.label_com_baud_rate = new System.Windows.Forms.Label();
            this.comboBox_com_baud_rate = new System.Windows.Forms.ComboBox();
            this.groupBox_can_commands = new System.Windows.Forms.GroupBox();
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
            this.button_setup = new System.Windows.Forms.Button();
            this.label_bitrate = new System.Windows.Forms.Label();
            this.comboBox_can_bitrate = new System.Windows.Forms.ComboBox();
            this.groupBox_can_frame_transmit = new System.Windows.Forms.GroupBox();
            this.label_data_bytes = new System.Windows.Forms.Label();
            this.label_dlc = new System.Windows.Forms.Label();
            this.label_can_id = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_send_frame = new System.Windows.Forms.Button();
            this.textBox_hex1 = new System.Windows.Forms.TextBox();
            this.checkBox_rtr = new System.Windows.Forms.CheckBox();
            this.textBox_hex2 = new System.Windows.Forms.TextBox();
            this.checkBox_ext = new System.Windows.Forms.CheckBox();
            this.numericUpDown_dlc = new System.Windows.Forms.NumericUpDown();
            this.textBox_hex3 = new System.Windows.Forms.TextBox();
            this.textBox_hex8 = new System.Windows.Forms.TextBox();
            this.textBox_hex4 = new System.Windows.Forms.TextBox();
            this.textBox_hex7 = new System.Windows.Forms.TextBox();
            this.textBox_hex5 = new System.Windows.Forms.TextBox();
            this.textBox_hex6 = new System.Windows.Forms.TextBox();
            this.groupBox_can_frame_receive = new System.Windows.Forms.GroupBox();
            this.richTextBox_receive = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_com_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_baud_rate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_msg_counter_received = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_com_port.SuspendLayout();
            this.groupBox_can_commands.SuspendLayout();
            this.groupBox_can_frame_transmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlc)).BeginInit();
            this.groupBox_can_frame_receive.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBox_com_port
            // 
            this.groupBox_com_port.Controls.Add(this.button_com_close);
            this.groupBox_com_port.Controls.Add(this.button_com_open);
            this.groupBox_com_port.Controls.Add(this.label_com_baud_rate);
            this.groupBox_com_port.Controls.Add(this.comboBox_com_baud_rate);
            this.groupBox_com_port.Location = new System.Drawing.Point(471, 15);
            this.groupBox_com_port.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_com_port.Name = "groupBox_com_port";
            this.groupBox_com_port.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_com_port.Size = new System.Drawing.Size(231, 114);
            this.groupBox_com_port.TabIndex = 1;
            this.groupBox_com_port.TabStop = false;
            this.groupBox_com_port.Text = "COM Port Settings";
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
            this.button_com_close.Click += new System.EventHandler(this.button_com_close_Click);
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
            this.button_com_open.Click += new System.EventHandler(this.button_com_open_Click);
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
            this.comboBox_com_baud_rate.Location = new System.Drawing.Point(123, 46);
            this.comboBox_com_baud_rate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_com_baud_rate.Name = "comboBox_com_baud_rate";
            this.comboBox_com_baud_rate.Size = new System.Drawing.Size(99, 24);
            this.comboBox_com_baud_rate.TabIndex = 14;
            // 
            // groupBox_can_commands
            // 
            this.groupBox_can_commands.Controls.Add(this.button_auto_off);
            this.groupBox_can_commands.Controls.Add(this.button_auto_on);
            this.groupBox_can_commands.Controls.Add(this.button_time_stamp_off);
            this.groupBox_can_commands.Controls.Add(this.button_time_stamp_on);
            this.groupBox_can_commands.Controls.Add(this.button_poll_all);
            this.groupBox_can_commands.Controls.Add(this.button_poll_one);
            this.groupBox_can_commands.Controls.Add(this.button_serial_number);
            this.groupBox_can_commands.Controls.Add(this.button_can_version);
            this.groupBox_can_commands.Controls.Add(this.button_can_flags);
            this.groupBox_can_commands.Controls.Add(this.button_can_close);
            this.groupBox_can_commands.Controls.Add(this.button_can_open);
            this.groupBox_can_commands.Controls.Add(this.button_setup);
            this.groupBox_can_commands.Controls.Add(this.label_bitrate);
            this.groupBox_can_commands.Controls.Add(this.comboBox_can_bitrate);
            this.groupBox_can_commands.Enabled = false;
            this.groupBox_can_commands.Location = new System.Drawing.Point(471, 137);
            this.groupBox_can_commands.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_can_commands.Name = "groupBox_can_commands";
            this.groupBox_can_commands.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_can_commands.Size = new System.Drawing.Size(231, 370);
            this.groupBox_can_commands.TabIndex = 2;
            this.groupBox_can_commands.TabStop = false;
            this.groupBox_can_commands.Text = "CAN Commands";
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
            this.button_auto_off.Click += new System.EventHandler(this.button_auto_off_Click);
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
            this.button_auto_on.Click += new System.EventHandler(this.button_auto_on_Click);
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
            this.button_time_stamp_off.Click += new System.EventHandler(this.button_time_stamp_off_Click);
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
            this.button_time_stamp_on.Click += new System.EventHandler(this.button_time_stamp_on_Click);
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
            this.button_poll_all.Click += new System.EventHandler(this.button_poll_all_Click);
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
            this.button_poll_one.Click += new System.EventHandler(this.button_poll_one_Click);
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
            this.button_serial_number.Click += new System.EventHandler(this.button_serial_number_Click);
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
            this.button_can_version.Click += new System.EventHandler(this.button_can_version_Click);
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
            this.button_can_flags.Click += new System.EventHandler(this.button_can_flags_Click);
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
            this.button_can_close.Click += new System.EventHandler(this.button_can_close_Click);
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
            this.button_can_open.Click += new System.EventHandler(this.button_can_open_Click);
            // 
            // button_setup
            // 
            this.button_setup.Location = new System.Drawing.Point(123, 42);
            this.button_setup.Margin = new System.Windows.Forms.Padding(4);
            this.button_setup.Name = "button_setup";
            this.button_setup.Size = new System.Drawing.Size(100, 28);
            this.button_setup.TabIndex = 18;
            this.button_setup.Text = "Setup";
            this.button_setup.UseVisualStyleBackColor = true;
            this.button_setup.Click += new System.EventHandler(this.button_setup_Click);
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
            this.comboBox_can_bitrate.Location = new System.Drawing.Point(8, 44);
            this.comboBox_can_bitrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_can_bitrate.Name = "comboBox_can_bitrate";
            this.comboBox_can_bitrate.Size = new System.Drawing.Size(99, 24);
            this.comboBox_can_bitrate.TabIndex = 16;
            // 
            // groupBox_can_frame_transmit
            // 
            this.groupBox_can_frame_transmit.Controls.Add(this.label_data_bytes);
            this.groupBox_can_frame_transmit.Controls.Add(this.label_dlc);
            this.groupBox_can_frame_transmit.Controls.Add(this.label_can_id);
            this.groupBox_can_frame_transmit.Controls.Add(this.label_result);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_id);
            this.groupBox_can_frame_transmit.Controls.Add(this.button_send_frame);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex1);
            this.groupBox_can_frame_transmit.Controls.Add(this.checkBox_rtr);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex2);
            this.groupBox_can_frame_transmit.Controls.Add(this.checkBox_ext);
            this.groupBox_can_frame_transmit.Controls.Add(this.numericUpDown_dlc);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex3);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex8);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex4);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex7);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex5);
            this.groupBox_can_frame_transmit.Controls.Add(this.textBox_hex6);
            this.groupBox_can_frame_transmit.Enabled = false;
            this.groupBox_can_frame_transmit.Location = new System.Drawing.Point(16, 334);
            this.groupBox_can_frame_transmit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_can_frame_transmit.Name = "groupBox_can_frame_transmit";
            this.groupBox_can_frame_transmit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_can_frame_transmit.Size = new System.Drawing.Size(447, 174);
            this.groupBox_can_frame_transmit.TabIndex = 14;
            this.groupBox_can_frame_transmit.TabStop = false;
            this.groupBox_can_frame_transmit.Text = "CAN Transmit Frame (HEX)";
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
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(8, 50);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(79, 22);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Text = "100";
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            this.textBox_id.Leave += new System.EventHandler(this.textBox_id_Leave);
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
            this.button_send_frame.Click += new System.EventHandler(this.button_send_frame_Click);
            // 
            // textBox_hex1
            // 
            this.textBox_hex1.Location = new System.Drawing.Point(144, 50);
            this.textBox_hex1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex1.Name = "textBox_hex1";
            this.textBox_hex1.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex1.TabIndex = 2;
            this.textBox_hex1.Text = "00";
            this.textBox_hex1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex1_KeyPress);
            this.textBox_hex1.Leave += new System.EventHandler(this.textBox_hex1_Leave);
            // 
            // checkBox_rtr
            // 
            this.checkBox_rtr.AutoSize = true;
            this.checkBox_rtr.Location = new System.Drawing.Point(8, 111);
            this.checkBox_rtr.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_rtr.Name = "checkBox_rtr";
            this.checkBox_rtr.Size = new System.Drawing.Size(103, 21);
            this.checkBox_rtr.TabIndex = 11;
            this.checkBox_rtr.Text = "RTR Frame";
            this.checkBox_rtr.UseVisualStyleBackColor = true;
            this.checkBox_rtr.CheckedChanged += new System.EventHandler(this.checkBox_rtr_CheckedChanged);
            // 
            // textBox_hex2
            // 
            this.textBox_hex2.Location = new System.Drawing.Point(181, 50);
            this.textBox_hex2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex2.Name = "textBox_hex2";
            this.textBox_hex2.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex2.TabIndex = 3;
            this.textBox_hex2.Text = "00";
            this.textBox_hex2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex2_KeyPress);
            this.textBox_hex2.Leave += new System.EventHandler(this.textBox_hex2_Leave);
            // 
            // checkBox_ext
            // 
            this.checkBox_ext.AutoSize = true;
            this.checkBox_ext.Location = new System.Drawing.Point(8, 82);
            this.checkBox_ext.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ext.Name = "checkBox_ext";
            this.checkBox_ext.Size = new System.Drawing.Size(155, 21);
            this.checkBox_ext.TabIndex = 10;
            this.checkBox_ext.Text = "Extended ID (29 bit)";
            this.checkBox_ext.UseVisualStyleBackColor = true;
            this.checkBox_ext.CheckedChanged += new System.EventHandler(this.checkBox_ext_CheckedChanged);
            // 
            // numericUpDown_dlc
            // 
            this.numericUpDown_dlc.Location = new System.Drawing.Point(96, 52);
            this.numericUpDown_dlc.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_dlc.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_dlc.Name = "numericUpDown_dlc";
            this.numericUpDown_dlc.ReadOnly = true;
            this.numericUpDown_dlc.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown_dlc.TabIndex = 1;
            this.numericUpDown_dlc.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_dlc.ValueChanged += new System.EventHandler(this.numericUpDown_dlc_ValueChanged);
            // 
            // textBox_hex3
            // 
            this.textBox_hex3.Location = new System.Drawing.Point(219, 50);
            this.textBox_hex3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex3.Name = "textBox_hex3";
            this.textBox_hex3.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex3.TabIndex = 4;
            this.textBox_hex3.Text = "00";
            this.textBox_hex3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex3_KeyPress);
            this.textBox_hex3.Leave += new System.EventHandler(this.textBox_hex3_Leave);
            // 
            // textBox_hex8
            // 
            this.textBox_hex8.Location = new System.Drawing.Point(405, 50);
            this.textBox_hex8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex8.Name = "textBox_hex8";
            this.textBox_hex8.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex8.TabIndex = 9;
            this.textBox_hex8.Text = "00";
            this.textBox_hex8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex8_KeyPress);
            this.textBox_hex8.Leave += new System.EventHandler(this.textBox_hex8_Leave);
            // 
            // textBox_hex4
            // 
            this.textBox_hex4.Location = new System.Drawing.Point(256, 50);
            this.textBox_hex4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex4.Name = "textBox_hex4";
            this.textBox_hex4.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex4.TabIndex = 5;
            this.textBox_hex4.Text = "00";
            this.textBox_hex4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex4_KeyPress);
            this.textBox_hex4.Leave += new System.EventHandler(this.textBox_hex4_Leave);
            // 
            // textBox_hex7
            // 
            this.textBox_hex7.Location = new System.Drawing.Point(368, 50);
            this.textBox_hex7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex7.Name = "textBox_hex7";
            this.textBox_hex7.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex7.TabIndex = 8;
            this.textBox_hex7.Text = "00";
            this.textBox_hex7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex7_KeyPress);
            this.textBox_hex7.Leave += new System.EventHandler(this.textBox_hex7_Leave);
            // 
            // textBox_hex5
            // 
            this.textBox_hex5.Location = new System.Drawing.Point(293, 50);
            this.textBox_hex5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex5.Name = "textBox_hex5";
            this.textBox_hex5.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex5.TabIndex = 6;
            this.textBox_hex5.Text = "00";
            this.textBox_hex5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex5_KeyPress);
            this.textBox_hex5.Leave += new System.EventHandler(this.textBox_hex5_Leave);
            // 
            // textBox_hex6
            // 
            this.textBox_hex6.Location = new System.Drawing.Point(331, 50);
            this.textBox_hex6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hex6.Name = "textBox_hex6";
            this.textBox_hex6.Size = new System.Drawing.Size(28, 22);
            this.textBox_hex6.TabIndex = 7;
            this.textBox_hex6.Text = "00";
            this.textBox_hex6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_hex6_KeyPress);
            this.textBox_hex6.Leave += new System.EventHandler(this.textBox_hex6_Leave);
            // 
            // groupBox_can_frame_receive
            // 
            this.groupBox_can_frame_receive.Controls.Add(this.richTextBox_receive);
            this.groupBox_can_frame_receive.Location = new System.Drawing.Point(16, 15);
            this.groupBox_can_frame_receive.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_can_frame_receive.Name = "groupBox_can_frame_receive";
            this.groupBox_can_frame_receive.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_can_frame_receive.Size = new System.Drawing.Size(447, 311);
            this.groupBox_can_frame_receive.TabIndex = 15;
            this.groupBox_can_frame_receive.TabStop = false;
            this.groupBox_can_frame_receive.Text = "Port Status";
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
            this.Controls.Add(this.groupBox_can_frame_receive);
            this.Controls.Add(this.groupBox_can_frame_transmit);
            this.Controls.Add(this.groupBox_can_commands);
            this.Controls.Add(this.groupBox_com_port);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CAN_monitor";
            this.Size = new System.Drawing.Size(719, 554);
            this.Load += new System.EventHandler(this.CAN_Monitor_Load);
            this.groupBox_com_port.ResumeLayout(false);
            this.groupBox_com_port.PerformLayout();
            this.groupBox_can_commands.ResumeLayout(false);
            this.groupBox_can_commands.PerformLayout();
            this.groupBox_can_frame_transmit.ResumeLayout(false);
            this.groupBox_can_frame_transmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlc)).EndInit();
            this.groupBox_can_frame_receive.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.IO.Ports.SerialPort serialPort;
        protected System.Windows.Forms.GroupBox groupBox_com_port;
        protected System.Windows.Forms.Button button_com_close;
        protected System.Windows.Forms.Button button_com_open;
        protected System.Windows.Forms.Label label_com_baud_rate;
        public System.Windows.Forms.ComboBox comboBox_com_baud_rate;
        protected System.Windows.Forms.GroupBox groupBox_can_commands;
        protected System.Windows.Forms.Button button_can_close;
        protected System.Windows.Forms.Button button_can_open;
        protected System.Windows.Forms.Button button_setup;
        protected System.Windows.Forms.Label label_bitrate;
        public System.Windows.Forms.ComboBox comboBox_can_bitrate;
        protected System.Windows.Forms.GroupBox groupBox_can_frame_transmit;
        public System.Windows.Forms.TextBox textBox_id;
        protected System.Windows.Forms.Button button_send_frame;
        public System.Windows.Forms.TextBox textBox_hex1;
        public System.Windows.Forms.CheckBox checkBox_rtr;
        public System.Windows.Forms.TextBox textBox_hex2;
        public System.Windows.Forms.CheckBox checkBox_ext;
        public System.Windows.Forms.NumericUpDown numericUpDown_dlc;
        public System.Windows.Forms.TextBox textBox_hex3;
        public System.Windows.Forms.TextBox textBox_hex8;
        public System.Windows.Forms.TextBox textBox_hex4;
        public System.Windows.Forms.TextBox textBox_hex7;
        public System.Windows.Forms.TextBox textBox_hex5;
        public System.Windows.Forms.TextBox textBox_hex6;
        protected System.Windows.Forms.GroupBox groupBox_can_frame_receive;
        protected System.Windows.Forms.RichTextBox richTextBox_receive;
        protected System.Windows.Forms.Button button_can_flags;
        protected System.Windows.Forms.StatusStrip statusStrip;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_com_port;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_baud_rate;
        protected System.Windows.Forms.Button button_serial_number;
        protected System.Windows.Forms.Button button_can_version;
        protected System.Windows.Forms.Label label_result;
        protected System.Windows.Forms.Label label_data_bytes;
        protected System.Windows.Forms.Label label_dlc;
        protected System.Windows.Forms.Label label_can_id;
        protected System.Windows.Forms.Button button_time_stamp_off;
        protected System.Windows.Forms.Button button_time_stamp_on;
        protected System.Windows.Forms.Button button_poll_all;
        protected System.Windows.Forms.Button button_poll_one;
        protected System.Windows.Forms.Button button_auto_off;
        protected System.Windows.Forms.Button button_auto_on;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_msg_counter_received;
    }
}

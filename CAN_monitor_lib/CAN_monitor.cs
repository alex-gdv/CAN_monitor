﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace CAN_monitor_lib
{
    public partial class CAN_monitor: UserControl
    {
        public static int WRITE_TIMEOUT = 100;
        private string port_name;
        private bool com_is_open;
        private string com_baud_rate;
        private bool can_is_open;
        private string can_bitrate;
        private string receive_buffer;
        private int msg_counter_received;

        public CAN_monitor(string port_name)
        {
            this.port_name = port_name;
            com_is_open = false;
            can_is_open = false;
            receive_buffer = "";
            msg_counter_received = 0;
            InitializeComponent();
            combo_box_com_baud_rate.SelectedIndex = 4;
            combo_box_can_bitrate.SelectedIndex = 5;
            com_baud_rate = combo_box_com_baud_rate.SelectedItem.ToString();
            can_bitrate = combo_box_can_bitrate.SelectedIndex.ToString();
            serial_port.WriteTimeout = WRITE_TIMEOUT;
        }

        public CAN_monitor(string port_name, bool com_is_open, string com_baud_rate, bool can_is_open, string can_bitrate, bool connected)
        {
            this.port_name = port_name;
            this.com_is_open = com_is_open;
            this.com_baud_rate = com_baud_rate;
            this.can_is_open = can_is_open;
            this.can_bitrate = can_bitrate;
            receive_buffer = "";
            msg_counter_received = 0;
            InitializeComponent();
            for (int i = 0; i < combo_box_com_baud_rate.Items.Count; i++)
            {
                if (combo_box_com_baud_rate.Items[i].ToString() == com_baud_rate)
                {
                    combo_box_com_baud_rate.SelectedIndex = i;
                }
            }
            combo_box_can_bitrate.SelectedIndex = Int32.Parse(can_bitrate);
            if (connected && com_is_open)
            {
                button_com_open_click(new object(), new EventArgs());
                if (can_is_open)
                {
                    button_can_setup_click(new object(), new EventArgs());
                    button_can_open_click(new object(), new EventArgs());
                }
            }
            serial_port.WriteTimeout = WRITE_TIMEOUT;
        }

        public void reconnected()
        {
            if (com_is_open)
            {
                button_com_open_click(new object(), new EventArgs());
                if (can_is_open)
                {
                    button_can_setup_click(new object(), new EventArgs());
                    button_can_open_click(new object(), new EventArgs());
                }
            }
        }

        public Tuple<string, bool, string, bool, string> get_attributes()
        {
            return new Tuple<string, bool, string, bool, string>(port_name, com_is_open, com_baud_rate,
                can_is_open, can_bitrate);
        }

        public Tuple<string, string, string> get_port_status()
        {
            string is_open = "Closed";
            if (com_is_open)
                is_open = "Open";
            return new Tuple<string, string, string>(port_name, is_open, msg_counter_received.ToString());
        }

        public string get_port_name()
        {
            return port_name;
        }

        public void set_baud_rate(string s)
        {
            com_baud_rate = s;
        }

        private void combo_box_com_baud_rate_selected_index_changed(object sender, EventArgs e)
        {
            com_baud_rate = combo_box_com_baud_rate.SelectedItem.ToString();
        }

        public void button_com_open_click(object sender, EventArgs e)
        {
            try
            {
                if (!serial_port.IsOpen)
                {
                    // Open port
                    serial_port.PortName = port_name;
                    serial_port.BaudRate = int.Parse(com_baud_rate);
                    serial_port.Open();
                    com_is_open = true;
                    // Update interface
                    combo_box_com_baud_rate.Enabled = false;
                    group_box_can_commands.Enabled = true;
                    group_box_can_transmit_frame.Enabled = true;
                    button_com_open.Enabled = false;
                    button_com_close.Enabled = true;
                    toolStripStatusLabel_com_port.Text = serial_port.PortName;
                    toolStripStatusLabel_baud_rate.Text = serial_port.BaudRate.ToString();
                    toolStripStatusLabel_msg_counter_received.Text = "0";
                }
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, 2000);
            }
        }

        public void button_com_close_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    // Close CAN bus connection, then close port
                    if (can_is_open)
                    {
                        button_can_close_click(sender, e);
                    }
                    serial_port.Close();
                    com_is_open = false;
                    // Update interface
                    toolStripStatusLabel_com_port.Text = "Closed";
                    toolStripStatusLabel_baud_rate.Text = "-";
                    group_box_can_commands.Enabled = false;
                    group_box_can_transmit_frame.Enabled = false;
                    button_com_close.Enabled = false;
                    button_com_open.Enabled = true;
                    combo_box_com_baud_rate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, 2000);
            }
        }

        public void button_can_open_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("O\r");
                    can_is_open = true;
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_can_close_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("C\r");
                    can_is_open = false;
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void set_can_bitrate(string s)
        {
            can_bitrate = s;
        }

        private void combo_box_can_bitrate_selected_index_changed(object sender, EventArgs e)
        {
            can_bitrate = combo_box_can_bitrate.SelectedIndex.ToString();
        }

        public void button_can_setup_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("S");
                    serial_port.Write(can_bitrate);
                    serial_port.Write("\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_can_version_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("V\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_can_flags_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("F\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_serial_number_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("N\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        private void increase_msg_counter_received()
        {
            msg_counter_received++;
            toolStripStatusLabel_msg_counter_received.Text = "Counter: " + msg_counter_received.ToString();
        }

        private void serial_port_data_received(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            receive_buffer = serial_port.ReadExisting();
            try
            {
                this.BeginInvoke(new EventHandler(display_text));
            }
            catch (InvalidOperationException)
            {
                System.Threading.Thread.Sleep(1000);
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, 2000);
            }
        }

        private void display_text(object s, EventArgs e)
        {
            int buff_len = receive_buffer.Length;
            int buff_pos = -1;
            int c = ' ';
            if (buff_len > 1)
            {
                // More than one character
                if ((buff_pos = receive_buffer.IndexOf("\r")) >= 0)
                {
                    richTextBox_receive.AppendText(receive_buffer.Substring(0, buff_pos));
                    richTextBox_receive.AppendText("[CR]");
                    richTextBox_receive.AppendText(receive_buffer.Substring(buff_pos, (buff_len - buff_pos)));
                    increase_msg_counter_received();
                }
                else
                {
                    richTextBox_receive.AppendText(receive_buffer);
                }
            }
            else if (buff_len == 1)
            {
                // Only one character
                c = receive_buffer[0];
                if (c == 13)
                {
                    richTextBox_receive.AppendText("[CR]");
                    richTextBox_receive.AppendText(receive_buffer);
                }
                else if (c == 7)
                {
                    richTextBox_receive.AppendText("[BELL]\n");
                }
            }
        }

        private void check_hex_value(object sender, KeyPressEventArgs e, int maxLen)
        {
            if ((sender as TextBox).TextLength < maxLen)
            {
                if (char.IsDigit(e.KeyChar) || (e.KeyChar >= 'a' && e.KeyChar <= 'f') ||
                    (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar == '\b'))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyChar == '\b')  // Backspace?
                {
                    e.Handled = false;
                }
                else if ((sender as TextBox).SelectionLength > 0)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void text_box_id_key_press(object sender, KeyPressEventArgs e)
        {
            if (check_box_ext.Checked == true)
            {
                check_hex_value(sender, e, 8);
            }
            else
            {
                check_hex_value(sender, e, 3);
            }
        }

        private void text_box_hex1_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex2_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex3_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex4_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex5_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex6_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex7_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_hex8_key_press(object sender, KeyPressEventArgs e)
        {
            check_hex_value(sender, e, 2);
        }

        private void text_box_id_leave(object sender, EventArgs e)
        {
            if (check_box_ext.Checked == true)
            {
                if (text_box_id.TextLength == 0)
                {
                    text_box_id.Text = "00000000";
                }
                else if (text_box_id.TextLength == 1)
                {
                    text_box_id.Text = "0000000" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 2)
                {
                    text_box_id.Text = "000000" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 3)
                {
                    text_box_id.Text = "00000" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 4)
                {
                    text_box_id.Text = "0000" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 5)
                {
                    text_box_id.Text = "000" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 6)
                {
                    text_box_id.Text = "00" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 7)
                {
                    text_box_id.Text = "0" + text_box_id.Text;
                }
            }
            else
            {
                if (text_box_id.TextLength == 0)
                {
                    text_box_id.Text = "000";
                }
                else if (text_box_id.TextLength == 1)
                {
                    text_box_id.Text = "00" + text_box_id.Text;
                }
                else if (text_box_id.TextLength == 2)
                {
                    text_box_id.Text = "0" + text_box_id.Text;
                }
            }
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex1_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex2_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex3_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex4_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex5_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex6_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex7_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void text_box_hex8_leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void update_data_boxes()
        {
            if (numeric_up_down_dlc.Value < 8)
            {
                text_box_hex8.Visible = false;
            }
            else
            {
                text_box_hex8.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 7)
            {
                text_box_hex7.Visible = false;
            }
            else
            {
                text_box_hex7.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 6)
            {
                text_box_hex6.Visible = false;
            }
            else
            {
                text_box_hex6.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 5)
            {
                text_box_hex5.Visible = false;
            }
            else
            {
                text_box_hex5.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 4)
            {
                text_box_hex4.Visible = false;
            }
            else
            {
                text_box_hex4.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 3)
            {
                text_box_hex3.Visible = false;
            }
            else
            {
                text_box_hex3.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 2)
            {
                text_box_hex2.Visible = false;
            }
            else
            {
                text_box_hex2.Visible = true;
            }

            if (numeric_up_down_dlc.Value < 1)
            {
                text_box_hex1.Visible = false;
            }
            else
            {
                text_box_hex1.Visible = true;
            }
        }

        private void numeric_up_down_dlc_value_changed(object sender, EventArgs e)
        {
            update_data_boxes();
        }

        private void check_box_ext_checked_changed(object sender, EventArgs e)
        {
            if (check_box_ext.Checked == true)
            {
                text_box_id.Text = "00000" + text_box_id.Text;
            }
            else
            {
                text_box_id.Text = text_box_id.Text.Substring(text_box_id.Text.Length - 3);
            }
        }

        private void check_box_rtr_checked_changed(object sender, EventArgs e)
        {
            if (check_box_rtr.Checked == true)
            {
                text_box_hex1.Visible = false;
                text_box_hex2.Visible = false;
                text_box_hex3.Visible = false;
                text_box_hex4.Visible = false;
                text_box_hex5.Visible = false;
                text_box_hex6.Visible = false;
                text_box_hex7.Visible = false;
                text_box_hex8.Visible = false;
            }
            else
            {
                update_data_boxes();
            }
        }

        public void send_frame(bool rtr, bool ext, string id, string dlc, string hex1, string hex2, 
            string hex3, string hex4, string hex5, string hex6, string hex7, string hex8)
        {
            string can_frame_data = "";

            if (rtr == true)        // RTR Frame
            {
                if (ext == true)    // 29bit Frame
                {
                    can_frame_data += "R";
                }
                else                            // 11bit frame
                {
                    can_frame_data += "r";
                }
                can_frame_data += id + dlc;
            }
            else                                // Normal Frame
            {
                if (ext == true)    // 29bit Frame
                {
                    can_frame_data += "T";
                }
                else                            // 11bit frame
                {
                    can_frame_data += "t";
                }
                can_frame_data += id + dlc;
                if (numeric_up_down_dlc.Value >= 1)
                {
                    can_frame_data += hex1;
                }
                if (numeric_up_down_dlc.Value >= 2)
                {
                    can_frame_data += hex2;
                }
                if (numeric_up_down_dlc.Value >= 3)
                {
                    can_frame_data += hex3;
                }
                if (numeric_up_down_dlc.Value >= 4)
                {
                    can_frame_data += hex4;
                }
                if (numeric_up_down_dlc.Value >= 5)
                {
                    can_frame_data += hex5;
                }
                if (numeric_up_down_dlc.Value >= 6)
                {
                    can_frame_data += hex6;
                }
                if (numeric_up_down_dlc.Value >= 7)
                {
                    can_frame_data += hex7;
                }
                if (numeric_up_down_dlc.Value >= 8)
                {
                    can_frame_data += hex8;
                }
            }
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write(can_frame_data);
                    serial_port.Write("\r");
                }
            }
            catch (TimeoutException ex)
            {
                button_com_close_click(new object(), new EventArgs());
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message + ". Closing the port now", 2000);
            }
            label_result.Text = "Resulting command: " + can_frame_data + "[CR]";
        }

        public void button_send_frame_click(object sender, EventArgs e)
        {
            if (serial_port.IsOpen)
                send_frame(check_box_rtr.Checked, check_box_ext.Checked, text_box_id.Text, 
                numeric_up_down_dlc.Value.ToString(), text_box_hex1.Text, text_box_hex2.Text,
                text_box_hex3.Text, text_box_hex4.Text, text_box_hex5.Text, text_box_hex6.Text,
                text_box_hex7.Text, text_box_hex8.Text);
        }

        public void button_time_stamp_on_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("Z1\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_time_stamp_off_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("Z0\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_auto_on_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("X1\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_auto_off_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("X0\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_poll_one_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("P\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }

        public void button_poll_all_click(object sender, EventArgs e)
        {
            try
            {
                if (serial_port.IsOpen)
                {
                    serial_port.Write("A\r");
                }
            }
            catch (TimeoutException ex)
            {
                AutoClosingMessageBox.Show(serial_port.PortName, ex.Message, serial_port.WriteTimeout);
            }
        }
    }

    // Source: https://stackoverflow.com/a/14522952/16445870
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string caption, string text, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CAN_monitor_lib
{
    public partial class CAN_monitor: UserControl
    {
        private string port_name;
        private bool com_is_open;
        private string com_baud_rate;
        private bool can_is_open;
        private string can_bitrate;
        private string receive_buffer;
        private int msg_counter_received;

        public CAN_monitor()
        {

        }

        public CAN_monitor(string port_name)
        {
            this.port_name = port_name;
            com_is_open = false;
            can_is_open = false;
            receive_buffer = "";
            msg_counter_received = 0;
            InitializeComponent();
            comboBox_com_baud_rate.SelectedIndex = 4;
            comboBox_can_bitrate.SelectedIndex = 5;
            com_baud_rate = comboBox_com_baud_rate.SelectedItem.ToString();
            can_bitrate = comboBox_can_bitrate.SelectedItem.ToString();
        }

        public CAN_monitor(string port_name, bool com_is_open, string com_baud_rate, bool can_is_open,
            string can_bitrate, bool connected)
        {
            this.port_name = port_name;
            this.com_is_open = com_is_open;
            this.com_baud_rate = com_baud_rate;
            this.can_is_open = can_is_open;
            this.can_bitrate = can_bitrate;
            receive_buffer = "";
            msg_counter_received = 0;
            InitializeComponent();
            for (int i = 0; i < comboBox_com_baud_rate.Items.Count; i++)
            {
                if (comboBox_com_baud_rate.Items[i].ToString() == com_baud_rate)
                {
                    comboBox_com_baud_rate.SelectedIndex = i;
                }
            }
            for (int i = 0; i < comboBox_can_bitrate.Items.Count; i++)
            {
                if (comboBox_can_bitrate.Items[i].ToString() == can_bitrate)
                {
                    comboBox_can_bitrate.SelectedIndex = i;
                }
            }
            if (connected && com_is_open)
            {
                button_com_open_click(new object(), new EventArgs());
                if (can_is_open)
                {
                    button_setup_click(new object(), new EventArgs());
                    button_can_open_click(new object(), new EventArgs());
                }
            }
        }

        private void CAN_Monitor_Load(object sender, EventArgs e)
        {

        }

        public void reconnected()
        {
            if (com_is_open)
            {
                button_com_open_click(new object(), new EventArgs());
                if (can_is_open)
                {
                    button_setup_click(new object(), new EventArgs());
                    button_can_open_click(new object(), new EventArgs());
                }
            }
        }

        public void disconnected()
        {
            button_can_close_click(new object(), new EventArgs());
            button_com_close_click(new object(), new EventArgs());
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

        private void comboBox_com_baud_rate_SelectedIndexChanged(object sender, EventArgs e)
        {
            com_baud_rate = comboBox_com_baud_rate.SelectedItem.ToString();
        }

        public void button_com_open_click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    com_is_open = true;
                    serialPort.PortName = port_name;
                    serialPort.BaudRate = int.Parse(com_baud_rate);
                    serialPort.Open();
                    // Update controls
                    comboBox_com_baud_rate.Enabled = false;
                    groupBox_can_commands.Enabled = true;
                    groupBox_can_transmit_frame.Enabled = true;
                    button_com_open.Enabled = false;
                    button_com_close.Enabled = true;
                    // Set status
                    toolStripStatusLabel_com_port.Text = serialPort.PortName;
                    toolStripStatusLabel_baud_rate.Text = serialPort.BaudRate.ToString();
                    toolStripStatusLabel_msg_counter_received.Text = "0";
                }
                else
                {
                    richTextBox_receive.Text = "Failed to open COM port";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckHexValue(object sender, KeyPressEventArgs e, int maxLen)
        {
            if ((sender as TextBox).TextLength < maxLen)
            {
                if (char.IsDigit(e.KeyChar) || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar == '\b'))
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

        private void UpdateDataBoxes()
        {
            if (numericUpDown_dlc.Value < 8)
            {
                textBox_hex8.Visible = false;
            }
            else
            {
                textBox_hex8.Visible = true;
            }

            if (numericUpDown_dlc.Value < 7)
            {
                textBox_hex7.Visible = false;
            }
            else
            {
                textBox_hex7.Visible = true;
            }

            if (numericUpDown_dlc.Value < 6)
            {
                textBox_hex6.Visible = false;
            }
            else
            {
                textBox_hex6.Visible = true;
            }

            if (numericUpDown_dlc.Value < 5)
            {
                textBox_hex5.Visible = false;
            }
            else
            {
                textBox_hex5.Visible = true;
            }

            if (numericUpDown_dlc.Value < 4)
            {
                textBox_hex4.Visible = false;
            }
            else
            {
                textBox_hex4.Visible = true;
            }

            if (numericUpDown_dlc.Value < 3)
            {
                textBox_hex3.Visible = false;
            }
            else
            {
                textBox_hex3.Visible = true;
            }

            if (numericUpDown_dlc.Value < 2)
            {
                textBox_hex2.Visible = false;
            }
            else
            {
                textBox_hex2.Visible = true;
            }

            if (numericUpDown_dlc.Value < 1)
            {
                textBox_hex1.Visible = false;
            }
            else
            {
                textBox_hex1.Visible = true;
            }
        }

        public virtual void button_com_close_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                com_is_open = false;
                serialPort.Close();
                toolStripStatusLabel_com_port.Text = "Closed";
                toolStripStatusLabel_baud_rate.Text = "-";
                groupBox_can_commands.Enabled = false;
                groupBox_can_transmit_frame.Enabled = false;
                button_com_close.Enabled = false;
                button_com_open.Enabled = true;
                comboBox_com_baud_rate.Enabled = true;
            }
        }

        public virtual void button_can_open_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                can_is_open = true;
                serialPort.Write("O\r");
            }
        }

        public virtual void button_can_close_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                can_is_open = false;
                serialPort.Write("C\r");
            }
        }

        public void set_can_bitrate(string s)
        {
            can_bitrate = s;
        }

        private void comboBox_can_bitrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            can_bitrate = comboBox_can_bitrate.SelectedItem.ToString();
        }

        public virtual void button_setup_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("S");
                serialPort.Write(can_bitrate);
                serialPort.Write("\r");
            }
        }

        public virtual void button_can_version_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("V\r");
            }
        }

        public virtual void button_can_flags_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("F\r");
            }
        }

        public virtual void button_serial_number_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("N\r");
            }
        }

        private void increase_msg_counter_received()
        {
            msg_counter_received++;
            toolStripStatusLabel_msg_counter_received.Text = "Counter: " + msg_counter_received.ToString();
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                receive_buffer = serialPort.ReadExisting();
                increase_msg_counter_received();
                this.Invoke(new EventHandler(DisplayText));
            }
            catch (System.TimeoutException ex)
            {
                MessageBox.Show(serialPort.PortName + ": " + ex.Message);
            }
        }

        private void DisplayText(object s, EventArgs e)
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

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox_ext.Checked == true)
            {
                CheckHexValue(sender, e, 8);
            }
            else
            {
                CheckHexValue(sender, e, 3);
            }
        }

        private void textBox_hex1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex4_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex5_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex6_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex7_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_hex8_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckHexValue(sender, e, 2);
        }

        private void textBox_id_Leave(object sender, EventArgs e)
        {
            if (checkBox_ext.Checked == true)
            {
                if (textBox_id.TextLength == 0)
                {
                    textBox_id.Text = "00000000";
                }
                else if (textBox_id.TextLength == 1)
                {
                    textBox_id.Text = "0000000" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 2)
                {
                    textBox_id.Text = "000000" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 3)
                {
                    textBox_id.Text = "00000" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 4)
                {
                    textBox_id.Text = "0000" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 5)
                {
                    textBox_id.Text = "000" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 6)
                {
                    textBox_id.Text = "00" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 7)
                {
                    textBox_id.Text = "0" + textBox_id.Text;
                }
            }
            else
            {
                if (textBox_id.TextLength == 0)
                {
                    textBox_id.Text = "000";
                }
                else if (textBox_id.TextLength == 1)
                {
                    textBox_id.Text = "00" + textBox_id.Text;
                }
                else if (textBox_id.TextLength == 2)
                {
                    textBox_id.Text = "0" + textBox_id.Text;
                }
            }
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex1_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex2_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex3_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex4_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex5_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex6_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex7_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void textBox_hex8_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = (sender as TextBox).Text.ToUpper();
        }

        private void numericUpDown_dlc_ValueChanged(object sender, EventArgs e)
        {
            UpdateDataBoxes();
        }

        private void checkBox_ext_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ext.Checked == true)
            {
                textBox_id.Text = "00000" + textBox_id.Text;
            }
            else
            {
                textBox_id.Text = textBox_id.Text.Substring(textBox_id.Text.Length - 3);
            }
        }

        private void checkBox_rtr_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rtr.Checked == true)
            {
                textBox_hex1.Visible = false;
                textBox_hex2.Visible = false;
                textBox_hex3.Visible = false;
                textBox_hex4.Visible = false;
                textBox_hex5.Visible = false;
                textBox_hex6.Visible = false;
                textBox_hex7.Visible = false;
                textBox_hex8.Visible = false;
            }
            else
            {
                UpdateDataBoxes();
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
                if (numericUpDown_dlc.Value >= 1)
                {
                    can_frame_data += hex1;
                }
                if (numericUpDown_dlc.Value >= 2)
                {
                    can_frame_data += hex2;
                }
                if (numericUpDown_dlc.Value >= 3)
                {
                    can_frame_data += hex3;
                }
                if (numericUpDown_dlc.Value >= 4)
                {
                    can_frame_data += hex4;
                }
                if (numericUpDown_dlc.Value >= 5)
                {
                    can_frame_data += hex5;
                }
                if (numericUpDown_dlc.Value >= 6)
                {
                    can_frame_data += hex6;
                }
                if (numericUpDown_dlc.Value >= 7)
                {
                    can_frame_data += hex7;
                }
                if (numericUpDown_dlc.Value >= 8)
                {
                    can_frame_data += hex8;
                }
            }
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(can_frame_data);
                    serialPort.Write("\r");
                }
                catch (System.TimeoutException ex)
                {
                    MessageBox.Show(serialPort.PortName + ": " + ex.Message);
                }
            }
            label_result.Text = "Resulting command: " + can_frame_data + "[CR]";
        }

        public virtual void button_send_frame_click(object sender, EventArgs e)
        {
            send_frame(checkBox_rtr.Checked, checkBox_ext.Checked, textBox_id.Text, 
                numericUpDown_dlc.Value.ToString(), textBox_hex1.Text, textBox_hex2.Text,
                textBox_hex3.Text, textBox_hex4.Text, textBox_hex5.Text, textBox_hex6.Text,
                textBox_hex7.Text, textBox_hex8.Text);
        }

        public virtual void button_time_stamp_on_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z1\r");
            }
        }

        public virtual void button_time_stamp_off_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z0\r");
            }
        }

        public virtual void button_auto_on_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X1\r");
            }
        }

        public virtual void button_auto_off_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X0\r");
            }
        }

        public virtual void button_poll_one_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("P\r");
            }
        }

        public virtual void button_poll_all_click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("A\r");
            }
        }
    }
}

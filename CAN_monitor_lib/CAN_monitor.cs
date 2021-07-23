using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAN_monitor_lib
{
    public partial class CAN_monitor: UserControl
    {
        private string receive_buffer;
        private int msg_counter_received;
        private int msg_counter_sent;
        // Global bitrate var
        private string global_can_bitrate = "";
        // Global send frame vars
        bool global_rtr = false;
        bool global_ext = false;
        string global_id = "";
        string global_dlc = "";
        string global_hex1 = "";
        string global_hex2 = "";
        string global_hex3 = "";
        string global_hex4 = "";
        string global_hex5 = "";
        string global_hex6 = "";
        string global_hex7 = "";
        string global_hex8 = "";

        public CAN_monitor()
        {
            receive_buffer = "";
            msg_counter_received = 0;
            msg_counter_sent = 0;
            InitializeComponent();
        }

        public void set_settings(int com_baud_rate_index, int can_bitrate_index, string can_id,
            int can_dlc, string hex1, string hex2, string hex3, string hex4, string hex5,
            string hex6, string hex7, string hex8, bool ext_id, bool rtr)
        {
            comboBox_com_baud_rate.SelectedIndex = com_baud_rate_index;
            comboBox_can_bitrate.SelectedIndex = can_bitrate_index;
            textBox_id.Text = can_id;
            numericUpDown_dlc.Value = can_dlc;
            textBox_hex1.Text = hex1;
            textBox_hex2.Text = hex2;
            textBox_hex3.Text = hex3;
            textBox_hex4.Text = hex4;
            textBox_hex5.Text = hex5;
            textBox_hex6.Text = hex6;
            textBox_hex7.Text = hex7;
            textBox_hex8.Text = hex8;
            checkBox_ext.Checked = ext_id;
            checkBox_rtr.Checked = rtr;
        }

        public Tuple<string, string, string, string> get_serialPort_status()
        {
            string serialPort_open = "Closed";
            if (serialPort.IsOpen)
                serialPort_open = "Open";
            return Tuple.Create(serialPort.PortName, serialPort_open, 
                msg_counter_received.ToString(), msg_counter_sent.ToString());
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

        private void CAN_Monitor_Load(object sender, EventArgs e)
        {
            comboBox_com_baud_rate.SelectedIndex = 4;
            comboBox_can_bitrate.SelectedIndex = 5;

        }

        public virtual void button_com_open_Click(object sender, EventArgs e)
        {

        }

        public virtual void button_com_close_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                toolStripStatusLabel_com_port.Text = "Closed";
                toolStripStatusLabel_baud_rate.Text = "-";
                groupBox_can_commands.Enabled = false;
                groupBox_can_frame_transmit.Enabled = false;
                button_com_close.Enabled = false;
                button_com_open.Enabled = true;
                comboBox_com_baud_rate.Enabled = true;
            }
        }

        public virtual void button_can_open_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("O\r");
            }
        }

        public virtual void button_can_close_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("C\r");
            }
        }

        public void set_global_can_bitrate(string s)
        {
            this.global_can_bitrate = s;
        }

        public virtual void button_setup_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("S");
                if (global_can_bitrate != "")
                {
                    serialPort.Write(global_can_bitrate);
                    global_can_bitrate = "";
                }
                else
                    serialPort.Write(comboBox_can_bitrate.SelectedIndex.ToString());
                serialPort.Write("\r");
            }
        }

        public virtual void button_can_version_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("V\r");
            }
        }

        public virtual void button_can_flags_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("F\r");
            }
        }

        public virtual void button_serial_number_Click(object sender, EventArgs e)
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

        public void set_global_send_frame_vars(bool rtr, bool ext, string id, string dlc, string hex1,
            string hex2, string hex3, string hex4, string hex5, string hex6, string hex7, string hex8)
        {
            this.global_rtr = rtr;
            this.global_ext = ext;
            this.global_id = id;
            this.global_dlc = dlc;
            this.global_hex1 = hex1;
            this.global_hex2 = hex2;
            this.global_hex3 = hex3;
            this.global_hex4 = hex4;
            this.global_hex5 = hex5;
            this.global_hex6 = hex6;
            this.global_hex7 = hex7;
            this.global_hex8 = hex8;
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

        public virtual void button_send_frame_Click(object sender, EventArgs e)
        {
            if (global_id != "")
            {
                send_frame(global_rtr, global_ext, global_id, global_dlc, global_hex1, global_hex2,
                    global_hex3, global_hex4, global_hex5, global_hex6, global_hex7, global_hex8);
                this.global_rtr = false;
                this.global_ext = false;
                this.global_id = "";
                this.global_dlc = "";
                this.global_hex1 = "";
                this.global_hex2 = "";
                this.global_hex3 = "";
                this.global_hex4 = "";
                this.global_hex5 = "";
                this.global_hex6 = "";
                this.global_hex7 = "";
                this.global_hex8 = "";
            }
            else
                send_frame(checkBox_rtr.Checked, checkBox_ext.Checked, textBox_id.Text, 
                    numericUpDown_dlc.Value.ToString(), textBox_hex1.Text, textBox_hex2.Text,
                    textBox_hex3.Text, textBox_hex4.Text, textBox_hex5.Text, textBox_hex6.Text,
                    textBox_hex7.Text, textBox_hex8.Text);
        }

        public virtual void button_time_stamp_on_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z1\r");
            }
        }

        public virtual void button_time_stamp_off_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Z0\r");
            }
        }

        public virtual void button_auto_on_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X1\r");
            }
        }

        public virtual void button_auto_off_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("X0\r");
            }
        }

        public virtual void button_poll_one_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("P\r");
            }
        }

        public virtual void button_poll_all_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("A\r");
            }
        }
    }
}

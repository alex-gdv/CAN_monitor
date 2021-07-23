using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAN_monitor_lib
{
    public partial class CAN_monitor_global : CAN_monitor_lib.CAN_monitor
    {
        private List<CAN_monitor_individual> can_monitor_indivual_lst;

        public CAN_monitor_global()
        {
            can_monitor_indivual_lst = new List<CAN_monitor_individual>();
            InitializeComponent();
            toolStripStatusLabel_com_port.Visible = false;
            toolStripStatusLabel_msg_counter_received.Visible = false;
        }

        public void add_change_line(RichTextBox rtb, int line, string text)
        {
            // source: https://stackoverflow.com/questions/29445411/c-sharp-how-can-i-update-just-one-line-text-in-richtextbox
            int s1 = rtb.GetFirstCharIndexFromLine(line);
            if (s1 != -1)
            {
                int s2 = line < rtb.Lines.Length - 1 ?
                          rtb.GetFirstCharIndexFromLine(line + 1) - 1 :
                          rtb.Text.Length;
                rtb.Select(s1, s2 - s1);
                rtb.SelectedText = text;
            }
            else
            {
                rtb.AppendText(line+"\n");
            }
        }

        public void update_selected_ports_interface()
        {
            int counter = 0;
            foreach (CAN_monitor_individual can_monitor_indivual in can_monitor_indivual_lst)
            {
                Tuple<string, string, string, string> data = can_monitor_indivual.get_serialPort_status();
                add_change_line(richTextBox_receive, counter, data.Item1 + ": " + data.Item2);
                add_change_line(richTextBox_receive, counter+1, "Messages received: " + data.Item3);
                add_change_line(richTextBox_receive, counter+2, "Messages sent: " + data.Item4);
                counter += 3;
            }
        }

        public void add_can_monitor_individual(CAN_monitor_individual can_monitor_individual)
        {
            can_monitor_indivual_lst.Add(can_monitor_individual);
        }

        public override void button_com_open_Click(object sender, EventArgs e)
        {
            int baud_rate = int.Parse(comboBox_com_baud_rate.SelectedItem.ToString());
            // Loop through individual CAN monitors
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
            {
                can_monitor_individual.set_global_baud_rate(baud_rate);
                can_monitor_individual.button_com_open_Click(sender, e);
            }
            // Update controls
            comboBox_com_baud_rate.Enabled = false;
            groupBox_can_commands.Enabled = true;
            groupBox_can_frame_transmit.Enabled = true;
            button_com_open.Enabled = false;
            button_com_close.Enabled = true;
            toolStripStatusLabel_baud_rate.Text = baud_rate.ToString();
        }

        public override void button_com_close_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_com_close_Click(sender, e);
            // Update controls
            toolStripStatusLabel_baud_rate.Text = "-";
            groupBox_can_commands.Enabled = false;
            groupBox_can_frame_transmit.Enabled = false;
            button_com_close.Enabled = false;
            button_com_open.Enabled = true;
            comboBox_com_baud_rate.Enabled = true;
        }

        public override void button_setup_Click(object sender, EventArgs e)
        {
            string global_can_bitrate = comboBox_can_bitrate.SelectedIndex.ToString();
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
            {
                can_monitor_individual.set_global_can_bitrate(global_can_bitrate);
                can_monitor_individual.button_setup_Click(sender, e);
            }
        }

        public override void button_can_open_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_can_open_Click(sender, e);
        }

        public override void button_can_close_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_can_close_Click(sender, e);
        }

        public override void button_can_version_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_can_version_Click(sender, e);
        }

        public override void button_can_flags_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_can_flags_Click(sender, e);
        }

        public override void button_serial_number_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_serial_number_Click(sender, e);
        }

        public override void button_time_stamp_on_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_time_stamp_on_Click(sender, e);
        }

        public override void button_time_stamp_off_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_time_stamp_off_Click(sender, e);
        }

        public override void button_auto_on_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_auto_on_Click(sender, e);
        }

        public override void button_auto_off_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_auto_off_Click(sender, e);
        }

        public override void button_poll_one_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_poll_one_Click(sender, e);
        }

        public override void button_poll_all_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
                can_monitor_individual.button_poll_all_Click(sender, e);
        }

        public override void button_send_frame_Click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_individual can_monitor_individual in can_monitor_indivual_lst)
            {
                can_monitor_individual.set_global_send_frame_vars(checkBox_rtr.Checked, checkBox_ext.Checked, textBox_id.Text,
                    numericUpDown_dlc.Value.ToString(), textBox_hex1.Text, textBox_hex2.Text,
                    textBox_hex3.Text, textBox_hex4.Text, textBox_hex5.Text, textBox_hex6.Text,
                    textBox_hex7.Text, textBox_hex8.Text);
                can_monitor_individual.button_send_frame_Click(sender, e);
            }
        }
    }
}

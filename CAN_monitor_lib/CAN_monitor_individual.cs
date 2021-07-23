using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAN_monitor_lib
{
    public partial class CAN_monitor_individual : CAN_monitor_lib.CAN_monitor
    {
        private int global_baud_rate = -1;

        public CAN_monitor_individual(string port_name)
        {
            serialPort.PortName = port_name;
            InitializeComponent();
        }

        public void set_global_baud_rate(int i)
        {
            this.global_baud_rate = i;
        }

        public override void button_com_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    // Open Port
                    if (global_baud_rate != -1)
                    {
                        serialPort.BaudRate = global_baud_rate;
                        global_baud_rate = -1;
                    }
                    else
                        serialPort.BaudRate = int.Parse(comboBox_com_baud_rate.SelectedItem.ToString());
                    serialPort.Open();
                    // Update controls
                    comboBox_com_baud_rate.Enabled = false;
                    groupBox_can_commands.Enabled = true;
                    groupBox_can_frame_transmit.Enabled = true;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAN_monitor_app
{
    public partial class Menu : Form
    {
        private List<string> active_ports_names_lst;
        private List<string> available_ports_names_lst;

        public Menu()
        {
            active_ports_names_lst = new List<string>();
            available_ports_names_lst = new List<string>();
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_com_ports.SelectedItem != null)
            {
                // Add new tab page
                TabPage newPage = new TabPage(comboBox_com_ports.Text);
                CAN_monitor_lib.CAN_monitor_individual can_monitor_individual = new CAN_monitor_lib.CAN_monitor_individual(comboBox_com_ports.Text);
                newPage.Controls.Add(can_monitor_individual);
                this.tabControl.TabPages.Add(newPage);
                // Update variables and controls
                can_monitor_global.add_can_monitor_individual(can_monitor_individual);
                active_ports_names_lst.Add(comboBox_com_ports.Text);
                can_monitor_global.update_selected_ports_interface();
                available_ports_names_lst.Remove(comboBox_com_ports.Text);
                comboBox_com_ports.Items.Remove(comboBox_com_ports.SelectedItem);
            }
        }

        public void timer_tick(object sender, EventArgs e)
        {
            can_monitor_global.update_selected_ports_interface();
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                if (!active_ports_names_lst.Contains(portName) && !available_ports_names_lst.Contains(portName))
                {
                    comboBox_com_ports.Items.Add(portName);
                    available_ports_names_lst.Add(portName);
                }
            }
            List<string> port_not_found_lst = new List<string>();
            foreach (string available_port_name in available_ports_names_lst){
                bool found = false;
                foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
                {
                    if (portName == available_port_name)
                        found = true;
                }
                if (!found)
                    port_not_found_lst.Add(available_port_name);
            }
            foreach (string port_not_found in port_not_found_lst)
            {
                comboBox_com_ports.Items.Remove(port_not_found);
                available_ports_names_lst.Remove(port_not_found);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox_com_ports.Items.Add(portName);
                available_ports_names_lst.Add(portName);
            }
            if (comboBox_com_ports.SelectedItem != null)
                comboBox_com_ports.SelectedIndex = 0;
            Timer timer = new Timer();
            timer.Interval = (100);
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
            can_monitor_global.set_settings(Properties.Settings.Default.Port_baud_rate_index,
                Properties.Settings.Default.CAN_bitrate_index, Properties.Settings.Default.CAN_id,
                Properties.Settings.Default.CAN_dlc, Properties.Settings.Default.Hex1,
                Properties.Settings.Default.Hex2, Properties.Settings.Default.Hex3,
                Properties.Settings.Default.Hex4, Properties.Settings.Default.Hex5,
                Properties.Settings.Default.Hex6, Properties.Settings.Default.Hex7,
                Properties.Settings.Default.Hex8, Properties.Settings.Default.Ext_id,
                Properties.Settings.Default.Rtr);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            can_monitor_global.button_com_close_Click(sender, e);
            Properties.Settings.Default.Port_baud_rate_index = can_monitor_global.comboBox_com_baud_rate.SelectedIndex;
            Properties.Settings.Default.CAN_bitrate_index = can_monitor_global.comboBox_can_bitrate.SelectedIndex;
            Properties.Settings.Default.CAN_id = can_monitor_global.textBox_id.Text;
            Properties.Settings.Default.CAN_dlc = Decimal.ToInt32(can_monitor_global.numericUpDown_dlc.Value);
            Properties.Settings.Default.Hex1 = can_monitor_global.textBox_hex1.Text;
            Properties.Settings.Default.Hex2 = can_monitor_global.textBox_hex2.Text;
            Properties.Settings.Default.Hex3 = can_monitor_global.textBox_hex3.Text;
            Properties.Settings.Default.Hex4 = can_monitor_global.textBox_hex4.Text;
            Properties.Settings.Default.Hex5 = can_monitor_global.textBox_hex5.Text;
            Properties.Settings.Default.Hex6 = can_monitor_global.textBox_hex6.Text;
            Properties.Settings.Default.Hex7 = can_monitor_global.textBox_hex7.Text;
            Properties.Settings.Default.Hex8 = can_monitor_global.textBox_hex8.Text;
            Properties.Settings.Default.Ext_id = can_monitor_global.checkBox_ext.Checked;
            Properties.Settings.Default.Rtr = can_monitor_global.checkBox_rtr.Checked;
            Properties.Settings.Default.Save();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CAN_monitor_app
{
    public partial class Menu : Form
    {
        private List<CAN_monitor_lib.CAN_monitor> active_can_monitors_lst;
        private List<string> active_ports_lst;
        private List<string> available_ports_lst;
        private List<string> disconnected_ports_lst;
        private bool button_send_frame_clicked;
        private Timer timer_send;

        public Menu()
        {
            active_can_monitors_lst = new List<CAN_monitor_lib.CAN_monitor>();
            active_ports_lst = new List<string>();
            available_ports_lst = new List<string>();
            disconnected_ports_lst = new List<string>();
            button_send_frame_clicked = false;
            timer_send = new Timer();
            timer_send.Tick += new EventHandler(timer_send_tick);
            InitializeComponent();
        }

        public void timer_interface_tick(object sender, EventArgs e)
        {
            // Check if disconnected ports have been connected again
            for (int i = disconnected_ports_lst.Count - 1; i >= 0; i--)
            {
                bool found = false;
                foreach (string port_name in System.IO.Ports.SerialPort.GetPortNames())
                {
                    if (port_name == disconnected_ports_lst[i])
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
                    {
                        if (can_monitor.get_port_name() == disconnected_ports_lst[i])
                        {
                            can_monitor.reconnected();
                        }
                    }
                    active_ports_lst.Add(disconnected_ports_lst[i]);
                    disconnected_ports_lst.RemoveAt(i);
                }
            }
            // Update port status table
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
            {
                bool found = false;
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems[0].Text == can_monitor.get_port_name())
                    {
                        Tuple<string, string, string> data = can_monitor.get_port_status();
                        found = true;
                        item.SubItems[1].Text = data.Item2;
                        if (item.SubItems[1].Text == "Open")
                            item.SubItems[1].BackColor = Color.Green;
                        else
                            item.SubItems[1].BackColor = Color.Red;
                        item.SubItems[2].Text = data.Item3;
                    }
                }
                if (!found)
                {
                    Tuple<string, string, string> data = can_monitor.get_port_status();
                    ListViewItem item = new ListViewItem(data.Item1);
                    item.SubItems.Add(data.Item2);
                    if (item.SubItems[1].Text == "Open")
                        item.SubItems[1].BackColor = Color.Green;
                    else
                        item.SubItems[1].BackColor = Color.Red;
                    item.SubItems.Add(data.Item3);
                    item.UseItemStyleForSubItems = false;
                    listView.Items.Add(item);
                }
            }
            // Update lists
            foreach (string port_name in System.IO.Ports.SerialPort.GetPortNames())
            {
                if (!active_ports_lst.Contains(port_name) && !available_ports_lst.Contains(port_name))
                {
                    comboBox_com_ports.Items.Add(port_name);
                    available_ports_lst.Add(port_name);
                }
            }
            // Check if any available port has been disconnected
            List<string> ports_not_found_lst = new List<string>();
            foreach (string available_port_name in available_ports_lst){
                bool found = false;
                foreach (string port_name in System.IO.Ports.SerialPort.GetPortNames())
                {
                    if (port_name == available_port_name)
                        found = true;
                }
                if (!found)
                {
                    ports_not_found_lst.Add(available_port_name);
                }
            }
            foreach (string port_not_found in ports_not_found_lst)
            {
                comboBox_com_ports.Items.Remove(port_not_found);
                available_ports_lst.Remove(port_not_found);
            }
            // Check if any active port has been disconnected
            ports_not_found_lst.Clear();
            foreach (string active_port_name in active_ports_lst)
            {
                bool found = false;
                foreach (string port_name in System.IO.Ports.SerialPort.GetPortNames())
                {
                    if (port_name == active_port_name)
                        found = true;
                }
                if (!found)
                {
                    ports_not_found_lst.Add(active_port_name);
                }
            }
            foreach (string port_not_found in ports_not_found_lst)
            {
                disconnected_ports_lst.Add(port_not_found);
                active_ports_lst.Remove(port_not_found);
                foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
                {
                    if (can_monitor.get_port_name() == port_not_found)
                    {
                        can_monitor.disconnected();
                        // Update interface
                        foreach (ListViewItem item in listView.Items)
                        {
                            if (item.SubItems[0].Text == port_not_found)
                            {
                                item.SubItems[1].Text = "Disconnected";
                                item.SubItems[1].BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (string port_name in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox_com_ports.Items.Add(port_name);
                available_ports_lst.Add(port_name);
            }
            if (comboBox_com_ports.SelectedItem != null)
            {
                comboBox_com_ports.SelectedIndex = 0;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "//monitor_data.xml";
            if (System.IO.File.Exists(path))
            {
                System.IO.FileStream file = System.IO.File.Open(path, System.IO.FileMode.Open,
                    System.IO.FileAccess.Read, System.IO.FileShare.Delete);
                List<CAN_monitor_attributes> can_monitor_attributes_lst = new List<CAN_monitor_attributes>();
                XmlSerializer reader = new XmlSerializer(can_monitor_attributes_lst.GetType());
                can_monitor_attributes_lst = (List<CAN_monitor_attributes>) reader.Deserialize(file);
                file.Close();
                foreach (CAN_monitor_attributes can_monitor_attributes in can_monitor_attributes_lst)
                {
                    Tuple<string, bool, string, bool, string> data = can_monitor_attributes.get_attributes();
                    if (available_ports_lst.Contains(data.Item1))
                    {
                        CAN_monitor_lib.CAN_monitor can_monitor = new CAN_monitor_lib.CAN_monitor(data.Item1, data.Item2,
                            data.Item3, data.Item4, data.Item5, true);
                        add_new_tab(can_monitor, true);
                    }
                    else
                    {
                        CAN_monitor_lib.CAN_monitor can_monitor = new CAN_monitor_lib.CAN_monitor(data.Item1, data.Item2,
                            data.Item3, data.Item4, data.Item5, false);
                        add_new_tab(can_monitor, false);
                    }
                }
            }
            Timer timer_interface = new Timer();
            timer_interface.Interval = (100);
            timer_interface.Tick += new EventHandler(timer_interface_tick);
            timer_interface.Start();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<CAN_monitor_attributes> can_monitor_attributes_lst = new List<CAN_monitor_attributes>();
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
            {
                Tuple<string, bool, string, bool, string> temp_attributes = can_monitor.get_attributes();
                CAN_monitor_attributes temp = new CAN_monitor_attributes(temp_attributes.Item1,
                    temp_attributes.Item2, temp_attributes.Item3, temp_attributes.Item4, temp_attributes.Item5);
                can_monitor_attributes_lst.Add(temp);
            }
            button_com_close_click(sender, e);
            XmlSerializer writer
                = new XmlSerializer(can_monitor_attributes_lst.GetType());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + "//monitor_data.xml";
            System.IO.FileStream file = System.IO.File.Open(path, System.IO.FileMode.Create,
                System.IO.FileAccess.Write, System.IO.FileShare.None);
            writer.Serialize(file, can_monitor_attributes_lst);
            file.Close();
        }

        private void button_close_tab_click(object sender, EventArgs e)
        {
            String name = tabControl.SelectedTab.Text;
            for (int i = active_can_monitors_lst.Count - 1; i >= 0; i--)
            {
                if (active_can_monitors_lst[i].get_port_name() == name)
                {
                    // Close port
                    active_can_monitors_lst[i].button_can_close_click(sender, e);
                    active_can_monitors_lst[i].button_com_close_click(sender, e);
                    // Update lists
                    active_can_monitors_lst.RemoveAt(i);
                    active_ports_lst.Remove(name);
                    available_ports_lst.Add(name);
                    // Update interface
                    comboBox_com_ports.Items.Add(name);
                    foreach (ListViewItem item in listView.Items)
                    {
                        if (item.SubItems[0].Text == name)
                        {
                            listView.Items.Remove(item);
                        }
                    }
                }
            }
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        public void add_new_tab(CAN_monitor_lib.CAN_monitor can_monitor, bool connected)
        {
            // Add new tab page
            TabPage newPage = new TabPage(can_monitor.get_port_name());
            tabControl.TabPages.Add(newPage);
            // Create split container
            System.Windows.Forms.SplitContainer new_split_container = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(new_split_container)).BeginInit();
            new_split_container.Panel1.SuspendLayout();
            new_split_container.Panel2.SuspendLayout();
            new_split_container.SuspendLayout();
            newPage.Controls.Add(new_split_container);
            new_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
            new_split_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            new_split_container.Location = new System.Drawing.Point(3, 3);
            new_split_container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // Add CAN monitor to split container
            new_split_container.Panel1.Controls.Add(can_monitor);
            // Add button to split container
            System.Windows.Forms.Button button_close_tab = new Button();
            new_split_container.Panel2.Controls.Add(button_close_tab);
            button_close_tab.Text = "Close tab";
            button_close_tab.UseVisualStyleBackColor = true;
            button_close_tab.Click += new System.EventHandler(button_close_tab_click);
            // Draw new tab
            new_split_container.Size = new System.Drawing.Size(718, 618);
            new_split_container.SplitterDistance = 450;
            new_split_container.Panel1.ResumeLayout(false);
            new_split_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(new_split_container)).EndInit();
            new_split_container.ResumeLayout(false);
            // Update lists
            active_can_monitors_lst.Add(can_monitor);
            if (connected)
            {
                active_ports_lst.Add(can_monitor.get_port_name());
                available_ports_lst.Remove(can_monitor.get_port_name());
            }
            else
            {
                disconnected_ports_lst.Add(can_monitor.get_port_name());
            }
            comboBox_com_ports.Items.Remove(comboBox_com_ports.SelectedItem);
        }

        private void button_add_click(object sender, EventArgs e)
        {
            if (comboBox_com_ports.SelectedItem != null)
            {
                // Add new tab page
                TabPage newPage = new TabPage(comboBox_com_ports.Text);
                tabControl.TabPages.Add(newPage);
                // Create split container
                System.Windows.Forms.SplitContainer new_split_container = new System.Windows.Forms.SplitContainer();
                ((System.ComponentModel.ISupportInitialize)(new_split_container)).BeginInit();
                new_split_container.Panel1.SuspendLayout();
                new_split_container.Panel2.SuspendLayout();
                new_split_container.SuspendLayout();
                newPage.Controls.Add(new_split_container);
                new_split_container.Dock = System.Windows.Forms.DockStyle.Fill;
                new_split_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                    | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                new_split_container.Location = new System.Drawing.Point(3, 3);
                new_split_container.Orientation = System.Windows.Forms.Orientation.Horizontal;
                // Add CAN monitor to split container
                CAN_monitor_lib.CAN_monitor can_monitor = new CAN_monitor_lib.CAN_monitor(comboBox_com_ports.Text);
                new_split_container.Panel1.Controls.Add(can_monitor);
                // Add button to split container
                System.Windows.Forms.Button button_close_tab = new Button();
                new_split_container.Panel2.Controls.Add(button_close_tab);
                button_close_tab.Text = "Close tab";
                button_close_tab.UseVisualStyleBackColor = true;
                button_close_tab.Click += new System.EventHandler(button_close_tab_click);
                // Draw new tab
                new_split_container.Size = new System.Drawing.Size(718, 618);
                new_split_container.SplitterDistance = 450;
                new_split_container.Panel1.ResumeLayout(false);
                new_split_container.Panel2.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(new_split_container)).EndInit();
                new_split_container.ResumeLayout(false);
                // Update lists
                active_can_monitors_lst.Add(can_monitor);
                active_ports_lst.Add(comboBox_com_ports.Text);
                available_ports_lst.Remove(comboBox_com_ports.Text);
                comboBox_com_ports.Items.Remove(comboBox_com_ports.SelectedItem);
            }
        }

        public void button_com_open_click(object sender, EventArgs e)
        {
            string baud_rate = comboBox_com_baud_rate.SelectedItem.ToString();
            // Loop through CAN monitor list
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
            {
                can_monitor.set_baud_rate(baud_rate);
                can_monitor.button_com_open_click(sender, e);
            }
            // Update interface
            comboBox_com_baud_rate.Enabled = false;
            button_com_open.Enabled = false;
            button_com_close.Enabled = true;
        }

        public void button_com_close_click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
                can_monitor.button_com_close_click(sender, e);
            button_com_close.Enabled = false;
            button_com_open.Enabled = true;
            comboBox_com_baud_rate.Enabled = true;
        }

        public void button_setup_click(object sender, EventArgs e)
        {
            string global_can_bitrate = comboBox_can_bitrate.SelectedIndex.ToString();
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
            {
                can_monitor.set_can_bitrate(global_can_bitrate);
                can_monitor.button_setup_click(sender, e);
            }
        }

        public void button_can_open_click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
                can_monitor.button_can_open_click(sender, e);
        }

        public void button_can_close_click(object sender, EventArgs e)
        {
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
                can_monitor.button_can_close_click(sender, e);
        }

        private void timer_send_tick(object sender, EventArgs e)
        {
            foreach (CAN_monitor_lib.CAN_monitor can_monitor in active_can_monitors_lst)
            {
                can_monitor.button_send_frame_click(sender, e);
            }
        }

        private void button_send_frame_click(object sender, EventArgs e)
        {
            if (!button_send_frame_clicked)
            {
                timer_send.Interval = Int32.Parse(textBox_interval.Text);
                timer_send.Start();
                button_send_frame_clicked = true;
                button_send_frame.Text = "Stop";
            }
            else
            {
                timer_send.Stop();
                button_send_frame_clicked = false;
                button_send_frame.Text = "Start";
            }
        }
    }

    public class CAN_monitor_attributes
    {
        public string port_name;
        public bool com_is_open;
        public string com_baud_rate;
        public bool can_is_open;
        public string can_bitrate;

        public CAN_monitor_attributes()
        {

        }

        public CAN_monitor_attributes(string port_name, bool com_is_open, string com_baud_rate,
            bool can_is_open, string can_bitrate)
        {
            this.port_name = port_name;
            this.com_is_open = com_is_open;
            this.com_baud_rate = com_baud_rate;
            this.can_is_open = can_is_open;
            this.can_bitrate = can_bitrate;
        }

        public Tuple<string, bool, string, bool, string> get_attributes()
        {
            return new Tuple<string, bool, string, bool, string>(port_name, com_is_open,
                com_baud_rate, can_is_open, can_bitrate);
        }
    }
}
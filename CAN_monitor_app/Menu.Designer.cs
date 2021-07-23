
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_global = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.can_monitor_global = new CAN_monitor_lib.CAN_monitor_global();
            this.comboBox_com_ports = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_global.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_global);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(732, 653);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_global
            // 
            this.tabPage_global.Controls.Add(this.splitContainer);
            this.tabPage_global.Location = new System.Drawing.Point(4, 25);
            this.tabPage_global.Name = "tabPage_global";
            this.tabPage_global.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_global.Size = new System.Drawing.Size(724, 624);
            this.tabPage_global.TabIndex = 0;
            this.tabPage_global.Text = "Global";
            this.tabPage_global.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.can_monitor_global);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.comboBox_com_ports);
            this.splitContainer.Panel2.Controls.Add(this.button_add);
            this.splitContainer.Panel2MinSize = 45;
            this.splitContainer.Size = new System.Drawing.Size(718, 618);
            this.splitContainer.SplitterDistance = 547;
            this.splitContainer.TabIndex = 0;
            // 
            // can_monitor_global
            // 
            this.can_monitor_global.Dock = System.Windows.Forms.DockStyle.Fill;
            this.can_monitor_global.Location = new System.Drawing.Point(0, 0);
            this.can_monitor_global.Margin = new System.Windows.Forms.Padding(4);
            this.can_monitor_global.Name = "can_monitor_global";
            this.can_monitor_global.Size = new System.Drawing.Size(718, 547);
            this.can_monitor_global.TabIndex = 0;
            // 
            // comboBox_com_ports
            // 
            this.comboBox_com_ports.FormattingEnabled = true;
            this.comboBox_com_ports.Location = new System.Drawing.Point(85, 20);
            this.comboBox_com_ports.Name = "comboBox_com_ports";
            this.comboBox_com_ports.Size = new System.Drawing.Size(99, 24);
            this.comboBox_com_ports.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(5, 20);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 24);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 653);
            this.Controls.Add(this.tabControl);
            this.Name = "Menu";
            this.Text = "CAN Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_global.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_global;
        private System.Windows.Forms.SplitContainer splitContainer;
        private CAN_monitor_lib.CAN_monitor_global can_monitor_global;
        private System.Windows.Forms.ComboBox comboBox_com_ports;
        private System.Windows.Forms.Button button_add;
    }
}


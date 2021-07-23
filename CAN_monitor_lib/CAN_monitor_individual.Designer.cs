
namespace CAN_monitor_lib
{
    partial class CAN_monitor_individual
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
            this.groupBox_com_port.SuspendLayout();
            this.groupBox_can_commands.SuspendLayout();
            this.groupBox_can_frame_transmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlc)).BeginInit();
            this.groupBox_can_frame_receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_com_baud_rate
            // 
            this.comboBox_com_baud_rate.Size = new System.Drawing.Size(99, 24);
            // 
            // comboBox_can_bitrate
            // 
            this.comboBox_can_bitrate.Size = new System.Drawing.Size(99, 24);
            // 
            // CAN_monitor_individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Name = "CAN_monitor_individual";
            this.groupBox_com_port.ResumeLayout(false);
            this.groupBox_com_port.PerformLayout();
            this.groupBox_can_commands.ResumeLayout(false);
            this.groupBox_can_commands.PerformLayout();
            this.groupBox_can_frame_transmit.ResumeLayout(false);
            this.groupBox_can_frame_transmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dlc)).EndInit();
            this.groupBox_can_frame_receive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

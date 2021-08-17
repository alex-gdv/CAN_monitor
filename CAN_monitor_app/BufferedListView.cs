using System.Windows.Forms;

namespace CAN_monitor_app
{
    class BufferedListView : ListView
    {
        public BufferedListView()
        {
            this.DoubleBuffered = true;
        }
    }
}

using System;
using System.Windows.Forms;

namespace TaskbarPicsApp
{
    /// <summary>
    /// Interaction logic for IconWindow.xaml
    /// </summary>
    public partial class IconWindow
    {
        private NotifyIcon _notifyIcon;

        public IconWindow()
        {
            InitializeComponent();
            _notifyIcon = new NotifyIcon
            {
                BalloonTipText = Properties.Resources.IconWindow_IconWindow_Hello_world_,
                BalloonTipTitle = Properties.Resources.IconWindow_IconWindow_The_App,
                Text = Properties.Resources.IconWindow_IconWindow_Text,
                Icon = Properties.Resources.TaskbarIcon
            };
            _notifyIcon.Click += NotifyIcon_Click;
            ShowTrayIcon(true);
            _notifyIcon.ShowBalloonTip(2000);
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
        }

        private void ShowTrayIcon(bool show)
        {
            if (_notifyIcon != null)
            {
                _notifyIcon.Visible = show;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _notifyIcon.Dispose();
            _notifyIcon = null;
        }
    }
}
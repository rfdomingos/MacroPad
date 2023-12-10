using System;
using System.Linq;
using System.Windows.Forms;
using RSoft.MacroPad.BLL.Infrasturture.Model;
using RSoft.MacroPad.Infrastructure;

namespace RSoft.MacroPad.Controls.Tabs
{
    public partial class SystemKeyTab : UserControl
    {
        private SystemKey key = SystemKey.Sleep;

        public SystemKey Key
        {
            get => key;
            set
            {
                key = value;
                UpdateControls();
            }
        }

        public SystemKeyTab()
        {
            InitializeComponent();

            rbPower.Tag = SystemKey.Power;
            rbSleep.Tag = SystemKey.Sleep;
            rbWake.Tag = SystemKey.Wake;

            UpdateControls();
        }

        private void KeyChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            key = (SystemKey)rb.Tag;
        }

        private void UpdateControls()
        {
            foreach (var rb in Controls.As<RadioButton>())
            {
                if ((SystemKey)rb.Tag == key)
                {
                    rb.Checked = true;
                    break;
                }
            }
        }
    }
}

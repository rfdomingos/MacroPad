using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RSoft.MacroPad.Infrastructure;
using RSoft.MacroPad.Model;

namespace RSoft.MacroPad.Controls.Tabs
{
    public partial class MediaKeyTab : UserControl
    {
        private Keys key = Keys.MediaPreviousTrack;

        public Keys Key
        {
            get => key;
            set
            {
                key = value;
                UpdateControls();
            }
        }

        public KeyStroke KeyStroke
        {
            get => new KeyStroke { Key = key, Operation = KeyStrokeOperation.Press };
            set
            {
                key = value.Key;
                UpdateControls();
            }
        }
        public MediaKeyTab()
        {
            InitializeComponent();

            rbTrackNext.Tag = Keys.MediaNextTrack;
            rbTrackPrev.Tag = Keys.MediaPreviousTrack;
            rbTrackPlay.Tag = Keys.MediaPlayPause;

            rbVolUp.Tag = Keys.VolumeUp;
            rbVolDown.Tag = Keys.VolumeDown;
            rbVolMute.Tag = Keys.VolumeMute;
            rbMediaPlayer.Tag = Keys.SelectMedia;
            rbCalculator.Tag = Keys.LaunchApplication2;
            rbLocalComputer.Tag = Keys.LaunchApplication1;
            rbHomepage.Tag = Keys.BrowserHome;
            rbEmail.Tag = Keys.LaunchMail;
            rbSearch.Tag = Keys.BrowserSearch;

            UpdateControls();
        }

        private void KeyChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            key = (Keys)rb.Tag;
        }

        private void UpdateControls()
        {
            foreach (var rb in Controls.As<RadioButton>())
            {
                if ((Keys)rb.Tag == key)
                {
                    rb.Checked = true;
                    break;
                }
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace UtilizaciondeComponentes
{
    public partial class Frm_MediaPlayer : Form
    {
        private string currentFile = string.Empty;
        
        public Frm_MediaPlayer()
        {
            InitializeComponent();
        }

        private void MediaPlayerForm_Load(object sender, EventArgs e)
        {
            // Initialize volume
            trckBar_Volumen.Value = 50;
            mediaPlayer.settings.volume = 50;
            lblVolumen.Text = "Volume: 50%";
            
            // Disable controls until a file is loaded
            SetControlsEnabled(false);
        }

        private void MediaPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop playback when closing the form
            mediaPlayer.Ctlcontrols.stop();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Media Files|*.mp3;*.wav;*.mp4;*.avi;*.mkv;*.wmv|All Files|*.*",
                    Title = "Select a Media File"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = openFileDialog.FileName;
                    lblNombreArchivo.Text = Path.GetFileName(currentFile);
                    
                    mediaPlayer.URL = currentFile;
                    mediaPlayer.Ctlcontrols.play();
                    
                    SetControlsEnabled(true);
                    btnPlay.Text = "Pause";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening media file: " + ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
                return;

            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mediaPlayer.Ctlcontrols.pause();
                btnPlay.Text = "Play";
            }
            else
            {
                mediaPlayer.Ctlcontrols.play();
                btnPlay.Text = "Pause";
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
                return;

            mediaPlayer.Ctlcontrols.stop();
            btnPlay.Text = "Play";
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = trckBar_Volumen.Value;
            lblVolumen.Text = $"Volume: {trckBar_Volumen.Value}%";
        }

        private void BtnFullScreen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFile))
                return;

            mediaPlayer.fullScreen = true;
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.settings.mute)
            {
                mediaPlayer.settings.mute = false;
                btnMutear.Text = "Mute";
            }
            else
            {
                mediaPlayer.settings.mute = true;
                btnMutear.Text = "Unmute";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MediaPlayer_PlayStateChange(object _, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Update UI based on play state
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Text = "Pause";
            }
            else if (e.newState == (int)WMPLib.WMPPlayState.wmppsPaused ||
                     e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                btnPlay.Text = "Play";
            }
        }

        private void MediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent _)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            MessageBox.Show("Media error: The file could not be played.", "Media Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            SetControlsEnabled(false);
        }

        private void SetControlsEnabled(bool enabled)
        {
            btnPlay.Enabled = enabled;
            btnParar.Enabled = enabled;
            btnMutear.Enabled = enabled;
            btnPantallaCompleta.Enabled = enabled;
            trckBar_Volumen.Enabled = enabled;
        }
    }
}

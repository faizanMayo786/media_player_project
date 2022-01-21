using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using Menu.DAL;
using Menu.BAL;
namespace Menu
{
    public partial class ControlCenter : Form
    {

        SpeechRecognitionEngine newengine = new SpeechRecognitionEngine();
        Choices choice = new Choices();
        public ControlCenter()
        {
            InitializeComponent();

        }
        private string[] favPath,favName;
        private void btnFavourite_Click(object sender, EventArgs e)
        {
            //pnlFavorite.BringToFront();

            //btnNowPlaying.BackColor = Color.FromArgb(9, 6, 11);
            //btnRecentAdded.BackColor = Color.FromArgb(9, 6, 11);
            //btnFavourite.BackColor = btnNowPlaying.FlatAppearance.MouseDownBackColor;


            //DataSet dsfile = DataQueries.ReadFileName();

            ////Favourites.DataSource = dsfile.Tables[0];
            ////Favourites.DisplayMember = "FileName";
            //Favourites.Items.Clear();

            //List<string> str = new List<string>();
            //List<string> strname = new List<string>();

            //foreach (DataRow d in dsfile.Tables[0].Rows)
            //{
            //    str.Add(d["Path"].ToString());
            //    strname.Add(d["FileName"].ToString());
            //}
            //favPath = str.ToArray();
            //favName = strname.ToArray();
            //for (int i = 0; i < favName.Length; i++)
            //{
            //    Favourites.Items.Add(favName[i]);
            //}
        }
        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if(Tracks.Items.Count != 0){
                    pnlRecentAdd.Hide();
                    pnlNowPlaying.BringToFront();
                    pnlNowPlaying.Show();
                    Tracks.Hide();
                    btnNowPlaying.BackColor = btnNowPlaying.FlatAppearance.MouseDownBackColor;
                    btnRecentAdded.BackColor = Color.FromArgb(9, 6, 11);

                    btnFavourite.BackColor = Color.FromArgb(9, 6, 11);
                }
            }
            );
        }

        private async void btnRecentAdded_Click(object sender, EventArgs e)
        {
           await Task.Run(() =>
            {
                pnlNowPlaying.Hide();
                pnlRecentAdd.Show();
                Tracks.Show();
                pnlRecentAdd.BringToFront();
                Tracks.BringToFront();
                btnNowPlaying.BackColor = Color.FromArgb(9, 6, 11);
                btnFavourite.BackColor = Color.FromArgb(9, 6, 11);
                btnRecentAdded.BackColor = btnNowPlaying.FlatAppearance.MouseDownBackColor;
            }
            );
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckPlay()
        {

            btnPlay.Image = Properties.Resources.imgPause;
            wmpPlaying.Ctlcontrols.play();
            btnPlay.Tag = "Pause";
        }
        public void CheckPause()
        {

            wmpPlaying.Ctlcontrols.pause();
            btnPlay.Image = Properties.Resources.imgPlay;
            btnPlay.Tag = "Play";
            
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Tag ==  "Play")
            {
                CheckPlay();
            }
            else
            {
                CheckPause();
            }
        }
        private string[] file;
        private string[] path ;
        private string[] pth = new string[2];
        private string[] p= new string[2];
        private async void btnAdd_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Title = "Add Media Files";
            ofg.InitialDirectory = "Desktop";
            ofg.Multiselect = true;
            if (ofg.ShowDialog() == DialogResult.OK)
                await    Task.Run(() =>
            {
                
                {
                    file = ofg.SafeFileNames;
                    pth = p;
                    p = ofg.FileNames;
                    path = new string[p.Length + pth.Length];
                    p.CopyTo(path, 0);
                    pth.CopyTo(path, p.Length);
                    for (int i = 0; i < file.Length; i++)
                    {
                        Tracks.Items.Add(file[i]);
                    }
                    CheckPlay();
                    wmpPlaying.URL = path[Tracks.Items.Count - 1];
                    wmpPlaying.Ctlcontrols.play();
                    timer1.Start();
                }
//                DataSet dsfile = DataQueries.ReadFileName();

                //Favourites.DataSource = dsfile.Tables[0];
                //Favourites.DisplayMember = "FileName";
  //              Favourites.Items.Clear();

                List<string> str = new List<string>();
                List<string> strname = new List<string>();

                //foreach (DataRow d in dsfile.Tables[0].Rows)
                //{
                //    str.Add(d["Path"].ToString());
                //    strname.Add(d["FileName"].ToString());
                //}
                //favPath = str.ToArray();
                //favName = strname.ToArray();
                //for (int i = 0; i < favName.Length; i++)
                //{
                //    Favourites.Items.Add(favName[i]);
                //}
            });
        }
        private string[] options;
        private void ControlCenter_Load(object sender, EventArgs e)
        {
            //VoiceControls.Controls(ref options);
            //choice.Add(options);
            //GrammarBuilder gbuilder = new GrammarBuilder();
            //gbuilder.Append(choice);
            //Grammar grammer = new Grammar(gbuilder);
            //newengine.RequestRecognizerUpdate();
            //newengine.LoadGrammarAsync(grammer);
            //newengine.SetInputToDefaultAudioDevice();
            //newengine.SpeechRecognized += newengine_SpeechRecognized;
            pnlNowPlaying.Show();
            wmpPlaying.settings.volume = tbrVolume.Value * 10;
            lblPercent.Text = (tbrVolume.Value * 10).ToString() + "%";
            pnlNowPlaying.BringToFront();
            DataQueries.GetConnection();

            //DataSet dsfile = DataQueries.ReadFileName();

            //Favourites.DataSource = dsfile.Tables[0];
            //Favourites.DisplayMember = "FileName";
            Favourites.Items.Clear();

            List<string> str = new List<string>();
            List<string> strname = new List<string>();

           // foreach (DataRow d in dsfile.Tables[0].Rows)
            //{
            //    str.Add(d["Path"].ToString());
            //    strname.Add(d["FileName"].ToString());
            //}
            //favPath = str.ToArray();
            //favName = strname.ToArray();
            //for (int i = 0; i < favName.Length; i++)
            //{
            //    Favourites.Items.Add(favName[i]);
            //}
        }

        void newengine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Stop":
                    wmpPlaying.Ctlcontrols.stop();
                    btnPlay.Image = Properties.Resources.imgPlay;
                    btnPlay.Tag = "Play";
                    break;
                case "Play":
                    CheckPlay();
                    break;
                case "Pause":
                    CheckPause();
                    break;
                case "Resume":
                    CheckPlay();
                    break;
                case "Next":
                    if (Tracks.SelectedIndex < Tracks.Items.Count - 1)
                    {
                        Tracks.SelectedIndex++;
                        CheckPlay();
                    }
                    break;
                case "Previous":
                     if (Tracks.SelectedIndex > 0)
                    {
                        Tracks.SelectedIndex--;
                        CheckPlay();
                    }
                    break;
                case "Exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void Tracks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Tracks.SelectedItem != null)
            {
                wmpPlaying.URL = path[Tracks.SelectedIndex];
                CheckPlay();
                wmpPlaying.Ctlcontrols.play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpPlaying.Ctlcontrols.stop();
            CheckPause();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Tracks.SelectedIndex > 0 ||Tracks.SelectedItem!=null)
            {
                Tracks.SelectedIndex--; CheckPlay();
            }
            else if (Favourites.SelectedIndex > 0 || Favourites.SelectedItem != null)
            {
                Favourites.SelectedIndex--; CheckPlay();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Tracks.SelectedIndex < Tracks.Items.Count - 1 || Tracks.SelectedItem != null)
            {
                Tracks.SelectedIndex++; CheckPlay();
                CheckPlay();
            }else if (Favourites.SelectedIndex < Favourites.Items.Count - 1 || Favourites.SelectedItem != null)
            {
                Favourites.SelectedIndex++; CheckPlay();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            CheckPlay();
            wmpPlaying.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (wmpPlaying.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pbrStatus.Maximum = (int)wmpPlaying.Ctlcontrols.currentItem.duration;
                pbrStatus.Value = (int)wmpPlaying.Ctlcontrols.currentPosition;
            }
            lblSTime.Text= wmpPlaying.Ctlcontrols.currentPositionString;
            lblETimer.Text = wmpPlaying.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void tbr_Scroll(object sender, EventArgs e)
        {
            wmpPlaying.settings.volume = tbrVolume.Value*10;
            lblPercent.Text = (tbrVolume.Value * 10).ToString() + "%";
        }
        private void btnVoice_Click(object sender, EventArgs e)
        {
            if (btnVoiceControl.Tag == "off")
            {
                newengine.RecognizeAsync(RecognizeMode.Multiple);
                btnVoiceControl.Tag = "on";
                lblVR.Text = "Voice Recoginition: ON";
            }
            else
            {
                newengine.RecognizeAsyncStop();
                btnVoiceControl.Tag = "off";
                lblVR.Text = "Voice Recoginition: OFF";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            
                Favourite fav = new Favourite(file[Tracks.SelectedIndex], path[Tracks.SelectedIndex]);
                DataQueries.AddMedia(fav);
            
        }

        private void Favourites_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Favourites.SelectedItem != null)
            {
                wmpPlaying.URL = favPath[Favourites.SelectedIndex];
                CheckPlay();
                wmpPlaying.Ctlcontrols.play();
            }
            timer1.Start();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DataQueries.RemoveMedia(favName[Favourites.SelectedIndex]);
            DataSet dsfile = DataQueries.ReadFileName();

            //Favourites.DataSource = dsfile.Tables[0];
            //Favourites.DisplayMember = "FileName";
            Favourites.Items.Clear();
            List<string> str = new List<string>();
            List<string> strname = new List<string>();

            foreach (DataRow d in dsfile.Tables[0].Rows)
            {
                str.Add(d["Path"].ToString());
                strname.Add(d["FileName"].ToString());
            }
            favPath = str.ToArray();
            favName = strname.ToArray();
            for (int i = 0; i < favName.Length; i++)
            {
                Favourites.Items.Add(favName[i]);
            }
        }

        private void btnResume_Click_1(object sender, EventArgs e)
        {
            CheckPlay();
            wmpPlaying.Ctlcontrols.play();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

       

    }
}

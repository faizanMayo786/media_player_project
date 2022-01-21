namespace Menu
{
    partial class ControlCenter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCenter));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFavourite = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRecentAdded = new System.Windows.Forms.Button();
            this.btnNowPlaying = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.pnlNowPlaying = new System.Windows.Forms.Panel();
            this.lblVR = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tbrVolume = new System.Windows.Forms.TrackBar();
            this.lblETimer = new System.Windows.Forms.Label();
            this.lblSTime = new System.Windows.Forms.Label();
            this.pbrStatus = new System.Windows.Forms.ProgressBar();
            this.wmpPlaying = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlRecentAdd = new System.Windows.Forms.Panel();
            this.lblAddRecord = new System.Windows.Forms.Label();
            this.Tracks = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlFavorite = new System.Windows.Forms.Panel();
            this.Favourites = new System.Windows.Forms.ListBox();
            this.lblFavortes = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVoiceControl = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddMedia = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNowPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlaying)).BeginInit();
            this.pnlRecentAdd.SuspendLayout();
            this.pnlFavorite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(6)))), ((int)(((byte)(11)))));
            this.panel2.Controls.Add(this.btnFavourite);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnRecentAdded);
            this.panel2.Controls.Add(this.btnNowPlaying);
            this.panel2.Location = new System.Drawing.Point(-9, -15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 598);
            this.panel2.TabIndex = 1;
            // 
            // btnFavourite
            // 
            this.btnFavourite.FlatAppearance.BorderSize = 0;
            this.btnFavourite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourite.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.btnFavourite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btnFavourite.Location = new System.Drawing.Point(73, 208);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(183, 51);
            this.btnFavourite.TabIndex = 4;
            this.btnFavourite.Text = "Favourites";
            this.btnFavourite.UseVisualStyleBackColor = true;
            this.btnFavourite.Click += new System.EventHandler(this.btnFavourite_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(5, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 579);
            this.panel3.TabIndex = 3;
            // 
            // btnRecentAdded
            // 
            this.btnRecentAdded.FlatAppearance.BorderSize = 0;
            this.btnRecentAdded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnRecentAdded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRecentAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecentAdded.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecentAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btnRecentAdded.Location = new System.Drawing.Point(73, 147);
            this.btnRecentAdded.Name = "btnRecentAdded";
            this.btnRecentAdded.Size = new System.Drawing.Size(183, 51);
            this.btnRecentAdded.TabIndex = 0;
            this.btnRecentAdded.Text = "Recently Added";
            this.btnRecentAdded.UseVisualStyleBackColor = true;
            this.btnRecentAdded.Click += new System.EventHandler(this.btnRecentAdded_Click);
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.FlatAppearance.BorderSize = 0;
            this.btnNowPlaying.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnNowPlaying.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnNowPlaying.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowPlaying.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNowPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.btnNowPlaying.Location = new System.Drawing.Point(73, 86);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.Size = new System.Drawing.Size(183, 51);
            this.btnNowPlaying.TabIndex = 0;
            this.btnNowPlaying.Text = "Now Playing";
            this.btnNowPlaying.UseVisualStyleBackColor = true;
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblVolume);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 61);
            this.panel1.TabIndex = 2;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblVolume.Location = new System.Drawing.Point(76, 22);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(139, 29);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Media Player";
            // 
            // pnlNowPlaying
            // 
            this.pnlNowPlaying.Controls.Add(this.btnVoiceControl);
            this.pnlNowPlaying.Controls.Add(this.lblVR);
            this.pnlNowPlaying.Controls.Add(this.lblVol);
            this.pnlNowPlaying.Controls.Add(this.lblPercent);
            this.pnlNowPlaying.Controls.Add(this.tbrVolume);
            this.pnlNowPlaying.Controls.Add(this.lblETimer);
            this.pnlNowPlaying.Controls.Add(this.lblSTime);
            this.pnlNowPlaying.Controls.Add(this.pbrStatus);
            this.pnlNowPlaying.Controls.Add(this.btnPrevious);
            this.pnlNowPlaying.Controls.Add(this.btnStop);
            this.pnlNowPlaying.Controls.Add(this.btnNext);
            this.pnlNowPlaying.Controls.Add(this.btnResume);
            this.pnlNowPlaying.Controls.Add(this.btnPlay);
            this.pnlNowPlaying.Controls.Add(this.wmpPlaying);
            this.pnlNowPlaying.Location = new System.Drawing.Point(253, 55);
            this.pnlNowPlaying.Name = "pnlNowPlaying";
            this.pnlNowPlaying.Size = new System.Drawing.Size(772, 518);
            this.pnlNowPlaying.TabIndex = 3;
            // 
            // lblVR
            // 
            this.lblVR.AutoSize = true;
            this.lblVR.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblVR.Location = new System.Drawing.Point(40, 491);
            this.lblVR.Name = "lblVR";
            this.lblVR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVR.Size = new System.Drawing.Size(153, 18);
            this.lblVR.TabIndex = 7;
            this.lblVR.Text = "Voice Recoginition: OFF";
            this.lblVR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblVol.Location = new System.Drawing.Point(557, 482);
            this.lblVol.Name = "lblVol";
            this.lblVol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVol.Size = new System.Drawing.Size(54, 18);
            this.lblVol.TabIndex = 7;
            this.lblVol.Text = "Volume:";
            this.lblVol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblPercent.Location = new System.Drawing.Point(636, 483);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPercent.Size = new System.Drawing.Size(27, 18);
            this.lblPercent.TabIndex = 7;
            this.lblPercent.Text = "0%";
            this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbrVolume
            // 
            this.tbrVolume.Location = new System.Drawing.Point(548, 443);
            this.tbrVolume.Name = "tbrVolume";
            this.tbrVolume.Size = new System.Drawing.Size(123, 45);
            this.tbrVolume.TabIndex = 8;
            this.tbrVolume.Value = 5;
            this.tbrVolume.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // lblETimer
            // 
            this.lblETimer.AutoSize = true;
            this.lblETimer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblETimer.Location = new System.Drawing.Point(695, 415);
            this.lblETimer.Name = "lblETimer";
            this.lblETimer.Size = new System.Drawing.Size(44, 18);
            this.lblETimer.TabIndex = 7;
            this.lblETimer.Text = "00:00";
            // 
            // lblSTime
            // 
            this.lblSTime.AutoSize = true;
            this.lblSTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblSTime.Location = new System.Drawing.Point(14, 415);
            this.lblSTime.Name = "lblSTime";
            this.lblSTime.Size = new System.Drawing.Size(44, 18);
            this.lblSTime.TabIndex = 7;
            this.lblSTime.Text = "00:00";
            // 
            // pbrStatus
            // 
            this.pbrStatus.Location = new System.Drawing.Point(70, 419);
            this.pbrStatus.Name = "pbrStatus";
            this.pbrStatus.Size = new System.Drawing.Size(613, 10);
            this.pbrStatus.TabIndex = 6;
            // 
            // wmpPlaying
            // 
            this.wmpPlaying.Enabled = true;
            this.wmpPlaying.Location = new System.Drawing.Point(8, 9);
            this.wmpPlaying.Name = "wmpPlaying";
            this.wmpPlaying.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlaying.OcxState")));
            this.wmpPlaying.Size = new System.Drawing.Size(735, 398);
            this.wmpPlaying.TabIndex = 4;
            // 
            // pnlRecentAdd
            // 
            this.pnlRecentAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.pnlRecentAdd.Controls.Add(this.btnAddMedia);
            this.pnlRecentAdd.Controls.Add(this.lblAddRecord);
            this.pnlRecentAdd.Controls.Add(this.Tracks);
            this.pnlRecentAdd.Location = new System.Drawing.Point(264, 65);
            this.pnlRecentAdd.Name = "pnlRecentAdd";
            this.pnlRecentAdd.Size = new System.Drawing.Size(756, 492);
            this.pnlRecentAdd.TabIndex = 4;
            // 
            // lblAddRecord
            // 
            this.lblAddRecord.AutoSize = true;
            this.lblAddRecord.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblAddRecord.Location = new System.Drawing.Point(70, 44);
            this.lblAddRecord.Name = "lblAddRecord";
            this.lblAddRecord.Size = new System.Drawing.Size(171, 33);
            this.lblAddRecord.TabIndex = 1;
            this.lblAddRecord.Text = "Added Tracks";
            // 
            // Tracks
            // 
            this.Tracks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Tracks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tracks.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tracks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.Tracks.FormattingEnabled = true;
            this.Tracks.ItemHeight = 26;
            this.Tracks.Location = new System.Drawing.Point(68, 83);
            this.Tracks.Name = "Tracks";
            this.Tracks.Size = new System.Drawing.Size(600, 314);
            this.Tracks.TabIndex = 0;
            this.Tracks.SelectedIndexChanged += new System.EventHandler(this.Tracks_SelectedIndexChanged_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlFavorite
            // 
            this.pnlFavorite.Controls.Add(this.btnRemove);
            this.pnlFavorite.Controls.Add(this.Favourites);
            this.pnlFavorite.Controls.Add(this.lblFavortes);
            this.pnlFavorite.Location = new System.Drawing.Point(260, 64);
            this.pnlFavorite.Name = "pnlFavorite";
            this.pnlFavorite.Size = new System.Drawing.Size(744, 513);
            this.pnlFavorite.TabIndex = 5;
            // 
            // Favourites
            // 
            this.Favourites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.Favourites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Favourites.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Favourites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.Favourites.FormattingEnabled = true;
            this.Favourites.ItemHeight = 29;
            this.Favourites.Location = new System.Drawing.Point(63, 94);
            this.Favourites.Name = "Favourites";
            this.Favourites.Size = new System.Drawing.Size(600, 292);
            this.Favourites.TabIndex = 8;
            this.Favourites.SelectedIndexChanged += new System.EventHandler(this.Favourites_SelectedIndexChanged);
            // 
            // lblFavortes
            // 
            this.lblFavortes.AutoSize = true;
            this.lblFavortes.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavortes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
            this.lblFavortes.Location = new System.Drawing.Point(67, 59);
            this.lblFavortes.Name = "lblFavortes";
            this.lblFavortes.Size = new System.Drawing.Size(116, 29);
            this.lblFavortes.TabIndex = 7;
            this.lblFavortes.Text = "Favourites";
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Image = global::Menu.Properties.Resources.imgAbout;
            this.btnAbout.Location = new System.Drawing.Point(865, 19);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(40, 37);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Menu.Properties.Resources.imgMinimize;
            this.pictureBox3.Location = new System.Drawing.Point(911, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Menu.Properties.Resources.imgCancel;
            this.pictureBox2.Location = new System.Drawing.Point(957, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.imgLogo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(13, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(45, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVoiceControl
            // 
            this.btnVoiceControl.FlatAppearance.BorderSize = 0;
            this.btnVoiceControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoiceControl.Image = ((System.Drawing.Image)(resources.GetObject("btnVoiceControl.Image")));
            this.btnVoiceControl.Location = new System.Drawing.Point(96, 448);
            this.btnVoiceControl.Name = "btnVoiceControl";
            this.btnVoiceControl.Size = new System.Drawing.Size(40, 40);
            this.btnVoiceControl.TabIndex = 9;
            this.btnVoiceControl.Tag = "off";
            this.btnVoiceControl.UseVisualStyleBackColor = true;
            this.btnVoiceControl.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::Menu.Properties.Resources.imgPrevious;
            this.btnPrevious.Location = new System.Drawing.Point(211, 448);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::Menu.Properties.Resources.imgStop;
            this.btnStop.Location = new System.Drawing.Point(277, 448);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Menu.Properties.Resources.imgNext;
            this.btnNext.Location = new System.Drawing.Point(475, 448);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 5;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnResume
            // 
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Image = global::Menu.Properties.Resources.imgResume;
            this.btnResume.Location = new System.Drawing.Point(409, 448);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(40, 40);
            this.btnResume.TabIndex = 5;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::Menu.Properties.Resources.imgPlay;
            this.btnPlay.Location = new System.Drawing.Point(343, 448);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Tag = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::Menu.Properties.Resources.imgDeleteMedia;
            this.btnRemove.Location = new System.Drawing.Point(613, 49);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 40);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddMedia
            // 
            this.btnAddMedia.FlatAppearance.BorderSize = 0;
            this.btnAddMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedia.Image = global::Menu.Properties.Resources.imgAddMedia;
            this.btnAddMedia.Location = new System.Drawing.Point(619, 37);
            this.btnAddMedia.Name = "btnAddMedia";
            this.btnAddMedia.Size = new System.Drawing.Size(40, 40);
            this.btnAddMedia.TabIndex = 2;
            this.btnAddMedia.UseVisualStyleBackColor = true;
            this.btnAddMedia.Click += new System.EventHandler(this.btnAddMedia_Click);
            // 
            // ControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlNowPlaying);
            this.Controls.Add(this.pnlFavorite);
            this.Controls.Add(this.pnlRecentAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.ControlCenter_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNowPlaying.ResumeLayout(false);
            this.pnlNowPlaying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlaying)).EndInit();
            this.pnlRecentAdd.ResumeLayout(false);
            this.pnlRecentAdd.PerformLayout();
            this.pnlFavorite.ResumeLayout(false);
            this.pnlFavorite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNowPlaying;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecentAdded;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlNowPlaying;
        private AxWMPLib.AxWindowsMediaPlayer wmpPlaying;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlRecentAdd;
        private System.Windows.Forms.ListBox Tracks;
        private System.Windows.Forms.Label lblAddRecord;
        private System.Windows.Forms.ProgressBar pbrStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblETimer;
        private System.Windows.Forms.Label lblSTime;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar tbrVolume;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Panel pnlFavorite;
        private System.Windows.Forms.ListBox Favourites;
        private System.Windows.Forms.Label lblFavortes;
        private System.Windows.Forms.Button btnVoiceControl;
        private System.Windows.Forms.Label lblVR;
        private System.Windows.Forms.Button btnFavourite;
        private System.Windows.Forms.Button btnAddMedia;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAbout;
    }
}


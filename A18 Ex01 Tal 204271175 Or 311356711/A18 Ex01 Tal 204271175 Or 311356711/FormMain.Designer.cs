using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer m_Components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (m_Components != null))
            {
                m_Components.Dispose();
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
            this.tabFindMutualProperties = new System.Windows.Forms.TabPage();
            this.textBoxNoteNullFriends = new System.Windows.Forms.TextBox();
            this.labelMatchesCount = new System.Windows.Forms.Label();
            this.checkBoxFriendsFilter = new System.Windows.Forms.CheckBox();
            this.labelPickProp = new System.Windows.Forms.Label();
            this.panelFriends = new System.Windows.Forms.Panel();
            this.listBoxProfileInfoProps = new System.Windows.Forms.ListBox();
            this.buttonFilterFriends = new System.Windows.Forms.Button();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.labelCheckStats = new System.Windows.Forms.Label();
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.labelEventsNum = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelFriendsNum = new System.Windows.Forms.Label();
            this.labelAlbumsCount = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.groupBoxStatisticInfo = new System.Windows.Forms.GroupBox();
            this.labelLikesNum = new System.Windows.Forms.Label();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.labelMessagesNum = new System.Windows.Forms.Label();
            this.labelPicsTaggedIn = new System.Windows.Forms.Label();
            this.labelWallPostNum = new System.Windows.Forms.Label();
            this.labelWallPosts = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.tabLikedPages = new System.Windows.Forms.TabPage();
            this.labelIfNothingUserLiked = new System.Windows.Forms.Label();
            this.labelFindPostLikedPages = new System.Windows.Forms.Label();
            this.textBoxPageStatus = new System.Windows.Forms.TextBox();
            this.buttonRandomPostFromAll = new System.Windows.Forms.Button();
            this.buttonRandomPostFromSpecified = new System.Windows.Forms.Button();
            this.buttonRecentPosts = new System.Windows.Forms.Button();
            this.ListBoxLikedPagesListBox = new System.Windows.Forms.ListBox();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.tabPagePhotos = new System.Windows.Forms.TabPage();
            this.m_vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.AppIdComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxChangeAppId = new System.Windows.Forms.TextBox();
            this.buttonChangeAppID = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLastCheckIn = new System.Windows.Forms.TextBox();
            this.textboxStatus = new System.Windows.Forms.TextBox();
            this.checkBoxRememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonPostButton = new System.Windows.Forms.Button();
            this.pictureBoxLastTaggedIn = new System.Windows.Forms.PictureBox();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.labelNextEvent = new System.Windows.Forms.Label();
            this.labelTaggedPhoto = new System.Windows.Forms.Label();
            this.labelTimeOfDay = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.buttonLoginBtn = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.labelHighestMutualLikedPagesFriend = new System.Windows.Forms.Label();
            this.pictureBoxFriendWithMutualLikedPages = new System.Windows.Forms.PictureBox();
            this.lableNumOfMutualPages = new System.Windows.Forms.Label();
            this.tabFindMutualProperties.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.groupBoxStat.SuspendLayout();
            this.groupBoxStatisticInfo.SuspendLayout();
            this.tabLikedPages.SuspendLayout();
            this.tabPagePhotos.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastTaggedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            this.tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendWithMutualLikedPages)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFindMutualProperties
            // 
            this.tabFindMutualProperties.AutoScroll = true;
            this.tabFindMutualProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabFindMutualProperties.Controls.Add(this.textBoxNoteNullFriends);
            this.tabFindMutualProperties.Controls.Add(this.labelMatchesCount);
            this.tabFindMutualProperties.Controls.Add(this.checkBoxFriendsFilter);
            this.tabFindMutualProperties.Controls.Add(this.labelPickProp);
            this.tabFindMutualProperties.Controls.Add(this.panelFriends);
            this.tabFindMutualProperties.Controls.Add(this.listBoxProfileInfoProps);
            this.tabFindMutualProperties.Controls.Add(this.buttonFilterFriends);
            this.tabFindMutualProperties.Location = new System.Drawing.Point(4, 25);
            this.tabFindMutualProperties.Name = "tabFindMutualProperties";
            this.tabFindMutualProperties.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabFindMutualProperties.Size = new System.Drawing.Size(818, 557);
            this.tabFindMutualProperties.TabIndex = 6;
            this.tabFindMutualProperties.Text = "Friends";
            // 
            // textBoxNoteNullFriends
            // 
            this.textBoxNoteNullFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.textBoxNoteNullFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoteNullFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxNoteNullFriends.Location = new System.Drawing.Point(369, 167);
            this.textBoxNoteNullFriends.Multiline = true;
            this.textBoxNoteNullFriends.Name = "textBoxNoteNullFriends";
            this.textBoxNoteNullFriends.Size = new System.Drawing.Size(218, 83);
            this.textBoxNoteNullFriends.TabIndex = 7;
            this.textBoxNoteNullFriends.Text = "Note that if you AND your friend did not fill a property, that friend will be dis" +
    "played";
            this.textBoxNoteNullFriends.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNoteNullFriends.Visible = false;
            // 
            // labelMatchesCount
            // 
            this.labelMatchesCount.AutoSize = true;
            this.labelMatchesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMatchesCount.Location = new System.Drawing.Point(25, 262);
            this.labelMatchesCount.Name = "labelMatchesCount";
            this.labelMatchesCount.Size = new System.Drawing.Size(64, 25);
            this.labelMatchesCount.TabIndex = 6;
            this.labelMatchesCount.Text = "label4";
            this.labelMatchesCount.Visible = false;
            // 
            // checkBoxFriendsFilter
            // 
            this.checkBoxFriendsFilter.AutoSize = true;
            this.checkBoxFriendsFilter.Location = new System.Drawing.Point(366, 87);
            this.checkBoxFriendsFilter.Name = "checkBoxFriendsFilter";
            this.checkBoxFriendsFilter.Size = new System.Drawing.Size(79, 21);
            this.checkBoxFriendsFilter.TabIndex = 5;
            this.checkBoxFriendsFilter.Text = "No filter";
            this.checkBoxFriendsFilter.UseVisualStyleBackColor = true;
            this.checkBoxFriendsFilter.CheckedChanged += new System.EventHandler(this.checkBoxCheckedChanged);
            // 
            // labelPickProp
            // 
            this.labelPickProp.AutoSize = true;
            this.labelPickProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickProp.Location = new System.Drawing.Point(153, 20);
            this.labelPickProp.Name = "labelPickProp";
            this.labelPickProp.Size = new System.Drawing.Size(556, 25);
            this.labelPickProp.TabIndex = 4;
            this.labelPickProp.Text = "Pick properties and find friends with the same properties!";
            // 
            // panelFriends
            // 
            this.panelFriends.AutoScroll = true;
            this.panelFriends.AutoSize = true;
            this.panelFriends.Location = new System.Drawing.Point(18, 316);
            this.panelFriends.Name = "panelFriends";
            this.panelFriends.Size = new System.Drawing.Size(779, 233);
            this.panelFriends.TabIndex = 3;
            // 
            // listBoxProfileInfoProps
            // 
            this.listBoxProfileInfoProps.FormattingEnabled = true;
            this.listBoxProfileInfoProps.ItemHeight = 16;
            this.listBoxProfileInfoProps.Location = new System.Drawing.Point(18, 87);
            this.listBoxProfileInfoProps.Name = "listBoxProfileInfoProps";
            this.listBoxProfileInfoProps.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxProfileInfoProps.Size = new System.Drawing.Size(316, 116);
            this.listBoxProfileInfoProps.TabIndex = 2;
            this.listBoxProfileInfoProps.SelectedIndexChanged += new System.EventHandler(this.listBoxProfileInfoProps_SelectedIndexChanged);
            // 
            // buttonFilterFriends
            // 
            this.buttonFilterFriends.Enabled = false;
            this.buttonFilterFriends.Location = new System.Drawing.Point(366, 114);
            this.buttonFilterFriends.Name = "buttonFilterFriends";
            this.buttonFilterFriends.Size = new System.Drawing.Size(108, 35);
            this.buttonFilterFriends.TabIndex = 1;
            this.buttonFilterFriends.Text = "Fetch friends";
            this.buttonFilterFriends.UseVisualStyleBackColor = true;
            this.buttonFilterFriends.Click += new System.EventHandler(this.buttonFilterFriends_Click);
            // 
            // tabStatistics
            // 
            this.tabStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabStatistics.Controls.Add(this.lableNumOfMutualPages);
            this.tabStatistics.Controls.Add(this.pictureBoxFriendWithMutualLikedPages);
            this.tabStatistics.Controls.Add(this.labelHighestMutualLikedPagesFriend);
            this.tabStatistics.Controls.Add(this.labelCheckStats);
            this.tabStatistics.Controls.Add(this.groupBoxStat);
            this.tabStatistics.Controls.Add(this.groupBoxStatisticInfo);
            this.tabStatistics.Controls.Add(this.buttonStats);
            this.tabStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(818, 557);
            this.tabStatistics.TabIndex = 5;
            this.tabStatistics.Text = "Statistics";
            // 
            // labelCheckStats
            // 
            this.labelCheckStats.AutoSize = true;
            this.labelCheckStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckStats.Location = new System.Drawing.Point(231, 19);
            this.labelCheckStats.Name = "labelCheckStats";
            this.labelCheckStats.Size = new System.Drawing.Size(361, 25);
            this.labelCheckStats.TabIndex = 46;
            this.labelCheckStats.Text = "Check your Facebook user statistics";
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.Controls.Add(this.labelEventsNum);
            this.groupBoxStat.Controls.Add(this.labelEvents);
            this.groupBoxStat.Controls.Add(this.labelAlbums);
            this.groupBoxStat.Controls.Add(this.labelFriendsNum);
            this.groupBoxStat.Controls.Add(this.labelAlbumsCount);
            this.groupBoxStat.Controls.Add(this.labelFriends);
            this.groupBoxStat.Location = new System.Drawing.Point(72, 102);
            this.groupBoxStat.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStat.Size = new System.Drawing.Size(309, 247);
            this.groupBoxStat.TabIndex = 44;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "Account Statistics";
            // 
            // labelEventsNum
            // 
            this.labelEventsNum.AutoSize = true;
            this.labelEventsNum.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventsNum.Location = new System.Drawing.Point(40, 200);
            this.labelEventsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventsNum.Name = "labelEventsNum";
            this.labelEventsNum.Size = new System.Drawing.Size(45, 29);
            this.labelEventsNum.TabIndex = 5;
            this.labelEventsNum.Text = "NA";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEvents.Location = new System.Drawing.Point(41, 180);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(93, 20);
            this.labelEvents.TabIndex = 4;
            this.labelEvents.Text = "Events:";
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(40, 122);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(45, 29);
            this.labelAlbums.TabIndex = 3;
            this.labelAlbums.Text = "NA";
            // 
            // labelFriendsNum
            // 
            this.labelFriendsNum.AutoSize = true;
            this.labelFriendsNum.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsNum.Location = new System.Drawing.Point(40, 52);
            this.labelFriendsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsNum.Name = "labelFriendsNum";
            this.labelFriendsNum.Size = new System.Drawing.Size(45, 29);
            this.labelFriendsNum.TabIndex = 2;
            this.labelFriendsNum.Text = "NA";
            // 
            // labelAlbumsCount
            // 
            this.labelAlbumsCount.AutoSize = true;
            this.labelAlbumsCount.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAlbumsCount.Location = new System.Drawing.Point(41, 102);
            this.labelAlbumsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbumsCount.Name = "labelAlbumsCount";
            this.labelAlbumsCount.Size = new System.Drawing.Size(81, 20);
            this.labelAlbumsCount.TabIndex = 1;
            this.labelAlbumsCount.Text = "Albums";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(41, 32);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(105, 20);
            this.labelFriends.TabIndex = 0;
            this.labelFriends.Text = "Friends:";
            // 
            // groupBoxStatisticInfo
            // 
            this.groupBoxStatisticInfo.Controls.Add(this.labelLikesNum);
            this.groupBoxStatisticInfo.Controls.Add(this.labelLikedPages);
            this.groupBoxStatisticInfo.Controls.Add(this.labelMessagesNum);
            this.groupBoxStatisticInfo.Controls.Add(this.labelPicsTaggedIn);
            this.groupBoxStatisticInfo.Controls.Add(this.labelWallPostNum);
            this.groupBoxStatisticInfo.Controls.Add(this.labelWallPosts);
            this.groupBoxStatisticInfo.Location = new System.Drawing.Point(377, 102);
            this.groupBoxStatisticInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStatisticInfo.Name = "groupBoxStatisticInfo";
            this.groupBoxStatisticInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStatisticInfo.Size = new System.Drawing.Size(361, 247);
            this.groupBoxStatisticInfo.TabIndex = 45;
            this.groupBoxStatisticInfo.TabStop = false;
            // 
            // labelLikesNum
            // 
            this.labelLikesNum.AutoSize = true;
            this.labelLikesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikesNum.Location = new System.Drawing.Point(52, 200);
            this.labelLikesNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikesNum.Name = "labelLikesNum";
            this.labelLikesNum.Size = new System.Drawing.Size(46, 29);
            this.labelLikesNum.TabIndex = 9;
            this.labelLikesNum.Text = "NA";
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLikedPages.Location = new System.Drawing.Point(52, 180);
            this.labelLikedPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(153, 20);
            this.labelLikedPages.TabIndex = 8;
            this.labelLikedPages.Text = "Liked Pages:";
            // 
            // labelMessagesNum
            // 
            this.labelMessagesNum.AutoSize = true;
            this.labelMessagesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessagesNum.Location = new System.Drawing.Point(51, 122);
            this.labelMessagesNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessagesNum.Name = "labelMessagesNum";
            this.labelMessagesNum.Size = new System.Drawing.Size(46, 29);
            this.labelMessagesNum.TabIndex = 7;
            this.labelMessagesNum.Text = "NA";
            // 
            // labelPicsTaggedIn
            // 
            this.labelPicsTaggedIn.AutoSize = true;
            this.labelPicsTaggedIn.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPicsTaggedIn.Location = new System.Drawing.Point(52, 102);
            this.labelPicsTaggedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPicsTaggedIn.Name = "labelPicsTaggedIn";
            this.labelPicsTaggedIn.Size = new System.Drawing.Size(237, 20);
            this.labelPicsTaggedIn.TabIndex = 6;
            this.labelPicsTaggedIn.Text = "Pictures tagged in:";
            // 
            // labelWallPostNum
            // 
            this.labelWallPostNum.AutoSize = true;
            this.labelWallPostNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWallPostNum.Location = new System.Drawing.Point(51, 52);
            this.labelWallPostNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallPostNum.Name = "labelWallPostNum";
            this.labelWallPostNum.Size = new System.Drawing.Size(46, 29);
            this.labelWallPostNum.TabIndex = 3;
            this.labelWallPostNum.Text = "NA";
            // 
            // labelWallPosts
            // 
            this.labelWallPosts.AutoSize = true;
            this.labelWallPosts.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWallPosts.Location = new System.Drawing.Point(52, 32);
            this.labelWallPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWallPosts.Name = "labelWallPosts";
            this.labelWallPosts.Size = new System.Drawing.Size(129, 20);
            this.labelWallPosts.TabIndex = 1;
            this.labelWallPosts.Text = "WallPosts:";
            // 
            // buttonStats
            // 
            this.buttonStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonStats.Location = new System.Drawing.Point(314, 57);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(161, 37);
            this.buttonStats.TabIndex = 3;
            this.buttonStats.Text = "Fetch Statistics";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.imageStats_Click);
            // 
            // tabLikedPages
            // 
            this.tabLikedPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabLikedPages.Controls.Add(this.labelIfNothingUserLiked);
            this.tabLikedPages.Controls.Add(this.labelFindPostLikedPages);
            this.tabLikedPages.Controls.Add(this.textBoxPageStatus);
            this.tabLikedPages.Controls.Add(this.buttonRandomPostFromAll);
            this.tabLikedPages.Controls.Add(this.buttonRandomPostFromSpecified);
            this.tabLikedPages.Controls.Add(this.buttonRecentPosts);
            this.tabLikedPages.Controls.Add(this.ListBoxLikedPagesListBox);
            this.tabLikedPages.Location = new System.Drawing.Point(4, 25);
            this.tabLikedPages.Name = "tabLikedPages";
            this.tabLikedPages.Size = new System.Drawing.Size(818, 557);
            this.tabLikedPages.TabIndex = 4;
            this.tabLikedPages.Text = "Random liked page post!";
            // 
            // labelIfNothingUserLiked
            // 
            this.labelIfNothingUserLiked.AutoSize = true;
            this.labelIfNothingUserLiked.Location = new System.Drawing.Point(16, 25);
            this.labelIfNothingUserLiked.Name = "labelIfNothingUserLiked";
            this.labelIfNothingUserLiked.Size = new System.Drawing.Size(46, 17);
            this.labelIfNothingUserLiked.TabIndex = 48;
            this.labelIfNothingUserLiked.Text = "label4";
            this.labelIfNothingUserLiked.Visible = false;
            // 
            // labelFindPostLikedPages
            // 
            this.labelFindPostLikedPages.AutoSize = true;
            this.labelFindPostLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFindPostLikedPages.Location = new System.Drawing.Point(233, 22);
            this.labelFindPostLikedPages.Name = "labelFindPostLikedPages";
            this.labelFindPostLikedPages.Size = new System.Drawing.Size(324, 25);
            this.labelFindPostLikedPages.TabIndex = 47;
            this.labelFindPostLikedPages.Text = "Find posts from your liked pages";
            // 
            // textBoxPageStatus
            // 
            this.textBoxPageStatus.Location = new System.Drawing.Point(354, 129);
            this.textBoxPageStatus.Multiline = true;
            this.textBoxPageStatus.Name = "textBoxPageStatus";
            this.textBoxPageStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPageStatus.Size = new System.Drawing.Size(445, 378);
            this.textBoxPageStatus.TabIndex = 7;
            this.textBoxPageStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRandomPostFromAll
            // 
            this.buttonRandomPostFromAll.Location = new System.Drawing.Point(662, 64);
            this.buttonRandomPostFromAll.Name = "buttonRandomPostFromAll";
            this.buttonRandomPostFromAll.Size = new System.Drawing.Size(137, 48);
            this.buttonRandomPostFromAll.TabIndex = 6;
            this.buttonRandomPostFromAll.Text = "Fetch a random post!";
            this.buttonRandomPostFromAll.UseVisualStyleBackColor = true;
            this.buttonRandomPostFromAll.Click += new System.EventHandler(this.randomPostFromAll_Click);
            // 
            // buttonRandomPostFromSpecified
            // 
            this.buttonRandomPostFromSpecified.Location = new System.Drawing.Point(510, 64);
            this.buttonRandomPostFromSpecified.Name = "buttonRandomPostFromSpecified";
            this.buttonRandomPostFromSpecified.Size = new System.Drawing.Size(137, 48);
            this.buttonRandomPostFromSpecified.TabIndex = 5;
            this.buttonRandomPostFromSpecified.Text = "Fetch random post from specified";
            this.buttonRandomPostFromSpecified.UseVisualStyleBackColor = true;
            this.buttonRandomPostFromSpecified.Click += new System.EventHandler(this.randomPostFromSpecified_Click);
            // 
            // buttonRecentPosts
            // 
            this.buttonRecentPosts.Location = new System.Drawing.Point(354, 64);
            this.buttonRecentPosts.Name = "buttonRecentPosts";
            this.buttonRecentPosts.Size = new System.Drawing.Size(137, 48);
            this.buttonRecentPosts.TabIndex = 3;
            this.buttonRecentPosts.Text = "Fetch recent posts";
            this.buttonRecentPosts.UseVisualStyleBackColor = true;
            this.buttonRecentPosts.Click += new System.EventHandler(this.recentPosts_Click);
            // 
            // ListBoxLikedPagesListBox
            // 
            this.ListBoxLikedPagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListBoxLikedPagesListBox.FormattingEnabled = true;
            this.ListBoxLikedPagesListBox.HorizontalScrollbar = true;
            this.ListBoxLikedPagesListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListBoxLikedPagesListBox.ItemHeight = 20;
            this.ListBoxLikedPagesListBox.Location = new System.Drawing.Point(13, 64);
            this.ListBoxLikedPagesListBox.Name = "ListBoxLikedPagesListBox";
            this.ListBoxLikedPagesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxLikedPagesListBox.Size = new System.Drawing.Size(304, 384);
            this.ListBoxLikedPagesListBox.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Size = new System.Drawing.Size(818, 557);
            this.tabPageEvents.TabIndex = 3;
            this.tabPageEvents.Text = "Events";
            // 
            // tabPagePhotos
            // 
            this.tabPagePhotos.AutoScroll = true;
            this.tabPagePhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabPagePhotos.Controls.Add(this.m_vScrollBar1);
            this.tabPagePhotos.Location = new System.Drawing.Point(4, 25);
            this.tabPagePhotos.Name = "tabPagePhotos";
            this.tabPagePhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhotos.Size = new System.Drawing.Size(818, 557);
            this.tabPagePhotos.TabIndex = 1;
            this.tabPagePhotos.Text = "Photos";
            // 
            // m_vScrollBar1
            // 
            this.m_vScrollBar1.Location = new System.Drawing.Point(1247, 31);
            this.m_vScrollBar1.Name = "m_vScrollBar1";
            this.m_vScrollBar1.Size = new System.Drawing.Size(33, 391);
            this.m_vScrollBar1.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.tabPageProfile.Controls.Add(this.AppIdComboBox);
            this.tabPageProfile.Controls.Add(this.textBoxChangeAppId);
            this.tabPageProfile.Controls.Add(this.buttonChangeAppID);
            this.tabPageProfile.Controls.Add(this.buttonLogout);
            this.tabPageProfile.Controls.Add(this.labelLastCheckIn);
            this.tabPageProfile.Controls.Add(this.textboxStatus);
            this.tabPageProfile.Controls.Add(this.checkBoxRememberMeCheckBox);
            this.tabPageProfile.Controls.Add(this.buttonPostButton);
            this.tabPageProfile.Controls.Add(this.pictureBoxLastTaggedIn);
            this.tabPageProfile.Controls.Add(this.labelCheckIn);
            this.tabPageProfile.Controls.Add(this.labelNextEvent);
            this.tabPageProfile.Controls.Add(this.labelTaggedPhoto);
            this.tabPageProfile.Controls.Add(this.labelTimeOfDay);
            this.tabPageProfile.Controls.Add(this.pictureBoxUserProfile);
            this.tabPageProfile.Controls.Add(this.buttonLoginBtn);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 25);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(818, 557);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            // 
            // AppIdComboBox
            // 
            this.AppIdComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.AppIdComboBox.Location = new System.Drawing.Point(632, 97);
            this.AppIdComboBox.Name = "AppIdComboBox";
            this.AppIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.AppIdComboBox.TabIndex = 22;
            // 
            // textBoxChangeAppId
            // 
            this.textBoxChangeAppId.Location = new System.Drawing.Point(399, 9);
            this.textBoxChangeAppId.Name = "textBoxChangeAppId";
            this.textBoxChangeAppId.Size = new System.Drawing.Size(261, 22);
            this.textBoxChangeAppId.TabIndex = 21;
            // 
            // buttonChangeAppID
            // 
            this.buttonChangeAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonChangeAppID.Location = new System.Drawing.Point(666, 9);
            this.buttonChangeAppID.Name = "buttonChangeAppID";
            this.buttonChangeAppID.Size = new System.Drawing.Size(126, 24);
            this.buttonChangeAppID.TabIndex = 20;
            this.buttonChangeAppID.Text = "Change AppID";
            this.buttonChangeAppID.UseVisualStyleBackColor = true;
            this.buttonChangeAppID.Click += new System.EventHandler(this.buttonChangeAppID_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(211, 109);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(95, 56);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout and exit";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelLastCheckIn
            // 
            this.labelLastCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.labelLastCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelLastCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastCheckIn.Location = new System.Drawing.Point(401, 109);
            this.labelLastCheckIn.Multiline = true;
            this.labelLastCheckIn.Name = "labelLastCheckIn";
            this.labelLastCheckIn.Size = new System.Drawing.Size(391, 65);
            this.labelLastCheckIn.TabIndex = 17;
            // 
            // textboxStatus
            // 
            this.textboxStatus.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxStatus.Location = new System.Drawing.Point(407, 243);
            this.textboxStatus.Multiline = true;
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.Size = new System.Drawing.Size(376, 210);
            this.textboxStatus.TabIndex = 15;
            this.textboxStatus.Visible = false;
            // 
            // checkBoxRememberMeCheckBox
            // 
            this.checkBoxRememberMeCheckBox.AutoSize = true;
            this.checkBoxRememberMeCheckBox.Location = new System.Drawing.Point(211, 6);
            this.checkBoxRememberMeCheckBox.Name = "checkBoxRememberMeCheckBox";
            this.checkBoxRememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.checkBoxRememberMeCheckBox.TabIndex = 19;
            this.checkBoxRememberMeCheckBox.Text = "Remember me";
            this.checkBoxRememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonPostButton
            // 
            this.buttonPostButton.Location = new System.Drawing.Point(674, 459);
            this.buttonPostButton.Name = "buttonPostButton";
            this.buttonPostButton.Size = new System.Drawing.Size(109, 37);
            this.buttonPostButton.TabIndex = 16;
            this.buttonPostButton.Text = "Post";
            this.buttonPostButton.UseVisualStyleBackColor = true;
            this.buttonPostButton.Visible = false;
            this.buttonPostButton.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // pictureBoxLastTaggedIn
            // 
            this.pictureBoxLastTaggedIn.Location = new System.Drawing.Point(31, 243);
            this.pictureBoxLastTaggedIn.Name = "pictureBoxLastTaggedIn";
            this.pictureBoxLastTaggedIn.Size = new System.Drawing.Size(275, 253);
            this.pictureBoxLastTaggedIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLastTaggedIn.TabIndex = 14;
            this.pictureBoxLastTaggedIn.TabStop = false;
            this.pictureBoxLastTaggedIn.Visible = false;
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.Location = new System.Drawing.Point(403, 184);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(60, 24);
            this.labelCheckIn.TabIndex = 13;
            this.labelCheckIn.Text = "label3";
            this.labelCheckIn.Visible = false;
            // 
            // labelNextEvent
            // 
            this.labelNextEvent.AutoSize = true;
            this.labelNextEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNextEvent.Location = new System.Drawing.Point(403, 50);
            this.labelNextEvent.Name = "labelNextEvent";
            this.labelNextEvent.Size = new System.Drawing.Size(94, 24);
            this.labelNextEvent.TabIndex = 7;
            this.labelNextEvent.Text = "nextEvent";
            this.labelNextEvent.Visible = false;
            // 
            // labelTaggedPhoto
            // 
            this.labelTaggedPhoto.AutoSize = true;
            this.labelTaggedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaggedPhoto.Location = new System.Drawing.Point(27, 213);
            this.labelTaggedPhoto.Name = "labelTaggedPhoto";
            this.labelTaggedPhoto.Size = new System.Drawing.Size(361, 20);
            this.labelTaggedPhoto.TabIndex = 6;
            this.labelTaggedPhoto.Text = "Here\'s a random picture you\'ve been tagged in!";
            this.labelTaggedPhoto.Visible = false;
            // 
            // labelTimeOfDay
            // 
            this.labelTimeOfDay.AutoSize = true;
            this.labelTimeOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOfDay.Location = new System.Drawing.Point(27, 179);
            this.labelTimeOfDay.Name = "labelTimeOfDay";
            this.labelTimeOfDay.Size = new System.Drawing.Size(53, 20);
            this.labelTimeOfDay.TabIndex = 5;
            this.labelTimeOfDay.Text = "label1";
            this.labelTimeOfDay.Visible = false;
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(31, 6);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfile.TabIndex = 3;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // buttonLoginBtn
            // 
            this.buttonLoginBtn.Location = new System.Drawing.Point(211, 36);
            this.buttonLoginBtn.Name = "buttonLoginBtn";
            this.buttonLoginBtn.Size = new System.Drawing.Size(95, 54);
            this.buttonLoginBtn.TabIndex = 2;
            this.buttonLoginBtn.Text = "Login";
            this.buttonLoginBtn.UseVisualStyleBackColor = true;
            this.buttonLoginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPageProfile);
            this.tabs.Controls.Add(this.tabPagePhotos);
            this.tabs.Controls.Add(this.tabFindMutualProperties);
            this.tabs.Controls.Add(this.tabPageEvents);
            this.tabs.Controls.Add(this.tabLikedPages);
            this.tabs.Controls.Add(this.tabStatistics);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(826, 586);
            this.tabs.TabIndex = 5;
            // 
            // labelHighestMutualLikedPagesFriend
            // 
            this.labelHighestMutualLikedPagesFriend.AutoSize = true;
            this.labelHighestMutualLikedPagesFriend.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHighestMutualLikedPagesFriend.Location = new System.Drawing.Point(9, 367);
            this.labelHighestMutualLikedPagesFriend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHighestMutualLikedPagesFriend.Name = "labelHighestMutualLikedPagesFriend";
            this.labelHighestMutualLikedPagesFriend.Size = new System.Drawing.Size(477, 20);
            this.labelHighestMutualLikedPagesFriend.TabIndex = 47;
            this.labelHighestMutualLikedPagesFriend.Text = "Friend with highest mutual liked pages:";
            // 
            // pictureBoxFriendWithMutualLikedPages
            // 
            this.pictureBoxFriendWithMutualLikedPages.Location = new System.Drawing.Point(72, 401);
            this.pictureBoxFriendWithMutualLikedPages.Name = "pictureBoxFriendWithMutualLikedPages";
            this.pictureBoxFriendWithMutualLikedPages.Size = new System.Drawing.Size(122, 115);
            this.pictureBoxFriendWithMutualLikedPages.TabIndex = 48;
            this.pictureBoxFriendWithMutualLikedPages.TabStop = false;
            // 
            // lableNumOfMutualPages
            // 
            this.lableNumOfMutualPages.AutoSize = true;
            this.lableNumOfMutualPages.Font = new System.Drawing.Font("Rod", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lableNumOfMutualPages.Location = new System.Drawing.Point(210, 401);
            this.lableNumOfMutualPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableNumOfMutualPages.Name = "lableNumOfMutualPages";
            this.lableNumOfMutualPages.Size = new System.Drawing.Size(0, 20);
            this.lableNumOfMutualPages.TabIndex = 49;
            // 
            // FormMain
            // 
            this.AccessibleDescription = "";
            this.ClientSize = new System.Drawing.Size(826, 586);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.tabFindMutualProperties.ResumeLayout(false);
            this.tabFindMutualProperties.PerformLayout();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            this.groupBoxStatisticInfo.ResumeLayout(false);
            this.groupBoxStatisticInfo.PerformLayout();
            this.tabLikedPages.ResumeLayout(false);
            this.tabLikedPages.PerformLayout();
            this.tabPagePhotos.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastTaggedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            this.tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendWithMutualLikedPages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabFindMutualProperties;
        private CheckBox checkBoxFriendsFilter;
        private Label labelPickProp;
        private Panel panelFriends;
        private ListBox listBoxProfileInfoProps;
        private Button buttonFilterFriends;
        private TabPage tabStatistics;
        private Label labelCheckStats;
        private GroupBox groupBoxStat;
        private Label labelEventsNum;
        private Label labelEvents;
        private Label labelAlbums;
        private Label labelFriendsNum;
        private Label labelAlbumsCount;
        private Label labelFriends;
        private GroupBox groupBoxStatisticInfo;
        private Label labelLikesNum;
        private Label labelLikedPages;
        private Label labelMessagesNum;
        private Label labelPicsTaggedIn;
        private Label labelWallPostNum;
        private Label labelWallPosts;
        private Button buttonStats;
        private TabPage tabLikedPages;
        private Label labelFindPostLikedPages;
        private TextBox textBoxPageStatus;
        private Button buttonRandomPostFromAll;
        private Button buttonRandomPostFromSpecified;
        private Button buttonRecentPosts;
        private ListBox ListBoxLikedPagesListBox;
        private TabPage tabPageEvents;
        private TabPage tabPagePhotos;
        private VScrollBar m_vScrollBar1;
        private TabPage tabPageProfile;
        private Button buttonLogout;
        private TextBox labelLastCheckIn;
        private TextBox textboxStatus;
        private CheckBox checkBoxRememberMeCheckBox;
        private Button buttonPostButton;
        private PictureBox pictureBoxLastTaggedIn;
        private Label labelCheckIn;
        private Label labelNextEvent;
        private Label labelTaggedPhoto;
        private Label labelTimeOfDay;
        private PictureBox pictureBoxUserProfile;
        private Button buttonLoginBtn;
        private TabControl tabs;
        private Label labelMatchesCount;
        private TextBox textBoxNoteNullFriends;
        private TextBox textBoxChangeAppId;
        private Button buttonChangeAppID;
        private Label labelIfNothingUserLiked;
        private ComboBox AppIdComboBox;
        private PictureBox pictureBoxFriendWithMutualLikedPages;
        private Label labelHighestMutualLikedPagesFriend;
        private Label lableNumOfMutualPages;
    }
}
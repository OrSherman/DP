using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormMain : Form
    {
        private const int k_itemsInLine = 4;
        private const string k_DisplayMember = "Name";
        private readonly Size r_PicturesSize = new Size(150, 150);
        private readonly Point r_PicturesStartPosition = new Point(50, 30);
        private readonly Random r_Random = new Random();
        private User m_User;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;
        private DescriptivePicturesSpreaderFacebookCollectionAdapter m_FreindSpreader;
        
        public FormMain()
        {
            this.StartPosition = FormStartPosition.Manual;
            m_AppSettings = AppSettings.LoadFromFile();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
            this.Location = m_AppSettings.LastWindowLocation;
            this.Size = m_AppSettings.LastWindowSize;
            m_FreindSpreader = new DescriptivePicturesSpreaderFacebookCollectionAdapter();
            ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.RememberUser = checkBoxRememberMeCheckBox.Checked;
            m_AppSettings.SaveToFile();
            m_AppSettings.LastAccessToken = m_AppSettings.RememberUser ? m_LoginResult.AccessToken : string.Empty;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                populateUIFromData();
            }
        }

        private void loadEvents()
        {
            new DescriptivePicturesSpreaderFacebookCollectionAdapter().LoadAndSpreadFacebookCollection<Event>(m_User.Events, r_PicturesSize, tabPageEvents, r_PicturesStartPosition, k_itemsInLine);
        }

        private void loadAlbums()
        {
            new DescriptivePicturesSpreaderFacebookCollectionAdapter().LoadAndSpreadFacebookCollection<Album>(m_User.Albums, r_PicturesSize, tabPagePhotos, r_PicturesStartPosition, k_itemsInLine);
        }
        private void loadFriends()
        {
            m_FreindSpreader.LoadFacebookCollection<User>(m_User.Friends, r_PicturesSize);
        }

        private void loginBtn_Click(object i_Sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
               m_AppSettings.AppId,
               "public_profile",
               "user_education_history",
               "user_birthday",
               "user_actions.video",
               "user_actions.news",
               "user_actions.music",
               "user_actions.fitness",
               "user_actions.books",
               "user_about_me",
               "user_friends",
               "publish_actions",
               "user_events",
               "user_games_activity",
               "user_hometown",
               "user_likes",
               "user_location",
               "user_managed_groups",
               "user_photos",
               "user_posts",
               "user_relationships",
               "user_relationship_details",
               "user_religion_politics",
               "user_tagged_places",
               "user_videos",
               "user_website",
               "user_work_history",
               "read_custom_friendlists",
               "read_page_mailboxes",
               "manage_pages",
               "publish_pages",
               "rsvp_event");
            populateUIFromData();
            buttonLogout.Visible = true;
        }

        private void populateUIFromData()
        {
            m_User = m_LoginResult.LoggedInUser; 
            initLabels();
            pictureBoxUserProfile.LoadAsync(m_User.PictureNormalURL);
            fetchLikedPages();
            new Thread(loadAlbums).Start();
            new Thread(loadEvents).Start();
            new Thread(loadFriends).Start();
        }

        private string calcTimeOfDay()
        {
            DateTime time = DateTime.Now;
            string timeOfDay;

            if (time.Hour < 4)
            {
                timeOfDay = "night";
            }
            else if (time.Hour < 12)
            {
                timeOfDay = "morning";
            }
            else if (time.Hour < 18)
            {
                timeOfDay = "afternoon";
            }
            else
            {
                timeOfDay = "evening";
            }

            return timeOfDay;
        }

        private void initLabels()
        {
            buttonLoginBtn.Visible = false;
            buttonChangeAppID.Enabled = buttonLoginBtn.Visible;
            textBoxChangeAppId.Enabled = buttonLoginBtn.Visible;
            labelTimeOfDay.Text = string.Format("Good {0}, {1}", calcTimeOfDay(), m_User.FirstName);
            labelTimeOfDay.Visible = true;

            if (m_User.PhotosTaggedIn != null && m_User.PhotosTaggedIn.Count > 0)
            {
                labelTaggedPhoto.Visible = true;
                pictureBoxLastTaggedIn.LoadAsync(m_User.PhotosTaggedIn[r_Random.Next(0, m_User.PhotosTaggedIn.Count)].PictureNormalURL);
                pictureBoxLastTaggedIn.Visible = true;
            }

            if (m_User.EventsNotYetReplied != null && m_User.EventsNotYetReplied.Count > 0)
            {
                labelNextEvent.Text = string.Format("You'r last event was: {0}{1} At {2}", System.Environment.NewLine, m_User.EventsNotYetReplied[0].Name, m_User.EventsNotYetReplied[0].StartTime.ToString());
                labelNextEvent.Visible = true;
            }

            //if (m_User.Checkins != null && m_User.Checkins.Count > 0)
            //{
            //    labelLastCheckIn.Text = string.Format("You've last {0}", m_User.Checkins[0]);
            //    labelLastCheckIn.Visible = true;
            //}
            //else
            //{
            //    labelLastCheckIn.Text = "You don't have any checkins :(";
            //}

            labelCheckIn.Text = "What's on your mind?";
            labelCheckIn.Visible = true;
            textboxStatus.Visible = true;
            buttonPostButton.Visible = true;
            listBoxProfileInfoProps.Items.Clear();
            listBoxProfileInfoProps.DisplayMember = k_DisplayMember;

            foreach (eProperties propertie in Enum.GetValues(typeof(eProperties)))
            {
                listBoxProfileInfoProps.Items.Add(propertie);
            }
        }

        private void fetchLikedPages()
        {
            ListBoxLikedPagesListBox.Items.Clear();
            ListBoxLikedPagesListBox.DisplayMember = k_DisplayMember;

            if (m_User.LikedPages.Count > 0)
            {
                foreach (object likedPage in m_User.LikedPages)
                {
                    ListBoxLikedPagesListBox.Items.Add(likedPage);
                }
            }
            else
            {
                labelIfNothingUserLiked.Text = "There are no pages you liked :(";
                labelIfNothingUserLiked.Visible = true;
            }
        }

        private void imageStats_Click(object i_Sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = int.MaxValue;
            labelFriendsNum.Text = m_User.Friends.Count.ToString();
            labelLikesNum.Text = m_User.LikedPages.Count.ToString();
            labelEventsNum.Text = m_User.Events.Count.ToString();
            labelMessagesNum.Text = m_User.PhotosTaggedIn.Count.ToString();
            labelWallPostNum.Text = m_User.WallPosts.Count.ToString();
            labelAlbums.Text = m_User.Albums.Count.ToString();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void recentPosts_Click(object i_Sender, EventArgs e)
        {
            Page selectedPages = ListBoxLikedPagesListBox.SelectedItem as Page;
            string textBox = string.Empty;

            if (ListBoxLikedPagesListBox.SelectedItems.Count == 1)
            {
                showPostFromLikedPages(5);
            }
            else if (ListBoxLikedPagesListBox.SelectedItems.Count < 5)
            {
                showPostFromLikedPages(2);
            }
            else
            {
                showPostFromLikedPages(1);
            }
        }

        private void showPostFromLikedPages(int i_PostsToFetch)
        {
            string textBox = string.Empty;

            foreach (Page page in ListBoxLikedPagesListBox.SelectedItems)
            {
                for (int i = 0; i < i_PostsToFetch; i++)
                {
                    textBox += updatePageStatus(page, i);
                }
            }

            textBoxPageStatus.Text = textBox;
        }

        private string updatePageStatus(Page i_Page, int i_PostNumber)
        {
            if (i_Page.Posts.Count >= i_PostNumber)
            {
                return string.Format("Posted by {0} On {1}.{2}{3}{4}{4}{4}", i_Page.Name, i_Page.Posts[i_PostNumber].CreatedTime, Environment.NewLine, i_Page.Posts[i_PostNumber].Message, Environment.NewLine);
            }
            else
            {
                return string.Format("{0} has no posts to show", i_Page.Name);
            }
        }

        private void randomPostFromSpecified_Click(object i_Sender, EventArgs e)
        {
            string textBox = string.Empty;
            int randomPagePick;
            int randomPostPick;
            Page selectedPages;

            if (ListBoxLikedPagesListBox.SelectedItems.Count > 0)
            {
                randomPagePick = r_Random.Next(0, ListBoxLikedPagesListBox.SelectedItems.Count);
                selectedPages = ListBoxLikedPagesListBox.SelectedItems[randomPagePick] as Page;
                randomPostPick = r_Random.Next(0, Math.Min(100, selectedPages.Posts.Count));
                textBox = updatePageStatus(selectedPages, randomPostPick);
            }

            textBoxPageStatus.Text = textBox;
        }

        private void randomPostFromAll_Click(object i_Sender, EventArgs e)
        {
            int randomPagePick;
            Page selectedPages;

            if (m_User.LikedPages.Count > 0)
            {
                randomPagePick = r_Random.Next(0, m_User.LikedPages.Count);
                selectedPages = m_User.LikedPages[randomPagePick] as Page;
                textBoxPageStatus.Text = updatePageStatus(selectedPages, 0);
            }
        }

        private void buttonFilterFriends_Click(object i_Sender, EventArgs e)
        {
            new Thread(fetchFilterdFriends).Start();
        }

        private void fetchFilterdFriends()
        {
            List<User> userFriends = new List<User>(m_User.Friends);
            DescriptivePicturesSpreader finalFriends = new DescriptivePicturesSpreader();

            panelFriends.Invoke(new Action(() => panelFriends.Controls.Clear()));

            checkFriendsMutualPropertie(userFriends);
            foreach (User friend in userFriends)
            {
                finalFriends.Add(DescriptivePictureFactory.CreateDescriptivePicture(friend, r_PicturesSize));
            }

            labelMatchesCount.Invoke(new Action(() =>
            {
                labelMatchesCount.Text = finalFriends.Count > 0 ? string.Format("Found {0} matches", finalFriends.Count) : "0 matches found";
                labelMatchesCount.Visible = true;
            }));
            panelFriends.Invoke(new Action(() => finalFriends.SpreadOnForm(panelFriends, new Point(0, 0), 4)));

        }

        private void checkFriendsMutualPropertie(List<User> i_UserFriends)
        {
            string userProp, friendProp;
            List<User> test = new List<User>(i_UserFriends);
            listBoxProfileInfoProps.Invoke(new Action(() =>
            {
                foreach (eProperties prop in listBoxProfileInfoProps.SelectedItems)
                {
                    foreach (User friend in test)
                    {
                        if (prop.ToString() == "Location" && friend.Location != null && m_User.Location != null)
                        {
                            userProp = m_User.Location.Name;
                            friendProp = friend.Location.Name;
                        }
                        else
                        {
                            userProp = m_User.GetType().GetProperty(prop.ToString()).GetValue(m_User, null) as string;
                            friendProp = friend.GetType().GetProperty(prop.ToString()).GetValue(friend, null) as string;
                        }

                        if ((userProp != friendProp && i_UserFriends.Contains(friend)) || !(userProp == null && friendProp == null))
                        {
                            i_UserFriends.Remove(friend);
                        }
                    }
                }
            }));
        }

        private void checkBoxCheckedChanged(object i_Sender, EventArgs e)
        {
            if (checkBoxFriendsFilter.Checked)
            {
                listBoxProfileInfoProps.SelectedItems.Clear();
                textBoxNoteNullFriends.Visible = false;
            }

            listBoxProfileInfoProps.Enabled = !listBoxProfileInfoProps.Enabled;
            buttonFilterFriends.Enabled = listBoxProfileInfoProps.SelectedItems.Count > 0 || checkBoxFriendsFilter.Checked;
        }

        private void buttonLogout_Click(object i_Sender, EventArgs e)
        {
            FacebookService.Logout(logout);
            this.Close();
        }

        private void listBoxProfileInfoProps_SelectedIndexChanged(object i_Sender, EventArgs e)
        {
            buttonFilterFriends.Enabled = listBoxProfileInfoProps.SelectedItems.Count > 0 || checkBoxFriendsFilter.Checked;
            textBoxNoteNullFriends.Visible = listBoxProfileInfoProps.SelectedItems.Count > 0;
        }

        private void logout()
        {
            buttonChangeAppID.Enabled = true;
            textBoxChangeAppId.Enabled = true;
        }

        private void buttonPost_Click(object i_Sender, EventArgs e)
        {
            m_User.PostStatus(textboxStatus.Text);
            MessageBox.Show("Your status has been successfuly published");
            textboxStatus.Clear();
        }

        private void buttonChangeAppID_Click(object i_Sender, EventArgs e)
        {
            m_AppSettings = AppSettings.LoadFromFile();
            m_AppSettings.AppId = textBoxChangeAppId.Text;
            login();
        }


    }
}

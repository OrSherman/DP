using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormFriend : Form
    {
        private readonly User r_FriendProfile;

        public FormFriend(User i_User)
        {
            InitializeComponent();
            r_FriendProfile = i_User;
            InitLabelsData();
            m_PictureBoxUserProfilePic.LoadAsync(i_User.PictureNormalURL);
        }

        private void InitLabelsData()
        {
            m_LabelUsername.Text = r_FriendProfile.Name;
            m_LabelUsername.Font = new Font("Times new roman", 16, FontStyle.Regular);
            m_MutualFriendsCount.Text = string.Format("{0} has {1} friends who use this app!", r_FriendProfile.FirstName, r_FriendProfile.Friends.Count);
            m_Birthday.Text = (r_FriendProfile.Birthday != null) ? string.Format("{0} was born at {1}", r_FriendProfile.FirstName, r_FriendProfile.Birthday) : string.Format("{0} did not provide his birthday", r_FriendProfile.Name);
            m_LivesIn.Text = (r_FriendProfile.Location != null) ? string.Format("{0} lives in {1}", r_FriendProfile.FirstName, r_FriendProfile.Location.Name) : string.Format("{0} did not provide his location", r_FriendProfile.Name);
            m_lastCheckIn.Text = ((r_FriendProfile.Checkins != null) && (r_FriendProfile.Checkins.Count > 0)) ? r_FriendProfile.Checkins[0].ToString() : string.Format("{0} has no checkins", r_FriendProfile.Name);
        }
    }
}

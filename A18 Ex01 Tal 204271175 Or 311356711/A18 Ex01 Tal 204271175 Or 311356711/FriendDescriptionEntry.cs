using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class FriendDescriptionEntry : DescriptivePicture
    {
        private FormFriend m_UserForm;
        private User m_Friend;

        public FriendDescriptionEntry(User i_Friend, Size i_PicBoxSize) : base(i_PicBoxSize, i_Friend.PictureNormalURL)
        {
            m_Friend = i_Friend;
            SetDescriptionText(i_Friend.Name);
        }

        protected override void Picture_Click(object i_Sender, EventArgs e)
        {
            if(m_UserForm == null)
            {
                m_UserForm = new FormFriend(m_Friend);
            }

            m_UserForm.ShowDialog();
        }
    }
}

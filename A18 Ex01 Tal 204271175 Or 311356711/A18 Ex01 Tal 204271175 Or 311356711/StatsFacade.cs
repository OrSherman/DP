using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Windows.Forms;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public class StatsFacade
    {
        private readonly User m_User;
        private readonly Size r_PicturesSize = new Size(150, 150);
        private readonly Random r_Random = new Random();

        public StatsFacade(User i_User)
        {
            m_User = i_User;
        }

        public User getHighestMutualLikedPagesFriend(ref int i_NumOfLikedPages)
        {
            User highestMutualLikedPagesFriend = m_User.Friends[0];
            int mutualLikedPagesCounter = 0;
            i_NumOfLikedPages = 0;

            foreach (User friend in m_User.Friends)
            {
                foreach (Page page in m_User.LikedPages)
                {
                    foreach (Page friendPage in friend.LikedPages)
                    {
                        if (page.Name == friendPage.Name)
                        {
                            mutualLikedPagesCounter++;
                            break;
                        }
                    }
                }

                if (mutualLikedPagesCounter > i_NumOfLikedPages)
                {
                    highestMutualLikedPagesFriend = friend;
                    i_NumOfLikedPages = mutualLikedPagesCounter;
                }

                mutualLikedPagesCounter = 0;
            }

            return highestMutualLikedPagesFriend;
        }

        internal FacebookObjectCollection<User> fetchFilterdFriends(List<eProperties> listboxItems)
        {
            FacebookObjectCollection<User> userFriends = new FacebookObjectCollection<User>();
            FacebookObjectCollection<User> tempFriendsList = new FacebookObjectCollection<User>();
            string userProp, friendProp;

            foreach (User friend in m_User.Friends)
            {
                userFriends.Add(friend);
            }

            foreach (User friend in m_User.Friends)
            {
                tempFriendsList.Add(friend);
            }

            foreach (eProperties prop in listboxItems)
            {
                foreach (User friend in tempFriendsList)
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

                    if ((userProp != friendProp && userFriends.Contains(friend)) || !(userProp == null && friendProp == null))
                    {
                        userFriends.Remove(friend);
                    }
                }
            }

            return userFriends;
        }

        public string getRecentPosts(ListBox.SelectedObjectCollection i_SelectedPages)
        {
            string textBox = string.Empty;

            if (i_SelectedPages.Count == 1)
            {
                textBox = showPostFromLikedPages(i_SelectedPages, 5);
            }
            else if (i_SelectedPages.Count < 5)
            {
                textBox = showPostFromLikedPages(i_SelectedPages, 2);
            }
            else
            {
                textBox = showPostFromLikedPages(i_SelectedPages, 1);
            }

            return textBox;
        }

        private string showPostFromLikedPages(ListBox.SelectedObjectCollection i_SelectedPages, int i_PostsToFetch)
        {
            string textBox = string.Empty;

            foreach (Page page in i_SelectedPages)
            {
                for (int i = 0; i < i_PostsToFetch; i++)
                {
                    textBox += getAndFormatPageStatus(page, i);
                }
            }

            return textBox;
        }

        public string getAndFormatPageStatus(Page i_Page, int i_PostNumber)
        {
            string textBox = string.Empty;

            if (i_Page.Posts.Count >= i_PostNumber)
            {
                textBox = string.Format("Posted by {0} On {1}.{2}{3}{4}{4}{4}", i_Page.Name, i_Page.Posts[i_PostNumber].CreatedTime, Environment.NewLine, i_Page.Posts[i_PostNumber].Message, Environment.NewLine);
            }
            else
            {
                textBox = string.Format("{0} has no posts to show", i_Page.Name);
            }

            return textBox;
        }


        public string getRandomPosts()
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
                textBox = m_StatsFacade.getAndFormatPageStatus(selectedPages, randomPostPick);
            }
        }

    }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public class StatsFacade
    {
        private readonly User m_User;

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
                foreach(Page page in m_User.LikedPages)
                {
                    foreach(Page friendPage in friend.LikedPages) 
                    {
                        if(page.Name == friendPage.Name)
                        {
                            mutualLikedPagesCounter++;
                            break;
                        }
                    }
                }

                if(mutualLikedPagesCounter > i_NumOfLikedPages)
                {
                    highestMutualLikedPagesFriend = friend;
                    i_NumOfLikedPages = mutualLikedPagesCounter;
                }

                mutualLikedPagesCounter = 0;
            }

            return highestMutualLikedPagesFriend;
        }

    }
}

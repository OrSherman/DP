using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class DescriptivePicturesSpreaderFacebookCollectionAdapter
    {
        private DescriptivePicturesSpreader m_DescriptivePicturesSpreader;

        public DescriptivePicturesSpreaderFacebookCollectionAdapter()
        {
            m_DescriptivePicturesSpreader = new DescriptivePicturesSpreader();
        }

        public void LoadFacebookCollection<T>(FacebookObjectCollection<T> i_FacebookObjectCollection, Size i_PictureSize) where T : FacebookObject
        {
            foreach (T facebookObject in i_FacebookObjectCollection)
            {
                m_DescriptivePicturesSpreader.Add(DescriptivePictureFactory.CreateDescriptivePicture(facebookObject as T, i_PictureSize));
            }
        }

        public void SpreadOnForm(ScrollableControl i_ScrollableControl, Point i_StartPosition, int i_ItemsInALine)
        {
            m_DescriptivePicturesSpreader.SpreadOnForm(i_ScrollableControl, i_StartPosition, i_ItemsInALine);
        }

        public void Add(DescriptivePicture i_DescriptivePicture)
        {
            m_DescriptivePicturesSpreader.Add(i_DescriptivePicture);
        }

        public void LoadAndSpreadFacebookCollection<T>(FacebookObjectCollection<T> i_FacebookObjectCollection, Size i_PictureSize, ScrollableControl i_ScrollableControl, Point i_StartPosition, int i_ItemsInALine) where T : FacebookObject
        {
            LoadFacebookCollection(i_FacebookObjectCollection, i_PictureSize);
            SpreadOnForm(i_ScrollableControl, i_StartPosition, i_ItemsInALine);
        }

        public int Count
        {
            get { return m_DescriptivePicturesSpreader.Count; }
        }
    }
}

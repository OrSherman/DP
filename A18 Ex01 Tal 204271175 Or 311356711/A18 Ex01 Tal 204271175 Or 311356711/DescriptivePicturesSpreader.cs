using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using System;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class DescriptivePicturesSpreader
    {
        private const int k_ItemsRelativeDistance = 30;
        private List<DescriptivePicture> m_DescriptivePictures;

        public DescriptivePicturesSpreader(DescriptivePicturesSpreader i_DescriptivePicturesSpreader)
        {
            m_DescriptivePictures = new List<DescriptivePicture>(i_DescriptivePicturesSpreader.m_DescriptivePictures);
        }

        public DescriptivePicturesSpreader()
        {
            m_DescriptivePictures = new List<DescriptivePicture>();
        }

        public void Add(DescriptivePicture i_DescriptivePicture)
        {
            m_DescriptivePictures.Add(i_DescriptivePicture);
        }

        public void SpreadOnForm(ScrollableControl i_ScrollableControl, Point i_StartPosition, int i_ItemsInALine)
        {
            Point currentPosition = i_StartPosition;
            int itemNumberInCurrentLine = 1;

            foreach (DescriptivePicture descriptivePicture in m_DescriptivePictures)
            {
                descriptivePicture.SetLocation(currentPosition);
                i_ScrollableControl.Invoke(new Action(() => descriptivePicture.AddToForm(i_ScrollableControl)));
                if (itemNumberInCurrentLine < i_ItemsInALine)
                {
                    currentPosition.X += descriptivePicture.Width + k_ItemsRelativeDistance;
                }
                else
                {
                    itemNumberInCurrentLine = 0;
                    currentPosition.X = i_StartPosition.X;
                    currentPosition.Y += descriptivePicture.Height + k_ItemsRelativeDistance;
                }

                itemNumberInCurrentLine++;
            }
        }

        public void LoadFacebookCollection<T>(FacebookObjectCollection<T> i_FacebookObjectCollection, Size i_PictureSize) where T : FacebookObject
        {
            foreach (T facebookObject in i_FacebookObjectCollection)
            {
                this.Add(DescriptivePictureFactory.CreateDescriptivePicture(facebookObject as T, i_PictureSize));
            }
        }

        public void LoadAndSpreadFacebookCollection<T>(FacebookObjectCollection<T> i_FacebookObjectCollection, Size i_PictureSize, ScrollableControl i_ScrollableControl, Point i_StartPosition, int i_ItemsInALine) where T : FacebookObject
        {
            LoadFacebookCollection(i_FacebookObjectCollection, i_PictureSize);
            SpreadOnForm(i_ScrollableControl, i_StartPosition, i_ItemsInALine);
        }

        public int Count
        {
            get { return m_DescriptivePictures.Count; }
        }
    }
}
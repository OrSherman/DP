using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.ObjectModel;

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
        public void LoadDescriptivePicturesCollection(Collection<DescriptivePicture> i_DescriptivePictures)
        {
            m_DescriptivePictures.AddRange(i_DescriptivePictures);
        }


        public void LoadAndSpreadCollection<T>(Collection<DescriptivePicture> i_DescriptivePicturesCollection, Size i_PictureSize, ScrollableControl i_ScrollableControl, Point i_StartPosition, int i_ItemsInALine) where T : FacebookObject
        {
            LoadDescriptivePicturesCollection(i_DescriptivePicturesCollection);
            SpreadOnForm(i_ScrollableControl, i_StartPosition, i_ItemsInALine);
        }

        public int Count
        {
            get { return m_DescriptivePictures.Count; }
        }
    }
}
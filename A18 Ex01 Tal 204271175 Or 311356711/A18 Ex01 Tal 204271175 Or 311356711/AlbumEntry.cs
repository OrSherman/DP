using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class AlbumEntry : DescriptivePicture
    {
        private readonly string r_AlbumDescription;
        private FormAlbum m_AlbumForm;
        private Album m_Album;

        public AlbumEntry(Album i_Album, Size i_PicBoxSize) : base(i_PicBoxSize, i_Album.PictureAlbumURL)
        {
            r_AlbumDescription = string.Format("{0}{1}{2} photos", i_Album.Name, Environment.NewLine, i_Album.Photos.Count);
            m_Album = i_Album;
            SetDescriptionText(r_AlbumDescription);
        }

        protected override void Picture_Click(object i_Sender, EventArgs e)
        {
            if(m_AlbumForm == null)
            {
                m_AlbumForm = new FormAlbum(m_Album);
            }

            m_AlbumForm.ShowDialog();
        }
    }
}

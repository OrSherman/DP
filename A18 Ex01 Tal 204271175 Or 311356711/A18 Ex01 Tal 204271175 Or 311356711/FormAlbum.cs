using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using System;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormAlbum : Form
    {
        private const int k_picturesInLine = 4;
        private readonly Size r_PicturesSize = new Size(150, 150);
        private readonly Point r_PicturesStartPosition = new Point(50, 30);
        private readonly Album r_Album;

        public FormAlbum(Album i_Album)
        {
            r_Album = i_Album;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            loadAlbumPictures();
        }

        private void loadAlbumPictures()
        {
            DescriptivePicturesSpreaderFacebookCollectionAdapter descriptivePicturesSpreader = new DescriptivePicturesSpreaderFacebookCollectionAdapter();
            descriptivePicturesSpreader.LoadFacebookCollection<Photo>(r_Album.Photos, r_PicturesSize);
            descriptivePicturesSpreader.SpreadOnForm(this, r_PicturesStartPosition, k_picturesInLine);
        }
    }
}

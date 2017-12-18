using System;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class DescriptivePhoto : DescriptivePicture
    {
        private const string k_CreatedOnString = "Uploaded at ";
        private const string k_NoDescriptionMessage = "No description";
        private readonly string r_PhotoMessage;

        public DescriptivePhoto(Photo i_Photo, Size i_PicBoxSize) : base(i_PicBoxSize, i_Photo.PictureNormalURL)
        {
            r_PhotoMessage = i_Photo.CreatedTime == null ? k_NoDescriptionMessage : string.Format("{0}{1}", k_CreatedOnString, i_Photo.CreatedTime.ToString());
            SetDescriptionText(string.Empty);
        }

        protected override void Picture_Click(object sender, EventArgs e)
        {
            MessageBox.Show(r_PhotoMessage);
        }
    }
}
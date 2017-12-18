using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal abstract class DescriptivePicture
    {
        private const int r_LabelDistanceFromPicture = 5;
        protected LazyPictureBox Picture { get; set; }
        protected TextBox TextBoxPictureDedcription { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Point Location { get; set; }

        protected DescriptivePicture(Size i_PicBoxSize, string i_PictureURL)
        {
            initializePicture(i_PicBoxSize);
            initializeTextBoxPictureDedcription();
            Width = Picture.Width;
            Height = Picture.Height + TextBoxPictureDedcription.Height;
            Picture.Load(i_PictureURL);
            SetLocation(new Point(0, 0));
        }

        public DescriptivePicture(Size i_PicBoxSize, string i_PictureURL, Point i_PictureLocation) : this(i_PicBoxSize, i_PictureURL)
        {
            SetLocation(i_PictureLocation);
        }

        private void initializePicture(Size i_PicBoxSize)
        {
            Picture = new LazyPictureBox();
            Picture.BorderStyle = BorderStyle.FixedSingle;
            Picture.Size = i_PicBoxSize;
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.Click += Picture_Click;
        }

        private void initializeTextBoxPictureDedcription()
        {
            TextBoxPictureDedcription = new TextBox();
            TextBoxPictureDedcription.Height *= 2;
            TextBoxPictureDedcription.Multiline = true;
            TextBoxPictureDedcription.BorderStyle = BorderStyle.None;
            TextBoxPictureDedcription.ReadOnly = true;
            TextBoxPictureDedcription.TextAlign = HorizontalAlignment.Center;
        }

        public void SetDescriptionText(string i_Text)
        {
            TextBoxPictureDedcription.Text = i_Text;
        }

        public void SetLocation(Point i_Location)
        {
            Picture.Location = i_Location;
            TextBoxPictureDedcription.Location = new Point(Picture.Location.X + (Picture.Width / 8), Picture.Location.Y + Picture.Height + r_LabelDistanceFromPicture);
            Width = Picture.Width;
            Height = Picture.Height + TextBoxPictureDedcription.Height;
        }

        public void AddToForm(ScrollableControl i_ScrollableControl)
        {
            TextBoxPictureDedcription.BackColor = i_ScrollableControl.BackColor;
            i_ScrollableControl.Controls.Add(Picture);
            i_ScrollableControl.Controls.Add(TextBoxPictureDedcription);
        }

        protected abstract void Picture_Click(object sender, EventArgs e);
    }
}

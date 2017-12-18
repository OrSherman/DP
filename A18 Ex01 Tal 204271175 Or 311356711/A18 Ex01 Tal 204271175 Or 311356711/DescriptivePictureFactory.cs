using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public static class DescriptivePictureFactory
    {
        private const string k_WrongArgumentExceptionMessage = "Wrong Argument!";

        internal static DescriptivePicture CreateDescriptivePicture(FacebookObject i_FacebookObject, Size i_Size)
        {
            DescriptivePicture descriptivePicture;

            if (i_FacebookObject is Album)
            {
                descriptivePicture = new AlbumEntry(i_FacebookObject as Album, i_Size);
            }
            else if(i_FacebookObject is User)
            {
                descriptivePicture = new FriendDescriptionEntry(i_FacebookObject as User, i_Size);
            }
            else if(i_FacebookObject is Event)
            {
                descriptivePicture = new EventEntry(i_FacebookObject as Event, i_Size);
            }
            else if(i_FacebookObject is Photo)
            {
                descriptivePicture = new DescriptivePhoto(i_FacebookObject as Photo, i_Size);
            }
            else
            {
                throw new ArgumentException(k_WrongArgumentExceptionMessage);
            }

            return descriptivePicture;
        }
    }
}

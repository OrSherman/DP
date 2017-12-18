using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormEvent : Form
    {
        private readonly Event r_Event;

        public FormEvent(Event i_FbEvent)
        {
            r_Event = i_FbEvent;
            InitializeComponent();
            InitLabelsData();
            pictureBoxEventPic.LoadAsync(i_FbEvent.PictureNormalURL);
        }

        private void InitLabelsData()
        {
            this.labelEventOwner.Text = string.Format("Hosted by {0}", r_Event.Owner.Name);
            this.labelEventAccess.Text = string.Format("{0}", r_Event.Privacy);
            pictureBoxEventPic.LoadAsync(r_Event.PictureNormalURL);
            this.labelEventName.Text = string.Format("{0}", r_Event.Name);
            this.labelEventTime.Text = string.Format("{0}", r_Event.StartTime);
            this.labelEventLoc.Text = string.Format("{0}", r_Event.Place);
            this.textBoxEventDescription.Text = string.Format("{0}", r_Event.Description);
        }
    }
}
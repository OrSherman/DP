using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    internal class EventEntry : DescriptivePicture
    {
        private FormEvent m_EventForm;
        private Event m_Event;

        public EventEntry(Event i_Event, Size i_PicBoxSize) : base(i_PicBoxSize, i_Event.PictureNormalURL)
        {
            m_Event = i_Event;
            SetDescriptionText(i_Event.Name);
        }

        protected override void Picture_Click(object i_Sender, EventArgs e)
        {
            if(m_EventForm == null)
            {
                m_EventForm = new FormEvent(m_Event);
            }
            m_EventForm.ShowDialog();
        }
    }
}

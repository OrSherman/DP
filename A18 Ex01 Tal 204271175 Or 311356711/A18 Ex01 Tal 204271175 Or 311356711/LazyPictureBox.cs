using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    class LazyPictureBox : PictureBox
    {
        private string m_Url;

        public new void Load(string i_UrlToLoad)
        {
            m_Url = i_UrlToLoad;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (ImageLocation == null)
            {
                LoadAsync(m_Url);
            }

            base.OnPaint(pe);
        }
    }
}

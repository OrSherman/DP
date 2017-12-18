using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelEventOwner;
        private Label labelEventAccess;
        private Label labelEventName;
        private Label labelEventTime;
        private Label labelEventLoc;
        private PictureBox pictureBoxEventPic;
        private TextBox textBoxEventDescription;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEventOwner = new System.Windows.Forms.Label();
            this.labelEventAccess = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventLoc = new System.Windows.Forms.Label();
            this.pictureBoxEventPic = new System.Windows.Forms.PictureBox();
            this.textBoxEventDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxEventPic).BeginInit();
            this.SuspendLayout();
            // 
            // EventOwner
            // 
            this.labelEventOwner.AutoSize = true;
            this.labelEventOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEventOwner.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelEventOwner.Location = new System.Drawing.Point(394, 225);
            this.labelEventOwner.Name = "EventOwner";
            this.labelEventOwner.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEventOwner.Size = new System.Drawing.Size(125, 25);
            this.labelEventOwner.TabIndex = 17;
            this.labelEventOwner.Text = "Event Owner";
            // 
            // EventAccess
            // 
            this.labelEventAccess.AutoSize = true;
            this.labelEventAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEventAccess.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelEventAccess.Location = new System.Drawing.Point(37, 225);
            this.labelEventAccess.Name = "EventAccess";
            this.labelEventAccess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEventAccess.Size = new System.Drawing.Size(132, 25);
            this.labelEventAccess.TabIndex = 16;
            this.labelEventAccess.Text = "Event Access";
            // 
            // EventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEventName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelEventName.Location = new System.Drawing.Point(394, 179);
            this.labelEventName.Name = "EventName";
            this.labelEventName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEventName.Size = new System.Drawing.Size(119, 25);
            this.labelEventName.TabIndex = 15;
            this.labelEventName.Text = "Event Name";
            // 
            // EventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEventTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelEventTime.Location = new System.Drawing.Point(37, 179);
            this.labelEventTime.Name = "EventTime";
            this.labelEventTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEventTime.Size = new System.Drawing.Size(103, 25);
            this.labelEventTime.TabIndex = 14;
            this.labelEventTime.Text = "Event time";
            // 
            // EventLoc
            // 
            this.labelEventLoc.AutoSize = true;
            this.labelEventLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEventLoc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelEventLoc.Location = new System.Drawing.Point(37, 271);
            this.labelEventLoc.Name = "EventLoc";
            this.labelEventLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEventLoc.Size = new System.Drawing.Size(136, 25);
            this.labelEventLoc.TabIndex = 13;
            this.labelEventLoc.Text = "EventLocation";
            // 
            // pictureBoxEventPic
            // 
            this.pictureBoxEventPic.Location = new System.Drawing.Point(297, 25);
            this.pictureBoxEventPic.Name = "pictureBoxEventPic";
            this.pictureBoxEventPic.Size = new System.Drawing.Size(148, 132);
            this.pictureBoxEventPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventPic.TabIndex = 12;
            this.pictureBoxEventPic.TabStop = false;
            // 
            // DescriptionBox
            // 
            this.textBoxEventDescription.Location = new System.Drawing.Point(42, 323);
            this.textBoxEventDescription.Multiline = true;
            this.textBoxEventDescription.Name = "DescriptionBox";
            this.textBoxEventDescription.ReadOnly = true;
            this.textBoxEventDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventDescription.Size = new System.Drawing.Size(652, 143);
            this.textBoxEventDescription.TabIndex = 18;
            // 
            // EventForm
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(742, 500);
            this.Controls.Add(this.textBoxEventDescription);
            this.Controls.Add(this.labelEventOwner);
            this.Controls.Add(this.labelEventAccess);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.labelEventTime);
            this.Controls.Add(this.labelEventLoc);
            this.Controls.Add(this.pictureBoxEventPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "EventForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxEventPic).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
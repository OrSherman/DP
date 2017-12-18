using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public partial class FormFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label m_LabelUsername = new System.Windows.Forms.Label();
        private Label m_MutualFriendsCount;
        private Label m_LivesIn;
        private Label m_lastCheckIn;
        private Label m_Birthday;
        private PictureBox m_PictureBoxUserProfilePic = new System.Windows.Forms.PictureBox();

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
            this.m_PictureBoxUserProfilePic = new System.Windows.Forms.PictureBox();
            this.m_LabelUsername = new System.Windows.Forms.Label();
            this.m_MutualFriendsCount = new System.Windows.Forms.Label();
            this.m_LivesIn = new System.Windows.Forms.Label();
            this.m_lastCheckIn = new System.Windows.Forms.Label();
            this.m_Birthday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)this.m_PictureBoxUserProfilePic).BeginInit();
            this.SuspendLayout();
            // 
            // m_PictureBoxUserProfilePic
            // 
            this.m_PictureBoxUserProfilePic.Location = new System.Drawing.Point(15, 12);
            this.m_PictureBoxUserProfilePic.Name = "m_PictureBoxUserProfilePic";
            this.m_PictureBoxUserProfilePic.Size = new System.Drawing.Size(100, 100);
            this.m_PictureBoxUserProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxUserProfilePic.TabIndex = 0;
            this.m_PictureBoxUserProfilePic.TabStop = false;
            // 
            // m_LabelUsername
            // 
            this.m_LabelUsername.AutoSize = true;
            this.m_LabelUsername.Location = new System.Drawing.Point(148, 32);
            this.m_LabelUsername.Name = "m_LabelUsername";
            this.m_LabelUsername.Size = new System.Drawing.Size(127, 17);
            this.m_LabelUsername.TabIndex = 2;
            this.m_LabelUsername.Text = "m_LabelUsername";
            // 
            // m_MutualFriendsCount
            // 
            this.m_MutualFriendsCount.AutoSize = true;
            this.m_MutualFriendsCount.Location = new System.Drawing.Point(12, 164);
            this.m_MutualFriendsCount.Name = "m_MutualFriendsCount";
            this.m_MutualFriendsCount.Size = new System.Drawing.Size(46, 17);
            this.m_MutualFriendsCount.TabIndex = 3;
            this.m_MutualFriendsCount.Text = "label1";
            // 
            // m_LivesIn
            // 
            this.m_LivesIn.AutoSize = true;
            this.m_LivesIn.Location = new System.Drawing.Point(12, 199);
            this.m_LivesIn.Name = "m_LivesIn";
            this.m_LivesIn.Size = new System.Drawing.Size(46, 17);
            this.m_LivesIn.TabIndex = 4;
            this.m_LivesIn.Text = "label2";
            // 
            // m_lastCheckIn
            // 
            this.m_lastCheckIn.AutoSize = true;
            this.m_lastCheckIn.Location = new System.Drawing.Point(12, 234);
            this.m_lastCheckIn.Name = "m_lastCheckIn";
            this.m_lastCheckIn.Size = new System.Drawing.Size(46, 17);
            this.m_lastCheckIn.TabIndex = 5;
            this.m_lastCheckIn.Text = "label3";
            // 
            // m_Birthday
            // 
            this.m_Birthday.AutoSize = true;
            this.m_Birthday.Location = new System.Drawing.Point(12, 133);
            this.m_Birthday.Name = "m_Birthday";
            this.m_Birthday.Size = new System.Drawing.Size(0, 17);
            this.m_Birthday.TabIndex = 8;
            // 
            // UserForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb((int)(byte)233, (int)(byte)235, (int)(byte)238);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.m_Birthday);
            this.Controls.Add(this.m_lastCheckIn);
            this.Controls.Add(this.m_LivesIn);
            this.Controls.Add(this.m_MutualFriendsCount);
            this.Controls.Add(this.m_LabelUsername);
            this.Controls.Add(this.m_PictureBoxUserProfilePic);
            this.Name = "FriendForm";
            ((System.ComponentModel.ISupportInitialize)this.m_PictureBoxUserProfilePic).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
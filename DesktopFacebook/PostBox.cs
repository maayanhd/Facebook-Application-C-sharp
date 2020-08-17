﻿using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp.UI
{
    public partial class PostBox : UserControl
    {
        private Post m_Post;
        private string m_FromName = string.Empty;

        public PostBox(Post i_Post)
        {
            InitializeComponent();
            m_Post = i_Post;

            if (i_Post.From != null)
            {
                m_FromName = i_Post.From.Name;
                loadImage(i_Post.From.PictureSmallURL);
            }
            
            setTimeAndFromHeader(i_Post.CreatedTime, m_FromName);
            insertPostContent();
        }

        private void loadImage(string i_ImageURL)
        {
            this.pictureBoxPostProfilePic.Load(i_ImageURL);
        }

        private void setTimeAndFromHeader(DateTime? i_TimePosted, string i_FromPosted)
        {
            StringBuilder timeAndFromHeader = new StringBuilder();
            if (i_TimePosted != null)
            {
                timeAndFromHeader.AppendFormat("[{0:dd/MM/yyyy H:mm:ss}] ", i_TimePosted);
            }

            timeAndFromHeader.AppendFormat("{0}", i_FromPosted);

            this.labelPostTimeAndFrom.Text = timeAndFromHeader.ToString();
        }

        private void insertPostContent()
        {
            if (m_Post.Message != null)
            {
                this.richTextBoxPost.AppendText(string.Format("{0}{1}{1}", m_Post.Message, Environment.NewLine));
            }

            if (m_Post.Description != null)
            {
                this.richTextBoxPost.AppendText(string.Format("{0}{1}{1}", m_Post.Description, Environment.NewLine));
            }
        }

        private void buttonPostLikes_Click(object i_Sender, EventArgs e)
        {
            this.richTextBoxComments.Visible = false;
            try
            {
                if (m_Post.LikedBy.Count > 0)
                {
                    foreach (User userLiked in m_Post.LikedBy)
                    {
                        this.richTextBoxLikes.AppendText(string.Format("{0}{1}", userLiked.Name, Environment.NewLine));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    string.Format("Unable to retreive post's Likes.{0}Please try again at a later time.", Environment.NewLine)
                    );
            }
            
            this.richTextBoxLikes.Visible = true;
        }

        private void buttonPostComments_Click(object i_Sender, EventArgs e)
        {
            this.richTextBoxLikes.Visible = false;
            try
            {
                if (m_Post.Comments.Count > 0)
                {
                    foreach (Comment comment in m_Post.Comments)
                    {
                        string createTimeString = formatDateTime(comment.CreatedTime);
                        this.richTextBoxLikes.AppendText(
                            string.Format(
                                "{0} {1}:{2}{3}{2}",
                                createTimeString,
                                comment.From.Name,
                                Environment.NewLine,
                                comment.Message));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                            string.Format("Unable to retreive post's Comments.{0}Please try again at a later time.", Environment.NewLine)
                            );
            }
            
            this.richTextBoxLikes.Visible = true;
        }

        private string formatDateTime(DateTime? i_dateTime)
        {
            if (i_dateTime != null)
            {
                return string.Format("[{0:dd/MM/yyyy H:mm:ss}]", i_dateTime);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook
{
     public partial class signInForm : Form
     {
          User m_LoggedInUser;
          PictureBox m_pictureBox_smallProfilePicture;




          public signInForm()
          {
               InitializeComponent();
               FacebookWrapper.FacebookService.s_CollectionLimit = 200;
               FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
          }

          private void customPictureBoxButton1_Click(object sender, EventArgs e)
          {
               loginAndInit();
               this.Enabled = false;
               this.Hide();

          }

          private void m_CheckBoxRememberMe_CheckedChanged(object sender, EventArgs e)
          {
               handleRememberingMechanism();
          }

          private void handleRememberingMechanism()
          {
          }
          private void loginAndInit()
          {
               LoginResult result = FacebookService.Login("3267288006666062",

               "public_profile",
               "email",
               "publish_to_groups",
               "user_birthday",
               "user_age_range",
               "user_gender",
               "user_link",
               "user_tagged_places",
               "user_videos",
               "publish_to_groups",
               "groups_access_member_info",
               "user_friends",
               "user_events",
               "user_likes",
               "user_location",
               "user_photos",
               "user_posts",
               "user_hometown"

               /// DEPRECATED PERMISSIONS:
               ///"publish_actions"
               ///"user_about_me",
               ///"user_education_history",
               ///"user_actions.video",
               ///"user_actions.news",
               ///"user_actions.music",
               ///"user_actions.fitness",
               ///"user_actions.books",
               ///"user_games_activity",
               ///"user_managed_groups",
               ///"user_relationships",
               ///"user_relationship_details",
               ///"user_religion_politics",
               ///"user_tagged_places",
               ///"user_website",
               ///"user_work_history",
               ///"read_custom_friendlists",
               ///"read_page_mailboxes",
               ///"manage_pages",
               ///"publish_pages",
               ///"publish_actions",
               ///"rsvp_event"
               ///"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
               ///"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
               /// "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
               /// "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
               /// "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)

               );


               if (!string.IsNullOrEmpty(result.AccessToken))
               {
                    m_LoggedInUser = result.LoggedInUser;
                    fetchUserInfo();
               }
               else
               {
                    MessageBox.Show(result.ErrorMessage);
               }
          }

          private void fetchUserInfo()
          {
               m_pictureBox_smallProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
               if (m_LoggedInUser.Posts.Count > 0)
               {
                    textBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
               }
          }

          private void customPictureBoxButton1_MouseHover(object sender, EventArgs e)
          {

          }
     }
}

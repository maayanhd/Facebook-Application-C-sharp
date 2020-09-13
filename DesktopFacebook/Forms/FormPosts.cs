using FacebookApp.UI;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
    public partial class FormPosts : Form
    {
        private PostsController PostsController { get; set; }

        public FormPosts(User i_LoggedInUser)
        {
            PostsController = new PostsController(i_LoggedInUser, this.PostsController_PostCreatedEvent, this.PostsController_ErrorMessageEvent);
            InitializeComponent();
            initializePostsForm();
        }

        private void initializePostsForm()
        {
            //PostsController.FetchUserPosts();
            new Thread(PostsController.FetchUserPosts).Start();
        }

        private void PostsController_PostCreatedEvent(object sender, EventArgs e)
        {
            //if (!this.IsHandleCreated)
            //{
            //    this.CreateHandle();
            //}
            while (!this.IsHandleCreated)
                System.Threading.Thread.Sleep(100);
            this.flowLayoutPanelPosts.Invoke(new Action(() =>
            {
                PostBox postBox = new PostBox(sender as Post);
                this.flowLayoutPanelPosts.Controls.Add(postBox);
                this.flowLayoutPanelPosts.SetFlowBreak(postBox, true);
            }));
        }

        private void PostsController_ErrorMessageEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }
    }
}

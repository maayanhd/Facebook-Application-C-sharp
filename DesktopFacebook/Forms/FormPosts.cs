using System;
using System.Threading;
using System.Windows.Forms;
using FacebookApp.UI;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebook.Forms
{
    public partial class FormPosts : Form
    {
        private ApplicationController ApplicationController { get; set; }

        public FormPosts(ApplicationController i_AppController)
        {
            ApplicationController = i_AppController;
            ApplicationController.InitializePostsService(this.PostsController_PostCreatedEvent, this.PostsController_ErrorMessageEvent);
            InitializeComponent();
            initializePostsForm();
        }

        private void initializePostsForm()
        {
            new Thread(ApplicationController.FetchUserPosts).Start();
        }

        private void PostsController_PostCreatedEvent(object sender, EventArgs e)
        {
            while (!this.IsHandleCreated)
            {
                System.Threading.Thread.Sleep(100);
            }
                
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

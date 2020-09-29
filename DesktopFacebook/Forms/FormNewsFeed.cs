using System;
using System.Threading;
using System.Windows.Forms;
using FacebookApp.UI;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebook.Forms
{
     public partial class FormNewsFeed : Form
     {
        private ApplicationController ApplicationController { get; set; }

        public FormNewsFeed(ApplicationController i_AppController)
        {
            ApplicationController = i_AppController;
            ApplicationController.InitializeNewsFeedService(this.NewsFeedController_FeedItemCreatedEvent, this.NewsFeedController_ErrorMessageEvent);
            InitializeComponent();
            new Thread(ApplicationController.FetchNewsFeed).Start();
        }

        private void NewsFeedController_FeedItemCreatedEvent(object sender, EventArgs e)
        {
            while (!this.IsHandleCreated)
            {
                System.Threading.Thread.Sleep(100);
            }

            this.flowLayoutPanelNewsFeed.Invoke(new Action(() =>
            {
                PostBox postBox = new PostBox(sender as Post);
                this.flowLayoutPanelNewsFeed.Controls.Add(postBox);
                this.flowLayoutPanelNewsFeed.SetFlowBreak(postBox, true);
            }));
        }

        private void NewsFeedController_ErrorMessageEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }
    }
}

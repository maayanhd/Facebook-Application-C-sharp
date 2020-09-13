using FacebookApp.UI;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
     public partial class FormNewsFeed : Form
     {
        //private NewsFeedController PostsController { get; set; }
        private ApplicationController ApplicationController { get; set; }

        public FormNewsFeed(ApplicationController i_AppController)
        {
            ApplicationController = i_AppController;
            ApplicationController.InitializeNewsFeedService(this.NewsFeedController_FeedItemCreatedEvent, this.NewsFeedController_ErrorMessageEvent);
            InitializeComponent();
            initializePostsForm();
        }

        private void initializePostsForm()
        {
            //PostsController.FetchNewsFeed();
            new Thread(ApplicationController.FetchNewsFeed).Start();
        }

        private void NewsFeedController_FeedItemCreatedEvent(object sender, EventArgs e)
        {
            ////if (!this.IsHandleCreated)
            //{
            //    this.CreateHandle();
            //}
            while (!this.IsHandleCreated)
                System.Threading.Thread.Sleep(100);
            this.flowLayoutPanelNewsFeed.Invoke(new Action(() =>
            {
                PostBox postBox = new PostBox(sender as Post);
                this.flowLayoutPanelNewsFeed.Controls.Add(postBox);
                this.flowLayoutPanelNewsFeed.SetFlowBreak(postBox, true);
            }));
            //PostBox postBox = new PostBox(sender as Post);
            //this.flowLayoutPanelNewsFeed.Controls.Add(postBox);
            //this.flowLayoutPanelNewsFeed.SetFlowBreak(postBox, true);
        }

        private void NewsFeedController_ErrorMessageEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender as string);
        }
    }
}

using FacebookLogic;
using FacebookLogic.Controllers;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebook.Forms
{
    public partial class FormFriends : Form
    {
        public FriendController m_FriendsController { get; private set; }
        public FormFriends(User i_LoggedInUser)
        {
            InitializeComponent();
            defineListBoxBehaviour();
            m_FriendsController = new FriendController(i_LoggedInUser, this.FormFriends_FriendItemRetrivied, this.listBoxFriends_SelectedIndexChanged);
            m_FriendsController.FetchUserFriends();
        }

        private void defineListBoxBehaviour()
        {
            this.listBoxFriends.DisplayMember = "Name";
        }

        private void FormFriends_FriendItemRetrivied(object sender, EventArgs e)
        {
            this.listBoxFriends.Items.Add(sender as User);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend(m_FriendsController.GetUserByName((listBoxFriends.SelectedItem as User).Name));
        }

        private void displaySelectedFriend(User i_SelectedFriend)
        {
            if (isThereASelectetdFriendItem())
            {
                if (i_SelectedFriend.PictureNormalURL != null)
                {
                    this.pictureBoxFriend.LoadAsync(i_SelectedFriend.PictureNormalURL);
                }

                this.labelFriendsNameData.Text = string.Format("{0} {1}", i_SelectedFriend.FirstName, i_SelectedFriend.LastName);
                this.labelFriendsBirthdayData.Text = i_SelectedFriend.Birthday != null ? i_SelectedFriend.Birthday.ToString() : "N/A";
                this.labelFriendsGenderData.Text = i_SelectedFriend.Gender != null ? i_SelectedFriend.Gender.ToString() : "N/A";
                this.labelFriendsLocationData.Text = i_SelectedFriend.Location != null ? i_SelectedFriend.Location.ToString() : "N/A";
                this.labelFriendsHometownData.Text = i_SelectedFriend.Hometown != null ? i_SelectedFriend.Hometown.ToString() : "N/A";
                this.labelFriendsRelationshipData.Text = i_SelectedFriend.RelationshipStatus != null ? i_SelectedFriend.RelationshipStatus.ToString() : "N/A";
                this.labelFriendsStatusData.Text = i_SelectedFriend.Statuses[0].Message != null ? i_SelectedFriend.Statuses[0].Message : "N/A";
            }
        }

        private bool isThereASelectetdFriendItem()
        {
            return this.listBoxFriends.SelectedItems.Count == 1;
        }
    }
}

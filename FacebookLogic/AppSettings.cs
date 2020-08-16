using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
    public sealed class AppSettings
    {
        private static AppSettings s_Instance = null;
        private readonly int r_MaxPostsAvailableToSee = 15;
        private readonly string r_AppID = "3267288006666062";
        private readonly string[] r_UserPermissions =
        //{
        //    "public_profile", "user_gender", "user_birthday", "user_hometown", "user_age_range", "user_likes",
        //    "user_photos", "user_posts", "user_friends", "user_location", "user_tagged_places", "publish_to_groups",
        //    "groups_access_member_info", "publish_pages"
        //};
        {
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
        };

        private bool m_IsUserAskingToRememberLoginDets;
        private string m_LastAccessToken;

        private AppSettings()
        {
               m_IsUserAskingToRememberLoginDets = false;
            m_LastAccessToken = string.Empty;
        }
        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new AppSettings();
                }
                else
                {
                    return s_Instance;
                }
                return s_Instance;
            }
        }

        public int MaxPostsShown
        {
            get
            {
                return r_MaxPostsAvailableToSee;
            }
        }

        public string AppID
        {
            get
            {
                return r_AppID;
            }
        }

        public string[] UserPermissions
        {
            get
            {
                return r_UserPermissions;
            }
        }

        public bool RememberUser
        {
            get
            {
                return m_IsUserAskingToRememberLoginDets;
            }

            set
            {
                    m_IsUserAskingToRememberLoginDets = value;
            }
        }

        public string LastAccessToken
        {
            get
            {
                return m_LastAccessToken;
            }

            set
            {
                m_LastAccessToken = value;
            }
        }
    }
}

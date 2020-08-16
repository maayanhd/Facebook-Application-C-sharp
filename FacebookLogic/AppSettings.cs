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
        private readonly string r_AppID = "322171932313614";
        private readonly string[] r_UserPermissions =
            {
                "public_profile", "user_gender", "user_birthday", "user_hometown", "user_age_range", "user_likes",
                "user_photos", "user_posts", "user_friends", "user_location", "user_tagged_places", "publish_to_groups",
                "groups_access_member_info", "publish_pages"
            };

        private bool m_RememberUser;
        private string m_LastAccessToken;

        private AppSettings()
        {
            m_RememberUser = false;
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
                return m_RememberUser;
            }

            set
            {
                m_RememberUser = value;
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

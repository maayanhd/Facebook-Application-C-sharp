using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
     public sealed class LoginManager
     {
          private static readonly string sr_ErrorLoginMassage = "Error: login failed. Please try again";
          private static readonly string sr_ErrorInvalidAccessTokenMassage = "Error: Invalid access token. Please try again with a different token";
          private static LoginManager s_Instance = null;
          private readonly AppSettings r_AppSettings;
          private LoginResult m_LoginResult;
          private User m_LoggedInUser;

          private LoginManager()
          {
               m_LoginResult = null;
               m_LoggedInUser = null;
               r_AppSettings = AppSettings.Instance;
          }

          public static LoginManager Instance
          {
               get
               {
                    if (s_Instance == null)
                    {
                         s_Instance = new LoginManager();
                    }

                    return s_Instance;
               }
          }

          private void saveLoginData(LoginResult i_LoginResult)
          {
               m_LoginResult = i_LoginResult;
               m_LoggedInUser = i_LoginResult.LoggedInUser;
          }

          public User LoggedInUser
          {
               get
               {
                    return m_LoggedInUser;
               }

               set
               {
                    m_LoggedInUser = value;
               }
          }

          public bool IsLoggedIn
          {
               get
               {
                    return m_LoginResult != null;
               }
          }

          public void Login()
          {
               LoginResult result;
               try
               {
                    result = FacebookService.Login(r_AppSettings.AppID, r_AppSettings.UserPermissions);
                    if (!string.IsNullOrEmpty(result.AccessToken))
                    {
                         saveLoginData(result);
                    }
               }
               catch (Exception)
               {
                    throw new Exception(sr_ErrorLoginMassage);
               }
          }

          public void Logout()
          {
               FacebookWrapper.FacebookService.Logout(logoutSuccessful);
          }

          private void logoutSuccessful()
          {
               onLogoutSuccessful(EventArgs.Empty);
          }

          public void Connect(string i_AccessToken)
          {
               try
               {
                    LoginResult res = FacebookService.Connect(i_AccessToken);
                    if (!string.IsNullOrEmpty(res.AccessToken))
                    {
                         saveLoginData(res);
                    }
               }
               catch (Exception)
               {
                    throw new Exception(sr_ErrorInvalidAccessTokenMassage);
               }
          }

          private void onLogoutSuccessful(EventArgs e)
          {
               EventHandler handler = LogoutSuccessful;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          public void directToMainForm()
          {
               onDirectedToMainForm(EventArgs.Empty);
          }

          private void onDirectedToMainForm(EventArgs e)
          {
               EventHandler handler = DirectedToMainForm;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          public event EventHandler LogoutSuccessful;
          public event EventHandler DirectedToMainForm;
     }
}


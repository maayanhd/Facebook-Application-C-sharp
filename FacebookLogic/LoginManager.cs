using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
     public sealed class LoginManager
     {
          private static readonly string sr_ErrorLoginMassage = "Error: login failed. Please try again";
          private static readonly string sr_ErrorInvalidAccessTokenMassage = "Error: Invalid access token. Please try again with a different token";
          private static readonly object sr_CreateLock = new object();
          private static LoginManager s_Instance = null;
          private readonly AppSettings r_AppSettings;
          private LoginResult m_LoginResult;
          private User m_LoggedInUser;


          public event EventHandler LogoutSuccessful;
          public event EventHandler DirectedToMainForm;

          private LoginManager()
          {
               r_AppSettings = AppSettings.Instance;
               m_LoginResult = null;
               m_LoggedInUser = null;
          }

          public static LoginManager Instance
          {
               get
               {
                    if (s_Instance == null) // Double check for 
                    {
                         lock (sr_CreateLock) // Thread safe 
                         {
                              if (s_Instance == null)
                              {
                                   s_Instance = new LoginManager();
                              }
                         }
                    }
                    
                    return s_Instance;
               }
          }

          private void logoutSuccessful()
          {
               onLogoutSuccessful(EventArgs.Empty);
          }
          private void saveLoginData(LoginResult i_LoginResult)
          {
               m_LoginResult = i_LoginResult;
               m_LoggedInUser = i_LoginResult.LoggedInUser;
          }

          public void Connect(string i_AccessToken)
          {
               try
               {
                    LoginResult loginResult = FacebookService.Connect(i_AccessToken);


                    if (!string.IsNullOrEmpty(loginResult.AccessToken))
                    {
                         saveLoginData(loginResult);
                    }
               }
               catch (Exception e)
               {
                    throw new Exception(sr_ErrorInvalidAccessTokenMassage);
               }               
          }

          #region Properties
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

          #endregion     
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
               FacebookWrapper.FacebookService.Logout(operateLogoutSuccessful, r_AppSettings.AppID);
          }

          private void operateLogoutSuccessful()
          {
               onLogoutSuccessful(EventArgs.Empty);
          }

          public void directToMainForm()
          {
               onDirectedToMainForm(EventArgs.Empty);
          }

          private void onLogoutSuccessful(EventArgs e)
          {
               EventHandler handler = LogoutSuccessful;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

          private void onDirectedToMainForm(EventArgs e)
          {
               EventHandler handler = DirectedToMainForm;
               if (handler != null)
               {
                    handler.Invoke(this, e);
               }
          }

     }
}


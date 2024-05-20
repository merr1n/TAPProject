using EventManagerFrontend.Models;

namespace EventManagerFrontend.Components
{
    public class UserState
    {
        public User CurrentUser { get; private set; }

        public bool IsLoggedIn => CurrentUser != null;

        public void LogIn(User user)
        {
            CurrentUser = user;
        }

        public void LogOut()
        {
            CurrentUser = null;
        }
    }
}

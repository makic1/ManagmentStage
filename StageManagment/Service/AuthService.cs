namespace StageManagment.Service
{
    public class AuthService
    {
        /// <summary>
        /// Singleton authService
        /// </summary>
        public static AuthService _instance;

        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthService();
                }
                return _instance;
            }
        }

        private AuthService()
        {

        }

        public bool IsAuthenticated { get; set; } = false;
        public string Username { get; set; }

        /// <summary>
        /// Set the Authenticatedstaus of true
        /// </summary>
        /// <param name="username"></param>
        public void Login(string username)
        {
            IsAuthenticated = true;
            Username = username;
        }

        /// <summary>
        /// Set the Authenticatedstaus of fals and the Username of null
        /// </summary>
        public void Logout()
        {
            IsAuthenticated = false;
            Username = string.Empty;
        }
    }
}

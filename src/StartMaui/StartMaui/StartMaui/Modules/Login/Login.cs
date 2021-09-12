namespace StartMaui.Modules.Login
{
    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }

        #region Validation
        private bool IsComplete => Message == 0;
        public bool IsValid => IsComplete;
        public int Message => string.IsNullOrEmpty(Login) && string.IsNullOrEmpty(Password) ?
                1 : !string.IsNullOrEmpty(Login) && string.IsNullOrEmpty(Password) ?
                    2 : string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password) ?
                        3 : 0;

        public Dictionary<int, string> MessagesError { get; } = new Dictionary<int, string>
        {
            {1, "Login e Senha" },
            {2, "Login" },
            {3, "Senha" },
        };
        #endregion
    }

    public class LoginResponse
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public object Image { get; }
    }
}

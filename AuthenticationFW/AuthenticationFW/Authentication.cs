namespace AuthenticationFW
{
    public class Authentication
    {
        public bool Login(string login, string password)
        {
            UserStore userStore = new UserStore();
            RsaEncryption rsaEncryption = new RsaEncryption();
            User myUser = userStore.Get(login);
            if (myUser == null)
            {
                return false;
            }
            if (myUser.Password == rsaEncryption.Encrypt(password))
            {
                return true;
            }
            return false;
        }
    }
}
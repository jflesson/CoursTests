namespace AuthenticationFW
{
    public class Authentication
    {
        readonly IUserStore userStore;
        readonly IRsaEncryption rsaEncryption;
        public Authentication()
        {
            userStore = new UserStore();
            rsaEncryption = new RsaEncryption();
        }

        public Authentication(IUserStore userStore, IRsaEncryption rsaEncryption)
        {
            this.userStore = userStore;
            this.rsaEncryption = rsaEncryption;
        }

        public bool Login(string login, string password)
        {   
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
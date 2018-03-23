namespace AuthenticationFW
{
    public class RsaEncryption : IRsaEncryption
    {
        public string Encrypt(string password)
        {
            return password;
        }
    }
}
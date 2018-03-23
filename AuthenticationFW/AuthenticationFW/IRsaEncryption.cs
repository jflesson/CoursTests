namespace AuthenticationFW
{
    public interface IRsaEncryption
    {
        string Encrypt(string password);
    }
}
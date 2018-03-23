namespace AuhenticationFW{
public class Authentication{
 public bool Login(string login, string password){
UserStore userStore = new UserStore();
RsaEncryption rsaEncryption = new RsaEncryption();
User myUser = userStore.Get(login);
if(myUser == null)
{
    return false;
}
if(myUser.Password == rsaEncryption.Encrypt(password){
return true;
}
return false;
 }
}


public class UserStore{
    public User Get(string login){
        return new User(){
            Login = login,
            Password = "password"
        };
    }
}

public class User{
    public string Login { get; set; }
    public string Password { get; set; }
}

public class RsaEncryption{
public string Encrypt(string password){
return password;
}
}
}
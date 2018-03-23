namespace Hero{
    public class FF7{
        public FF7(){
            string firstName = "Squall";
            string lastName = "Leonhart";
            Hero squall = new Hero(firstName,lastName); 
        }
    }

    public class Hero{
        public Hero(string firstName, string lastName){

        }
    }


    public interface ILogger{
        void Log(string message);
    }


    public class A{
        private string str;
    }

    public class B : A{

    }

    public abstract class Authentication{
        public abstract bool Auhenticate(string login, string password);
    }
}
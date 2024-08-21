namespace REGEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REGEX EXAMPLES");

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Email Validation");
                Console.WriteLine("2.PhoneNumber Validation");
                Console.WriteLine("3.Password Validation");
                Console.WriteLine("4.Username Validation");
                Console.WriteLine("5.Capitalize First Letter");
                Console.WriteLine("6.Url Validation");
                int option=int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        flag = false;
                        break;
                    case 1:
                        Email_Validation email=new Email_Validation();
                        email.Validate();
                        break;
                    case 2:
                        PhoneNumber_Validation phoneNumber=new PhoneNumber_Validation();
                        phoneNumber.ValidatePhoneNumber();
                        break;
                    case 3:
                        Password_Validation password=new Password_Validation();
                        password.Validate();
                        break;
                    case 4:
                        Username_Validation username=new Username_Validation();
                        username.Validate();
                        break;
                    case 5:
                        CapitlizeFirstLetter.Capitlize();
                        break;
                    case 6:
                        Url_Validation.Validate();
                        break;  
                    default:    
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}

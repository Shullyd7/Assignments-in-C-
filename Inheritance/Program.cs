using System;

namespace Inheritance
{
    class Chairman : ManagingDirector
    {
        //string nameOfCompany;

  
        static void Main(string[] args)
        {
            Chairman chairman = new Chairman();
            chairman.firstname = "Jacob";
            chairman.surname = "Adams";
            chairman.age = 40;
            chairman.gender = "Male";
            chairman.phoneNumber = "09087645624";
            chairman.nameOfCompany = "Microsoft";
           
            Console.WriteLine("Hello World!");
        }
    }
}

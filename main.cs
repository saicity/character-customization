using System;

class Customize{
    public void setGender(){
      Console.WriteLine("Are you a girl or a boy:");
      string gender = Console.ReadLine();
      Console.WriteLine("You selected: " + gender);
    }
    
    public static void Main(string[] args)
    {
        Customize user = new Customize();
        user.setGender();
    }
};

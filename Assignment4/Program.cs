using Assignment4.Abstractions;
using Assignment4.Classes;


string exit = "";
List<Users> users = new List<Users>();


while (exit != "out")
{

    string is_Subject_Exist = "no";

    Console.WriteLine("Enter Your Type{ student / teacher }");
    string Type = Convert.ToString(Console.ReadLine());
    if (Type == "out")
    {
        break;
    }

    Console.WriteLine("Enter Your Id : ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Your Name : ");
    string Name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Enter Your Age : ");
    int Age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Is ther Enrolled Subjects? {yes / no }");
    is_Subject_Exist = Console.ReadLine();
    decimal NumberOf_Subjects = 0;
    if (is_Subject_Exist == "yes")
    {
        Console.WriteLine("Enter your Number Of Subjects : ");
        NumberOf_Subjects = Convert.ToDecimal(Console.ReadLine());
    }

    if (Type == "student")
    {


        users.Add(new Students(id, Name, Age, NumberOf_Subjects));

    }

    else
    {
        users.Add(new Teachers(id, Name, Age, NumberOf_Subjects));
    }



}




foreach (Users user in users)
{
    user.Calculate();
    user.info();


}
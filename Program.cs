
//Console readline exception handling ?

using StudentClassTask;

string? name =null;
string? surname= null;
int group=0;
int point=0;



Console.Write("Enter your Name:");
name=Console.ReadLine();
Console.Write("Enter your surname:");
surname=Console.ReadLine(); 
Console.Write("Enter your group number:");
group = int.Parse(Console.ReadLine());//Bu exceptionlari duzeltmek?    
Console.Write("Enter your point:");
point = int.Parse(Console.ReadLine());


if (name!=null&&surname!=null&&group>0&&point>0)
{
    Student student = new Student(name, surname, group, point);
}















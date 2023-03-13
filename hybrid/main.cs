/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class grandfather
{
    public void native()
    {
        Console.WriteLine("grandfather native place is mahadai");
    }
    public void car()
    {
        Console.WriteLine("grandfather cars is pathmini");
    }
}
public class father:grandfather
{
    public void native()
    {
        Console.WriteLine("father native place is keelapetai");
    }
    public void age()
    {
        Console.WriteLine("Father age is 45");
    }
}
public class son:father
{
   public void age()
   {
       Console.WriteLine("son age is 23");
   }
}
public class daughter:father
{
   public void age()
   {
       Console.WriteLine("son age is 67");
   }
}
class HelloWorld {
  static void Main() {
    daughter c1=new daughter();
    c1.native();
    c1.age();
    c1.car();
    
  }
}
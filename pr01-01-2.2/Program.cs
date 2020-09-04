using System;

namespace pr01_01_2._2
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      string s = "Microsoft .NET Framework 2 Application Development Foundation";
      string[] sa = s.Split(“ “);
      // C#
      Array.Sort(sa);
      s = string.Join(" ", sa); Console.WriteLine(s);
    }
  }
}

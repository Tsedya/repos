using System;

namespace pr01_01_2
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      SByte a = 0; Byte b = 0; Int16 с =
      0; Int32 d = 0; Int64 e = 0; string s
      = "";
      Exception ex = new Exception();
      // C#
      object[] types = { a, b, c, d, e, s, ex };
      foreach (object о in types)
      {
        string type;
        if (o.GetType().IsValueType) type = "Value type";
        else
          type = "Reference Type";
        Console.WriteLine("{0}: {1}", o.GetType(), type);
      }
    }
  }
}

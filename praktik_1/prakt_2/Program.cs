﻿using System;

namespace prakt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            String s = "";
            Exception ex = new Exception();

            object[] types = {a, b, c, d, e, s, ex};
            foreach (object o in types) {
                string type;
                if (o.GetType().IsValueType) type = "Value Type";
                else type = "Reference Type";
                Console.WriteLine("{0} is {1}", o.GetType(), type);
            }
        }
    }
}

using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Shell shell = new Shell();

            for (; ; )
            {
                shell.CommandText();
            }
        }
    }

}

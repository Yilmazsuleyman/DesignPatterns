using System;

namespace Iterator.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleContainer sc = new SampleContainer();

            SampleIterator iter = (SampleIterator)sc.GetEnumerator();

            while (iter.MoveNext())
            {
                Console.WriteLine(((SampleObject) iter.Current).Value);
            }
        }
    }
}

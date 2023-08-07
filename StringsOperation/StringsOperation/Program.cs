using System;


namespace StringsOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "My name ";
            string st2 = "is ";
            string st3 = "Jennifer.";
            string wholest = st1 + st2 + st3;
            Console.WriteLine(wholest);
           // Console.ReadLine();

            string name = "Jennifer";
            Console.WriteLine(name.ToUpper());
            Console.ReadLine();

            //stringBuilder sb = new stringBuilder();
            //sb.Append("My name is Jennifer");
            //Console.WriteLine(sb);

        }
    }
}

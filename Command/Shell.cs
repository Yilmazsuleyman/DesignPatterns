using System;
using System.Collections;

namespace Command
{
    public class Shell
    {
        private Hashtable commands;
        private const string name = "FreeCSD";
        private string version = "1.0.0.0";

        public string Name { get { return name; } }
        public string Version { get { return version; } set { version = value; } }

        public Shell()
        {
            Console.Clear();
            Console.WriteLine("{0} ver: {1}", name, version);
            Console.WriteLine("===========================");
            Console.Beep(440, 1550);

            commands = new Hashtable();
            commands.Add("1st", new ListCommand());
            commands.Add("crd", new MakeDirCommand());
            commands.Add("dlt", new DelCommand());
            commands.Add("quit", new QuitCommand());
        }

        public void CommandText()
        {
            Console.Write("> ");
            string cmdtxt = Console.ReadLine();
            string[] content = cmdtxt.Split(' ');
            if (content.Length == 1)
            {
                AcceptCommand(content[0], "");
            }
            else if (content.Length == 2)
            {
                AcceptCommand(content[0], content[1]);
            }
            else
            {
                Console.WriteLine("Bad command !");
            }
        }

        private void AcceptCommand(string cmd, string path)
        {
            if (commands.ContainsKey(cmd))
            {
                Command cmnd = (Command) commands[cmd];
                cmnd.Path = path;
                cmnd.execute();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Bad command!");
            }
        }
    }
}

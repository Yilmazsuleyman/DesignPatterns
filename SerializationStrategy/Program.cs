using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class SerializationStrategy
    {
        protected object graph;
        protected Type type;

        protected SerializationStrategy(object graph)
        {
            this.graph = graph;
            this.type = this.graph.GetType();
        }

        public abstract void Persist(string path);
        public abstract object Load(string path);
    }

    public sealed class BinaryStrategy : SerializationStrategy
    {
        private BinaryFormatter formatter;
        public BinaryStrategy(object graph) : base(graph)
        {
            formatter = new BinaryFormatter();
        }
        public override void Persist(string path)
        {
            FileStream fs = File.Create(path);
            formatter.Serialize(fs, graph);
            fs.Close();
        }
        public override object Load(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);
            object tmp = formatter.Deserialize(fs);
            fs.Close();
            return tmp;
        }
        ~BinaryStrategy()
        {
            formatter = null;
        }
    }

    
}

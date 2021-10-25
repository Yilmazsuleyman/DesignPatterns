using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace YüzeyselveDerinKopyalama
{
    [Serializable]
    public abstract class PrototypeHelper<T>
    {
        //Shallow yüzeysel kopyalama
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        //Deep derin kopyalama
        public T DeepCopy()
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, this);
            ms.Seek(0, SeekOrigin.Begin);

            T tmp = (T)bf.Deserialize(ms);
            ms.Close();
            return tmp;
        }
    }

}

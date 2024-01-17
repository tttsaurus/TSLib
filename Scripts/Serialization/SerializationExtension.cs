using System.Runtime.Serialization;
using System.IO;
using System.Text;
using System;

namespace TS.TSLib.Serialization
{
    public static class SerializationExtension
    {
        public static bool TryAddValue<T>(this SerializationInfo info, string name, T value)
        {
            try
            {
                Type type = typeof(T);
                DataContractSerializer serializer = new DataContractSerializer(type);
                string text = string.Empty;
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.WriteObject(stream, value);
                    stream.Position = 0;
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        text = reader.ReadToEnd();
                    }
                }
                info.AddValue(name, text, typeof(string));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool TryGetValue<T>(this SerializationInfo info, string name, out T value)
        {
            value = default(T);
            try
            {
                string text = (string)info.GetValue(name, typeof(string));
                if (string.IsNullOrEmpty(text)) return false;

                Type type = typeof(T);
                DataContractSerializer serializer = new DataContractSerializer(type);
                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(text)))
                {
                    T obj = (T)serializer.ReadObject(stream);
                    if (obj == null)
                    {
                        return false;
                    }
                    else
                    {
                        value = obj;
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

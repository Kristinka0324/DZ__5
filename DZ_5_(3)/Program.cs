using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace DZ_5__3_
{
    [Serializable]
    class Program
    {

        static void Main()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            var array = new byte[] { 1, 2, 3 };
            for (byte i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            FileStream fs = new FileStream("File.bin", FileMode.OpenOrCreate);
            try
            {
                formatter.Serialize(fs, array);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

    }

}



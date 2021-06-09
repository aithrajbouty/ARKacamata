using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveKacamata (Kacamata1 kacamata1)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/kacamata1.tes";
        FileStream stream = new FileStream(path, FileMode.Create);

        Kacamata1Data data = new Kacamata1Data(kacamata1);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Kacamata1Data LoadKacamata1()
    {
        string path = Application.persistentDataPath + "/kacamata1.tes";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Kacamata1Data data = formatter.Deserialize(stream) as Kacamata1Data;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}

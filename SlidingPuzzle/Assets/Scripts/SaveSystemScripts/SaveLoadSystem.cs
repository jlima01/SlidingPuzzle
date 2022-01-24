using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Responsável por salvar e carregar dados em um arquivo convertido em binário.
public static class SaveLoadSystem
{
    public static void SaveData (PuzzleData puzzleData)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        
        //string path = Application.persistentDataPath + SavePathManager.GetPath();
        string path = Application.persistentDataPath + "/data2.doc";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(puzzleData);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadData()
    {
        //string path = Application.persistentDataPath + SavePathManager.GetPath();
        string path = Application.persistentDataPath + "/data2.doc";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File not Founded!");
            return null;
        }
    }

    public static void DeleteData()
    {
        string path = Application.persistentDataPath + SavePathManager.GetPath();

        if(File.Exists(path))
        {
            File.Delete(path);
        }
        else
        {
            Debug.LogError("Save File not Founded!");
        }
    }
}

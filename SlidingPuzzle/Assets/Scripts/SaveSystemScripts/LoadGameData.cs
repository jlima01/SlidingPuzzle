using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameData : MonoBehaviour
{
    public static GameData GetData()
    {
        GameData data = SaveLoadSystem.LoadData();

        return data;
    }
}

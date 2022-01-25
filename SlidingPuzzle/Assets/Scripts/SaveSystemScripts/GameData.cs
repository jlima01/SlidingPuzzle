using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Responsável por levar os dados para o sistema de save e load.
[System.Serializable]
public class GameData
{
    public float slot0 = 0;

    public GameData (PuzzleData puzzleData)
    {
        slot0 = puzzleData.slot0;
    }
}

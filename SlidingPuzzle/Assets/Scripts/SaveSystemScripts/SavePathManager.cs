using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SavePathManager : MonoBehaviour
{
    public static string pathName = "/data.doc";
    int savePath = 0;

    [SerializeField]
    private PuzzleData puzzleData;

    public UnityEvent OnFileNotFounded, OnFileFounded;

    public void ChooseSaveFile(int dataPath)
    {
        switch(dataPath)
        {
            case 0:
                savePath = 0; 
            break;

            case 1:
                savePath = 1;
            break;

            case 2:
                savePath = 2;
            break;
        }
    }

    public void SavePathFile()
    {
        switch(savePath)
        {
            case 0:
                pathName = "/data.doc";
            break;

            case 1:
                pathName = "/data2.doc";
            break;

            case 2:
                pathName = "/data3.doc";
            break;
        }
    }

    public static string GetPath()
    {
        return pathName;
    }

    public static void SetPath(string pName)
    {
        pathName = pName;
    }

    public void EraseData()
    {
       
    }

    public void SaveOptionsData()
    {
        SaveLoadSystem.SaveData(puzzleData);
    }

    public void SaveNewData()
    {
        EraseData();
        SaveLoadSystem.SaveData(puzzleData);
    }

    public void LoadData()
    {   
        switch(savePath)
        {
            case 0:
            if(SaveLoadSystem.LoadData() != null)
            {
                Load();
            }
            else
            {
                ActivateFileNotFoundAction();
            }
            break;

            case 1:
            if(SaveLoadSystem.LoadData() != null)
            {
                Load();
            }
            else
            {
                ActivateFileNotFoundAction();
            }
            break;

            case 2:
            if(SaveLoadSystem.LoadData() != null)
            {
                Load();
            }
            else
            {
                ActivateFileNotFoundAction();
            }
            break;
        }
    }

    void Load()
    {
        puzzleData.posX_0 = LoadGameData.GetData().posX_0;
        puzzleData.posY_0 = LoadGameData.GetData().posY_0;
        puzzleData.posX_1 = LoadGameData.GetData().posX_1;
        puzzleData.posY_1 = LoadGameData.GetData().posY_1;
        puzzleData.posX_2 = LoadGameData.GetData().posX_2;
        puzzleData.posY_2 = LoadGameData.GetData().posY_2;
        puzzleData.posX_3 = LoadGameData.GetData().posX_3;
        puzzleData.posY_3 = LoadGameData.GetData().posY_3;
        puzzleData.posX_4 = LoadGameData.GetData().posX_4;
        puzzleData.posY_4 = LoadGameData.GetData().posY_4;
        puzzleData.posX_5 = LoadGameData.GetData().posX_5;
        puzzleData.posY_5 = LoadGameData.GetData().posY_5;
        puzzleData.posX_6 = LoadGameData.GetData().posX_6;
        puzzleData.posY_6 = LoadGameData.GetData().posY_6;
        puzzleData.posX_7 = LoadGameData.GetData().posX_7;
        puzzleData.posY_7 = LoadGameData.GetData().posY_7;
        puzzleData.posX_8 = LoadGameData.GetData().posX_8;
        puzzleData.posY_8 = LoadGameData.GetData().posY_8;
        puzzleData.posX_9 = LoadGameData.GetData().posX_9;
        puzzleData.posY_9 = LoadGameData.GetData().posY_9;
        puzzleData.posX_10 = LoadGameData.GetData().posX_10;
        puzzleData.posY_10 = LoadGameData.GetData().posY_10;
        puzzleData.posX_11 = LoadGameData.GetData().posX_11;
        puzzleData.posY_11 = LoadGameData.GetData().posY_11;
        puzzleData.posX_12 = LoadGameData.GetData().posX_12;
        puzzleData.posY_12 = LoadGameData.GetData().posY_12;
        puzzleData.posX_13 = LoadGameData.GetData().posX_13;
        puzzleData.posY_13 = LoadGameData.GetData().posY_13;
        puzzleData.posX_14 = LoadGameData.GetData().posX_14;
        puzzleData.posY_14 = LoadGameData.GetData().posY_14;
        puzzleData.posX_15 = LoadGameData.GetData().posX_15;
        puzzleData.posY_15 = LoadGameData.GetData().posY_15;

        ActivateFileFoundedAction();
    }

    void ActivateFileNotFoundAction()
    {
        if(OnFileNotFounded != null)
        {
            OnFileNotFounded.Invoke();
        }
    }

    void ActivateFileFoundedAction()
    {
        if(OnFileFounded != null)
        {
            OnFileFounded.Invoke();
        }
    }
}

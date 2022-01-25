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
        puzzleData.slot0 = LoadGameData.GetData().slot0;

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

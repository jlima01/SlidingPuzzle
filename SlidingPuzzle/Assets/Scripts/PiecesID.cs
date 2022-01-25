using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiecesID : MonoBehaviour
{
    public Sprite[] sp;
    public int id = 0;
    public Text text;
    public static int rand = 0;

    [SerializeField]
    protected PuzzleData puzzleData;
    void Awake()
    {
        id = Random.Range(0, 15);
    }
    void Start()
    {
        text.text = "" + id;
        GetComponent<SpriteRenderer>().sprite = sp[id];
        CheckTextColor();
        CheckTextFont();
    }
    void CheckTextColor()
    {
        switch(puzzleData.textColor)
        {
            default:
                text.color = Color.black;
            break;

            case 0: 
                text.color = Color.red;
            break;

            case 1: 
                text.color = Color.blue;
            break;

            case 2: 
                text.color = Color.yellow;
            break;
        }
    }
    void CheckTextFont()
    {
        switch(puzzleData.textFont)
        {
            default:
                text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            break;

            case 0: 
                text.font = Resources.GetBuiltinResource(typeof(Font), "DancingScript-VariableFont_wght.ttf") as Font;
            break;

            case 1: 
                text.font = Resources.GetBuiltinResource(typeof(Font), "Mohave-Italic-VariableFont_wght.ttf") as Font;
            break;

            case 2: 
                text.font = Resources.GetBuiltinResource(typeof(Font), "Mohave-VariableFont_wght.ttf") as Font;
            break;
        }
    }
    public int GetPieceID()
    {
        return id;
    }
}

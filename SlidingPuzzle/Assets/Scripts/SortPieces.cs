using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortPieces : MonoBehaviour
{
    public List<GameObject> piecesList;

    public GameObject[] puzzlesArray;
    float positonInTheList;
    Vector2[] position;

    [SerializeField]
    protected PuzzleData puzzleData;
    void Start()
    {
        FillPiecesList();
        //Sort();
    }
    void FillPiecesList()
    {
        Debug.Log("Fill list" + " " + GetPieces.instance.position0);
        for(int i = 0; i < piecesList.Count; i++)
        {
            
            if(i <= 3)
            piecesList.Add(GetPieces.instance.position0[i].gameObject);
            if(i > 3 && i <= 7)
            piecesList.Add(GetPieces.instance.position1[i].gameObject);
            if(i > 7 && i <= 11)
            piecesList.Add(GetPieces.instance.position2[i].gameObject);
            if(i > 11 && i <= 15)
            piecesList.Add(GetPieces.instance.position3[i].gameObject);
        }
    }

    public void Sort()
    {
        for(int i = 0; i < piecesList.Count; i++)
        {
            positonInTheList = Random.Range(0, piecesList.Count);
            position[i] = piecesList[(int)positonInTheList].transform.position;
            puzzleData.posX_0 = position[i].x;
            puzzleData.posY_0 = position[i].y;
            piecesList.Remove(piecesList[(int)positonInTheList]);
        }
    }
    /* public void SavePuzzlePieces()
    {
        FindPuzzlePieces();

        for(int i = 0; i < piecesList.Count; i++ )
        {
            piecesList[i].GetComponent<PieceControl>().SavePuzzlesPiecesPosition();
        }
    }

    public void FindPuzzlePieces()
    {
        puzzlesArray = GameObject.FindGameObjectsWithTag("Puzzle");

        for(int i = 0; i < puzzlesArray.Length; i++)
        {
            piecesList.Add(puzzlesArray[i]);
        }
        
    } */
}

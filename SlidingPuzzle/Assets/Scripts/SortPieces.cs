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
    void Awake()
    {
        Sort();
        FillPiecesList();
    }
    void FillPiecesList()
    {
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
        /* position[0] = new Vector2(puzzleData.posX_0, puzzleData.posY_0);
        position[1] = new Vector2(puzzleData.posX_1, puzzleData.posY_1);
        position[2] = new Vector2(puzzleData.posX_2, puzzleData.posY_2);
        position[3] = new Vector2(puzzleData.posX_3, puzzleData.posY_3);
        position[4] = new Vector2(puzzleData.posX_4, puzzleData.posY_4);
        position[5] = new Vector2(puzzleData.posX_5, puzzleData.posY_5);
        position[6] = new Vector2(puzzleData.posX_6, puzzleData.posY_6);
        position[7] = new Vector2(puzzleData.posX_7, puzzleData.posY_7);
        position[8] = new Vector2(puzzleData.posX_8, puzzleData.posY_8); */

        for(int i = 0; i < piecesList.Count; i++)
        {
            positonInTheList = Random.Range(0, piecesList.Count);
            position[i] = piecesList[(int)positonInTheList].transform.position;
            puzzleData.posX_0 = position[i].x;
            puzzleData.posY_0 = position[i].y;
            piecesList.Remove(piecesList[(int)positonInTheList]);
        }
    }
    void UpdatePuzzleData(Vector2 pos)
    {
        /* puzzleData.posX_0 = pos[0];
        puzzleData.posY_0 = GenerateRandomY();
        puzzleData.posX_1 = GenerateRandomX();
        puzzleData.posY_1 = GenerateRandomY();
        puzzleData.posX_2 = GenerateRandomX();
        puzzleData.posY_2 = GenerateRandomY();
        puzzleData.posX_3 = GenerateRandomX();
        puzzleData.posY_3 = GenerateRandomY();
        puzzleData.posX_4 = GenerateRandomX();
        puzzleData.posY_4 = GenerateRandomY();
        puzzleData.posX_5 = GenerateRandomX();
        puzzleData.posY_5 = GenerateRandomY();
        puzzleData.posX_6 = GenerateRandomX();
        puzzleData.posY_6 = GenerateRandomY();
        puzzleData.posX_7 = GenerateRandomX();
        puzzleData.posY_7 = GenerateRandomY();
        puzzleData.posX_8 = GenerateRandomX();
        puzzleData.posY_8 = GenerateRandomY();
        puzzleData.posX_9 = GenerateRandomX();
        puzzleData.posY_9 = GenerateRandomY();
        puzzleData.posX_10 = GenerateRandomX();
        puzzleData.posY_10 = GenerateRandomY();
        puzzleData.posX_11 = GenerateRandomX();
        puzzleData.posY_11 = GenerateRandomY();
        puzzleData.posX_12 = GenerateRandomX();
        puzzleData.posY_12 = GenerateRandomY();
        puzzleData.posX_13 = GenerateRandomX();
        puzzleData.posY_13 = GenerateRandomY();
        puzzleData.posX_14 = GenerateRandomX();
        puzzleData.posY_14 = GenerateRandomY();
        puzzleData.posX_15 = GenerateRandomX();
        puzzleData.posY_15 = GenerateRandomY(); */
    }
    public void SavePuzzlePieces()
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
        
    }
}

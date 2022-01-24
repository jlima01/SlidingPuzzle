using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PieceControl : MonoBehaviour
{
    public int puzzleID = 0;
    bool inRightPosition, selected, acomplished, activated = false;
    public static bool puzzlesInitialized = false;
    public GameObject effect;
    public Vector2 rightPosition;

    [SerializeField]
    protected PuzzleData puzzleData;
    public UnityEvent OnRightPosition;
    void Awake()
    {
        rightPosition = this.transform.position;
        SortPuzzles();
    }
    void Start()
    {
        //pointX = Random.Range(minX, maxX);
        //pointY = Random.Range(minY, maxY);
        StartInitialPosition();
    }

    void Update()
    {
        float distance = Vector2.Distance(this.transform.position, rightPosition);

        if(distance <= 0.05f)
        {
            if(!selected)
            {
                this.transform.position = rightPosition;
                inRightPosition = true;
                ActivateInRightPositionAction();
            }
        }

        if(inRightPosition)
        {
            if(!acomplished)
            {
                //LevelAcomplishment.AddInPositionPuzzle();
                acomplished = true;
                Instantiate(effect, transform.localPosition, Quaternion.identity);
            }
        }
    }

    void StartInitialPosition()
    {
        switch(puzzleID)
        {
            case 0:
                this.transform.position = new Vector2 (puzzleData.posX_0, puzzleData.posY_0);
            break;

            case 1:
                this.transform.position = new Vector2 (puzzleData.posX_1, puzzleData.posY_1);
            break;

            case 2:
                this.transform.position = new Vector2 (puzzleData.posX_2, puzzleData.posY_2);
            break;

            case 3:
                this.transform.position = new Vector2 (puzzleData.posX_3, puzzleData.posY_3);
            break;

            case 4:
                this.transform.position = new Vector2 (puzzleData.posX_4, puzzleData.posY_4);
            break;

            case 5:
                this.transform.position = new Vector2 (puzzleData.posX_5, puzzleData.posY_5);
            break;

            case 6:
                this.transform.position = new Vector2 (puzzleData.posX_6, puzzleData.posY_6);
            break;

            case 7:
                this.transform.position = new Vector2 (puzzleData.posX_7, puzzleData.posY_7);
            break;

            case 8:
                this.transform.position = new Vector2 (puzzleData.posX_8, puzzleData.posY_8);
            break;

            case 9:
                this.transform.position = new Vector2 (puzzleData.posX_9, puzzleData.posY_9);
            break;

            case 10:
                this.transform.position = new Vector2 (puzzleData.posX_10, puzzleData.posY_10);
            break;

            case 11:
                this.transform.position = new Vector2 (puzzleData.posX_11, puzzleData.posY_11);
            break;

            case 12:
                this.transform.position = new Vector2 (puzzleData.posX_12, puzzleData.posY_12);
            break;

            case 13:
                this.transform.position = new Vector2 (puzzleData.posX_13, puzzleData.posY_13);
            break;

            case 14:
                this.transform.position = new Vector2 (puzzleData.posX_14, puzzleData.posY_14);
            break;

            case 15:
                this.transform.position = new Vector2 (puzzleData.posX_15, puzzleData.posY_15);
            break;
        }

        puzzlesInitialized = true;
    }

    public void SavePuzzlesPiecesPosition()
    {
        switch(puzzleID)
        {
            case 0:
                puzzleData.posX_0 = this.transform.position.x;
                puzzleData.posY_0 = this.transform.position.y;
            break;

            case 1:
                puzzleData.posX_1 = this.transform.position.x;
                puzzleData.posY_1 = this.transform.position.y;
            break;

            case 2:
                puzzleData.posX_2 = this.transform.position.x;
                puzzleData.posY_2 = this.transform.position.y;
            break;

            case 3:
                puzzleData.posX_3 = this.transform.position.x;
                puzzleData.posY_3 = this.transform.position.y;
            break;

            case 4:
                puzzleData.posX_4 = this.transform.position.x;
                puzzleData.posY_4 = this.transform.position.y;
            break;

            case 5:
                puzzleData.posX_5 = this.transform.position.x;
                puzzleData.posY_5 = this.transform.position.y;
            break;

            case 6:
                puzzleData.posX_6 = this.transform.position.x;
                puzzleData.posY_6 = this.transform.position.y;
            break;

            case 7:
                puzzleData.posX_7 = this.transform.position.x;
                puzzleData.posY_7 = this.transform.position.y;
            break;

            case 8:
                puzzleData.posX_8 = this.transform.position.x;
                puzzleData.posY_8 = this.transform.position.y;
            break;

            case 9:
                puzzleData.posX_9 = this.transform.position.x;
                puzzleData.posY_9 = this.transform.position.y;
            break;

            case 10:
                puzzleData.posX_10 = this.transform.position.x;
                puzzleData.posY_10 = this.transform.position.y;
            break;

            case 11:
                puzzleData.posX_11 = this.transform.position.x;
                puzzleData.posY_11 = this.transform.position.y;
            break;

            case 12:
                puzzleData.posX_12 = this.transform.position.x;
                puzzleData.posY_12 = this.transform.position.y;
            break;

            case 13:
                puzzleData.posX_13 = this.transform.position.x;
                puzzleData.posY_13 = this.transform.position.y;
            break;

            case 14:
                puzzleData.posX_14 = this.transform.position.x;
                puzzleData.posY_14 = this.transform.position.y;
            break;

            case 15:
                puzzleData.posX_15 = this.transform.position.x;
                puzzleData.posY_15 = this.transform.position.y;
            break;
        }
    }

    public void SortPuzzles()
    {
        //this.transform.position = new Vector2 (pointX, pointY);
    }

    public void ActivateInRightPositionAction()
    {
        if(OnRightPosition != null)
        {
            if(!activated)
            {
                OnRightPosition.Invoke();
                activated = true;
            }
        }
    }
}

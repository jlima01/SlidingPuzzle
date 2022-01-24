using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PieceControl : MonoBehaviour
{
    public int puzzleID = 0;

    public bool inRightPosition, selected, acomplished, activated = false;

    public static bool puzzlesInitialized = false;

    public GameObject effect;

    public Vector3 rightPosition;

    [SerializeField]
    protected PuzzleData puzzleData;

    public UnityEvent OnRightPosition;

    void Awake()
    {
        rightPosition = this.transform.position;
    }

    void Start()
    {
        //pointX = Random.Range(minX, maxX);
        //pointZ = Random.Range(minZ, maxZ);
        StartInitialPosition();
        //SortPuzzles();
    }

    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, rightPosition);

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
                //this.transform.position = new Vector3 (puzzleData.posX_0, 0, puzzleData.posZ_0);
            break;

            case 1:
                //this.transform.position = new Vector3 (puzzleData.posX_1, 0, puzzleData.posZ_1);
            break;

            case 2:
                //this.transform.position = new Vector3 (puzzleData.posX_2, 0, puzzleData.posZ_2);
            break;

            case 3:
                //this.transform.position = new Vector3 (puzzleData.posX_3, 0, puzzleData.posZ_3);
            break;

            case 4:
                //this.transform.position = new Vector3 (puzzleData.posX_4, 0, puzzleData.posZ_4);
            break;

            case 5:
                //this.transform.position = new Vector3 (puzzleData.posX_5, 0, puzzleData.posZ_5);
            break;

            case 6:
                //this.transform.position = new Vector3 (puzzleData.posX_6, 0, puzzleData.posZ_6);
            break;

            case 7:
                //this.transform.position = new Vector3 (puzzleData.posX_7, 0, puzzleData.posZ_7);
            break;

            case 8:
                //this.transform.position = new Vector3 (puzzleData.posX_8, 0, puzzleData.posZ_8);
            break;

            case 9:
                //this.transform.position = new Vector3 (puzzleData.posX_9, 0, puzzleData.posZ_9);
            break;

            case 10:
                //this.transform.position = new Vector3 (puzzleData.posX_10, 0, puzzleData.posZ_10);
            break;

            case 11:
                //this.transform.position = new Vector3 (puzzleData.posX_11, 0, puzzleData.posZ_11);
            break;

            case 12:
                //this.transform.position = new Vector3 (puzzleData.posX_12, 0, puzzleData.posZ_12);
            break;

            case 13:
                //this.transform.position = new Vector3 (puzzleData.posX_13, 0, puzzleData.posZ_13);
            break;

            case 14:
                //this.transform.position = new Vector3 (puzzleData.posX_14, 0, puzzleData.posZ_14);
            break;

            case 15:
                //this.transform.position = new Vector3 (puzzleData.posX_15, 0, puzzleData.posZ_15);
            break;
        }

        puzzlesInitialized = true;
    }

    public void SavePuzzlesPosition()
    {
        switch(puzzleID)
        {
            case 0:
                //puzzleData.posX_0 = this.transform.position.x;
                //puzzleData.posZ_0 = this.transform.position.z;
            break;

            case 1:
                //puzzleData.posX_1 = this.transform.position.x;
                //puzzleData.posZ_1 = this.transform.position.z;
            break;

            case 2:
                //puzzleData.posX_2 = this.transform.position.x;
                //puzzleData.posZ_2 = this.transform.position.z;
            break;

            case 3:
                //puzzleData.posX_3 = this.transform.position.x;
                //puzzleData.posZ_3 = this.transform.position.z;
            break;

            case 4:
                //puzzleData.posX_4 = this.transform.position.x;
                //puzzleData.posZ_4 = this.transform.position.z;
            break;

            case 5:
                //puzzleData.posX_5 = this.transform.position.x;
                //puzzleData.posZ_5 = this.transform.position.z;
            break;

            case 6:
                //puzzleData.posX_6 = this.transform.position.x;
                //puzzleData.posZ_6 = this.transform.position.z;
            break;

            case 7:
                //puzzleData.posX_7 = this.transform.position.x;
                //puzzleData.posZ_7 = this.transform.position.z;
            break;

            case 8:
                //puzzleData.posX_8 = this.transform.position.x;
                //puzzleData.posZ_8 = this.transform.position.z;
            break;

            case 9:
                //puzzleData.posX_9 = this.transform.position.x;
                //puzzleData.posZ_9 = this.transform.position.z;
            break;

            case 10:
                //puzzleData.posX_10 = this.transform.position.x;
                //puzzleData.posZ_10 = this.transform.position.z;
            break;

            case 11:
                //puzzleData.posX_11 = this.transform.position.x;
                //puzzleData.posZ_11 = this.transform.position.z;
            break;

            case 12:
                //puzzleData.posX_12 = this.transform.position.x;
                //puzzleData.posZ_12 = this.transform.position.z;
            break;

            case 13:
                //puzzleData.posX_13 = this.transform.position.x;
                //puzzleData.posZ_13 = this.transform.position.z;
            break;

            case 14:
                //puzzleData.posX_14 = this.transform.position.x;
                //puzzleData.posZ_14 = this.transform.position.z;
            break;

            case 15:
                //puzzleData.posX_15 = this.transform.position.x;
                //puzzleData.posZ_15 = this.transform.position.z;
            break;
        }
    }

    public void SortPuzzles()
    {
        //this.transform.position = new Vector3 (pointX, 0, pointZ);
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

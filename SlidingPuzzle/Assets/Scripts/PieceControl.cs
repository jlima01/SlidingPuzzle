using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PieceControl : MonoBehaviour
{
    public int puzzleID = 0;
    public List<int> piecesID;
    bool inRightPosition, activated = false;
    public GameObject effect;
    public Vector2 rightPosition;
    protected GameObject gameManager;

    [SerializeField]
    protected PuzzleData puzzleData;
    public UnityEvent OnRightPosition;
    void Awake()
    {
        inRightPosition = false;
    }
    void Start()
    {
        StartInitialPosition();
    }

    void Update()
    {
        if(!inRightPosition)
        {
            if(transform.GetChild(0).GetComponent<PiecesID>().GetPieceID() == puzzleID)
            {
                inRightPosition = true;
                PuzzleManager.instance.LevelCompleted();
                ActivateInRightPositionAction();
            }
        }
    }

    void StartInitialPosition()
    {
        
    }

    public void SavePuzzlesPiecesPosition()
    {
        
    }

    public void SortPuzzles()
    {
        
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

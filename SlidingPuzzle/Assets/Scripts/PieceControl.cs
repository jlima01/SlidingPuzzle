using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PieceControl : MonoBehaviour
{
    public int puzzleID = 0;
    bool inRightPosition, activated = false;
    public GameObject effect;
    public Vector2 rightPosition;

    [SerializeField]
    protected PuzzleData puzzleData;
    public UnityEvent OnRightPosition;
    void Awake()
    {
        rightPosition = this.transform.position;
    }
    void Start()
    {
    
    }

    void Update()
    {
        
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

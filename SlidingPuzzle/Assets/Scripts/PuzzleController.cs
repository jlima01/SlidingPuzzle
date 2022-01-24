using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public InputHandler inputHandler {get; private set;}
    public PuzzleManager puzzleManager {get; private set;}
    public PuzzleMoventAndSelectionState movementAndSelectionState {get; private set;}
    public PuzzleControllState puzzleControllState {get; private set;}
    
    [SerializeField]
    protected PuzzleData puzzleData;
    bool inSelection = false;
    private void Awake()
    {
        movementAndSelectionState = new PuzzleMoventAndSelectionState(this, puzzleData);
        puzzleControllState = new PuzzleControllState(this, puzzleData);
    }
    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
        puzzleManager = GetComponent<PuzzleManager>();
    }
     void Update()
    {
        movementAndSelectionState.LogicUpdate();
    }
    public void SetMoveSelector(float horizontal, float vertical)
    {
        if(horizontal > 0)
        {
            puzzleManager.AddPositionX();
        }

        if(horizontal < 0)
        {
            puzzleManager.SubPositionX();
        }

        if(vertical > 0)
        {
            puzzleManager.SubPositionY();
        }
        
        if(vertical < 0)
        {
            puzzleManager.AddPositionY();
        }
    }
    public void SetSelectPiece()
    {
        if(inSelection)
        {
            inSelection = false;
            puzzleManager.ChangeState(PuzzleManager.PuzzleState.MoveSelector);
        }
        else
        {
            inSelection = true;
            puzzleManager.ChangeState(PuzzleManager.PuzzleState.PuzzleSelected);
        }
    }
}

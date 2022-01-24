using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    [SerializeField]
    protected PuzzleData puzzleData;
    protected InputHandler inputHandler;
    protected PuzzleManager puzzleManager;
    private Vector2 moveInput;
    protected bool interactInput;
    float inputThreshold = 0;
    bool startCounter = false, inSelection = true;
    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
        puzzleManager = GetComponent<PuzzleManager>();
    }
    void Update()
    {
        HandleInput();
        CheckInputThreshold();
    }
    void HandleInput()
    {
        moveInput = inputHandler.MovementInput;
        interactInput = inputHandler.InteractInput;

        if(puzzleManager.GetState() == PuzzleManager.PuzzleState.MoveSelector)
        {
            MoveSelector(moveInput.x, moveInput.y);
        }

        if(interactInput)
        {
            if(!startCounter)
            {
                startCounter = true;
                SelectPeace();
            }
        }
    }
    void CheckInputThreshold()
    {
        if(startCounter)
        {
            inputThreshold += Time.deltaTime;
        }

        if(inputThreshold >= puzzleData.maxInputThreshold)
        {
            startCounter = false;
            inputThreshold = 0;
        }
    }
    void MoveSelector(float horizontal, float vertical)
    {
        if(horizontal > 0)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleManager.AddPositionX();
            }
        }

        if(horizontal < 0)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleManager.SubPositionX();
            }
        }

        if(vertical > 0)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleManager.SubPositionY();
            }
        }
        
        if(vertical < 0)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleManager.AddPositionY();
            }
        }
    }
    void SelectPeace()
    {
        if(inSelection)
        {
            inSelection = false;
            puzzleManager.ChangeState(PuzzleManager.PuzzleState.PuzzleSelected);
        }
        else
        {
            inSelection = true;
            puzzleManager.ChangeState(PuzzleManager.PuzzleState.MoveSelector);
        }
    }
}

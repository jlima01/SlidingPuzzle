using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    protected InputHandler inputHandler;
    protected PuzzleManager puzzleManager;
    private Vector2 moveInput;
    protected bool interactInput;
    public float inputThreshold = 0;
    public float maxInputThreshold = 0.25f;
    bool startCounter = false;
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

        MoveSelector(moveInput.x, moveInput.y);

        if(interactInput)
        {
            SelectPeace();
        }
    }
    void CheckInputThreshold()
    {
        if(startCounter)
        {
            inputThreshold += Time.deltaTime;
        }

        if(inputThreshold >= maxInputThreshold)
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
        
    }
}

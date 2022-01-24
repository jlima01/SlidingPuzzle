using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    protected InputHandler inputHandler;
    protected PuzzleManager puzzleManager;
    private Vector2 moveInput;
    void Start()
    {
        inputHandler = GetComponent<InputHandler>();
        puzzleManager = GetComponent<PuzzleManager>();
    }
    void Update()
    {
        HandleInput();
    }
    void HandleInput()
    {
        moveInput = inputHandler.MovementInput;

        MoveSelector(moveInput.x, moveInput.y);
    }
    void MoveSelector(float horizontal, float vertical)
    {

    }
}

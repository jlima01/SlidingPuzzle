using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMoventAndSelectionState : PuzzleControllState
{
    protected Vector2 moveInput;
    protected bool interactInput;
    float inputThreshold = 0;
    bool startCounter = false;
    public PuzzleMoventAndSelectionState(PuzzleController puzzleController, PuzzleData puzzleData): base (puzzleController, puzzleData){} 

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(puzzleController.puzzleManager.GetState() != PuzzleManager.PuzzleState.Paused)
        {
            moveInput = puzzleController.inputHandler.MovementInput;
            interactInput = puzzleController.inputHandler.InteractInput;

            //Detectar Input
            
            if(moveInput.x != 0)
            {
                if(!startCounter)
                {
                    startCounter = true;
                    puzzleController.SetMoveSelector(moveInput.x, moveInput.y);
                    puzzleController.ActivateMoveAction();
                }
            }
            else if(moveInput.y != 0)
            {
                if(!startCounter)
                {
                    startCounter = true;
                    puzzleController.SetMoveSelector(moveInput.x, moveInput.y);
                    puzzleController.ActivateMoveAction();
                }
            }

            if(interactInput)
            {
                if(!startCounter)
                {
                    startCounter = true;
                    puzzleController.SetSelectPiece();
                    puzzleController.puzzleManager.CheckIfCanSlide();
                    puzzleController.ActivateInteractAction();
                }
            }

            //Dar um pequeno tempo(cooldown) na detecção do botão(inputThreshold)

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
    }
}

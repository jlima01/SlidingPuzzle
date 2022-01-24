using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleMoventAndSelectionState : PuzzleControllState
{
    protected Vector2 moveInput;
    protected bool interactInput;
    float inputThreshold = 0;
    bool startCounter = false;
    public PuzzleMoventAndSelectionState(PuzzleController puzzleControler, PuzzleData puzzleData): base (puzzleControler, puzzleData){} 

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        moveInput = puzzleControler.inputHandler.MovementInput;
        interactInput = puzzleControler.inputHandler.InteractInput;

        //Detectar Input
        
        if(moveInput.x != 0 || moveInput.y != 0)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleControler.SetMoveSelector(moveInput.x, moveInput.y);
            }
        }

        if(interactInput)
        {
            if(!startCounter)
            {
                startCounter = true;
                puzzleControler.SetSelectPeace();
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

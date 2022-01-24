using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleControllState
{
    protected PuzzleController puzzleController;
    protected InputHandler inputHandler;
    protected PuzzleManager puzzleManager;
    protected PuzzleData puzzleData;
    public PuzzleControllState(PuzzleController puzzleController, PuzzleData puzzleData)
    {
        this.puzzleController = puzzleController;
        this.puzzleData = puzzleData;
    }
    public virtual void LogicUpdate(){}
}

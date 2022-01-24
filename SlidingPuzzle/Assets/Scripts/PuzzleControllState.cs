using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleControllState
{
    protected PuzzleController puzzleControler;
    protected InputHandler inputHandler;
    protected PuzzleManager puzzleManager;
    protected PuzzleData puzzleData;
    public PuzzleControllState(PuzzleController puzzleControler, PuzzleData puzzleData)
    {
        this.puzzleControler = puzzleControler;
        this.puzzleData = puzzleData;
    }
    public virtual void LogicUpdate(){}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    #region Variáveis
    public Vector2 selectorPosition = new Vector2(0,0);
    public GameObject selector;

    #endregion

    public enum PuzzleState
    {
        MoveSelector,
        PuzzleSelected,
    }

    [SerializeField]
    private PuzzleState puzzleState;
    private void Awake()
    {
        puzzleState = PuzzleState.MoveSelector;
    }
    void Update()
    {
        CheckPuzzleState();
    }
    void CheckPuzzleState()
    {
        switch(puzzleState)
        {
            default:

            case PuzzleState.MoveSelector:
                CheckMoveSelectorRules();
                MoveSelector();
            break;

            case PuzzleState.PuzzleSelected:
            
            break;
        }
    }
    
    #region Checagem de regras.
    void CheckMoveSelectorRules()
    {
        #region regras de posição do tabuleiro
        if(selectorPosition.x > 3)
        {
            selectorPosition.x = 0;
        }

        if(selectorPosition.y > 3)
        {
            selectorPosition.y = 0;
        }

        if(selectorPosition.x < 0)
        {
            selectorPosition.x = 3;
        }

        if(selectorPosition.y < 0)
        {
            selectorPosition.y = 3;
        }
        #endregion
    }
    #endregion

    #region Métodos de adição e subtração de posição das peças(Movimentar as peças)
    public void AddPositionX()
    {
        selectorPosition.x += 1;
    }
    public void AddPositionY()
    {
        selectorPosition.y += 1;
    }
    public void SubPositionX()
    {
        selectorPosition.x -= 1;
    }
    public void SubPositionY()
    {
        selectorPosition.y -= 1;
    }
    #endregion

    void MoveSelector()
    {
        switch (selectorPosition.y)
        {
            default:

            case 0:
                selector.transform.position = PeacesPositionGenerator.instance.position0[(int)selectorPosition.x];
            break;

            case 1:
                selector.transform.position = PeacesPositionGenerator.instance.position1[(int)selectorPosition.x];
            break;

            case 2:
                selector.transform.position = PeacesPositionGenerator.instance.position2[(int)selectorPosition.x];
            break;

            case 3:
                selector.transform.position = PeacesPositionGenerator.instance.position3[(int)selectorPosition.x];
            break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    #region Variáveis

    [SerializeField]
    protected PuzzleState puzzleState;
    private Vector2 selectorPosition = new Vector2(0,0);
    private Vector2 initialPosition;
    public GameObject selector, peaceSelected;
    public Transform currentPeace, selectedPeace;
    bool initialPositionDefined;

    #endregion

    public enum PuzzleState
    {
        MoveSelector,
        PuzzleSelected,
        Paused,
    }
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
                selectedPeace = null;
                initialPositionDefined = false;
                CheckMoveSelectorRules();
                MoveSelection(selector.transform, peaceSelected.transform);
                peaceSelected.SetActive(false);
                selector.SetActive(true);
            break;

            case PuzzleState.PuzzleSelected:

                if(!initialPositionDefined)
                {
                    initialPositionDefined = true;
                    initialPosition = selectorPosition;
                    selectedPeace = currentPeace;
                }
                
                CheckMoveSelectedRules();
                MoveSelection(peaceSelected.transform, selector.transform);
                peaceSelected.SetActive(true);
                selector.SetActive(false);
            break;

            case PuzzleState.Paused:
            break;
        }
    }

    #region Checagem de regras.

    #region regras de posição do tabuleiro
    void CheckMoveSelectorRules()
    {
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
    }

    #endregion

    #region regras de posição de peça selecionada

    void CheckMoveSelectedRules()
    {
         if(selectorPosition.x > 3)
        {
            selectorPosition.x = 3;
        }

        if(selectorPosition.y > 3)
        {
            selectorPosition.y = 3;
        }

        if(selectorPosition.x < 0)
        {
            selectorPosition.x = 0;
        }

        if(selectorPosition.y < 0)
        {
            selectorPosition.y = 0;
        } 

        if(selectorPosition.x > initialPosition.x + 1)
        {
            selectorPosition.x = initialPosition.x + 1;
        }

        if(selectorPosition.x < initialPosition.x - 1)
        {
            selectorPosition.x = initialPosition.x - 1;
        }

        if(selectorPosition.y > initialPosition.y + 1)
        {
            selectorPosition.y = initialPosition.y + 1;
        }

        if(selectorPosition.y < initialPosition.y - 1)
        {
            selectorPosition.y = initialPosition.y - 1;
        }
    }   

    #endregion

    #region Checar regra de Slide, troca de peças

    public void CheckIfCanSlide()
    {
        if(selectedPeace != null && currentPeace != null && selectedPeace.GetChild(0).gameObject != null && currentPeace.GetChild(0).gameObject != null)
        {
            if(currentPeace.GetChild(0).gameObject.tag == "Empty")
            {
                currentPeace.GetChild(0).SetParent(selectedPeace.transform, false);
                selectedPeace.GetChild(0).SetParent(currentPeace.transform, false);
            }
        }
    }

    #endregion
    
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

    #region Mover seletor e peça selecionada (Quadrados Verde e Vermelho)

    void MoveSelection(Transform selection1, Transform selection2)
    {
        switch (selectorPosition.y)
        {
            default:

            case 0:
                selection1.position = GetPieces.instance.position0[(int)selectorPosition.x].position;
                selection2.position = selection1.position;
                currentPeace = GetPieces.instance.position0[(int)selectorPosition.x];
            break;

            case 1:
                selection1.position = GetPieces.instance.position1[(int)selectorPosition.x].position;
                selection2.position = selection1.position;
                currentPeace = GetPieces.instance.position1[(int)selectorPosition.x];
            break;

            case 2:
                selection1.position = GetPieces.instance.position2[(int)selectorPosition.x].position;
                selection2.position = selection1.position;
                currentPeace = GetPieces.instance.position2[(int)selectorPosition.x];
            break;

            case 3:
                selection1.position = GetPieces.instance.position3[(int)selectorPosition.x].position;
                selection2.position = selection1.position;
                currentPeace = GetPieces.instance.position3[(int)selectorPosition.x];
            break;
        }
    }

    #endregion
    public void ChangeState(PuzzleState stateID)
    {
        puzzleState = stateID;
    }
    public PuzzleState GetState()
    {
        return puzzleState;
    }
}

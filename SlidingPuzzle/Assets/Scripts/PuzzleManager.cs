using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    #region Variáveis
    public GameObject[] slots;
    public List <Vector3> position1;
    public List <Vector3> position2;
    public List <Vector3> position3;
    public List <Vector3> position4;
    public Vector2 selectorPosition = new Vector2(0,0);
    public GameObject selector;

    #endregion
    void Start()
    {
        //Pegar slots(containers das peças) e posição das peças. 
        slots = GameObject.FindGameObjectsWithTag("Slot");
        CheckPosition();
        selectorPosition = new Vector2(1,1);
    }
    void Update()
    {
        CheckGameRules();
        MoveSelector();
    }
    void CheckPosition()
    {
        //Salva a posição das peças para move-las corretamente no tabuleiro

        for(int i = 0; i < slots.Length; i++)
        {
            if(i <= 3)
            position1.Add(slots[i].transform.position);
            if(i > 3 && i <= 7)
            position2.Add(slots[i].transform.position);
            if(i > 7 && i <= 11)
            position3.Add(slots[i].transform.position);
            if(i > 11 && i <= 15)
            position4.Add(slots[i].transform.position);
        }
    }
    void CheckGameRules()
    {
        #region regras de posição do tabuleiro
        if(selectorPosition.x > 4)
        {
            selectorPosition.x = 1;
        }

        if(selectorPosition.y > 4)
        {
            selectorPosition.y = 1;
        }

        if(selectorPosition.x < 1)
        {
            selectorPosition.x = 4;
        }

        if(selectorPosition.y < 1)
        {
            selectorPosition.y = 4;
        }
        #endregion
    }
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
        //selector.transform.position = 
    }
}

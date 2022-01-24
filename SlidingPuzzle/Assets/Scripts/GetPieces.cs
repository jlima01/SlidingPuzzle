using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPieces : MonoBehaviour
{
    public static GetPieces instance;
    public GameObject[] slots;
    public List <Transform> position0;
    public List <Transform> position1;
    public List <Transform> position2;
    public List <Transform> position3;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //Pegar slots(containers das peças) e posição das peças(Lista). 
        slots = GameObject.FindGameObjectsWithTag("Slot");
        CheckPosition();
    }
    void CheckPosition()
    {
        //Salva a posição das peças para move-las corretamente no tabuleiro

        for(int i = 0; i < slots.Length; i++)
        {
            if(i <= 3)
            position0.Add(slots[i].transform);
            if(i > 3 && i <= 7)
            position1.Add(slots[i].transform);
            if(i > 7 && i <= 11)
            position2.Add(slots[i].transform);
            if(i > 11 && i <= 15)
            position3.Add(slots[i].transform);
        }
    }
}

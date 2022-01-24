using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeacesPositionGenerator : MonoBehaviour
{
    public static PeacesPositionGenerator instance;
    public GameObject[] slots;
    public List <Vector3> position0;
    public List <Vector3> position1;
    public List <Vector3> position2;
    public List <Vector3> position3;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //Salvar Posição inicial das peças na posição correta(Posição de Vitória).
        //Dispor peças aleatoriamente(Embaralhar).
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
            position0.Add(slots[i].transform.position);
            if(i > 3 && i <= 7)
            position1.Add(slots[i].transform.position);
            if(i > 7 && i <= 11)
            position2.Add(slots[i].transform.position);
            if(i > 11 && i <= 15)
            position3.Add(slots[i].transform.position);
        }
    }
}

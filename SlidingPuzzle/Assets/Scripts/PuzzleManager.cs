using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    #region Variáveis
    public GameObject[] slots;
    public List <Vector3> position;

    #endregion
    void Start()
    {
        //Pegar slots e posição das peças. 
        slots = GameObject.FindGameObjectsWithTag("Slot");
        CheckPosition();
    }
    void Update()
    {
        
    }
    void CheckPosition()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            position.Add(slots[i].transform.position);
        }
    }
}

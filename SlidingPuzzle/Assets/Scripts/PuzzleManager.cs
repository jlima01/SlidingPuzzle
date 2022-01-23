using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] Slots;
    void Start()
    {
        Slots = GameObject.FindGameObjectsWithTag("Slot");
    }
    void Update()
    {
        
    }
}

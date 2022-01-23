using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject[] puzzlePieces;

    void Start()
    {
        puzzlePieces = GameObject.FindGameObjectsWithTag("Puzzle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPuzzleData", menuName = "Data/Puzzle Data/Base Data")]
public class PuzzleData : ScriptableObject
{
    [Header("Input")]
    public float maxInputThreshold = 0.25f;

    [Header("Color Manager")]
    public float color;

    [Header("Puzzle Peaces Position")]
    public Vector3 position;

}

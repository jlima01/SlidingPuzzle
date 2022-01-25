using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPuzzleData", menuName = "Data/Puzzle Data/Base Data")]
public class PuzzleData : ScriptableObject
{
    [Header("Input")]
    public float maxInputThreshold = 0.25f;

    [Header("Color Manager")]
    public float textColor = 3; //Vermelho = 0; Azul = 1; Amarelo = 2; Preto > 2;
    public float textFont = 0;

    [Header("Puzzles Position")]
    public float slot0 = 0;
    public float slot1 = 0;
    public float slot2 = 0;
    public float slot3 = 0;
    public float slot4 = 0;
    public float slot5 = 0;
    public float slot6 = 0;
    public float slot7 = 0;
    public float slot8 = 0;
    public float slot9 = 0;
    public float slot10 = 0;
    public float slot11 = 0;
    public float slot12 = 0;
    public float slot13 = 0;
    public float slot14 = 0;
}

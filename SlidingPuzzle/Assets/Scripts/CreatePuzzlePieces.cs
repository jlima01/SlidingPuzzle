using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePuzzlePieces : MonoBehaviour
{
    public GameObject piece;
    public List<GameObject> slotsList;
    public GameObject[] slots;
    void Start()
    {        
        slots = GetPieces.instance.slots;
        FillSlotsList();
        CreatePieces();
    }
    void FillSlotsList()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slotsList.Add(slots[i]);
        }
    }
    void CreatePieces()
    {
        for(int i = 0; i < slotsList.Count; i++)
        {
            int rand = Random.Range(0, slotsList.Count);
            Instantiate(piece, slotsList[rand].transform.position, Quaternion.identity, slotsList[rand].transform);
            slotsList[rand].transform.SetParent(piece.transform, false);
            piece.GetComponent<PiecesID>().id = i;
        }
    }
}

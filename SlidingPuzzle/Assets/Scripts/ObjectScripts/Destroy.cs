using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float time;
    public bool hide = false;

    void Start()
    {
        if(hide)
        {
            Invoke("HideObject", time);
        }
        else
        {
            Destroy(gameObject, time);
        }
    }
    void HideObject()
    {
        gameObject.SetActive(false);
    }
}

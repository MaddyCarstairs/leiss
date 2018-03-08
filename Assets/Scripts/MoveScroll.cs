using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveScroll : MonoBehaviour {

    Scrollbar bar;
    float mySize;

    void Awake()
        {
        bar = gameObject.GetComponent<Scrollbar>();
        mySize = bar.size;
        }

    void FixedUpdate()
    {
        if (bar.size != mySize)
        {
            bar.value = 0;
            mySize = bar.size;
        }
        else
        {
            bar.value = bar.value;
        }

    }

}

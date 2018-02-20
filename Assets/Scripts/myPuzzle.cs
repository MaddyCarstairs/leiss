﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPuzzle : MonoBehaviour {

    [SerializeField] CLine[] myLines;
    [SerializeField] DragPanel myDragPanel;
    [SerializeField] GameObject completePzl;


    GameObject l1;
    GameObject l2;
    int toColor1;
    int toColor2;
    //GameObject winpanel;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < myLines.Length; ++i)
        {
            myLines[i].InitLine(transform, i);
        }
       // winpanel = GameObject.FindGameObjectWithTag("winpzl");

        myDragPanel.RegisterOnMoveEvent(UpdateLines);

        Check();

    }

    public bool Check()
    {
        bool intersect = false;
        for (int i = 0; i < myLines.Length; ++i)
            for (int j = i + 1; j < myLines.Length; ++j)
            {
                if (i != (myLines.Length - 1))
                {
                    intersect = CLine.SegmentIntersection(myLines[i], myLines[j]);
                    if (intersect)
                    {
                        Debug.Log("Check " + intersect);
                        Color2Line(i, j, Color.red);
                        return intersect;
                    }
                    else
                        Color2Line(i, j, Color.black);
                }
                else
                {
                    intersect = CLine.SegmentIntersection(myLines[j], myLines[i]);
                    if (intersect)
                    {
                        Debug.Log("Check " + intersect);
                        Color2Line(i, j, Color.red);
                        return intersect;
                    }
                    else
                        Color2Line(i, j, Color.black);
                }
            }
        Debug.Log("Check " + intersect);
        return intersect;
    }

    public void UpdateLines()
    {
        for (int i = 0; i < myLines.Length; ++i)
            myLines[i].UpdateLine();
    }

    public void Color2Line(int index1, int index2, Color color)
    {
        l1 = GameObject.FindGameObjectWithTag("lr " + index1);
        l2 = GameObject.FindGameObjectWithTag("lr " + index2);

        l1.GetComponent<LineRenderer>().startColor = color;
        l1.GetComponent<LineRenderer>().endColor = color;
        l2.GetComponent<LineRenderer>().startColor = color;
        l2.GetComponent<LineRenderer>().endColor = color;
    }

 
    public IEnumerator EndPuzzle()
    {
        yield return new WaitForSeconds(0.3f);
        completePzl.SetActive(true);
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CLine {

    [SerializeField] Transform origin;
    [SerializeField] Transform dest;

    LineRenderer lr;
    GameObject line1;
    GameObject line2;

    public void InitLine(Transform parent, int index)
    {
        lr = new GameObject("LineRenderer " + index).AddComponent<LineRenderer>();
        lr.transform.SetParent(parent);

        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.tag = "lr " + index;
        //lr.GetComponent<GameObject>().layer = 8;

        lr.SetPositions(new Vector3[] { origin.position, dest.position });
        lr.startColor = Color.black;
        lr.endColor = Color.black;

        lr.startWidth = 10;
        lr.endWidth = 10;
    }


    public void UpdateLine()
    {
        lr.SetPositions(new Vector3[] { origin.position, dest.position });
    }


    public static bool SegmentIntersection(CLine l1, CLine l2)
    {
        Vector2 p1 = l1.origin.position;
        Vector2 p2 = l1.dest.position;
        Vector2 p3 = l2.origin.position;
        Vector2 p4 = l2.dest.position;


        //Vector2 a = l1.dest.position - l1.origin.position;
        //Vector2 b = l2.origin.position - l2.dest.position;
        //Vector2 c = l1.origin.position - l2.origin.position;

        Vector2 a = p2 - p1;
        Vector2 b = p3 - p4;
        Vector2 c = p1 - p3;

        float alphaNumerator = b.y * c.x - b.x * c.y;
        float alphaDenominator = a.y * b.x - a.x * b.y;
        float betaNumerator = a.x * c.y - a.y * c.x;
        float betaDenominator = a.y * b.x - a.x * b.y;

        bool doIntersect = true;
        bool intersect = false;


        if (alphaDenominator == 0 || betaDenominator == 0)
        {
            doIntersect = false;

        }
        else
        {

            if (alphaDenominator > 0 && (alphaNumerator < 0 || alphaNumerator > alphaDenominator))
            {
                doIntersect = false;
            }
            else if (alphaNumerator > 0 || alphaNumerator < alphaDenominator)
            {
                doIntersect = false;
            }

            if (betaDenominator > 0)

                if (betaNumerator < 0 || betaNumerator > betaDenominator)
                {
                    doIntersect = false;
                }
                else if (betaNumerator > 0 || betaNumerator < betaDenominator)
                {
                    doIntersect = false;
                }
        }

        if (doIntersect)
        {
            float numX = alphaNumerator * a.x; // numerator //

            float x = p1.x + numX / alphaDenominator;

            float numY = alphaNumerator * a.y;

            float y = p1.y + numY / alphaDenominator;


            if (((p1.x < x && p2.x > x) || (p1.y < y && p2.y > y)) ||
                ((p1.x > x && p2.x < x) || (p1.y > y && p2.y < y)))
            {

                if (((p3.x < x && p4.x > x) || (p3.y < y && p4.y > y)) ||
                ((p3.x > x && p4.x < x) || (p3.y > y && p4.y < y)))
                {
                    intersect = true;

                }
            }
        }


        return intersect;
 
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCircle : MonoBehaviour {

 
    myPuzzle p;
    GameObject myCamera;
    
    void Start()
    {
        p = GetComponentInParent<myPuzzle>();
        myCamera = GameObject.FindGameObjectWithTag("MainCamera");

    }

    public void OnMouseDrag()
    {
        Vector3 myPosition;
        myPosition.x = Input.mousePosition.x;
        myPosition.y = Input.mousePosition.y;
        myPosition.z = transform.position.z;
        //transform.position = myPosition;
        //Vector3 mouselocation = Camera.main.camera.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = mouselocation;

        Vector3 mouseloc = myCamera.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        mouseloc.z = 10f;
        transform.position = mouseloc;
        p.UpdateLines();
    }

    private void OnMouseUp()
    {
        p.Check();
        if (p.Check() == false)
        {
            StartCoroutine(p.EndPuzzle());
           
        }
    }
}

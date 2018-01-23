using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrangOnClick : MonoBehaviour {

    [SerializeField] LineRenderer myLine;
    [SerializeField] LineRenderer conectedLine;

    private void OnMouseDrag()
    {
        Vector3 myPosition;
        myPosition.x = Input.mousePosition.x;
        myPosition.y = Input.mousePosition.y;
        myPosition.z = 0f;
        transform.position = myPosition;
        myLine.SetPosition(0, myPosition);
        conectedLine.SetPosition(1, myPosition);

        Vector3 bcPosition;
        bcPosition.x = Input.mousePosition.x;
        bcPosition.y = Input.mousePosition.y;
        bcPosition.z = 0f;

    }


}

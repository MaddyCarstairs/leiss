using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salir : MonoBehaviour {

    [SerializeField] GameObject panelSalir;
    public GameObject image;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(() => {
            image.SetActive(true);
        });
    }


//public void OnSalir_Click()
//    {
//        if (panelSalir.activeSelf == false)
//            {
//            panelSalir.SetActive(true);
//            }
//            //panelSalir.SetActive(true);
//    }

        public void OnAceptar_Click()
    {
        Debug.Log("SALIR");
        Application.Quit();
    }
    public void OnCancelar_Click()
    {

        if (panelSalir.activeSelf == true)
           {
          panelSalir.SetActive(false);
          }

    }

}

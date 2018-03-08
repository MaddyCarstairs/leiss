using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Salir : MonoBehaviour {

    [SerializeField] GameObject panelSalir;
    public GameObject image;
    public GameObject image1;
    public Button button;
    public Button button1;

    void Start()
    {
        button.onClick.AddListener(() => {
            image.SetActive(true);
        });
        button1.onClick.AddListener(() => {
            image1.SetActive(true);
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
        if (image1.activeSelf == true)
        {
            image1.SetActive(false);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarNombre : MonoBehaviour
{
    GuardarNombre NombreGuardado;
    public string nombre;
    void Start()
    {
        //NombreGuardado = GameObject.FindGameObjectWithTag("guardar").GetComponent<GuardarNombre>();
        //nombre.text = NombreGuardado.myName;

        //Debug.Log("este es nombre " + NombreGuardado.myName);
        
    }
    void Awake()
    {

        DontDestroyOnLoad(transform.gameObject);
        nombre = "todavoa mp spy nadie";
        Debug.Log("que se quede guardao");
        Debug.Log("este es nombre " + nombre);
        
    }

    //public void onShowNAme_click()
    //{
    //    nombreComprobacion.text = nombre.text;
    //}
}


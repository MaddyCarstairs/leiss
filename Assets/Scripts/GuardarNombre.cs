using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarNombre : MonoBehaviour {


    [SerializeField] InputField textInput;
    [SerializeField] Text nombreComprobacion;

    MostrarNombre noMuero;
    bool alreadyName;
    public string myName;

    //then drag and drop the Username_field



    // Use this for initialization
    void Start () {
        myName = "no soy nadie";
        Debug.Log(myName);

        if (alreadyName == true)
        {
            textInput.text = myName;
            Debug.Log("textinput.text" + textInput.text);
        }
        noMuero = GameObject.FindGameObjectWithTag("yo").GetComponent<MostrarNombre>();
        noMuero.nombre = myName;
    }
    public void onLogin_Click()
    {
        alreadyName = true;
        myName = textInput.text;
        Debug.Log("este es el nombre del otro script: " + myName);

        noMuero.nombre = myName;
        Debug.Log("este es el nombre del otro script: " + noMuero.nombre);

        //SceneManager.UnloadScene(0);
        //SceneManager.LoadScene(1);

    }


    // Update is called once per frame
    //public void onShowNAme_click()
    //{
    //    nombreComprobacion.text = myName;
    //}


}

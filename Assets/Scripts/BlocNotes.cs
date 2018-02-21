using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocNotes : MonoBehaviour {

    [SerializeField] InputField textInput;
    [SerializeField] Text saveText;
    [SerializeField] GameObject sobre;
    bool alreadyName;
    string myText;

    

    void Start()
    {
        if (alreadyName == true)
        {
            textInput.text = myText;
        }
        saveText.text = "No hay nada escrito de momento";
        textInput.text = "escribe algo";
    }

    public void OnSave_click(GameObject save)
    {
        save.SetActive(false);
        sobre.SetActive(true);
    }


    void ActualizeText2()
    {
        saveText.text = myText;
    }

    public void ShowSave(GameObject save)
    {
        save.SetActive(true);      
    }


    public void onYes_Click()
    {
        alreadyName = true;
        myText = textInput.text;

        ActualizeText2();
        sobre.SetActive(false);
    }

    public void onNo_Click()
    {
        sobre.SetActive(false);
    }
}



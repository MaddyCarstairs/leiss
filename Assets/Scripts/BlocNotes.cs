using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocNotes : MonoBehaviour {

    [SerializeField] InputField textInput;
    [SerializeField] GameObject sobre;
    bool alreadyName;
    string myText;
    public string mySaveText;

    

    void Start()
    {
        if (alreadyName == true)
        {
            textInput.text = myText;
        }
        textInput.text = "escribe algo";
        mySaveText = textInput.text;
    }

    public void OnSave_click(GameObject save)
    {
        save.SetActive(false);
        sobre.SetActive(true);
    }


    void ActualizeText2()
    {
        textInput.text = mySaveText;
    }

    public void ShowSave(GameObject save)
    {
        save.SetActive(true);      
    }


    public void onYes_Click()
    {
        alreadyName = true;
        myText = textInput.text;
        mySaveText = myText;

        ActualizeText2();
        sobre.SetActive(false);
    }

    public void onNo_Click()
    {
        //saveText.text = mySaveText;
        ActualizeText2();
        sobre.SetActive(false);
        

    }
}



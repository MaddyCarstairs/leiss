using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void OnAceptar_Click()
    {
        SceneManager.UnloadScene(0);
        SceneManager.LoadScene(1);
    }
    public void OnLogin_Click()
    {
        SceneManager.UnloadScene(1);
        SceneManager.LoadScene(2);
    }
}

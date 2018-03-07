using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour {

    public void CambiarEscena(string login)
    {
        print("Cambiando a la escena" + login);
        SceneManager.LoadScene(login);
    }

    public void Salir()
    {
        print("Saliendo del juego");
        Application.Quit();

    }
}

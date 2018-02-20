using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonesWindows : MonoBehaviour
{
    [SerializeField] GameObject puzzle;
    [SerializeField] GameObject chat;
    [SerializeField] GameObject myself;

    public void OnWindows_Click(GameObject image)
    {
        image.SetActive(!image.activeSelf);
    }
    public void OnBusqueda_Click()
    {
        Debug.Log("Has pulsado buscar");
    }
    public void OnPapelera_Click()
    {
        Debug.Log("Has pulsado la papelera");
    }
    public void OnBlocnotas_Click()
    {
        Debug.Log("Has pulsado el bloc de notas");
    }
    public void OnLeis_Click(GameObject panel)
    {
        panel.SetActive(true);
    }
    public void OnPuzzles_Click(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void OnPuzzlesinicio_Click()
    {       
        myself.SetActive(false);
        puzzle.SetActive(true);
    }

    public void OnChatinicio_Click()
    {     
        myself.SetActive(false);
        chat.SetActive(true);
    }

    public void OnCargarinicio_Click()
    {
        Debug.Log("Has pulsado boton inicio cargar partida");
    }

    public void Onnuevainicio_Click()
    {
        Debug.Log("Has pulsado boton inicio Nueva partida");
    }

    public void OnSalirinicio_Click()
    {
        Debug.Log("Has pulsado boton inicio Salir");
    }
    public void OnPanelinicio_Click(GameObject image)
    {
        image.SetActive(!image.activeSelf);
    }

}
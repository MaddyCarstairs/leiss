using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonesWindows : MonoBehaviour
{
    [SerializeField] GameObject puzzle;
    [SerializeField] GameObject renderlines;
    [SerializeField] GameObject chat;
    [SerializeField] GameObject notes;
    [SerializeField] GameObject myself;
    int myIndex;
    private void Start()
    {
        myIndex = 0;
    }

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

    public void OnLeis_Click(GameObject panel)
    {
        panel.SetActive(true);
        //puzzle.SetActive(false);
        //notes.SetActive(false);
        renderlines.SetActive(false);
        panel.transform.SetSiblingIndex(2);
    }
    public void OnPuzzles_Click(GameObject panel)
    {
        panel.SetActive(true);
        //chat.SetActive(false);
        //notes.SetActive(false);
        renderlines.SetActive(true);
        panel.transform.SetSiblingIndex(2);
    }

    public void OnPuzzlesinicio_Click()
    {       
        myself.SetActive(false);
        puzzle.SetActive(true);
        //chat.SetActive(false);
        //notes.SetActive(false);
        renderlines.SetActive(true);

        puzzle.transform.SetSiblingIndex(2);
    }

    public void OnChatinicio_Click()
    {     
        myself.SetActive(false);
        chat.SetActive(true);
        //puzzle.SetActive(false);
        //notes.SetActive(false);
        renderlines.SetActive(false);

        chat.transform.SetSiblingIndex(2);
    }

    public void OnCargarinicio_Click()
    {
        Debug.Log("Has pulsado boton inicio cargar partida");
    }

    public void Onnuevainicio_Click()
    {
        Debug.Log("Has pulsado boton inicio Nueva partida");
    }

    public void OnPanelinicio_Click(GameObject image)
    {
        image.SetActive(!image.activeSelf);
    }

}
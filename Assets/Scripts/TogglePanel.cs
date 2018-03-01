using UnityEngine;
using System.Collections;

public class TogglePanel : MonoBehaviour
{

    [SerializeField] GameObject puzzle;
    [SerializeField] GameObject puzzleCanvasOriginal;
    [SerializeField] GameObject chats;
    [SerializeField] GameObject notes;
    [SerializeField] GameObject renderlines;
    [SerializeField] GameObject pzlAlert;
    [SerializeField] GameObject alert1;
    [SerializeField] GameObject alert2;

    GameObject winds;
    int myIndex;

    private void Start()
    {
        myIndex = 0;
        //winds = GameObject.FindGameObjectWithTag("myWindows");
        //winds.transform.SetSiblingIndex(myIndex);
    }

    public void onClose_puzzles()
    {
        puzzle.SetActive(!puzzle.activeSelf);
        renderlines.SetActive(false);
    }

    public void OnClick_Puzzle(GameObject button)
    {

        puzzle.SetActive(true);
        //chats.SetActive(false);
        //notes.SetActive(false);
        renderlines.SetActive(true);

        if (button.activeSelf == true)
        {
            button.SetActive(false);
        }
        puzzle.transform.SetSiblingIndex(2);
    }

    public void OnClose_Notes()
    {
        notes.SetActive(false);
    }

    public void OnClick_Notes()
    {
        notes.SetActive(true);
        //chats.SetActive(false);
        //panel.SetActive(false);
        renderlines.SetActive(false);
        notes.transform.SetSiblingIndex(2);
    }

    public void TogglePanelMinimize(GameObject button)
    {
        //button.SetActive(!button.activeSelf);
        //if (button.activeSelf)
        //{
        //    button.transform.SetSiblingIndex(2);
        //    if (button.tag == "winplz")
        //    {
        //        //button.SetActive(!button.activeSelf);
        //        //if (button.activeSelf)
        //        //{
        //        //    button.SetActive(true);
        //        //    renderlines.SetActive(true);
        //        //}
        //        //else
        //        //{
        //        //    renderlines.SetActive(false);
        //        //    button.SetActive(false);
        //        //}
        //    }
        //}

        button.SetActive(!button.activeSelf);
        if (button.activeSelf)
        {
            button.transform.SetSiblingIndex(2);
        }
    }

    public void MinimizePuzzle(GameObject buttonMin)
    {
        if (puzzle.activeSelf)
        {
            buttonMin.SetActive(true);
            puzzle.SetActive(false);
            puzzleCanvasOriginal.SetActive(false);
        }
        else
        {
            buttonMin.SetActive(false);
            puzzle.SetActive(true);
            puzzleCanvasOriginal.SetActive(true);
        }
    }

    public void OnClick_Chat(GameObject button)
    {
        chats.SetActive(true);
        //notes.SetActive(false);
        //panel.SetActive(false);
        renderlines.SetActive(false);

        if (button.activeSelf == true)
        {
            button.SetActive(false);
        }
        chats.transform.SetSiblingIndex(2);

    }

    public void onClose_chats()
    {
        chats.SetActive(false);
    }

    public void onClose_PZLAlert(GameObject text)
    {
        pzlAlert.SetActive(false);
        text.SetActive(true);
    }

    public void onClose_alert1()
    {
        alert1.SetActive(false);
    }
    public void onClose_alert2()
    {
        alert2.SetActive(false);
    }

}

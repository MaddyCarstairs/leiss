using UnityEngine;
using System.Collections;

public class TogglePanel : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] GameObject chats;
    [SerializeField] GameObject notes;
    [SerializeField] GameObject pzlAlert;
    [SerializeField] GameObject alert1;
    [SerializeField] GameObject alert2;

    GameObject winds;
    int myIndex;

    private void Start()
    {
        myIndex = 0;
        winds = GameObject.FindGameObjectWithTag("myWindows");
        //winds.transform.SetSiblingIndex(myIndex);
    }

    public void onClose_puzzles()
    {
        panel.SetActive(!panel.activeSelf);
    }

    public void OnClick_Puzzle(GameObject button)
    {

        panel.SetActive(true);

        if(button.activeSelf == true)
        {
            button.SetActive(false);
        }
        panel.transform.SetSiblingIndex(2);
    }

    public void OnClose_Notes()
    {
        notes.SetActive(false);
    }

    public void OnClick_Notes()
    {
        notes.SetActive(true);
        notes.transform.SetSiblingIndex(2);
    }

    public void TogglePanelMinimize(GameObject button)
    {
        button.SetActive(!button.activeSelf);
        if (button.activeSelf)
        {
            button.transform.SetSiblingIndex(2);
        }
    }

    public void OnClick_Chat(GameObject button)
    {
        chats.SetActive(true);

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

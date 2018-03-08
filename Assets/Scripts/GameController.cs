using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] GameObject chatPanel;

    [SerializeField] GameObject alert1;
    [SerializeField] GameObject alert2;
    [SerializeField] GameObject MeshController;
    [SerializeField] GameObject chatWin;
    [SerializeField] GameObject noTouch;
    AudioSource leisAlert;
    AudioSource leisAlert2;
    AudioSource chatAlert;

    private void Start()
    {
        leisAlert = alert1.GetComponent<AudioSource>();
        leisAlert2 = alert2.GetComponent<AudioSource>();
        chatAlert = chatWin.GetComponent<AudioSource>();
        StartCoroutine(Alert());
    }

    public void OnAlert1_click()
    {
        StartCoroutine(Alert2());
    }

    public void OnAlert2_click()
    {
        StartCoroutine(Chat());
    }

    IEnumerator Alert()
    {
        yield return new WaitForSeconds(2);
        alert1.SetActive(true);
        leisAlert.Play();
    }
    IEnumerator Alert2()
    {
        alert1.SetActive(false);
        yield return new WaitForSeconds(2);
        alert2.SetActive(true);
        leisAlert2.Play();
        noTouch.SetActive(false);
    }

     IEnumerator Chat()
    {
        alert2.SetActive(false);
        yield return new WaitForSeconds(2f);
        chatPanel.SetActive(true);
        chatAlert.Play();
        // MeshController.GetComponent<Newanimationcrtine>().StartCoroutine(Chat());
        StartCoroutine(MeshController.GetComponent<Newanimationcrtine>().Chat());
    }
}

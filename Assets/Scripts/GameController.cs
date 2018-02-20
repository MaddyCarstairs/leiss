using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] GameObject chatPanel;

    [SerializeField] GameObject alert1;
    [SerializeField] GameObject alert2;

    private void Start()
    {
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
    }
    IEnumerator Alert2()
    {
        alert1.SetActive(false);
        yield return new WaitForSeconds(2);
        alert2.SetActive(true);
    }

    IEnumerator Chat()
    {
        alert2.SetActive(false);
        yield return new WaitForSeconds(2f);
        chatPanel.SetActive(true);
    }
}

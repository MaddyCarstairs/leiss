using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usclick : MonoBehaviour
{

    [SerializableField] GameObject maddyImg;
    [SerializableField] GameObject meriditchImg;
    [SerializableField] GameObject rataixImg;
    [SerializableField] GameObject carlosImg;
    [SerializableField] GameObject maddyInfo;
    [SerializableField] GameObject meriditchInfo;
    [SerializableField] GameObject ratarixInfo;
    [SerializableField] GameObject carlosInfo;

    public void OnMaddy_Click()
    {
        maddyInfo.SetActive(!maddyInfo.activeSelf);
        if (maddyInfo.activeSelf == true)
        {
            infoLista.SetActive(false);
            ratarixInfo.SetActive(false);
            infoGuapo.SetActive(false);
            maddyInfo.SetActive(true);
        }
    }
    public void OnMeriditch_Click()
    {
        Debug.Log("Has pulsado a el guapo");
        infoGuapo.SetActive(!infoGuapo.activeSelf);
        if (infoGuapo.activeSelf == true)
        {
            infoLista.SetActive(false);
            ratarixInfo.SetActive(false);
            maddyInfo.SetActive(false);
            infoGuapo.SetActive(true);

        }
    }
    public void OnRatarix_Click()
    {
        Debug.Log("Has pulsado a la lista");
        ratarixInfo.SetActive(!ratarixInfo.activeSelf);
        if (ratarixInfo.activeSelf == true)
        {
            infoGuapo.SetActive(false);
            ratarixInfo.SetActive(false);
            maddyInfo.SetActive(false);
            ratarixInfo.SetActive(true);
        }

    }
    public void OnCarlos_Click()
    {
        Debug.Log("Has pulsado al timido");
        infoTimido.SetActive(!infoTimido.activeSelf);
        if (infoTimido.activeSelf == true)
        {
            infoGuapo.SetActive(false);
            infoLista.SetActive(false);
            maddyInfo.SetActive(false);
            infoTimido.SetActive(true);
        }
    }
}
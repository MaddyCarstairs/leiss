using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usclick : MonoBehaviour
{


    [SerializeField]
    GameObject maddyInfo;
    [SerializeField]
    GameObject meriditchInfo;
    [SerializeField]
    GameObject ratarixInfo;
    [SerializeField]
    GameObject carlosInfo;

    public void OnMaddy_Click()
    {
        maddyInfo.SetActive(!maddyInfo.activeSelf);
        if (maddyInfo.activeSelf == true)
        {
            meriditchInfo.SetActive(false);
            ratarixInfo.SetActive(false);
            carlosInfo.SetActive(false);
            maddyInfo.SetActive(true);
        }
    }
    public void OnMeriditch_Click()
    {
        meriditchInfo.SetActive(!meriditchInfo.activeSelf);
        if (meriditchInfo.activeSelf == true)
        {
            carlosInfo.SetActive(false);
            ratarixInfo.SetActive(false);
            maddyInfo.SetActive(false);
            meriditchInfo.SetActive(true);

        }
    }
    public void OnRatarix_Click()
    {
        ratarixInfo.SetActive(!ratarixInfo.activeSelf);
        if (ratarixInfo.activeSelf == true)
        {
            carlosInfo.SetActive(false);
            ratarixInfo.SetActive(false);
            maddyInfo.SetActive(false);
            ratarixInfo.SetActive(true);
        }

    }
    public void OnCarlos_Click()
    {
        carlosInfo.SetActive(!carlosInfo.activeSelf);
        if (carlosInfo.activeSelf == true)
        {
            meriditchInfo.SetActive(false);
            ratarixInfo.SetActive(false);
            maddyInfo.SetActive(false);
            carlosInfo.SetActive(true);
        }
    }
}
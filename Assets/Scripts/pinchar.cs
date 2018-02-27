using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinchar : MonoBehaviour
{
    [SerializeField] GameObject infoGuapa;
    [SerializeField] GameObject infoGuapo;
    [SerializeField] GameObject infoLista;
    [SerializeField] GameObject infoTimido;
    [SerializeField] GameObject V1fija;
    [SerializeField] GameObject V2fija;
    [SerializeField] GameObject V3fija;
    [SerializeField] GameObject V4fija;
    [SerializeField] GameObject Vgrupalfija;

    //public void OnV1_Click(GameObject image)
    //{
    //    Debug.Log("Has pulsado la ventana 1");
    //    image.SetActive(!image.activeSelf);
    //}
    //public void OnV2_Click(GameObject image)
    //{
    //    Debug.Log("Has pulsado la ventana 2");
    //    image.SetActive(!image.activeSelf);
    //}
    //public void OnV3_Click(GameObject image)
    //{
    //    Debug.Log("Has pulsado la ventana 3");
    //    image.SetActive(!image.activeSelf);
    //}
    //public void OnV4_Click(GameObject image)
    //{
    //    Debug.Log("Has pulsado la ventana 4");
    //    image.SetActive(!image.activeSelf);
    //}
    //public void OnVgrupal_Click(GameObject image)
    //{
    //    Debug.Log("Has pulsado la ventana grupal");
    //    image.SetActive(!image.activeSelf);
    //}
    public void Onicono1_Click()
    {
        Debug.Log("Has pulsado a la guapa");
        //if (image.activeSelf == false)
        //{
        //image.SetActive(true);
        //}
        infoGuapa.SetActive(!infoGuapa.activeSelf);
        if (infoGuapa.activeSelf == true)
        {
            infoLista.SetActive(false);
            infoTimido.SetActive(false);
            infoGuapo.SetActive(false);
            infoGuapa.SetActive(true);
        }
    }
    public void Onicono2_Click()
    {
        Debug.Log("Has pulsado a el guapo");
        infoGuapo.SetActive(!infoGuapo.activeSelf);
        if(infoGuapo.activeSelf == true)
        {
            infoLista.SetActive(false);
            infoTimido.SetActive(false);
            infoGuapa.SetActive(false);
            infoGuapo.SetActive(true);

        }
    }
    public void Onicono3_Click()
    {
        Debug.Log("Has pulsado a la lista");
        infoLista.SetActive(!infoLista.activeSelf);
        if (infoLista.activeSelf == true)
        {
            infoGuapo.SetActive(false);
            infoTimido.SetActive(false);
            infoGuapa.SetActive(false);
            infoLista.SetActive(true);
        }

    }
    public void Onicono4_Click()
    {
        Debug.Log("Has pulsado al timido");
        infoTimido.SetActive(!infoTimido.activeSelf);
        if (infoTimido.activeSelf == true)
        {
            infoGuapo.SetActive(false);
            infoLista.SetActive(false);
            infoGuapa.SetActive(false);
            infoTimido.SetActive(true);
        }

    }
    public void OnV1_Click()
    {

        V1fija.SetActive(!V1fija.activeSelf);
        if (V1fija.activeSelf == true)
        {
            V2fija.SetActive(false);
            V3fija.SetActive(false);
            V4fija.SetActive(false);
            Vgrupalfija.SetActive(false);
        }
    }
    public void OnV2_Click()
    {

        V2fija.SetActive(!V2fija.activeSelf);
        if (V2fija.activeSelf == true)
        {
            V1fija.SetActive(false);
            V3fija.SetActive(false);
            V4fija.SetActive(false);
            Vgrupalfija.SetActive(false);
        }
    }
    public void OnV3_Click()
    {

        V3fija.SetActive(!V3fija.activeSelf);
        if (V3fija.activeSelf == true)
        {
            V2fija.SetActive(false);
            V1fija.SetActive(false);
            V4fija.SetActive(false);
            Vgrupalfija.SetActive(false);
        }
    }
    public void OnV4_Click()
    {

        V4fija.SetActive(!V4fija.activeSelf);
        if (V4fija.activeSelf == true)
        {
            V2fija.SetActive(false);
            V3fija.SetActive(false);
            V1fija.SetActive(false);
            Vgrupalfija.SetActive(false);
        }
    }
    public void OnVgrupal_Click()
    {

        Vgrupalfija.SetActive(!Vgrupalfija.activeSelf);
        if (Vgrupalfija.activeSelf == true)
        {
            V2fija.SetActive(false);
            V3fija.SetActive(false);
            V4fija.SetActive(false);
            V1fija.SetActive(false);
        }
    }
}

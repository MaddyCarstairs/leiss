using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{

    //To serialize the text

    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;
    [SerializeField] GameObject text5;
    [SerializeField] GameObject text6;
    [SerializeField] GameObject text7;
    [SerializeField] GameObject text8;
    [SerializeField] GameObject text9;
    [SerializeField] GameObject text10;
    [SerializeField] GameObject text11;
    [SerializeField] GameObject text12;
    [SerializeField] GameObject text13;
    [SerializeField] GameObject text14;
    [SerializeField] GameObject text15;
    [SerializeField] GameObject text16;
    [SerializeField] GameObject text17;
    [SerializeField] GameObject text18;
    [SerializeField] GameObject text19;
    [SerializeField] GameObject text20;
    [SerializeField] GameObject text21;
    [SerializeField] GameObject text22;
    [SerializeField] GameObject text23;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(TheConver());  
    }

    IEnumerator TheConver()                                                                                                     //The conversation
    {
        yield return new WaitForSeconds(1.5f);

        text1.SetActive(true);                //Bueno no ha estado mal no?  

        yield return new WaitForSeconds(1.5f);
        text2.SetActive(true);                //Qué os ha parecido?

         yield return new WaitForSeconds(1.5f);
        text3.SetActive(true);               //Os ha gustado?

        yield return new WaitForSeconds(1.5f);
        text4.SetActive(true);                //Somos los creadores del juego

        yield return new WaitForSeconds(2.5f);
        text5.SetActive(true);                //Hemos tardado 3 meses

        yield return new WaitForSeconds(2);
        text6.SetActive(true);                //Ahora vamos a presentarnos

        yield return new WaitForSeconds(2);
        text7.SetActive(true);                //¿Quién empieza?

        yield return new WaitForSeconds(3);
        text8.SetActive(true);                //Yo soy Maddy

        yield return new WaitForSeconds(2.5f);
        text9.SetActive(true);                 //Yo soy Meriditch   

        yield return new WaitForSeconds(2);
        text10.SetActive(true);                //Yo soy Carlos

        yield return new WaitForSeconds(2);
        text11.SetActive(true);                //Yo soy Ratarix

        yield return new WaitForSeconds(2);
        text12.SetActive(true);                //Ahora que hemos terminado, ¿Qué vais a hacer con vuestra vida?.

        yield return new WaitForSeconds(3);
        text13.SetActive(true);                //¿Qué habeis hecho para desconectar?

        yield return new WaitForSeconds(1.5f);
        text14.SetActive(true);                //Lololololol

        yield return new WaitForSeconds(2);
        text15.SetActive(true);                //Me ha dado tiempo a leer 19 libros

        yield return new WaitForSeconds(1.5f);
        text16.SetActive(true);                //Lololololol

        yield return new WaitForSeconds(1.2f);
        text17.SetActive(true);                //He subido a doble AK

        yield return new WaitForSeconds(1.7f);
        text18.SetActive(true);               //He tirado todo Argus en Mítico

        yield return new WaitForSeconds(1.5f);
        text19.SetActive(true);                //Reload recluta de cara a BFA

        yield return new WaitForSeconds(2);
        text20.SetActive(true);                //La propaganda xD

        yield return new WaitForSeconds(2);
        text21.SetActive(true);                //Dracarys

        yield return new WaitForSeconds(2);
        text22.SetActive(true);                 //Lol

        yield return new WaitForSeconds(2);
        text23.SetActive(true);                 //Después de trys hemos desbloqueado el título del aprobado

    }
}

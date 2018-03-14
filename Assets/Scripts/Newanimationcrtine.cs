using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newanimationcrtine : MonoBehaviour {
    [SerializeField] GameObject text0;
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;
    [SerializeField] GameObject text5;
    [SerializeField] GameObject text6;
    [SerializeField] GameObject text7;
    [SerializeField] GameObject text8;


    [SerializeField] GameObject t0;
    [SerializeField] GameObject t1;
    [SerializeField] GameObject t2;
    [SerializeField] GameObject t3;
    [SerializeField] GameObject t4;
    [SerializeField] GameObject t5;





    // Use this for initialization

    private void Start()
    {
        StartCoroutine(Chat());
    }


    public void On_WaitClick()
        {
            StartCoroutine(Wait());
        }



    

   IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        
        StartCoroutine(Chat());
    }

    public IEnumerator Chat()
    {
        t0.SetActive(true);
        text0.SetActive(true);
        yield return new WaitForSeconds(1);
        t1.SetActive(true);
        text1.SetActive(true);
       
        yield return new WaitForSeconds(1);
        t2.SetActive(true);
        text2.SetActive(true);
        
        yield return new WaitForSeconds(2);
        t3.SetActive(true);
        text3.SetActive(true);
        
        yield return new WaitForSeconds(2);
        t4.SetActive(true);
        text4.SetActive(true);
        
        yield return new WaitForSeconds(1);
        t5.SetActive(true);
        text5.SetActive(true);
        
        yield return new WaitForSeconds(3);
        text6.SetActive(true);
        text7.SetActive(true);
        text8.SetActive(true);

    }
}

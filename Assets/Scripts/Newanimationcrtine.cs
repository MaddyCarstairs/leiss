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
        text0.SetActive(true);
        yield return new WaitForSeconds(1);
        text1.SetActive(true);
       
        yield return new WaitForSeconds(1);
        text2.SetActive(true);
        
        yield return new WaitForSeconds(2);
        text3.SetActive(true);
        
        yield return new WaitForSeconds(2);
        text4.SetActive(true);
        
        yield return new WaitForSeconds(1);
        text5.SetActive(true);
        
        yield return new WaitForSeconds(3);
        text6.SetActive(true);
        text7.SetActive(true);
        text8.SetActive(true);
        
    }
}

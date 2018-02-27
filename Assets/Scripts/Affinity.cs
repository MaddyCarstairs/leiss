using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Affinity : MonoBehaviour
{

   // public Scrollbar afBar;
    public float af, maxaf = 100f;
    public float minaf = 0f;
    public float afinthai = 0f;
    public float afinancy = 0f;
    public float afinjack = 0f;
    public float afinkieran = 0f;
    GameObject kier;
    GameObject jack;
    GameObject thai;
    GameObject nancy;

    private void Awake()
    {
        kier = GameObject.FindGameObjectWithTag("kieranAf");
        jack = GameObject.FindGameObjectWithTag("jackAf");
        thai = GameObject.FindGameObjectWithTag("thaiAf");
        nancy = GameObject.FindGameObjectWithTag("nancyAf");
    }
    void Start()
    {
        //afBar.size = afinthai / 100f;
        //afBar.size = afinancy / 100f;
        //afBar.size = afinjack / 100f;
        //afBar.size = afinkieran / 100f;
        
        moreaf(50, "kieran");
        moreaf(20, "jack");
        moreaf(10, "kieran");
        moreaf(10, "thai");
    }


    public void lessaf(float value, string person)
    {
        if (person == "kieran")
        {
            af = Mathf.Clamp(af - value, minaf, maxaf);
            //afBar.size = af / 100f;
            afinkieran = af;
            kier.GetComponent<Scrollbar>().size = af / 100f;

        }

        if (person == "jack")
        {
            af = Mathf.Clamp(af - value, minaf, maxaf);
            //afBar.size = af / 100f;
            afinjack = af;
            jack.GetComponent<Scrollbar>().size = af / 100f;
        }

        if (person == "thai")
        {
            af = Mathf.Clamp(af - value, minaf, maxaf);
            //afBar.size = af / 100f;
            afinthai = af;
            thai.GetComponent<Scrollbar>().size = af / 100f;
        }

        if (person == "nancy")
        {
            af = Mathf.Clamp(af - value, minaf, maxaf);
            //afBar.size = af / 100f;
            afinancy = af;
            nancy.GetComponent<Scrollbar>().size = af / 100f;
        }
    }

    //Mathf.Clamp es una pequeña función que nos ayuda a ajustar un valor entre dos valores dados. Por ejemplo para ajustar la vida de un personaje entre 0 y 100.

    public void moreaf(float value, string person)
    {
        //af = Mathf.Clamp(af + value, minaf, maxaf); 
        //afBar.size = af / 100f;
        //person = af;
        if (person == "kieran")
        {

            af = Mathf.Clamp(af + (value + afinkieran), minaf, maxaf);
            //afBar.size = af / 100f;
            afinkieran = af;
            kier.GetComponent<Scrollbar>().size = afinkieran / 100f;
            af = 0f;
        }

        if (person == "jack")
        {
            af = Mathf.Clamp(af + (value + afinjack), minaf, maxaf);
            //afBar.size = af / 100f;
            afinjack = af;
            jack.GetComponent<Scrollbar>().size = afinjack / 100f;
            af = 0f;
        }

        if (person == "thai")
        {

            af = Mathf.Clamp(af + (value + afinthai), minaf, maxaf);
            //afBar.size = af / 100f;
            afinthai = af;
            thai.GetComponent<Scrollbar>().size = afinthai / 100f;
            af = 0f;
        }

        if (person == "nancy")
        {

            af = Mathf.Clamp(af + (value + afinthai), minaf, maxaf);
            //afBar.size = af / 100f;
            afinancy = af;
            nancy.GetComponent<Scrollbar>().size = afinancy / 100f;
            af = 0f;
        }
    }
}

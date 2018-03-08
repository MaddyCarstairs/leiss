using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiQuienEres : MonoBehaviour
{

    //Lol, mas que serializar cosas, parece un índice T-T

    [SerializeField] GameObject text1; //For "Si, ¿Quién eres?" (and buttons in general)
    [SerializeField] GameObject btn1;
    [SerializeField] GameObject btn2;
    [SerializeField] GameObject btn3;
    [SerializeField] GameObject btn4;
    [SerializeField] GameObject btn5;
    [SerializeField] GameObject btn5alt;
    [SerializeField] GameObject btn6;
    [SerializeField] GameObject btn6otro;
    [SerializeField] GameObject btn6otro2;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;


    //For text of scroll

    [SerializeField] GameObject t8;     //Si quien eres / Hola... / Soy Nancyyyy :))                                    

    [SerializeField] GameObject t9;     //holiiiii :))) / Nancy Melson y tu? :)

    [SerializeField] GameObject t10;    //Soy Nancy y tu? ;) / Jack.    

    [SerializeField] GameObject t11;    //Hola. Soy Jack. / ¿Y tu eres...?

    [SerializeField] GameObject t12;    //Yo soy MC, mucho gusto / MC / ¿Y por qué debería presentarme? No os conozco de nada. / Yo prefiero no presentarme, no os conozco de nada. /  ¿No sabe no contesta?

    [SerializeField] GameObject t13;    //Iguakmenteeeeee  ^o^ / ah bien / Hola MC / Hayyyy cieloooo / K cascarrabias eres u_u” / Huyyyy k borde T-T / Kt cuesta???

    [SerializeField] GameObject t14;    //Encantado. / Soy Jack / Pero lo que dice es razonable. / Costar, nada, pero no parece que vaya a respondernos...

    [SerializeField] GameObject t15;    //:D / Mucho gustoooo MC :)))  / T_T / Joooooooo ;-;

    [SerializeField] GameObject t16;    //Bueno, tenemos temas mas importantes de los que hablar.

    [SerializeField] GameObject t17;    //K.P. ha entrado al chat grupal

    [SerializeField] GameObject t18;    //Lol, temas + importantes????

    [SerializeField] GameObject t19;    //Ya leiste el por que estamos aqui, ¿no?

    [SerializeField] GameObject t20;    //Oooooohhhhh las pruebas esas no?

    [SerializeField] GameObject t21;    //¿Leiste el mensaje?

    [SerializeField] GameObject t22;    //Siiiiii lo de la ventanita de LEISSS :)

    [SerializeField] GameObject t23;    //Thailea ha entrado al chat grupal

    [SerializeField] GameObject t24;    //¿Lo de la supuesta prueba...?

    [SerializeField] GameObject t25;    //Holiiiii kien eresss??? :) 

    [SerializeField] GameObject t26;    //¿Y a ti que te importa?

    [SerializeField] GameObject t27;    //Alaaaaaa pro pr k??? k borde ;-;

    [SerializeField] GameObject t28;    //Baja esos humos, chaval.

    [SerializeField] GameObject t29;    //¿Y tu quien te crees que eres para mandarme a mi nada?

    [SerializeField] GameObject t30;    //Pues el que se va a quedar con el puesto de trabajo.

    [SerializeField] GameObject t31;    //¿Quien va a querer a un borde de mierda en su empresa?

    [SerializeField] GameObject t32;    //¿Disculpa...?

    [SerializeField] GameObject t33;    //Boysss plssss STOP FIGHTING ;-;

    [SerializeField] GameObject t34;    //¿Quién no se va a molestar con alguien tan desagradable?

    [SerializeField] GameObject t35;    //...

    [SerializeField] GameObject t36;    //Hey.... no os peleeis por favor.... 

    [SerializeField] GameObject t37;    //Huyy y tu kien eres? :))) 

    [SerializeField] GameObject t38;    //Hum.... Thais......

    [SerializeField] GameObject t39;    //Encantada Thais!! yo soy Nancy ;)

    [SerializeField] GameObject t40;    //Jack.

    [SerializeField] GameObject t41;    //Encantado.

    [SerializeField] GameObject t42;    //Por suerte, el número de personas incivilizadas es relativamente bajo.

    [SerializeField] GameObject t43;    //No empeceis otra vzzzz >.<;;;;

    [SerializeField] GameObject t44;    //No me puedo creer que un payaso como tu haya conseguido siquiera una entrevista de trabajo...

    [SerializeField] GameObject t45;    //Y te lo vas a creer menos todavía cuando a mi me cojan y a ti no. 

    [SerializeField] GameObject t46;    //...

    [SerializeField] GameObject t47;    //Bueno... si no se quiere presentar, no pasa nada...¿no? / ¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil. / Venga... No discutais.... Recordad que estamos a prueba para el trabajo... / STOP

    [SerializeField] GameObject t48;    //Ssssss verdaaaaad chicos ya vale no? :( / No necesito que nadie me defienda... / ¿Y si no me da la gana...? / Sta discusion no tiene ningun sentido T-T

    [SerializeField] GameObject t49;    //Tienes razón. Esta discusión es un despropósito... /  Pfff ¿Veis a lo que me refiero? / Solo es diecir tu nmbre >.<;;;; / Nancy tiene razón....

    [SerializeField] GameObject t50;    //Si este “individuo” no tiene “social skills”, no es mi problema. / No le hagas ni caso  MC tu solo trats de ser amable >-< / Ni k fuera tan dficil chico :( / Y si ns comportamos como buenos compañeros y nos hacemos tomodachis? ;)

    [SerializeField] GameObject t51;    //... / ... / Y estás en un entorno laboral, no puedes comportarte como un crío de 10 años.... / “Tomodachis”.....

    [SerializeField] GameObject t52;    //Hum... no discutais mas... ¿si? / Chicos... / Habló la que escribe como una prepuber analfabeta y el egocéntrico insolente. / ...

    [SerializeField] GameObject t53;    //Esso esoooooo >:(( / De verdad, si es que no se puede hablar con el. / ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ouch... / Please?? ^·^;

    [SerializeField] GameObject t54;    //Hacednos csoo plss!! / Eres la persona menos indicada para decir algo asi... / Uy.... como se nota esa envidia, ¿eh? / ...

    [SerializeField] GameObject t55;    //Ke estas¡is discutiendo por bobadasss / No empecemos eeehhhhh???? / ¿Envidia...? ¿De ti...? / Please???? >:(((

    [SerializeField] GameObject t56;    //Venga.... ya basta.... / Siiiiii parad ya prfaaaaaaaaa >-<;;;;;

    [SerializeField] GameObject t57;    //Vale... / Muy bien... Me llamo Kieran

    [SerializeField] GameObject t58;    //Al fiiiiiin >.< Hay cari lo kt a costao jo ^-^;; 

    [SerializeField] GameObject t59;    //Pero k nombre mas raro.... Es afrikano o algo asi? ;)

    [SerializeField] GameObject t60;    //Ese nombre... Es de origen feérico, ¿no?

    [SerializeField] GameObject t61;    //Lol... ahora entiendo por que no querias decirlo.

    [SerializeField] GameObject t62;    //...

    [SerializeField] GameObject t63;    //STOP!! 

    [SerializeField] GameObject t64;    //No ms pleas chicossss >.<;;

    [SerializeField] GameObject t65;    //K me enfado >:(((((

    [SerializeField] GameObject t66;    //Pues nada.... Buena suerte a tod@s :) / Dios....La que nos espera.... / El trabajo será mio >:) / Bueno... pues...emmm... buena suerte a todos...

    [SerializeField] GameObject t67;    //

    [SerializeField] GameObject t68;    //

    [SerializeField] GameObject t69;    //

    [SerializeField] GameObject t70;    //

    [SerializeField] GameObject t71;    //

    [SerializeField] GameObject t72;    //K me enfado >:(((((

    [SerializeField] GameObject t73;    //Pues nada.... Buena suerte a tod@s :) / Dios....La que nos espera.... / El trabajo será mio >:) / Bueno... pues...emmm... buena suerte a todos...

    [SerializeField] GameObject t74;    //

    [SerializeField] GameObject t75;    //

    [SerializeField] GameObject t76;    //

    [SerializeField] GameObject t77;    //

    [SerializeField] GameObject t78;



    [SerializeField] GameObject text1_1; //For "Hola..."
    [SerializeField] GameObject text2_1;
    [SerializeField] GameObject text3_1;
    [SerializeField] GameObject text4_1;


    [SerializeField] GameObject text1_2; //For "Yo soy MC"
    [SerializeField] GameObject text2_2;
    [SerializeField] GameObject text3_2;
    [SerializeField] GameObject text4_2;


    [SerializeField] GameObject text1_3; //Para "MC"
    [SerializeField] GameObject text2_3;
    [SerializeField] GameObject text3_3;
    [SerializeField] GameObject text4_3;
    [SerializeField] GameObject text5_3;


    [SerializeField] GameObject text1_4; //For "¿Y por qué debería presentarme? No os conozco de nada."
    [SerializeField] GameObject text1_4otro;
    [SerializeField] GameObject text2_4;
    [SerializeField] GameObject text3_4;
    [SerializeField] GameObject text4_4;
    [SerializeField] GameObject text5_4;


    [SerializeField] GameObject text1_5; //For "   "
    [SerializeField] GameObject text2_5;
    [SerializeField] GameObject text3_5;
    [SerializeField] GameObject text4_5;
    [SerializeField] GameObject text5_5;


    [SerializeField] GameObject text5; //To continue the conversation (Si te has presentado) 
    [SerializeField] GameObject text5o1;
    [SerializeField] GameObject text6;
    [SerializeField] GameObject text7;
    [SerializeField] GameObject text8;
    [SerializeField] GameObject text9;
    [SerializeField] GameObject text10;
    [SerializeField] GameObject text10o1;
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
    [SerializeField] GameObject text24;
    [SerializeField] GameObject text25;
    [SerializeField] GameObject text26;
    [SerializeField] GameObject text27;
    [SerializeField] GameObject text28;
    [SerializeField] GameObject text29;
    [SerializeField] GameObject text30;
    [SerializeField] GameObject text31;
    [SerializeField] GameObject text32;
    [SerializeField] GameObject text33;
    [SerializeField] GameObject btn7;
    [SerializeField] GameObject btn8;
    [SerializeField] GameObject btn9;
    [SerializeField] GameObject btn10;

    [SerializeField] GameObject btn7no;
    [SerializeField] GameObject btn8no;
    [SerializeField] GameObject btn9no;
    [SerializeField] GameObject btn10no;
    [SerializeField] GameObject btn4no;
    [SerializeField] GameObject btn3no;
    [SerializeField] GameObject btn5no;
    [SerializeField] GameObject btn6no;



    [SerializeField] GameObject text1_6; //Para "Bueno... si no se quiere presentar, no pasa nada...¿no?"
    [SerializeField] GameObject text2_6;
    [SerializeField] GameObject text3_6;
    [SerializeField] GameObject text4_6;
    [SerializeField] GameObject text5_6;
    [SerializeField] GameObject text6_6;
    [SerializeField] GameObject text7_6;
    [SerializeField] GameObject text8_6;
    [SerializeField] GameObject text9_6;



    [SerializeField] GameObject text1_7; //Para "¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil."
    [SerializeField] GameObject text2_7;
    [SerializeField] GameObject text3_7;
    [SerializeField] GameObject text4_7;
    [SerializeField] GameObject text5_7;
    [SerializeField] GameObject text6_7;
    [SerializeField] GameObject text7_7;
    [SerializeField] GameObject text8_7;
    [SerializeField] GameObject text9_7;
    [SerializeField] GameObject text10_7;
    [SerializeField] GameObject text11_7;



    [SerializeField] GameObject text1_8; //Para "Venga... No discutais.... Recordad que estamos a prueba para el trabajo..."
    [SerializeField] GameObject text2_8;
    [SerializeField] GameObject text3_8;
    [SerializeField] GameObject text4_8;
    [SerializeField] GameObject text5_8;
    [SerializeField] GameObject text6_8;
    [SerializeField] GameObject text7_8;
    [SerializeField] GameObject text8_8;
    [SerializeField] GameObject text9_8;


    [SerializeField] GameObject text1_9; //Para "None (Parte 2 xD)"
    [SerializeField] GameObject text2_9;
    [SerializeField] GameObject text3_9;
    [SerializeField] GameObject text4_9;
    [SerializeField] GameObject text5_9;
    [SerializeField] GameObject text6_9;
    [SerializeField] GameObject text7_9;
    [SerializeField] GameObject text8_9;
    [SerializeField] GameObject text9_9;



    [SerializeField] GameObject text34; //Para la 2º continuación.
    [SerializeField] GameObject text35;
    [SerializeField] GameObject text36;
    [SerializeField] GameObject text37;
    [SerializeField] GameObject text38;
    [SerializeField] GameObject text39;
    [SerializeField] GameObject text40;
    [SerializeField] GameObject text41;
    [SerializeField] GameObject text42;
    [SerializeField] GameObject text43;
    [SerializeField] GameObject btn11;
    [SerializeField] GameObject btn12;
    [SerializeField] GameObject btn13;
    [SerializeField] GameObject btn11no;
    [SerializeField] GameObject btn12no;
    [SerializeField] GameObject btn13no;
    [SerializeField] GameObject btn14;
    [SerializeField] GameObject btn14no;



    [SerializeField] GameObject text1_10; //Para "Pues nada.... Buena suerte a tod@s :)"
    [SerializeField] GameObject text2_10;
    [SerializeField] GameObject text3_10;
    [SerializeField] GameObject text4_10;
    [SerializeField] GameObject text5_10;



    [SerializeField] GameObject text1_11; //Para "Dios....La que nos espera...."
    [SerializeField] GameObject text2_11;
    [SerializeField] GameObject text3_11;
    [SerializeField] GameObject text4_11;
    [SerializeField] GameObject text5_11;



    [SerializeField] GameObject text1_12; //Para "El trabajo será mio >:)"
    [SerializeField] GameObject text2_12;
    [SerializeField] GameObject text3_12;
    [SerializeField] GameObject text4_12;
    [SerializeField] GameObject text5_12;



    [SerializeField] GameObject text1_13; //Para otro none kawaii xD
    [SerializeField] GameObject text2_13;
    [SerializeField] GameObject text3_13;
    [SerializeField] GameObject text4_13;
    



    [SerializeField] GameObject text44; //Para la 3º continuación.
    [SerializeField] GameObject text45;
    [SerializeField] GameObject text46;
    [SerializeField] GameObject text47;
    [SerializeField] GameObject text48;
    [SerializeField] GameObject text49;
    [SerializeField] GameObject text50;
    [SerializeField] GameObject text51;
    [SerializeField] GameObject text52;
    [SerializeField] GameObject text53;


    [SerializeField] GameObject text1_14; //Para El primer none de todos.
    [SerializeField] GameObject text2_14;
    [SerializeField] GameObject text3_14;
    [SerializeField] GameObject text4_14;
    [SerializeField] GameObject text5_14;



    [SerializeField] GameObject text1_15; //Para el none despues del none
    [SerializeField] GameObject text2_15;
    [SerializeField] GameObject text3_15;
    [SerializeField] GameObject text4_15;
    [SerializeField] GameObject text5_15;
    [SerializeField] GameObject text6_15;


    [SerializeField] GameObject text1_16; //Para "Bueno... si no se quiere presentar, no pasa nada...¿no?" nonp
    [SerializeField] GameObject text2_16;
    [SerializeField] GameObject text3_16;


    [SerializeField] GameObject text1_17; //Para "¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil." nonp
    [SerializeField] GameObject text2_17;
    [SerializeField] GameObject text3_17;
    [SerializeField] GameObject text4_17;
    [SerializeField] GameObject text5_17;


    [SerializeField] GameObject text1_18; //Para "Venga... No discutais.... Recordad que estamos a prueba para el trabajo..." nonp
    [SerializeField] GameObject text2_18;
    [SerializeField] GameObject text3_18;


    [SerializeField] GameObject text1_19; //Para "Yo soy MC" nonp
    [SerializeField] GameObject text2_19;
    [SerializeField] GameObject text3_19;
    [SerializeField] GameObject text4_19;
    [SerializeField] GameObject text5_19;


    [SerializeField] GameObject text1_20; //Para "MC" nonp
    [SerializeField] GameObject text2_20;
    [SerializeField] GameObject text3_20;
    [SerializeField] GameObject text4_20;
    [SerializeField] GameObject text5_20;



    [SerializeField] GameObject text1_21; //Para "¿Y por qué debería presentarme? No os conozco de nada." nonp
    [SerializeField] GameObject text2_21;
    [SerializeField] GameObject text3_21;
    [SerializeField] GameObject text4_21;
    [SerializeField] GameObject text5_21;



    [SerializeField] GameObject text1_22; //Para "   " nonp
    [SerializeField] GameObject text2_22;
    [SerializeField] GameObject text3_22;
    [SerializeField] GameObject text4_22;


    [SerializeField] GameObject text1_23; //Para "   " nonp
    [SerializeField] GameObject text2_23;
    [SerializeField] GameObject text3_23;
    [SerializeField] GameObject text4_23;


    [SerializeField] GameObject text1_24; //Para "   " nonp
    [SerializeField] GameObject text2_24;
    [SerializeField] GameObject text3_24;
    [SerializeField] GameObject text4_24;



    [SerializeField] GameObject text1_25; //Para "   " nonp
    [SerializeField] GameObject text2_25;
    [SerializeField] GameObject text3_25;
    [SerializeField] GameObject text4_25;
    [SerializeField] GameObject text5_25;


    //Para los textos del slider.
    [SerializeField] GameObject t1;
    [SerializeField] GameObject t2;
    [SerializeField] GameObject t3;
    [SerializeField] GameObject t4;
    [SerializeField] GameObject t5;
    [SerializeField] GameObject t6;
    [SerializeField] GameObject t7;




    // Use this for initialization
    GameObject affin;



    private void Start()
    {
        affin = GameObject.FindGameObjectWithTag("affin");
    }

    public void On_gustoClick()
    {

        StartCoroutine(QuienEres());
    }

    public void On_holaClick()
    {
        StartCoroutine(Hola());
    }

    public void On_YoSoyMCClick()
    {
        StartCoroutine(YoSoyMc());
    }

    public void On_MCClick()
    {
        StartCoroutine(Mc());
    }

    public void On_YPorQueClick()
    {
        StartCoroutine(YPorQueDeberia());
    }

    public void On_NONEClick()
    {
        StartCoroutine(None1());
    }

    public void On_ContinuarClick()
    {
        StartCoroutine(Continue1());
    }

    public void On_SiNoQuiere()
    {
        StartCoroutine(BuenoSiNoQuiere());
    }

    public void On_PorQueNoSimple()
    {
        StartCoroutine(PorQueNoSimplemente());
    }

    public void On_TrabajoClick()
    {
        StartCoroutine(VengaNoDiscutais());
    }

    public void On_NONE2Click()
    {
        StartCoroutine(None2());
    }

    public void On_SuerteClick()
    {
        StartCoroutine(BuenaSuerte());
    }

    public void On_LaquesperaClick()
    {
        StartCoroutine(LaQNosEspera());
    }

    public void On_TrabajomineClick()
    {
        StartCoroutine(TrabajoMio());
    }

    public void On_None1primClick()
    {
        StartCoroutine(NonePrim());
    }

    public void On_Prefierono()
    {
        StartCoroutine(PrefieroNoPresent());
    }

    public void On_Nonetrasnon1Click()
    {
        StartCoroutine(NondedNon());
    }

    public void On_None2Click()
    {
        StartCoroutine(None2());
    }

    IEnumerator QuienEres()                                                                                                 //Si eliges "Si, ¿Quién eres?"
    {

        affin.GetComponent<Affinity>().moreaf(10f, "nancy");

        t8.SetActive(true);
        text1.SetActive(true); //Si, ¿Quién eres?
        btn1.SetActive(false); //Dile bye bye a los demás botones xD 
        btn2.SetActive(false);
        btn6.SetActive(false);


        yield return new WaitForSeconds(1);
        t9.SetActive(true);
        text2.SetActive(true);              //Nancy Melson y tu? :)
        btn1.SetActive(false);


        yield return new WaitForSeconds(2);
        t10.SetActive(true);
        text3.SetActive(true);              //Jack.


        yield return new WaitForSeconds(1.5f);
        t11.SetActive(true);
        text4.SetActive(true);              //¿Y tu eres...?


        yield return new WaitForSeconds(1);
        btn3.SetActive(true);
        btn4.SetActive(true);
        btn5.SetActive(true);
        btn6otro.SetActive(true);
    }



    IEnumerator Hola()                                                                                                      //Si eliges "Hola..."
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        t8.SetActive(true);
        text1_1.SetActive(true); //Hola...
        btn1.SetActive(false); //Dile bye bye a los demás botones xD
        btn2.SetActive(false);
        btn6.SetActive(false);


        yield return new WaitForSeconds(1);
        t9.SetActive(true);
        text2_1.SetActive(true);              //holiiiii :)))
        btn2.SetActive(false);


        yield return new WaitForSeconds(2);
        t10.SetActive(true);
        text3_1.SetActive(true);              //Soy Nancy y tu? ;)


        yield return new WaitForSeconds(2);
        t11.SetActive(true);
        text4_1.SetActive(true);              //Hola. Soy Jack.


        yield return new WaitForSeconds(1);
        btn3.SetActive(true);
        btn4.SetActive(true);
        btn5.SetActive(true);
        btn6otro.SetActive(true);

    }


    IEnumerator YoSoyMc()                                                                                                   //Si eliges "Yo soy MC"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "nancy");
        t12.SetActive(true);
        text1_2.SetActive(true); //Yo soy MC, mucho gusto                                                   
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_2.SetActive(true);                //Iguakmenteeeeee  ^o^  


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text3_2.SetActive(true);                //Encantado.


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text4_2.SetActive(true);                //:D


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Botonespresen());
    }


    IEnumerator Mc()                                                                                                        //Si eliges "MC"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        t12.SetActive(true);
        text1_3.SetActive(true); //MC
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_3.SetActive(true);                //Ah, bien.  


        yield return new WaitForSeconds(1.5f);
        text3_3.SetActive(true);                //Hola, MC. 


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text4_3.SetActive(true);                //Soy Jack. 


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text5_3.SetActive(true);                //Mucho gustoooo MC soy Nancyy :)))


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Botonespresen());
    }


    IEnumerator YPorQueDeberia()                                                                                            //Si eliges "¿Y por qué debería presentarme? No os conozco de nada."
    {

        affin.GetComponent<Affinity>().lessaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");
        t12.SetActive(true);
        text1_4.SetActive(true); //¿Y por qué debería presentarme? No os conozco de nada.
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_4.SetActive(true);                //Hayyyy cieloooo.  


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text3_4.SetActive(true);                //K cascarrabias eres u_u”


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text4_4.SetActive(true);                //Pero lo que dice es razonable.


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text5_4.SetActive(true);                //T_T


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Nopresen());
    }


    IEnumerator None1()                                                                                                     //Si eliges "   "
    {

        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        t12.SetActive(true);
        text1_5.SetActive(true);                //¿No sabe no contesta?  

        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_5.SetActive(true);                //Huyyyy k borde T-T

        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_5.SetActive(true);                //Kt cuesta???

        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text2_5.SetActive(true);                //Costar, nada, pero no parece que vaya a respondernos...

        yield return new WaitForSeconds(1.5f);
        t14.SetActive(true);
        text2_5.SetActive(true);                //Kt cuesta???

        yield return new WaitForSeconds(2);     //Joooooooo ;-;
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Nopresen());


    }


    IEnumerator Continue1()                                                                                                     //Sigue la conversación.
    {
        yield return new WaitForSeconds(1.5f);
        t14.SetActive(true);
        text5.SetActive(true);                //Bueno, tenemos temas mas importantes de los que hablar.  

        yield return new WaitForSeconds(1.5f);
        t15.SetActive(true);
        text5o1.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t16.SetActive(true);
        text6.SetActive(true);                //Lol, temas + importantes????

        yield return new WaitForSeconds(2);
        t17.SetActive(true);
        text7.SetActive(true);                //Ya leiste el por que estamos aqui, ¿no?

        yield return new WaitForSeconds(2);
        t18.SetActive(true);
        text8.SetActive(true);                //Oooooohhhhh las pruebas esas no?

        yield return new WaitForSeconds(2);
        t19.SetActive(true);
        text9.SetActive(true);                //¿Leiste el mensaje?

        yield return new WaitForSeconds(2);
        t20.SetActive(true);
        text10.SetActive(true);                //Siiiiii lo de la ventanita de LEISSS :)

        yield return new WaitForSeconds(1.5f);
        t21.SetActive(true);
        text10o1.SetActive(true);

        yield return new WaitForSeconds(2);
        t22.SetActive(true);
        text11.SetActive(true);                //¿Lo de la supuesta prueba...?

        yield return new WaitForSeconds(2);
        t23.SetActive(true);
        text12.SetActive(true);                //Holiiiii kien eresss??? :)   

        yield return new WaitForSeconds(2);
        t24.SetActive(true);
        text13.SetActive(true);                //¿Y a ti que te importa?

        yield return new WaitForSeconds(2);
        t25.SetActive(true);
        text14.SetActive(true);                //Alaaaaaa pro pr k??? k borde ;-;

        yield return new WaitForSeconds(2);
        t26.SetActive(true);
        text15.SetActive(true);                //Baja esos humos, chaval.

        yield return new WaitForSeconds(2);
        t27.SetActive(true);
        text16.SetActive(true);                //¿Y tu quien te crees que eres para mandarme a mi nada?

        yield return new WaitForSeconds(2);
        t28.SetActive(true);
        text17.SetActive(true);                //Pues el que se va a quedar con el puesto de trabajo.

        yield return new WaitForSeconds(2);
        t29.SetActive(true);
        text18.SetActive(true);                //¿Quien va a querer a un borde de mierda en su empresa?

        yield return new WaitForSeconds(2);
        t30.SetActive(true);
        text19.SetActive(true);                //¿Disculpa...?

        yield return new WaitForSeconds(2);
        t31.SetActive(true);
        text20.SetActive(true);                //Boysss plssss STOP FIGHTING ;-;

        yield return new WaitForSeconds(2);
        t32.SetActive(true);
        text21.SetActive(true);                //¿Quién no se va a molestar con alguien tan desagradable?

        yield return new WaitForSeconds(2);
        t33.SetActive(true);
        text22.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t34.SetActive(true);
        text23.SetActive(true);                //Hey.... no os peleeis por favor.... 

        yield return new WaitForSeconds(2);
        t35.SetActive(true);
        text24.SetActive(true);                //Huyy y tu kien eres? :)))         

        yield return new WaitForSeconds(2);
        t36.SetActive(true);
        text25.SetActive(true);                //Hum.... Thais......

        yield return new WaitForSeconds(2);
        t37.SetActive(true);
        text26.SetActive(true);                //Encantada Thais!! yo soy Nancy ;)

        yield return new WaitForSeconds(2);
        t38.SetActive(true);
        text27.SetActive(true);                //Jack.

        yield return new WaitForSeconds(2);
        t39.SetActive(true);
        text28.SetActive(true);                //Encantado.

        yield return new WaitForSeconds(2);
        t40.SetActive(true);
        text29.SetActive(true);                //Por suerte, el número de personas incivilizadas es relativamente bajo.

        yield return new WaitForSeconds(2);
        t41.SetActive(true);
        text30.SetActive(true);                //No empeceis otra vzzzz >.<;;;;   

        yield return new WaitForSeconds(2);
        t42.SetActive(true);
        text31.SetActive(true);                //No me puedo creer que un payaso como tu haya conseguido siquiera una entrevista de trabajo...

        yield return new WaitForSeconds(2);
        t43.SetActive(true);
        text32.SetActive(true);                //Y te lo vas a creer menos todavía cuando a mi me cojan y a ti no.

        yield return new WaitForSeconds(2);
        t44.SetActive(true);
        text33.SetActive(true);                //...

    }


    IEnumerator Botonespresen()  //Esto es para seguir la conversación si te has presentado
    {
        yield return new WaitForSeconds(2);
        btn7.SetActive(true);                  //Election time :D
        btn8.SetActive(true);
        btn9.SetActive(true);
        btn10.SetActive(true);
    }

    IEnumerator Nopresen()  //Esto es para seguir la conversación si has pasado de responder nada o no has hablado en toda la conversación :) Haber si ya de paso te acuerdas de meter la variante de que no te quieres presentar porque eres especial, que ya va siendo hora de que las cosas funcionen correctamente, ¿no? con esa memoria, no se como te vas a aprender el guion de la obra ¬.¬;;
    {
        yield return new WaitForSeconds(2);
        btn7no.SetActive(true);                  //Election time >:D
        btn8no.SetActive(true);
        btn9no.SetActive(true);
        btn10no.SetActive(true);
    }



    IEnumerator BuenoSiNoQuiere()                                                                                                     //Si eliges "Bueno... si no se quiere presentar, no pasa nada...¿no?"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(5f, "thai");

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        t45.SetActive(true);
        text1_6.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text2_6.SetActive(true);                //No necesito que nadie me defienda...

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text3_6.SetActive(true);                //Pfff ¿Veis a lo que me refiero?

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_6.SetActive(true);                //No le hagas ni caso  MC tu solo trats de ser amable >-<

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_6.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t50.SetActive(true);
        text6_6.SetActive(true);                //Chicos...

        yield return new WaitForSeconds(2);
        t51.SetActive(true);
        text7_6.SetActive(true);                //De verdad, si es que no se puede hablar con el.

        yield return new WaitForSeconds(2);
        t52.SetActive(true);
        text8_6.SetActive(true);                //Eres la persona menos indicada para decir algo asi...

        yield return new WaitForSeconds(2);
        t53.SetActive(true);
        text9_6.SetActive(true);                //No empecemos eeehhhhh????
        t54.SetActive(true);
        yield return new WaitForSeconds(2);

        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);

    }


    IEnumerator PorQueNoSimplemente()                                                                                                     //Si eliges "¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil."
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        affin.GetComponent<Affinity>().lessaf(10f, "kieran");
        affin.GetComponent<Affinity>().moreaf(5f, "nancy");
        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        t45.SetActive(true);
        text1_7.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text2_7.SetActive(true);                //¿Y si no me da la gana...?

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text3_7.SetActive(true);                //Solo es diecir tu nmbre >.<;;;;

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_7.SetActive(true);                //Ni k fuera tan dficil chico :(

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_7.SetActive(true);                //Y estás en un entorno laboral, no puedes comportarte como un crío de 10 años....

        yield return new WaitForSeconds(2);
        t50.SetActive(true);
        text6_7.SetActive(true);                //Habló la que escribe como una prepuber analfabeta y el egocéntrico insolente.

        yield return new WaitForSeconds(2);
        t51.SetActive(true);
        text7_7.SetActive(true);                //;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ouch...

        yield return new WaitForSeconds(2);
        t52.SetActive(true);
        text8_7.SetActive(true);                //Uy.... como se nota esa envidia, ¿eh?

        yield return new WaitForSeconds(2);
        t53.SetActive(true);
        text9_7.SetActive(true);                //¿Envidia...? ¿De ti...?

        yield return new WaitForSeconds(2);
        t54.SetActive(true);
        text10_7.SetActive(true);                //Venga.... ya basta....

        yield return new WaitForSeconds(2);
        text11_7.SetActive(true);                //Siiiiii parad ya prfaaaaaaaaa >-<;;;;;

        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }


    IEnumerator VengaNoDiscutais()                                                                                                     //Venga... No discutais.... Recordad que estamos a prueba para el trabajo...
    {
        affin.GetComponent<Affinity>().moreaf(10f, "thai");
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        t45.SetActive(true);
        text1_8.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text2_8.SetActive(true);                //Ssssss verdaaaaad chicos ya vale no? :(

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text3_8.SetActive(true);                //Tienes razón. Esta discusión es un despropósito...

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_8.SetActive(true);                //Si este “individuo” no tiene “social skills”, no es mi problema.

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_8.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t50.SetActive(true);
        text6_8.SetActive(true);                //Hum... no discutais mas... ¿si?

        yield return new WaitForSeconds(2);
        t51.SetActive(true);
        text7_8.SetActive(true);                //Esso esoooooo >:((

        yield return new WaitForSeconds(2);
        t52.SetActive(true);
        text8_8.SetActive(true);                //Hacednos csoo plss!!

        yield return new WaitForSeconds(2);
        t53.SetActive(true);
        text9_8.SetActive(true);                //Ke estas¡is discutiendo por bobadasss
        t54.SetActive(true);
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }


    IEnumerator None2()                                                                                                     //" "
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn7no.SetActive(false);
        btn8no.SetActive(false);
        btn9no.SetActive(false);
        btn10.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text1_9.SetActive(true);                // STOP 

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text2_9.SetActive(true);                //Sta discusion no tiene ningun sentido T-T

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text3_9.SetActive(true);                //Nancy tiene razón....

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_9.SetActive(true);                //Y si ns comportamos como buenos compañeros y nos hacemos tomodachis? ;)

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_9.SetActive(true);                //“Tomodachis”.....

        yield return new WaitForSeconds(2);
        t50.SetActive(true);
        text6_9.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t51.SetActive(true);
        text7_9.SetActive(true);                //Please?? ^·^;

        yield return new WaitForSeconds(2);
        t52.SetActive(true);
        text8_9.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t53.SetActive(true);
        text9_9.SetActive(true);                //Please???? >:(((
        t54.SetActive(true);
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }



    IEnumerator Continue2()                                                                                                     //Sigue la conversación.
    {
        yield return new WaitForSeconds(1.5f);
        t55.SetActive(true);
        text34.SetActive(true);                //Vale...

        yield return new WaitForSeconds(1.5f);
        t55.SetActive(true);
        text35.SetActive(true);                //Muy bien... Me llamo Kieran

        yield return new WaitForSeconds(1.5f);
        t56.SetActive(true);
        text36.SetActive(true);                //Al fiiiiiin >.< Hay cari lo kt a costao jo ^-^;;

        yield return new WaitForSeconds(2);
        t57.SetActive(true);
        text37.SetActive(true);                //Pero k nombre mas raro.... Es afrikano o algo asi? ;)

        yield return new WaitForSeconds(2);
        t58.SetActive(true);
        text38.SetActive(true);                //Ese nombre... Es de origen feérico, ¿no?

        yield return new WaitForSeconds(2);
        t59.SetActive(true);
        text39.SetActive(true);                //Lol... ahora entiendo por que no querias decirlo.

        yield return new WaitForSeconds(2);
        t60.SetActive(true);
        text40.SetActive(true);                 //...

        yield return new WaitForSeconds(1.5f);
        t61.SetActive(true);
        text41.SetActive(true);                 // STOP!!  

        yield return new WaitForSeconds(2);
        t62.SetActive(true);
        text42.SetActive(true);                 //No ms pleas chicossss >.<;; 

        yield return new WaitForSeconds(2);
        t63.SetActive(true);
        text43.SetActive(true);                 //K me enfado >:(((((

        yield return new WaitForSeconds(2);



    }

    IEnumerator BuenaSuerte()                                                                                                     //Si eliges "Pues nada.... Buena suerte a tod@s :)"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(5f, "kieran");
        affin.GetComponent<Affinity>().moreaf(10f, "thai");
        affin.GetComponent<Affinity>().moreaf(5f, "jack");
        btn11.SetActive(false); //Dile bye bye a los demás botones xD
        btn12.SetActive(false);
        btn13.SetActive(false);
        btn14.SetActive(false);
        text1_10.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_10.SetActive(true);                //Thanksssss ^w^ <3<3<3

        yield return new WaitForSeconds(1.5f);
        text3_10.SetActive(true);                //Gracias, pero no la necesito. Esto está ganado

        yield return new WaitForSeconds(2);
        text4_10.SetActive(true);                //Buena suerte también.... :)

        yield return new WaitForSeconds(2);
        text5_10.SetActive(true);                //Gracias...
        StartCoroutine(Continue3());


    }


    IEnumerator LaQNosEspera()                                                                                                     //Si eliges "Dios....La que nos espera...."
    {
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");
        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        text1_11.SetActive(true);


        yield return new WaitForSeconds(1.5f);
        text2_11.SetActive(true);                //Huyhuyhuy no nos gafeees >.<;

        yield return new WaitForSeconds(1.5f);
        text3_11.SetActive(true);                //Con esta panda de individuos... Te lo aseguro...

        yield return new WaitForSeconds(2);
        text4_11.SetActive(true);                //¿Contigo? Pfff, el sufrimiento será interminable...

        yield return new WaitForSeconds(2);
        text5_11.SetActive(true);                //... :(

        yield return new WaitForSeconds(2);
        StartCoroutine(Continue3());
    }


    IEnumerator TrabajoMio()                                                                                                     //El trabajo será mio >:)
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        affin.GetComponent<Affinity>().moreaf(5f, "nancy");
        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        text1_12.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_12.SetActive(true);                //¡HA! Sigue soñando.

        yield return new WaitForSeconds(1.5f);
        text3_12.SetActive(true);                //Hahahahaha eso suena a reto?:p

        yield return new WaitForSeconds(2);
        text4_12.SetActive(true);                //Yo... también quiero conseguirlo....

        yield return new WaitForSeconds(2);
        text5_12.SetActive(true);                //...Si esta es la competencia... no puede ser tan difícil...
        StartCoroutine(Continue3());
    }


    IEnumerator None3()                                                                                                     //" "
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        text1_13.SetActive(true);                // Bueno... pues...emmm... buena suerte a todos... 

        yield return new WaitForSeconds(1.5f);
        text2_13.SetActive(true);                //Ooooowwwww buena suerte Thaiii \ºvº/ <3 <3 <3

        yield return new WaitForSeconds(2);
        text3_13.SetActive(true);                //Heh, gracias, pero el ganador seré yo.

        yield return new WaitForSeconds(2);
        text4_13.SetActive(true);                //Gracias... la vamos a necesitar...

        

        yield return new WaitForSeconds(2);
        StartCoroutine(Continue3());

    }


    IEnumerator Continue3()                                                                                                     //Sigue la conversación.
    {
        yield return new WaitForSeconds(1.5f);
        text44.SetActive(true);                //Bueno, mejor no pierdo mas el tiempo.

        yield return new WaitForSeconds(1.5f);
        text45.SetActive(true);                //Contra antes empiece con las pruebas, antes conseguiré el puesto.

        yield return new WaitForSeconds(1.5f);
        text46.SetActive(true);                //Adios.

        yield return new WaitForSeconds(1.2f);
        text47.SetActive(true);                //.Jack ha salido dell chat grupal

        yield return new WaitForSeconds(2);
        text48.SetActive(true);                //Byeeeeeeeee ;))))

        yield return new WaitForSeconds(1.5f);
        text49.SetActive(true);                //Nancy :) ha salido del chat grupal 

        yield return new WaitForSeconds(2);
        text50.SetActive(true);                 //Suerte a todos.... :)

        yield return new WaitForSeconds(1.5f);
        text51.SetActive(true);                 // ... Yo me largo...  

        yield return new WaitForSeconds(1.5f);
        text52.SetActive(true);                 //J.P. ha salido dell chat grupal

        yield return new WaitForSeconds(1.2f);
        text53.SetActive(true);                 //Thailea ha salido dell chat grupal

        yield return new WaitForSeconds(1);




    }


    IEnumerator NonePrim()                                                                                                     //" "
    {

        btn1.SetActive(false); //Dile bye bye a los demás botones xD
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn6.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        text1_14.SetActive(true);                // Soy Nancyyyy :))

        yield return new WaitForSeconds(1.5f);
        text2_14.SetActive(true);                //Y tu?

        yield return new WaitForSeconds(2);
        text3_14.SetActive(true);                //Jack

        yield return new WaitForSeconds(2);
        text4_14.SetActive(true);                //Nice t meet yu <3<3<3<3

        yield return new WaitForSeconds(2);
        text5_14.SetActive(true);                //Eh... ok.

        yield return new WaitForSeconds(2);
        btn3.SetActive(true);
        btn4.SetActive(true);
        btn5alt.SetActive(true);
        btn6otro2.SetActive(true);

    }


    IEnumerator PrefieroNoPresent()                                                                                            //Si eliges "¿Y por qué debería presentarme? No os conozco de nada."
    {
        affin.GetComponent<Affinity>().lessaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");

        text1_4otro.SetActive(true); //¿Y por qué debería presentarme? No os conozco de nada.
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        text2_4.SetActive(true);                //Hayyyy cieloooo.  


        yield return new WaitForSeconds(1.5f);
        text3_4.SetActive(true);                //K cascarrabias eres u_u”


        yield return new WaitForSeconds(2);
        text4_4.SetActive(true);                //Pero lo que dice es razonable.


        yield return new WaitForSeconds(2);
        text5_4.SetActive(true);                //T_T


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());

        yield return new WaitForSeconds(60);
        StartCoroutine(Nopresen());

    }

    IEnumerator NondedNon()                                                                                            //Si eliges el none después del primer none .
    {

        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        text1_15.SetActive(true);                //;)))))))))  


        yield return new WaitForSeconds(1.5f);
        text2_15.SetActive(true);                //Lol.


        yield return new WaitForSeconds(2);
        text3_15.SetActive(true);                //Nancy... ¿tú cuantos años tienes...?


        yield return new WaitForSeconds(2);
        text4_15.SetActive(true);                //Uy eso es secret ;D

        yield return new WaitForSeconds(2);
        text5_15.SetActive(true);                //Emmm ya, claro...

        yield return new WaitForSeconds(2);
        text6_15.SetActive(true);                //Hehe pero kconste ksoy jovensita ;D


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());

        yield return new WaitForSeconds(60);
        StartCoroutine(Nopresen());

    }



    IEnumerator BuenoSiNoQuiereSinPresen()                                                                                                     //Si eliges "Bueno... si no se quiere presentar, no pasa nada...¿no?"
    {
        affin.GetComponent<Affinity>().moreaf(5f, "kieran");


        btn7no.SetActive(false); //Dile bye bye a los demás botones xD
        btn8no.SetActive(false);
        btn9no.SetActive(false);
        btn10no.SetActive(false);
        t45.SetActive(true);
        text1_6.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text1_16.SetActive(true);                //... ¿Por qué solo me insistís a mi, cuando queda gente sin presentarse?

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text2_16.SetActive(true);                //Porque no es que haya participado en la conversación, que digamos...

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text3_16.SetActive(true);                //Huyhuy y tkien eresss??? :D

        yield return new WaitForSeconds(2);
        btn3no.SetActive(true);
        btn4no.SetActive(true);
        btn5no.SetActive(true);
        btn6no.SetActive(true);


    }



    IEnumerator PorQueNoSimplementenopres()                                                                                                     //Si eliges "¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil."
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        affin.GetComponent<Affinity>().lessaf(10f, "kieran");
        affin.GetComponent<Affinity>().moreaf(5f, "nancy");
        btn7no.SetActive(false); //Dile bye bye a los demás botones xD
        btn8no.SetActive(false);
        btn9no.SetActive(false);
        btn10no.SetActive(false);
        t45.SetActive(true);
        text1_17.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text2_17.SetActive(true);                //Holiiii???

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text3_17.SetActive(true);                //...Dice alguien que no se ha presentado...

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_17.SetActive(true);                //La hipocresía lol.

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_17.SetActive(true);                //Emm... ¿Y tu quién eres?



        yield return new WaitForSeconds(2);
        btn3no.SetActive(true);
        btn4no.SetActive(true);
        btn5no.SetActive(true);
        btn6no.SetActive(true);

    }


    IEnumerator VengaNoDiscutaisnopres()                                                                                                     //Venga... No discutais.... Recordad que estamos a prueba para el trabajo...
    {
        affin.GetComponent<Affinity>().moreaf(10f, "thai");
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");

        btn7no.SetActive(false); //Dile bye bye a los demás botones xD
        btn8no.SetActive(false);
        btn9no.SetActive(false);
        btn10no.SetActive(false);
        t45.SetActive(true);
        text1_18.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text2_18.SetActive(true);                //OMG el desconocip tiene razooon :(

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text3_18.SetActive(true);                //¿Y usted es el encargado...?


        yield return new WaitForSeconds(2);
        btn3no.SetActive(true);
        btn4no.SetActive(true);
        btn5no.SetActive(true);
        btn6no.SetActive(true);

    }


    IEnumerator None2nopres()                                                                                                     //" "
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn7no.SetActive(false);
        btn8no.SetActive(false);
        btn9no.SetActive(false);
        btn10no.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t46.SetActive(true);
        text1_9.SetActive(true);                // STOP 

        yield return new WaitForSeconds(1.5f);
        t47.SetActive(true);
        text2_9.SetActive(true);                //Sta discusion no tiene ningun sentido T-T

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text3_9.SetActive(true);                //Nancy tiene razón....

        yield return new WaitForSeconds(2);
        t48.SetActive(true);
        text4_9.SetActive(true);                //Y si ns comportamos como buenos compañeros y nos hacemos tomodachis? ;)

        yield return new WaitForSeconds(2);
        t49.SetActive(true);
        text5_9.SetActive(true);                //“Tomodachis”.....

        yield return new WaitForSeconds(2);
        t50.SetActive(true);
        text6_9.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t51.SetActive(true);
        text7_9.SetActive(true);                //Please?? ^·^;

        yield return new WaitForSeconds(2);
        t52.SetActive(true);
        text8_9.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        t53.SetActive(true);
        text9_9.SetActive(true);                //Please???? >:(((
        t54.SetActive(true);
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11no.SetActive(true);
        btn12no.SetActive(true);
        btn13no.SetActive(true);
        btn14no.SetActive(true);
    }


    IEnumerator YoSoyMc2()                                                                                                   //Si eliges "Yo soy MC"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "nancy");
        t12.SetActive(true);
        text1_19.SetActive(true); //Yo soy MC, mucho gusto                                                   
        btn3no.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4no.SetActive(false);
        btn5no.SetActive(false);
        btn6no.SetActive(false);

        btn6otro2.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_19.SetActive(true);                //Igualmenteeeee yopsoy Nancyyyy ^.^ 


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text3_19.SetActive(true);                //Jack.Encantado


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text4_19.SetActive(true);                //Yo soy Thai, encantada :)

        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text5_19.SetActive(true);                //Ejhemmmmm :))))))))


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }


    IEnumerator Mc2()                                                                                                        //Si eliges "MC"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        t12.SetActive(true);
        text1_20.SetActive(true); //MC
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_20.SetActive(true);                // Hola, soy Jack.


        yield return new WaitForSeconds(1.5f);
        text3_20.SetActive(true);                //Yo Nancyyyyy :D


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text4_20.SetActive(true);                //Soy Thai :)


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text5_20.SetActive(true);                //Bueno, creo que solo queda uno por presentarse...


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }


    IEnumerator YPorQueDeberia2()                                                                                            //Si eliges "¿Y por qué debería presentarme? No os conozco de nada."
    {

        affin.GetComponent<Affinity>().lessaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");
        t12.SetActive(true);
        text1_21.SetActive(true); //¿Y por qué debería presentarme? No os conozco de nada.
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_21.SetActive(true);                //Huyyyy otro igkual  u_u


        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text3_21.SetActive(true);                //Bueno, entonces no hace falta que me presente tampoco, ¿no?


        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text4_21.SetActive(true);                //Al menos no ha sido borde al negarse a presentarse, no como otros...


        yield return new WaitForSeconds(2);
        t15.SetActive(true);
        text5_21.SetActive(true);                //Vengaaaaa poresentate y asin no hay tntos desconocidossss


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);
    }


    IEnumerator None1delnopresen()                                                                                                     //Si eliges "   "
    {
        affin.GetComponent<Affinity>().lessaf(10f, "nancy");
        affin.GetComponent<Affinity>().lessaf(10f, "jack");
        affin.GetComponent<Affinity>().lessaf(10f, "kieran");
        affin.GetComponent<Affinity>().lessaf(10f, "thai");
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        t12.SetActive(true);
        text1_22.SetActive(true);                //... 

        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text2_22.SetActive(true);                //¡Felicidades! oficialmente ha aparecido alguien mas maleducado que Kieran.

        yield return new WaitForSeconds(1.5f);
        t13.SetActive(true);
        text3_22.SetActive(true);                //...:(

        yield return new WaitForSeconds(2);
        t14.SetActive(true);
        text4_22.SetActive(true);                //k brdeeeee vnga presentate y asi al mneos desaparecen los malos rllos :D



        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
        yield return new WaitForSeconds(20);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);


    }


    IEnumerator BuenaSuertenopres()                                                                                                     //Si eliges "Pues nada.... Buena suerte a tod@s :)"
    {
        affin.GetComponent<Affinity>().moreaf(10f, "nancy");
        affin.GetComponent<Affinity>().moreaf(5f, "kieran");
        affin.GetComponent<Affinity>().moreaf(10f, "thai");
        affin.GetComponent<Affinity>().moreaf(5f, "jack");
        btn11no.SetActive(false); //Dile bye bye a los demás botones xD
        btn12no.SetActive(false);
        btn13no.SetActive(false);
        btn14no.SetActive(false);
        text1_23.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_23.SetActive(true);                //Uyyy thks eeehhhhh desconocidp????? `-´;


        yield return new WaitForSeconds(1.5f);
        text3_23.SetActive(true);                //... Tanta insistencia para que me presente, ¿y hay alguien que ni siquiera a participado en la conversación?...


        yield return new WaitForSeconds(2);
        text4_23.SetActive(true);                //¿Quién eres tu?


        StartCoroutine(Continue3());


    }


    IEnumerator LaQNosEsperanopres()                                                                                                     //Si eliges "Dios....La que nos espera...."
    {
        affin.GetComponent<Affinity>().moreaf(10f, "kieran");
       btn11no.SetActive(false); //Dile bye bye a los demás botones xD
       btn12no.SetActive(false);
       btn13no.SetActive(false);
        btn14no.SetActive(false);
        text1_24.SetActive(true);


        yield return new WaitForSeconds(1.5f);
        text2_24.SetActive(true);                //Eeeeemmmmmm hola?????? ;-;


        yield return new WaitForSeconds(1.5f);
        text3_24.SetActive(true);                //¿Y tu eres...?

        yield return new WaitForSeconds(2);
        text4_24.SetActive(true);                //...


        StartCoroutine(Continue3());
    }


    IEnumerator TrabajoMionopres()                                                                                                     //El trabajo será mio >:)
    {
        affin.GetComponent<Affinity>().moreaf(10f, "jack");
        affin.GetComponent<Affinity>().moreaf(5f, "nancy");
       btn11no.SetActive(false); //Dile bye bye a los demás botones xD
       btn12no.SetActive(false);
       btn13no.SetActive(false);
        btn14no.SetActive(false);
        text1_25.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_25.SetActive(true);                //Whoaaaaaaa un cmpetidor aparecio d ela nadaaaaa o.O


        yield return new WaitForSeconds(1.5f);
        text3_25.SetActive(true);                //Wow, ¿Y tu de dónde sales? ¿Crees que vas a ganarme

        yield return new WaitForSeconds(2);
        text4_25.SetActive(true);                //...

        yield return new WaitForSeconds(2);
        text5_25.SetActive(true);                //Cuanto espíritu de competición ^-^;
        StartCoroutine(Continue3());
    }


    IEnumerator nopres()                                                                                                     //" "
    {

        btn11no.SetActive(false); //Dile bye bye a los demás botones xD
        btn12no.SetActive(false);
        btn13no.SetActive(false);
        btn14no.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        text1_13.SetActive(true);                // Bueno... pues...emmm... buena suerte a todos... 

        yield return new WaitForSeconds(1.5f);
        text2_13.SetActive(true);                //Ooooowwwww buena suerte Thaiii \ºvº/ <3 <3 <3

        yield return new WaitForSeconds(2);
        text3_13.SetActive(true);                //Heh, gracias, pero el ganador seré yo.

        yield return new WaitForSeconds(2);
        text4_13.SetActive(true);                //Gracias... la vamos a necesitar...

        

        yield return new WaitForSeconds(2);
        StartCoroutine(Continue3());

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiQuienEres : MonoBehaviour {
    [SerializeField] GameObject text1; //Para "Si, ¿Quién eres?" (Y botones en general)
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

    
    [SerializeField] GameObject t8; //Para textos del scroll
    [SerializeField] GameObject t9;
    [SerializeField] GameObject t10;
    [SerializeField] GameObject t11;
    [SerializeField] GameObject t12;
    [SerializeField] GameObject t13;
    [SerializeField] GameObject t14;
    [SerializeField] GameObject t15;
    [SerializeField] GameObject t16;
    [SerializeField] GameObject t17;
    [SerializeField] GameObject t18;
    [SerializeField] GameObject t19;
    [SerializeField] GameObject t20;
    [SerializeField] GameObject t21;
    [SerializeField] GameObject t22;


    [SerializeField] GameObject text1_1; //Para "Hola..."
    [SerializeField] GameObject text2_1;
    [SerializeField] GameObject text3_1;
    [SerializeField] GameObject text4_1;


    [SerializeField] GameObject text1_2; //Para "Yo soy MC"
    [SerializeField] GameObject text2_2;
    [SerializeField] GameObject text3_2;
    [SerializeField] GameObject text4_2;


    [SerializeField] GameObject text1_3; //Para "MC"
    [SerializeField] GameObject text2_3;
    [SerializeField] GameObject text3_3;
    [SerializeField] GameObject text4_3;
    [SerializeField] GameObject text5_3;


    [SerializeField] GameObject text1_4; //Para "¿Y por qué debería presentarme? No os conozco de nada."
    [SerializeField] GameObject text1_4otro;
    [SerializeField] GameObject text2_4;
    [SerializeField] GameObject text3_4;
    [SerializeField] GameObject text4_4;
    [SerializeField] GameObject text5_4;


    [SerializeField] GameObject text1_5; //Para "   "
    [SerializeField] GameObject text2_5;
    [SerializeField] GameObject text3_5;
    [SerializeField] GameObject text4_5;
    [SerializeField] GameObject text5_5;


    [SerializeField] GameObject text5; //Para continuar la conversación (Si te has presentado) 
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
    [SerializeField] GameObject btn14;



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



    //Para los textos del slider.
    [SerializeField] GameObject t1;
    [SerializeField] GameObject t2;
    [SerializeField] GameObject t3;
    [SerializeField] GameObject t4;
    [SerializeField] GameObject t5;
    [SerializeField] GameObject t6;
    [SerializeField] GameObject t7;




    // Use this for initialization


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


    IEnumerator QuienEres()                                                                                                 //Si eliges "Si, ¿Quién eres?"
    {
        text1.SetActive(true); //Si, ¿Quién eres?
        btn1.SetActive(false); //Dile bye bye a los demás botones xD 
        btn2.SetActive(false);
        btn6.SetActive(false);
        

        yield return new WaitForSeconds(1);
        text2.SetActive(true);              //Nancy Melson y tu? :)
        btn1.SetActive(false);
        

        yield return new WaitForSeconds(2); 
        text3.SetActive(true);              //Jack.
        

        yield return new WaitForSeconds(1.5f); 
        text4.SetActive(true);              //¿Y tu eres...?
        

        yield return new WaitForSeconds(1);
        btn3.SetActive(true);
        btn4.SetActive(true);
        btn5.SetActive(true);
        btn6otro.SetActive(true);
    }           

    

    IEnumerator Hola()                                                                                                      //Si eliges "Hola..."
    {
        text1_1.SetActive(true); //Hola...
        btn1.SetActive(false); //Dile bye bye a los demás botones xD
        btn2.SetActive(false);
        btn6.SetActive(false);
        

        yield return new WaitForSeconds(1);
        text2_1.SetActive(true);              //holiiiii :)))
        btn2.SetActive(false);
        

        yield return new WaitForSeconds(2);
        text3_1.SetActive(true);              //Soy Nancy y tu? ;)


        yield return new WaitForSeconds(2);
        text4_1.SetActive(true);              //Hola. Soy Jack.


        yield return new WaitForSeconds(1);
        btn3.SetActive(true);
        btn4.SetActive(true);
        btn5.SetActive(true);
        btn6otro.SetActive(true);

    }


    IEnumerator YoSoyMc()                                                                                                   //Si eliges "Yo soy MC"
    {
        text1_2.SetActive(true); //Yo soy MC, mucho gusto                                                   
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);



        yield return new WaitForSeconds(1.5f);
        text2_2.SetActive(true);                //Iguakmenteeeeee  ^o^  
        

        yield return new WaitForSeconds(2);
        text3_2.SetActive(true);                //Encantado.


        yield return new WaitForSeconds(2);
        text4_2.SetActive(true);                //:D


        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Botonespresen());
    }


    IEnumerator Mc()                                                                                                        //Si eliges "MC"
    {
        text1_3.SetActive(true); //MC
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        btn5alt.SetActive(false);
        btn6otro2.SetActive(false);


        yield return new WaitForSeconds(1.5f);
        text2_3.SetActive(true);                //Ah, bien.  
        

        yield return new WaitForSeconds(1.5f);
        text3_3.SetActive(true);                //Hola, MC. 
        

        yield return new WaitForSeconds(2);
        text4_3.SetActive(true);                //Soy Jack. 
        

        yield return new WaitForSeconds(2);
        text5_3.SetActive(true);                //Mucho gustoooo MC soy Nancyy :)))
        

        yield return new WaitForSeconds(2);
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Botonespresen());
    }


    IEnumerator YPorQueDeberia()                                                                                            //Si eliges "¿Y por qué debería presentarme? No os conozco de nada."
    {
        text1_4.SetActive(true); //¿Y por qué debería presentarme? No os conozco de nada.
        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);
        

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


    IEnumerator None1()                                                                                                     //Si eliges "   "
    {

        btn3.SetActive(false);   //Dile bye bye a los demás botones xD
        btn4.SetActive(false);
        btn5.SetActive(false);
        btn6otro.SetActive(false);

        

        yield return new WaitForSeconds(1.5f);
        text1_5.SetActive(true);                //¿No sabe no contesta?  
        
        yield return new WaitForSeconds(1.5f);
        text2_5.SetActive(true);                //Huyyyy k borde T-T

        yield return new WaitForSeconds(1.5f);
        text2_5.SetActive(true);                //Kt cuesta???

        yield return new WaitForSeconds(2);     
        text2_5.SetActive(true);                //Costar, nada, pero no parece que vaya a respondernos...

        yield return new WaitForSeconds(1.5f);
        text2_5.SetActive(true);                //Kt cuesta???

        yield return new WaitForSeconds(2);     //Joooooooo ;-;
        StartCoroutine(Continue1());
        yield return new WaitForSeconds(60);
        StartCoroutine(Nopresen());


    }


    IEnumerator Continue1()                                                                                                     //Sigue la conversación.
    {
        yield return new WaitForSeconds(1.5f);
        text5.SetActive(true);                //Bueno, tenemos temas mas importantes de los que hablar.  
        yield return new WaitForSeconds(1.5f);
        text5o1.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        text6.SetActive(true);                //Lol, temas + importantes????
        yield return new WaitForSeconds(2);
        text7.SetActive(true);                //Ya leiste el por que estamos aqui, ¿no?
        yield return new WaitForSeconds(2);
        text8.SetActive(true);                //Oooooohhhhh las pruebas esas no?
        yield return new WaitForSeconds(2);
        text9.SetActive(true);                //¿Leiste el mensaje?
        yield return new WaitForSeconds(2);
        text10.SetActive(true);                //Siiiiii lo de la ventanita de LEISSS :)
        yield return new WaitForSeconds(1.5f);
        text10o1.SetActive(true);
        yield return new WaitForSeconds(2);
        text11.SetActive(true);                //¿Lo de la supuesta prueba...?
        yield return new WaitForSeconds(2);
        text12.SetActive(true);                //Holiiiii kien eresss??? :)   
        yield return new WaitForSeconds(2);
        text13.SetActive(true);                //¿Y a ti que te importa?
        yield return new WaitForSeconds(2);
        text14.SetActive(true);                //Alaaaaaa pro pr k??? k borde ;-;
        yield return new WaitForSeconds(2);
        text15.SetActive(true);                //Baja esos humos, chaval.
        yield return new WaitForSeconds(2);
        text16.SetActive(true);                //¿Y tu quien te crees que eres para mandarme a mi nada?
        yield return new WaitForSeconds(2);
        text17.SetActive(true);                //Pues el que se va a quedar con el puesto de trabajo.
        yield return new WaitForSeconds(2);
        text18.SetActive(true);                //¿Quien va a querer a un borde de mierda en su empresa?
        yield return new WaitForSeconds(2);
        text19.SetActive(true);                //¿Disculpa...?
        yield return new WaitForSeconds(2);
        text20.SetActive(true);                //Boysss plssss STOP FIGHTING ;-;
        yield return new WaitForSeconds(2);
        text21.SetActive(true);                //¿Quién no se va a molestar con alguien tan desagradable?
        yield return new WaitForSeconds(2);
        text22.SetActive(true);                //...
        yield return new WaitForSeconds(2);
        text23.SetActive(true);                //Hey.... no os peleeis por favor.... 
        yield return new WaitForSeconds(2);
        text24.SetActive(true);                //Huyy y tu kien eres? :)))         
        yield return new WaitForSeconds(2);
        text25.SetActive(true);                //Hum.... Thais......
        yield return new WaitForSeconds(2);
        text26.SetActive(true);                //Encantada Thais!! yo soy Nancy ;)
        yield return new WaitForSeconds(2);
        text27.SetActive(true);                //Jack.
        yield return new WaitForSeconds(2);
        text28.SetActive(true);                //Encantado.
        yield return new WaitForSeconds(2);
        text29.SetActive(true);                //Por suerte, el número de personas incivilizadas es relativamente bajo.
        yield return new WaitForSeconds(2);
        text30.SetActive(true);                //No empeceis otra vzzzz >.<;;;;   
        yield return new WaitForSeconds(2);
        text31.SetActive(true);                //No me puedo creer que un payaso como tu haya conseguido siquiera una entrevista de trabajo...
        yield return new WaitForSeconds(2);
        text32.SetActive(true);                //Y te lo vas a creer menos todavía cuando a mi me cojan y a ti no.
        yield return new WaitForSeconds(2);
        text33.SetActive(true);                //...
       
    }


    IEnumerator Botonespresen()
    {
        yield return new WaitForSeconds(2);
        btn7.SetActive(true);                  //Election time :D
        btn8.SetActive(true);
        btn9.SetActive(true);
        btn10.SetActive(true);
    }

    IEnumerator Nopresen()
    {
        yield return new WaitForSeconds(2);
        btn7no.SetActive(true);                  //Election time >:D
        btn8no.SetActive(true);
        btn9no.SetActive(true);
        btn10.SetActive(true);
    }



    IEnumerator BuenoSiNoQuiere()                                                                                                     //Si eliges "Bueno... si no se quiere presentar, no pasa nada...¿no?"
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        text1_6.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_6.SetActive(true);                //No necesito que nadie me defienda...
        yield return new WaitForSeconds(1.5f);
        text3_6.SetActive(true);                //Pfff ¿Veis a lo que me refiero?
        yield return new WaitForSeconds(2);
        text4_6.SetActive(true);                //No le hagas ni caso  MC tu solo trats de ser amable >-<
        yield return new WaitForSeconds(2);
        text5_6.SetActive(true);                //...
        yield return new WaitForSeconds(2);
        text6_6.SetActive(true);                //Chicos...
        yield return new WaitForSeconds(2);
        text7_6.SetActive(true);                //De verdad, si es que no se puede hablar con el.
        yield return new WaitForSeconds(2);
        text8_6.SetActive(true);                //Eres la persona menos indicada para decir algo asi...
        yield return new WaitForSeconds(2);
        text9_6.SetActive(true);                //No empecemos eeehhhhh????
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());

    }


    IEnumerator PorQueNoSimplemente()                                                                                                     //Si eliges "¿Por que no simplemente dices tu nombre y ya? No creo que sea tan difícil."
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        text1_7.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_7.SetActive(true);                //¿Y si no me da la gana...?
        yield return new WaitForSeconds(1.5f);
        text3_7.SetActive(true);                //Solo es diecir tu nmbre >.<;;;;
        yield return new WaitForSeconds(2);
        text4_7.SetActive(true);                //Ni k fuera tan dficil chico :(
        yield return new WaitForSeconds(2);
        text5_7.SetActive(true);                //Y estás en un entorno laboral, no puedes comportarte como un crío de 10 años....
        yield return new WaitForSeconds(2);
        text6_7.SetActive(true);                //Habló la que escribe como una prepuber analfabeta y el egocéntrico insolente.
        yield return new WaitForSeconds(2);
        text7_7.SetActive(true);                //;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ;-; ouch...
        yield return new WaitForSeconds(2);
        text8_7.SetActive(true);                //Uy.... como se nota esa envidia, ¿eh?
        yield return new WaitForSeconds(2);
        text9_7.SetActive(true);                //¿Envidia...? ¿De ti...?
        yield return new WaitForSeconds(2);
        text10_7.SetActive(true);                //Venga.... ya basta....
        yield return new WaitForSeconds(2);
        text11_7.SetActive(true);                //Siiiiii parad ya prfaaaaaaaaa >-<;;;;;
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
    }


    IEnumerator VengaNoDiscutais()                                                                                                     //Venga... No discutais.... Recordad que estamos a prueba para el trabajo...
    {

        btn7.SetActive(false); //Dile bye bye a los demás botones xD
        btn8.SetActive(false);
        btn9.SetActive(false);
        btn10.SetActive(false);
        text1_8.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        text2_8.SetActive(true);                //Ssssss verdaaaaad chicos ya vale no? :(
        yield return new WaitForSeconds(1.5f);
        text3_8.SetActive(true);                //Tienes razón. Esta discusión es un despropósito...
        yield return new WaitForSeconds(2);
        text4_8.SetActive(true);                //Si este “individuo” no tiene “social skills”, no es mi problema.
        yield return new WaitForSeconds(2);
        text5_8.SetActive(true);                //...
        yield return new WaitForSeconds(2);
        text6_8.SetActive(true);                //Hum... no discutais mas... ¿si?
        yield return new WaitForSeconds(2);
        text7_8.SetActive(true);                //Esso esoooooo >:((
        yield return new WaitForSeconds(2);
        text8_8.SetActive(true);                //Hacednos csoo plss!!
        yield return new WaitForSeconds(2);
        text9_8.SetActive(true);                //Ke estas¡is discutiendo por bobadasss
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
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
        text1_9.SetActive(true);                // STOP 
        yield return new WaitForSeconds(1.5f);
        text2_9.SetActive(true);                //Sta discusion no tiene ningun sentido T-T
        yield return new WaitForSeconds(2);
        text3_9.SetActive(true);                //Nancy tiene razón....
        yield return new WaitForSeconds(2);
        text4_9.SetActive(true);                //Y si ns comportamos como buenos compañeros y nos hacemos tomodachis? ;)
        yield return new WaitForSeconds(2);
        text5_9.SetActive(true);                //“Tomodachis”.....
        yield return new WaitForSeconds(2);
        text6_9.SetActive(true);                //...
        yield return new WaitForSeconds(2);
        text7_9.SetActive(true);                //Please?? ^·^;
        yield return new WaitForSeconds(2);
        text8_9.SetActive(true);                //...
        yield return new WaitForSeconds(2);
        text9_9.SetActive(true);                //Please???? >:(((
        yield return new WaitForSeconds(2);
        StartCoroutine(Continue2());
    }


    IEnumerator Continue2()                                                                                                     //Sigue la conversación.
    {
        yield return new WaitForSeconds(1.5f);
        text34.SetActive(true);                //Vale...
        yield return new WaitForSeconds(1.5f);
        text35.SetActive(true);                //Muy bien... Me llamo Kieran
        yield return new WaitForSeconds(1.5f);
        text36.SetActive(true);                //Al fiiiiiin >.< Hay cari lo kt a costao jo ^-^;;
        yield return new WaitForSeconds(2);
        text37.SetActive(true);                //Pero k nombre mas raro.... Es afrikano o algo asi? ;)
        yield return new WaitForSeconds(2);
        text38.SetActive(true);                //Ese nombre... Es de origen feérico, ¿no?
        yield return new WaitForSeconds(2);
        text39.SetActive(true);                //Lol... ahora entiendo por que no querias decirlo.
        yield return new WaitForSeconds(2);
        text40.SetActive(true);                 //...
        yield return new WaitForSeconds(1.5f);
        text41.SetActive(true);                 // STOP!!  
        yield return new WaitForSeconds(2);
        text42.SetActive(true);                 //No ms pleas chicossss >.<;; 
        yield return new WaitForSeconds(2);
        text43.SetActive(true);                 //K me enfado >:(((((
        yield return new WaitForSeconds(2);
        btn11.SetActive(true);
        btn12.SetActive(true);
        btn13.SetActive(true);
        btn14.SetActive(true);

        
    }

    IEnumerator BuenaSuerte()                                                                                                     //Si eliges "Pues nada.... Buena suerte a tod@s :)"
    {

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

    IEnumerator NondedNon()                                                                                            //Si eliges el none después del none.
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
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    //En el Warcraft 3, el Príncipe Arthas quiere “reclutar” al menos 150 ciudadanos de Thrallmar.
    //La ciudad cuenta con 60 de construcciones y cada una aloja entre 2 y 8 personas, 
    //sabiendo que hay un 50% de chances de que se unan, indicar: (Las chances son por cada persona)


    //Imprima cuantos aldeanos logró reclutar tras visitar las 60 construcciones.
    //Imprima cuantas aldeanos se negaron a ser reclutados tras recorrer las 60 construcciones.
    //Indique si Arthas logró o no su cometido.

    // Start is called before the first frame update
    void Start()
    {
        //Declaro las varibles necesarias para poder realizar el codigo
        
        //Contadores
        int houses = 60;
        int recluted = 0;
        int notRecluted = 0;

        //Variables a las que voy a utilizar con randomrange para saber cant de aldeanos por casa y chances de que se recluten
        int chances;
        
        //La variable menInHouse tambien la voy a utilizar como contador y con randomrange
        int menInHouse;

        //Variable para saber si Arthas recluto 150 aldeanos
        int arthasDuty = 150;

        //Creo un while para que itere dentro de cada casa
        while (houses >= 0)
        {
            //Creo el random de cantidad de aldeanos por casa
            menInHouse = Random.Range(2, 9);
            
            //Creo un while para que itere por cada aldeano en la casa
            while (menInHouse >= 0)
            {
                //Creo el 50% de probabilidades de que un aldeano se sume a la causa de Arthas
                chances = Random.Range(0, 2);

                //Verifico si el aldeano se sumo o no
                if (chances == 0)
                {
                    //Sumo el aldeano que se unio a Arthas
                    recluted++;
                }
                else
                {
                    //Sumo el que rechazo a Arthas... Pobre diablo
                    notRecluted++;
                }
                //Resto un aldeano del contador 
                menInHouse -= 1;
            }
            //Resto una casa del contador
            houses -= 1;
        }
        //Printeo los resultado
        print("Arthas logro reclutar " + recluted + " aldeanos");
        print(notRecluted + " aldeanos se negaron a cumplir la peticion de Arthas");

        //Verifico si arthas logro su cometido o no. POR LA LUZ!!
        if (arthasDuty <= recluted)
        {
            print("Arthas logro su cometido");
        }
        else
        {
            print("Arthas no logro su cometido. MUERTE A LOS INFIELES!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

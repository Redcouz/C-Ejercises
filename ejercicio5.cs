using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    //En un juego de Dragon Ball Z hay 20 personajes enfrentado a Freezer, 
    //cada personaje realizará un ataque diferente al azar mientras Freezer esté vivo.

    //Teniendo en cuenta:
    //Hay un 10% de chances de que el personaje realice “Genkidama” , un 30% de hacer un “Kame Hame Ha” y un 60% de realizar el ”Makankosappo”.
    //Daños
    //“Genkidama”: 1500 a 3000.
    //“Kame Hame Ha”: 300 a 800.
    //“Makankosappo”: 50 a 150.
    //Hay un 20% de chance de que el daño sea crítico y se duplique.
    //La vida de freezer es de 12000

    //Indique:
    //¿Cuántos ataques de cada tipo se hicieron?
    //¿Cuantos Ataques críticos existieron?
    //Indique que pasó con Freezer, en caso de que freezer no haya muerto indicar con cuánta vida quedó.
    //¿Cuál fue el daño final realizado?

    // Start is called before the first frame update
    void Start()
    {
        //Declaro los contadores
        int pjs = 20;
        int freezerLife = 12000;
        int genkidama = 0;
        int kamehameha = 0;
        int mankankosappo = 0;
        int cantCrit = 0;
        int totalDmg = 0;

        //Declaro Variables de Dmg que despues seran utilizadas con randomrange
        int genkidamaDmg, kamehamehaDmg, mankankosappoDmg;

        //Declaro variables de porcentaje
        int typePower, critChance;

        //Creo el do while, que va a iterar mientras existen pjs (pj>=0) o freezer siga con vida (freezerLife>=0)
        do
        {
            //Hago las probabilidades para saber que tipo de poder es y si es critico o no
            typePower = Random.Range(0, 100);
            critChance = Random.Range(0, 5);
            
            //Verifico el tipo de poder
            if (typePower < 10)
            {
                //Creo el daño del poder
                genkidamaDmg = Random.Range(1500, 3001);
                
                //Verifico si es critico y si lo es le sumo 1 al contador de critico
                if (critChance == 0)
                {
                    genkidamaDmg = genkidamaDmg * 2;
                    cantCrit++;
                }
                
                //Sumo uno al contador de poder, resto vida a freezer y sumo el daño al daño total
                genkidama++;
                freezerLife = freezerLife - genkidamaDmg;
                totalDmg = totalDmg + genkidamaDmg; 
            }
            
            //repito el procedimiento anterior pero con el kamehameha y el mankankosappo
            else if(typePower < 40)
            {
                kamehamehaDmg = Random.Range(300, 801);

                if (critChance == 0)
                {
                    kamehamehaDmg = kamehamehaDmg * 2;
                    cantCrit++;
                }

                kamehameha++;
                freezerLife = freezerLife - kamehamehaDmg;
                totalDmg = totalDmg + kamehamehaDmg;
            }

            else
            {
                mankankosappoDmg = Random.Range(50, 151);

                if (critChance == 0)
                {
                    mankankosappoDmg = mankankosappoDmg * 2;
                    cantCrit++;
                }

                mankankosappo++;
                freezerLife = freezerLife - mankankosappoDmg;
                totalDmg = totalDmg + mankankosappoDmg;
            }
            
            //Resto un pj
            pjs -= 1;
            
        }
        while (pjs > 0 && freezerLife > 0);

        //Imprimo la cantidad de poderes realizados y la cantidad de criticos 
        print("Se realizaron " + genkidama + " Genkidamas, " + kamehameha + " Kamehamehas, " + mankankosappo + " Mankankosapos");
        print("Se realizaron " + cantCrit + " Ataques criticos");

        //Verifico si freezer murio o vivio e imprimo lo sucedido
        if (freezerLife <= 0)
        {
            freezerLife = 0;
            print("FREEZER HA SIDO DERROTADO");
        }
        else
        {
            print("A freezer le queda " + freezerLife + " de vida restante");
        }
        
        //Imprimo el daño total
        print("El daño total fue de " + totalDmg);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

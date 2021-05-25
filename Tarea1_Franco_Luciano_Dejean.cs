using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour

{
    //var ex0

    public int pj;
    public int money;

    //var ex1

    public int level;

    //var ex2

    public string raza;

    //var ex3

    public int tablas;
    public int obreros;
    public int clavos;
    public int alfileres;

    //var ex4

    public int punt_equipo1;
    public int punt_equipo2;
    

    // Start is called before the first frame update
    void Start()

    {
        print("Ejercisio 0");
        print("---------------------------------------------------");
        if (pj == 0)
        {
            print("No hay nadie aca che!");
        }
        else
        {

            int botin = money / pj;
            print("hay " + pj + " jugadores. Cada jugador tiene " + botin);

        }

        print("-------------------------------------------------");
        print("Ejercisio 1");
        print("-------------------------------------------------");

        if (level > 5)
        {
            print("Pasa por la puerta hermano");
        }
        else if (level == 5)
        {
            print("Si queres pasar. Entrega 5 de oro kpo");
        }
        else
        {
            print("vo so re pichichi no pasa ni a gancho");
        }
        print("-------------------------------------------------");
        print("Ejercisio 2");
        print("-------------------------------------------------");

        if (raza == "Elfo" || raza == "Enano")
        {
            print("Toma ete bonus amigo petizo o orejon");
        }
        else
        {
            print("Quien te conoce a vo? nada de bonu");
        }
        print("-------------------------------------------------");
        print("Ejercisio 3");
        print("-------------------------------------------------");

        if (tablas >= 20 && (clavos >= 100 || alfileres >= 100) && obreros >= 4)
        {
            print("Sale casa en 20min");
        }
        else if (tablas >= 10 && (clavos >= 30 || alfileres >= 30) && obreros >= 1)
        {
            print("Alta choza te hice amigo");
        }
        else
        {
            print("Te queres hacer una casa y no te alcanza ni para el pan del desayuno. Raton");
        }

        print("-------------------------------------------------");
        print("Ejercisio 4");
        print("-------------------------------------------------");

        if (punt_equipo1 == punt_equipo2)
        {
            print("Tenemos empate señoras y señores!");
        }
        else if(punt_equipo1 > punt_equipo2)
        {
            print("Gano el equipo 1!!!!!!!!!!");
        }
        else
        {
            print("Gano el equipo 2");
        }

        print("-------------------------------------------------");
        print("Fin del ejercisio");
        
    }

}

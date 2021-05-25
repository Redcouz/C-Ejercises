using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    //En un juego de plataforma necesitamos calcular la fuerza de salto que se calcula del siguiente modo:

    //La fuerza de salto base (10)  se ve afectada por el nivel que tenga el personaje, 
    //sumando a esta un 10% del nivel(ej: si el personaje es lvl 10 se suma 1 de fuerza de salto), 
    //a su vez es hay que tener en cuenta la gravedad del planeta la cual reduce la fuerza de salto quedando un 93% de su valor total) 

    //Imprima la fuerza de salto final de manera precisa, sabiendo que la fuerza base es 10, y el nivel del personaje varía entre 5 y 20. 

    // Start is called before the first frame update
    void Start()
    {
        //Declaro la variable de la fuerza base
        int fBase = 10;
        
        //Genero el random del nivel del personaje, ya que es entre 5 y 20
        int levelPj = Random.Range(5, 21);
        
        //Genero una variable float de gravedad, 
        //para poder hacer el calculo despues y sacar el 93% del total del salto
        float gravity = 0.93f;
        
        //Hago el calculo de la fuerza del salto:
        //Teniendo en cuenta el 10% del nivel, sumando la fuerza base y 
        //multiplicando por la gravedad para que quede el 93% del total de la fuerza del salto
        float fJump = ((levelPj * 0.1f) + fBase) * gravity;
        
        //Imprimo el nivel como parametro de revición
        print("tu nivel es " + levelPj);
        
        //Imprimo la resultante
        print("La fuerza del salto final es " + fJump);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{
    //En un juego de pelea medieval el brillo que tienen las armaduras varía de color e intensidad según el nivel que tenga el objeto.
    //Sabemos que si el ítem tiene un nivel menor a 4 el brillo será de color blanco y la intensidad será tenue.
    //En cambio si el nivel es 4,5,6 o 7 será de color amarillo y la intensidad moderada. 
    //Al llegar al nivel 8 el brillo será verde y la intensidad brillante, 
    //en nivel 9 será azul e intenso y 
    //al nivel máximo será Dorada y encandilante.

    //Imprima el color e intensidad según el nivel del objeto.

    // Start is called before the first frame update
      void Start()
    {
        //Declaro el nivel de la armadura de forma aleatoria para poder empezar el procedimiento 
        int levelArmor = Random.Range(0, 11);
        
        //Imprimo el nivel de la armadura como parametro de rivición
        print("Tu armadura es de nivel " + levelArmor);
         
        //Utilizo el switch para los niveles especificos
        switch (levelArmor)
        {
            case 8:
                print("Tu armadura es verde y es brillosa");
                break;
            case 9:
                print("Tu armadura es azul y brilla intensamente");
                break;
            case 10:
                print("Tu armadura es dorada y brilla de forma encandilante");
                break;
        }
        //En los ifs verifico los rangos de niveles que restan
        if (levelArmor < 4)
        {
            print("Tu armadura es blanca y brilla tenuemente");
        }
        else if(levelArmor <= 7)
        {
            print("Tu armadura es amarilla y brilla de forma moderada");
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

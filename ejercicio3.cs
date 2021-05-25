using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
    //En un juego de RPG el jugador entrará en el mercado con la intención de comprar algunos elementos:
    //Su idea es comprar los elementos para craftear 100 balas, para ello necesita(3 cajas de clavos, 2 cajas de cucharas y 1 barril de pólvora).
    //En caso de no poder comprar los tres elementos deseados el personaje tendrá que comprar un barril de pólvora.
    //En caso de no contar con el dinero para el barril, el personaje saldrá del negocio indicando que no compro nada.

    //Sabiendo que el jugador tiene una cantidad de oro entre 100 y 450, y la lista de precios de la tienda es:
    //Barril de pólvora 150 Monedas c/u
    //Caja de cuchara  50 Monedas c/u
    //Caja de clavos 20 Monedas c/u

    //Indicar:
    //Si el jugador pudo comprar el kit de elementos para craftear las 100 balas
    //Si el jugador solo compró el barril de pólvora
    //Si el jugador no compro nada.
    //En todos los casos imprimir con cuánto oro ingresó a la tienda y con cuanto salio.

    // Start is called before the first frame update
    void Start()
    {
        //Declaro las variables a utilizar
        int pjGold = Random.Range(100, 451);
        int priceGunpowder = 150;
        int priceSpoon = 50;
        int priceNails = 20;

        //Declaro una variable con el costo total de los materiales para crear 100 balas
        int craftBullet = priceGunpowder + (priceSpoon * 2) + (priceNails * 3);

        //Utilizo 2 booleanos para saber si tiene el dinero suficiente para comprar los elementos necesarios para crear las 100 balas
        //O comprar un barril de polvora
        bool canBullet = craftBullet <= pjGold;
        bool canPowder = priceGunpowder <= pjGold;

        //Imprimo la cantidad inicial de oro
        print("Tienes " + pjGold + " monedas de oro");

        //Verifico los booleanos, primero verifico el de las balas, 
        //Ya que el del barril de polvora tambien va a dar true cuando el de las balas de true
        //Si los 2 booleanos son false entonces no tiene el dinero suficiente para comprar nada
        if (canBullet)
        {
            pjGold = pjGold - craftBullet;
            //Imprimo el resultado, agregando el dinero restante
            print("Has comprado todos los elementos necesarios para fabricar 100 balas. Tu dinero restante es " + pjGold + " monedas de oro");
        }
        else if(canPowder)
        {
            pjGold = pjGold - priceGunpowder;
            //Imprimo el resultado, agregando el dinero restante
            print("Has comprado 1 barril de polvora. Tu dinero restante es " + pjGold + " monedas de oro");
        }
        else
        {
            //Imprimo el resultado, agregando el dinero restante
            print("No tienes dinero para comprar nada. Tu dinero es " + pjGold + " monedas de oro");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

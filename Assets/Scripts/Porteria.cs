using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Porteria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D bola)
    {

        if (bola.name == "Bola")
        {
            //Si es la portería izquierda
            if (this.name == "Izquierda")
            {
                //Cuento el gol y reinicio la bola
                bola.GetComponent<Bola>().reiniciarBola("Derecha");
            }
            //Si es la portería derecha
            else if (this.name == "Derecha")
            {
                //Cuento el gol y reinicio la bola
                bola.GetComponent<Bola>().reiniciarBola("Izquierda");
            }
        }
    }
}

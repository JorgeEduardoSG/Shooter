using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //para las variables debes identificar varios datos importantes
    //como ejemplo, si quieres que sea privado o publico
    //El tipo de dato que va a recibir
    //El nombre de la variable
    //de forma opcional se puede agregar un valor inicial
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 5.0f;
    
    private void Start()
    {
        Debug.Log(transform.position);
        transform.position = new Vector3(-3, 0, 0);
        
    }

    // Update is called once per frame
    private void Update()
    {
        Movimiento();
    }
    private void Movimiento()
    {
        float entradahorizontal = Input.GetAxis("Horizontal");                           //aqui simplemente se hace el calculo en el vector para el movimiento de la nave
        transform.Translate(Vector3.right * Time.deltaTime * speed * entradahorizontal); //vector3(1,0,0)*5* entrada horizontal ya sea 1(derecha), 0(quieto) y -1(izquierda)

        
        float entradavertical = Input.GetAxis("Vertical");                               //para hacer que la nave se mueva hacia arriba y abajo
        transform.Translate(Vector3.up * Time.deltaTime * speed * entradavertical);

        if (transform.position.y > 5.8f)                                                 // este es para cuando la nave sobrepasa la altura del juego regrese abajo
        {
            transform.position = new Vector3(transform.position.x, -5.8f, 0);
        }
        else if (transform.position.y < -5.8f)                                           //este de aqui es lo contrario al de arriba, si esta muy abajo lo pone arriba
        {
            transform.position = new Vector3(transform.position.x, 5.8f, 0);
        }
        if (transform.position.x > 9.3f)                                                 //este es para cuando la nave sobrepasa la derecha del mapa se teleporte a la izquierda
        {
            transform.position = new Vector3(-9.3f, transform.position.y, 0);
        }
        else if(transform.position.x < -9.3f)                                            //lo mismo pero de izquierda a derecha
        {
            transform.position = new Vector3(9.3f, transform.position.y, 0);
        }
    }
}

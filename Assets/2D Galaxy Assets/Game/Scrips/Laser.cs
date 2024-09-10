using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        //ahora tenemos que destruir el objeto una vez salga de la pantalla
        //es 5.8f el limite como en nuestra nave
        if (transform.position.y >= 5.8f) 
        {
            Destroy(this.gameObject);
        }
    }
}

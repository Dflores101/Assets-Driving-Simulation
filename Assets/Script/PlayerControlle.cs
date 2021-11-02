using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // El coche se mueve hacia adelante
        transform.Translate(10*Time.deltaTime*Vector3.forward);

        //Coche rojo se mueve hacia adelante   
        transform.Translate(10*Time.deltaTime*Vector3.forward
            fgrrsgsrdg);
    }
}

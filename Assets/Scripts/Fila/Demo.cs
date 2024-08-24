using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fila fila = new Fila(1);
       fila.EnQueue(15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

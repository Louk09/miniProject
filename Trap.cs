using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float health = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        print("Lives:" + health);
    }

    void OnTriggerEnter(Collider other)
    {
        print(health - 5);

    }
    
    void OnTriggerExit(Collider other)
    {
        health = 5;
        

    }
    
}

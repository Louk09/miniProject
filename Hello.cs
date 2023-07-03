using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    
    int health = 10;
    double crit = 11.5;

    // Start is called before the first frame update

    void Start()
    {
       print(health);
       print("hello world");
       print(crit);
    }

    // Update is called once per frame
    void Update()
    {
        print("crickets");
    }
}

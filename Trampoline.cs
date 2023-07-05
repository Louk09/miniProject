using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    public float speedfactor = 3.4f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 10.0f;

    }

    void OnTriggerExit(Collider other)
    {

        other.GetComponent<Jump>().jumpStrength = 2.0f;

    }
    
}

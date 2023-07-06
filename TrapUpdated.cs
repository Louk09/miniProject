using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Trap : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().health -= 5.0f;
        print("HP is now" + other.GetComponent<Player>().health);

        if (other.GetComponent<Player>().health <= 0)
        {
            EditorSceneManager.LoadScene("Level_1");

        }

    }
    
    void OnTriggerExit(Collider other)
    {
        
        

    }
    
}

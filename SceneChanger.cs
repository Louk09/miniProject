using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public string sceneName = "Level_1";

    void OnTriggerEnter(Collider other)
    {

        EditorSceneManager.LoadScene(sceneName);


    }
}

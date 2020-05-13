using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneToMain : MonoBehaviour
{

    public bool loadNextScene = false;
    void Update()
    {
        if (loadNextScene)
        {
            Debug.Log("load: Scene1");
            SceneManager.LoadScene(1);
        }


    }
}

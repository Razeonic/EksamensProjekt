using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public bool loadNextScene = false;
    void Update()
    {
        if (loadNextScene)
        {
            Debug.Log("load: SceneTwo");
            SceneManager.LoadScene(1);
        }


    }
}

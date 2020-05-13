using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    AudioSource m_explosion;
    public bool playsound = false;
    public float delaytimer = 3f;
    public int levelid = 3;
    void OnTriggerEnter(Collider other)
    {
        if (playsound)
        {
            m_explosion = GetComponent<AudioSource>();
            m_explosion.Play();
        }
        

        StartCoroutine(Delay());
        
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delaytimer);
        SceneManager.LoadScene(levelid);
    }
}

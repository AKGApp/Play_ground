using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public AudioSource SoundPlayer;
    public void Scene(string name)
    {
        SoundPlayer.Play();
        StartCoroutine(ExecuteAfterTime(2, name));
    }
     IEnumerator ExecuteAfterTime(float time, string X)
 {
     yield return new WaitForSeconds(time);
 
     SceneManager.LoadScene(X);
 }
}
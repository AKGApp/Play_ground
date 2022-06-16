using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delayed_Switch : MonoBehaviour
{
    public void ButtonFunction(string SceneName)
    {
        StartCoroutine(DelaySceneLoad());
        SceneManager.LoadScene(SceneName);
        
    }
    IEnumerator DelaySceneLoad()
    {
        yield return new WaitForSeconds(3f);
    }
}
 
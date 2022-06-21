using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
public class Scene1 : MonoBehaviour
{
  public static Scene1 scene1;
  public TMP_InputField Input;
  public string player_name;
  private void Awake() {
    if (scene1 == null)
    {
        scene1 = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        UnityEngine.Object.Destroy(gameObject);
    }

  }
  public void SetPlayerName()
  {
    player_name = Input.text;
    SceneManager.LoadSceneAsync("Result");

  }
}

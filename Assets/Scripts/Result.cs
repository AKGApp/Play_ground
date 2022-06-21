using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    public TextMeshProUGUI display_name;
    private void Awake() {
        display_name.text= Scene1.scene1.player_name;
    }
}

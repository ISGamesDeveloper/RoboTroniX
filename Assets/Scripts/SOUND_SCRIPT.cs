using UnityEngine;
using System.Collections;

public class SOUND_SCRIPT : MonoBehaviour {

    void Start () {    
        if (SettingsScript.sound == 0) { AudioListener.pause = true; }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (SettingsScript.sound == 0) { AudioListener.pause = false; }
        }
    }
}

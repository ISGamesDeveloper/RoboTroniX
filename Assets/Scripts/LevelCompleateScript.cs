using UnityEngine;
using System.Collections;

public class LevelCompleateScript : MonoBehaviour {

    public static bool LevelCompleate;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            LevelCompleate = true;        
        }
    }
}

using UnityEngine;

public class OchkiGroup : MonoBehaviour {

    public bool On;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            On = true;
        }
    }
    void OnTriggerExit(Collider col) 
    {
        if (col.gameObject.CompareTag("Player"))
        {
            On = false;
        }
    }
}

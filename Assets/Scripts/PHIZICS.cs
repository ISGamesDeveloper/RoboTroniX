using UnityEngine;
using System.Collections;

public class PHIZICS : MonoBehaviour
{
    public Vector3 ENTER;
    public Vector3 EXIT;
    void OnTriggerEnter(Collider col){if (col.gameObject.CompareTag("Player")){Physics.gravity = ENTER;}}
    void OnTriggerExit(Collider col){ if (col.gameObject.CompareTag("Player")){Physics.gravity = EXIT;}}
}

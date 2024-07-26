using UnityEngine;


public class KRISHKA_FINISHA1UROVEN : MonoBehaviour {

    float x,position_end;
    bool On;
    void Start()
    {
        x=transform.position.x;
        position_end = transform.position.x;
    }
	void Update () {
        if (On) { x -= 0.025f; transform.position = new Vector3(x, transform.position.y, transform.position.z); }
        if (x<position_end-1.5) { On = false; }
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            On = true;
        }
    }
}

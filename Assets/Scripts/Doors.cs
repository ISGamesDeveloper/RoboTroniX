using UnityEngine;
 
public class Doors : MonoBehaviour {

    public GameObject door;
    float player, korobka, speed2;
    public float speed;//0.01f;
    public float start_position,
                 end_position;
    bool ON;

    public bool SVET_ON;
    public Light SVET;


	void Start () {speed2=door.transform.position.y;}
	void Update () {
        if (ON)
        {
            if (player == 1 || korobka == 1)
            {
                speed2 -= speed * Time.deltaTime;
                door.transform.position = new Vector3(door.transform.position.x, speed2, door.transform.position.z);
                if (SVET_ON) { SVET.color = Color.green;}
            }
            if (player == 0 && korobka == 0)
            {
                speed2 += speed * Time.deltaTime; ;
                door.transform.position = new Vector3(door.transform.position.x, speed2, door.transform.position.z);
                if (SVET_ON) { SVET.color = Color.red; }
            }
            if (speed2 > start_position) { speed2 = start_position; }
            if (speed2 < end_position) { speed2 = end_position; }
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player")) { player = 1; ON = true; }
        if (col.gameObject.CompareTag("Cube")) { korobka = 1; ON = true; }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player")) { player = 0; }
        if (col.gameObject.CompareTag("Cube")) { korobka = 0; }
    }
}

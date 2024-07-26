using UnityEngine;
using System.Collections;

public class BATUT : MonoBehaviour {


    public float visota;
    public GameObject player; 
    Rigidbody rig;
    void Start()
    {
        player = GameObject.Find("Player 3DS");
        rig = player.GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            rig.velocity = new Vector3(rig.velocity.x, rig.velocity.y*-1*visota, rig.velocity.z);
        }
    }
}

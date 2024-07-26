using UnityEngine;
using System.Collections;

public class OPEN_DVER : MonoBehaviour {

    public GameObject door;
    public float speed,urovenSTOP;
    public bool VVERH, VNIZ;
    float player, korobka;
    public float AE;
    bool on; 

    void Update()
    {      
            if (VVERH)
        {
            if (player == 1 || korobka == 1)
            {            
                AE += speed * Time.deltaTime;
                door.transform.position = new Vector3(door.transform.position.x, transform.position.y+ AE, door.transform.position.z);
               if (door.transform.position.y > urovenSTOP) { speed = 0; }
            } 
        }
            if (VNIZ)
        {
            if (player == 1 || korobka == 1)
            {
        
                AE += speed * Time.deltaTime;
                door.transform.position = new Vector3(door.transform.position.x,  transform.position.y-AE, door.transform.position.z);
               if (door.transform.position.y < urovenSTOP) { speed = 0; }
            }
        }

        if (on)
        {
            if (player == 0 && korobka == 0)
            {            
                if (VVERH)
                {
                    AE += speed * Time.deltaTime;
                    door.transform.position = new Vector3(door.transform.position.x, transform.position.y - AE, door.transform.position.z);
                }
                if (VNIZ)
                {
                    AE += speed * Time.deltaTime;
                    door.transform.position = new Vector3(door.transform.position.x, transform.position.y + AE, door.transform.position.z);
                }

            }
        }
    }
    void OnTriggerEnter(Collider col)
       {
            if (col.gameObject.CompareTag("Player")) { player = 1; }
            if (col.gameObject.CompareTag("Cube")) { korobka = 1; }

       }
        void OnTriggerExit(Collider col)
       {
            if (col.gameObject.CompareTag("Player")) { player = 0; on = true; }
            if (col.gameObject.CompareTag("Cube")) { korobka = 0; on = true;  }
       }

    }






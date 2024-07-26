using UnityEngine;

public class DorozhkaDV : MonoBehaviour {
		
    Rigidbody rb;
    float speedPlatform1;   //была public
    public float SPEED_Dor5;
    bool On;
    bool speed;

    public bool Dor1,Dor2,Dor3,Dor4,Dor5;
    public float maxY, minY;//задать в инспекторе максимальную и минимальную позицию Y для Dor5.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (Dor1) { speedPlatform1 = 0.04f; }
        if (Dor2||Dor3||Dor4||Dor5) { speedPlatform1 = 0.03f; }        
    }
    void FixedUpdate()
    {

        if (On)
        {
            if (Dor1)
            {
                if (transform.position.x < 43.5f) { speedPlatform1 = 0.05f; }
                if (transform.position.x > 61) { speedPlatform1 = -0.05f; }
            }
            if (Dor2)
            {
                if (transform.position.x < -1f) { speedPlatform1 = 0.03f; }
                if (transform.position.x > 1f) { speedPlatform1 = -0.03f; }
            }
            if (Dor3)
            {
                if (transform.position.y < -1.5f) { speedPlatform1 = 0.05f; }
                if (transform.position.y > 1.5f) { speedPlatform1 = -0.05f; }
            }
            if (Dor4)
            {
                if (transform.position.y < 15f) { speedPlatform1 = 0.1f; }
                if (transform.position.y > 20f) { speedPlatform1 = -0.1f; }
            }
            if (Dor5)
            {
                if (transform.position.y < minY) { speedPlatform1 = SPEED_Dor5;}
                if (transform.position.y > maxY) { speedPlatform1 = -SPEED_Dor5; }    
            }
            if (Dor1 || Dor2) { rb.MovePosition(new Vector3(transform.position.x + speedPlatform1, transform.position.y, transform.position.z)); }
            if (Dor3||Dor4||Dor5) { rb.MovePosition(new Vector3(transform.position.x, transform.position.y + speedPlatform1, transform.position.z)); }         
        }      
    }
    void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag("Player")){On = true;}
	}
    void OnTriggerExit(Collider col)
	{
		if (col.gameObject.CompareTag("Player")){On = false;}
	}
}

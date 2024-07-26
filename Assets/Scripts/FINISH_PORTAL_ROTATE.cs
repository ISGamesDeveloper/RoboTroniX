using UnityEngine;

public class FINISH_PORTAL_ROTATE : MonoBehaviour {

    public bool On; 
    Vector3 eulerAngleVelocity;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void FixedUpdate()
    {
        if (On)
        {
            eulerAngleVelocity = new Vector3(5000 * Time.deltaTime, 0, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }

}

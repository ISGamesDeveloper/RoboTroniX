using UnityEngine;
using System.Collections;

public class DorozhkaRotate : MonoBehaviour {

    public Vector3 eulerAngleVelocity;
    public Rigidbody rb;
    public float speed;
    public bool On_Melnici;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (On_Melnici)
        {
                eulerAngleVelocity = new Vector3(0, speed * Time.deltaTime, 0);
                Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);
        }

    }

}
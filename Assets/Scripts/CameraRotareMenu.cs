using UnityEngine;
using System.Collections;

public class CameraRotareMenu : MonoBehaviour {
    Vector3 eulerAngleVelocity;
    Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
            eulerAngleVelocity = new Vector3(2f,2f ,2f);
            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
    }
}

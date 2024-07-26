
using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Transform target;
    private Rigidbody targetRB;
    private float distance = 3;
    public float height = 2.2f;
    public float heightDamping = 2.0f;
    public float rotationDamping = 3.0f;


    public bool aaa;
    public float speedDis;


    //@script AddComponentMenu("Camera-Control/Camera-Rolling-Player")
    private void Start()
    {
        target = transform.parent.Find("Player 3DS").transform;
        targetRB = transform.parent.Find("Player 3DS").GetComponent<Rigidbody>();
    }

    public void LateUpdate()
    {
        if (!target || !targetRB)
            return;

        var direction = Vector3.one;
        //direction.y = 1;
        //direction.x = 1;
        //direction.z = 1;
        //direction = direction.normalized;

        var wantedRotation = Quaternion.LookRotation(direction);
        var wantedRotationAngle = wantedRotation.eulerAngles.y;
        var wantedHeight = target.position.y + height;

        var currentRotation = Quaternion.LookRotation(target.position - transform.position);
        var currentRotationAngle = currentRotation.eulerAngles.y;
        var currentHeight = transform.position.y;

        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, 0);

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

        var finalRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        transform.position = target.position;
        transform.position -= finalRotation * Vector3.forward * distance;

        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        transform.LookAt(target);

        if (aaa)
        {
            distance += speedDis;
            if (distance > 3) { speedDis = 0; distance = 3; aaa = false; }
            if (distance < 0.3) { speedDis = 0; distance = 0.3f; }
        }


    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ForCamera")
        {
            aaa = true;
            speedDis = -0.1f;
        }
    }
    public void OnTriggerExit(Collider col)
    {
        if (col.tag == "ForCamera")
        {

            speedDis = 0.05f;
        }
    }

    public void CameraButton()
    {
        if (height == 1f) { height = 2.2f; return; }
        if (height == 2.2f) { height = 3.7f; return; }
        if (height == 3.7f) { height = 5f; return; }
        if (height == 5f) { height = 1f; return; }
    }
}

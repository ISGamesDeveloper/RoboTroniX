using UnityEngine;

public class ROTATEcamera : MonoBehaviour
{
    GameObject targetObject; 
    private float targetAngle = 0;
    const float rotationAmount = 2f;
    public bool Right;
    public bool Left;
    public bool NOcamera;
    GameObject cameraR;
    void Start()
    {
        targetObject = GameObject.Find("Player 3DS");
        cameraR = GameObject.Find("Camera");
    }
    void Update()
    {
        if (!NOcamera)
        {
            if (Left) { targetAngle += 2.5f + Time.deltaTime; }
            if (Right) { targetAngle -= 2.5f + Time.deltaTime; }
            if (!Right && !Left) { targetAngle = 0; }

            if (targetAngle > 0)
            {
                transform.RotateAround(targetObject.transform.position, Vector3.up, -rotationAmount);
                targetAngle -= rotationAmount;
            }
            else if (targetAngle < 0)
            {
                transform.RotateAround(targetObject.transform.position, Vector3.up, rotationAmount);
                targetAngle += rotationAmount;
            }
        }
    }
   
    public void RIGHTTRUE()
    {
        cameraR.GetComponent<ROTATEcamera>().Right = true;
    }
    public void RIGHTFALSE()
    {
        cameraR.GetComponent<ROTATEcamera>().Right = false;
    }
    public void LEFTTRUE()
    {
       cameraR.GetComponent<ROTATEcamera>().Left = true;
    }
    public void LEFTFALSE()
    {
        cameraR.GetComponent<ROTATEcamera>().Left = false;
    }
    
}
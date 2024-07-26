using UnityEngine;

public class screenshot : MonoBehaviour
{
#if UNITY_EDITOR
   int i;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            ScreenCapture.CaptureScreenshot(i + "Screenshot.png", 2);
            i++;
        }
       
    }
#endif 
}
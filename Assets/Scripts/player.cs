using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour
{

    Vector3 inp;
    Vector3 delta;
    Vector3 oldPos;
    private float pl2 = Mathf.PI * Mathf.PI;
    private float diam = 2f;
    public static float speed = 2f;
    Transform cam;
    TrailRenderer trail;
    bool traillllll;
    Vector3 cp;
    bool On;
    public bool NEplayer;//NEplayer для UI кнопки скорости!
    float ang;
    public static bool upravleniye;
   
    void Awake()
    {
        SettingsScript.control = PlayerPrefs.GetInt("control", 0);
        if (SettingsScript.control == 0) { upravleniye = false; }
        else { upravleniye=true; }
    }
    void Start()
    {
        Physics.gravity = new Vector3(0, -10, 0);
        if (!NEplayer)
        {
            trail = GetComponent<TrailRenderer>();
            oldPos = transform.position;
            speed = 2f;
            cam = GameObject.Find("Camera").GetComponent<Transform>();
        }
    }
    void Update()
    {
      
        if (!NEplayer)
        {
            if (upravleniye == false)
            {
                inp.x = CrossPlatformInputManager.GetAxis("Horizontal");
                inp.z = CrossPlatformInputManager.GetAxis("Vertical");
            }
            else {
                inp.x = Input.acceleration.x;
                inp.z = -Input.acceleration.z;
            }

            if (Input.GetKeyDown(KeyCode.LeftShift)) { speed = 5; }
            if (Input.GetKeyUp(KeyCode.LeftShift)) { speed = 2; }
            if (speed > 2) { trail.enabled = true; trail.time = 0.3f; traillllll = true; }
            if (speed == 2) { if (traillllll) { trail.time -= 0.01f; } if (trail.time < 0) { traillllll = false; trail.enabled = false; } }

        }
    }
    void FixedUpdate()
    {
        if (!NEplayer)
        {
            cp = transform.position - cam.position;
            cp.y = 0f;
            transform.Translate(Quaternion.LookRotation(cp) * inp * speed * Time.deltaTime, Space.World);
            delta = oldPos - transform.position;
            ang = Mathf.Sin(delta.magnitude / diam / pl2) * Mathf.Rad2Deg;
            transform.RotateAround(Vector3.Cross(delta, Vector3.up), ang);
            oldPos = transform.position;

            
        }
    }

    public void ON()
    { player.speed = 5f; }

    public void OFF()
    { player.speed = 2f; }

    public void STON()
    { player.upravleniye = false; }

    public void STOFF()
    { player.upravleniye = true; }




}

 

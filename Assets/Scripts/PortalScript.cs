using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour {

    public Material myMaterial; 
    public bool p1, p2,p3, p4, p5, p6, p7,p8,p9,p10; 
    public bool Blue, Cyan, Yellow, Magenta, Red,Green;
    public bool CameraXplus, CameraXminus, CameraZplus, CameraZminus;
    GameObject P1, P2, P3, P4, P5, P6, P7, P8, P9,P10,Player,Camera;
    public static byte material_count;
    public GameObject TELEPORTsound;
    public GameObject COLORsound;
    void Awake()
    {
        TELEPORTsound = GameObject.Find("телепорт");
        COLORsound = GameObject.Find("колодец");
    }
    void Start()
    {
   
        Player = GameObject.Find("Player 3DS");
        Camera = GameObject.Find("Camera");
        if (p1) { P1 = GameObject.Find("P1"); }
        if (p2) { P2 = GameObject.Find("P2"); } 
        if (p3) { P3 = GameObject.Find("P3"); }
        if (p4) { P4 = GameObject.Find("P4"); }
        if (p5) { P5 = GameObject.Find("P5"); }
        if (p6) { P6 = GameObject.Find("P6"); }
        if (p7) { P7 = GameObject.Find("P7"); }
        if (p8) { P8 = GameObject.Find("P8"); }
        if (p9) { P9 = GameObject.Find("P9"); }
        if (p10) { P9 = GameObject.Find("P10"); }
    }
    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.CompareTag("Player"))
        {       
            if (p1){ Player.transform.position = P1.transform.position;TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p2){ Player.transform.position = P2.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p3){ Player.transform.position = P3.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p4){ Player.transform.position = P4.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p5){ Player.transform.position = P5.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p6){ Player.transform.position = P6.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p7){ Player.transform.position = P7.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p8){ Player.transform.position = P8.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p9){ Player.transform.position = P9.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }
            if (p10) { Player.transform.position = P10.transform.position; TELEPORTsound.GetComponent<AudioSource>().Play(); }

            if (CameraXplus) { Camera.transform.position = new Vector3(Player.transform.position.x + 10f, Player.transform.position.y, Player.transform.position.z); }
            if (CameraXminus) { Camera.transform.position = new Vector3(Player.transform.position.x - 10f, Player.transform.position.y, Player.transform.position.z); }
            if (CameraZplus) { Camera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + 10f); }
            if (CameraZminus) { Camera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 10f); }

            if (Blue) { myMaterial.color = Color.blue;material_count = 1; COLORsound.GetComponent<AudioSource>().Play(); }
            if (Cyan) { myMaterial.color = Color.cyan; material_count = 2; COLORsound.GetComponent<AudioSource>().Play(); }
            if (Yellow) { myMaterial.color = Color.yellow; material_count = 3; COLORsound.GetComponent<AudioSource>().Play(); }
            if (Magenta) { myMaterial.color = Color.magenta; material_count = 4; COLORsound.GetComponent<AudioSource>().Play(); }
            if (Red){myMaterial.color = Color.red; material_count = 5; COLORsound.GetComponent<AudioSource>().Play(); }
            if (Green) { myMaterial.color = Color.green; material_count = 6; COLORsound.GetComponent<AudioSource>().Play(); }



        }
    }
}

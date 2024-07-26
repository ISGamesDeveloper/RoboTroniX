using UnityEngine;
using System.Collections;

public class TOKscript : MonoBehaviour {

    public bool TOKon;
 //   public AudioSource MolniyaSound;
    public GameObject MolniyaImage_1;
    public GameObject MolniyaImage_2;
    public GameObject MolniyaImage_3;
    public GameObject MolniyaImage_4;
    public GameObject collider;
    public float i;
    void Start () {
        //     MolniyaSound.Play();
        MolniyaImage_1.SetActive(false);
        MolniyaImage_2.SetActive(false);
        MolniyaImage_3.SetActive(false);
        MolniyaImage_4.SetActive(false);
        collider.SetActive(false);
        i = 4;
    }
    void Update()
    {
        if (TOKon)
        {
            if (i > 0) { i -= Time.deltaTime; }
            if (i >= 3&&i<=3.1f) { MolniyaImage_1.SetActive(true); collider.SetActive(true); }
            if (i >= 2.9&&i<=3f) { MolniyaImage_1.SetActive(false); }
            if (i >= 2.8&&i<=2.9f) { MolniyaImage_2.SetActive(true); }
            if (i>=2.7&&i<=2.8) { MolniyaImage_2.SetActive(false); }
            if (i>=2.6&&i<=2.7) { MolniyaImage_3.SetActive(true); }
            if (i> 2.5&&i<=2.6) { MolniyaImage_3.SetActive(false); }
            if (i >= 2.4 && i <= 2.5) { MolniyaImage_4.SetActive(true); }
            if (i > 2.3 && i <= 2.4) { MolniyaImage_4.SetActive(false); collider.SetActive(false);}

            if (i <= 2.2) { i = 3.4f; }
        }
    }
    void OnTriggerEnter(Collider col){if (col.gameObject.CompareTag("Player")){TOKon = true;} }
    void OnTriggerExit(Collider col){
        if (col.gameObject.CompareTag("Player")){
            TOKon = false;
            MolniyaImage_1.SetActive(false);
            MolniyaImage_2.SetActive(false);
            MolniyaImage_3.SetActive(false);
            MolniyaImage_4.SetActive(false);
            collider.SetActive(false);
        }
    }
}

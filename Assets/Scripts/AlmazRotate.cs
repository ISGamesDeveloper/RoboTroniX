using UnityEngine;


public class AlmazRotate : MonoBehaviour {
    public Material CristalColor; 
    public ParticleSystem stars;
    public bool One_Kristal; 
    public bool Two_Kristal;
    public bool Three_Kristal;

    public int checkPoint;
    public static int ALMAZ_COUNT;
    public GameObject Group;
    public OchkiGroup ochki;
    public static Vector3 almazPosition;
    GameObject AlmazRotateScript;
    MeshRenderer meshr;
    private Collider collider1;
    Vector3 eulerAngleVelocity;
    Rigidbody rb;

    //Код молнии
    public bool MolniyaON;
    public AudioSource MolniyaSound;
    public GameObject MolniyaImage_1;
    public GameObject MolniyaImage_2;
    public GameObject MolniyaImage_3;
    public Material MOLNIYA;
    int i;
 

    bool On;
    void Start()  
    {
        On = true;
        ALMAZ_COUNT = 0;
        checkPoint = 0;
        meshr = GetComponent<MeshRenderer>();
        collider1 = GetComponent<Collider>();
        if (One_Kristal) { CristalColor.color = Color.magenta;}
        if (Two_Kristal) { CristalColor.color = Color.green;  }
        if (Three_Kristal) { CristalColor.color = Color.yellow;}  
        ochki = Group.GetComponent<OchkiGroup>();
        rb = GetComponent<Rigidbody>();
        
        if (MolniyaON)
        {
            MolniyaImage_1.SetActive(false);
            MolniyaImage_2.SetActive(false);
            MolniyaImage_3.SetActive(false);
        }
    }
    void Update()
    {
        if (MolniyaON)
        {
            if (i > 0) { i -= 1; }
            if (i == 39) { MolniyaImage_1.SetActive(true); }
            if (i == 25) { MolniyaImage_1.SetActive(false); }
            if (i == 30) { MolniyaImage_2.SetActive(true); }
            if (i == 15) { MolniyaImage_2.SetActive(false); }
            if (i == 15) { MolniyaImage_3.SetActive(true); }
            if (i == 1) { MolniyaImage_3.SetActive(false); }
        }
    }
    void FixedUpdate()
    {
        if (On)
        {
            if (ochki.On)
            {         
                eulerAngleVelocity = new Vector3(0, 0, 6000 * Time.deltaTime);
                Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
                rb.MoveRotation(rb.rotation * deltaRotation);         
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {          
            almazPosition = transform.position;
            if (One_Kristal) { checkPoint = 1; ALMAZ_COUNT += 1; }
            if (Two_Kristal) { checkPoint = 2; ALMAZ_COUNT += 1; }
            if (Three_Kristal) { checkPoint = 3; ALMAZ_COUNT += 1; }

            stars.startColor = CristalColor.color;
            Instantiate(stars, transform.position, transform.rotation);

            meshr.enabled = false;
            collider1.enabled = false;
            On = false;
            //Код молнии
            if (MolniyaON){MolniyaSound.Play();i = 40;}

        }
        
    
      
    
    }


}

using UnityEngine;

public class OchkiRotate : MonoBehaviour {

    public static int count ;
    public Material red;
    public ParticleSystem stars;
    public GameObject Group;
    public OchkiGroup ochki;
    public bool Melnica;
    AudioSource audio1;
    Vector3 eulerAngleVelocity;
    Rigidbody rb;
  
    void Start()
    {
            count = 0;
            ochki = Group.GetComponent<OchkiGroup>();
            stars.startColor = red.color;
            audio1 = GameObject.Find("monetki").GetComponent<AudioSource>();

            rb = GetComponent<Rigidbody>();
           
    }

    void FixedUpdate()
    {
        if (ochki.On)
        {
            eulerAngleVelocity = new Vector3(0, 10000 * Time.deltaTime, 0);
            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    } 
    void OnTriggerEnter(Collider col)
    {    
            if (col.gameObject.CompareTag("Player"))
            {
                audio1.Play();
                stars.startColor = red.color;
                Instantiate(stars, transform.position, transform.rotation);
                count += 1;
                Destroy(gameObject);
            }
    }
}

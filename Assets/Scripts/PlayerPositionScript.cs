using UnityEngine;



public class PlayerPositionScript : MonoBehaviour {                                                                                                                                                                                                                                                                                                                                                                       //By ISGames
    
	public ParticleSystem stars;
    public GameObject OKNO;
    public GameObject SHIT;
    MeshRenderer meshRend;
	Behaviour halo;
	public GameObject Yadro;
	public Material matColor;
    public static int lifes;
    Vector3 StartPositionPlayer;
    Vector3 StartPositionPCamera;
    Vector3 AlmazPositionForCamera;
	int Almaz1,Almaz2,Almaz3,DOTRONULSYA;
	bool umer;   
	float otschet;
    GameObject zvukMyacha;
    void Awake(){zvukMyacha = GameObject.Find("взрыв мяча");}
	void Start () {       
        player.speed = 2f;
        lifes = PlayerPrefs.GetInt("Lifes", 0);
        StartPositionPlayer = transform.position;
		StartPositionPCamera = GameObject.Find("Camera").transform.position;
		otschet = 0.1f;
		meshRend = GetComponent<MeshRenderer> ();
		halo = (Behaviour)GetComponent("Halo");
    }
	void Update()  
	{
		if (umer)
		{		
			if (otschet > 0f) { player.speed = 0f; otschet -= 0.1f * Time.deltaTime;}
			if (otschet <= 0f) {

				lifes -= 1;
                PlayerPrefs.SetInt("Lifes", lifes);
                if (lifes < 1) {
                    Time.timeScale = 0;
                    OKNO.SetActive(true);
                    GameObject.Find("PauseButton").SetActive(false);
				}
				Almaz1 = GameObject.Find ("Алмаз").GetComponent<AlmazRotate> ().checkPoint;
				Almaz2 = GameObject.Find ("Алмаз2").GetComponent<AlmazRotate> ().checkPoint;
				Almaz3 = GameObject.Find ("Алмаз3").GetComponent<AlmazRotate> ().checkPoint;

				if (Almaz1 == 0) {
					transform.position = StartPositionPlayer;
					GameObject.Find ("Camera").transform.position = StartPositionPCamera;
				} 
				if (Almaz1 > 0 || Almaz2 > 0 || Almaz3 > 0) {transform.position = AlmazRotate.almazPosition;}
				if (Almaz1 == 1||Almaz2 == 2||Almaz3 == 3) {GameObject.Find ("Camera").transform.position = AlmazPositionForCamera;}
                if (SHIT.activeInHierarchy) { SHIT.GetComponent<MeshRenderer>().enabled = true; }
                meshRend.enabled = true;
				halo.enabled = true;
				Yadro.SetActive (true);			
				otschet = 0.001f;
                player.speed = 2f;
                umer = false;
                DOTRONULSYA = 0;
			}
		}
	}

    void OnTriggerEnter(Collider col)
    {

		if (col.gameObject.CompareTag("Almaz")){AlmazPositionForCamera=GameObject.Find("Camera").transform.position;}
        if (col.gameObject.CompareTag("Death"))
        {

                zvukMyacha.GetComponent<AudioSource>().Play();
                if (SHIT.activeInHierarchy) { SHIT.GetComponent<MeshRenderer>().enabled = false; }
                otschet = 0.1f;
                meshRend.enabled = false;
                halo.enabled = false;
                Yadro.SetActive(false);
                stars.startColor = matColor.color;
                Instantiate(stars, transform.position, transform.rotation);
                umer = true;
        }
       
        if (col.gameObject.CompareTag("Enemy"))
        {
            if (!SHIT.activeInHierarchy)
            {
                if (DOTRONULSYA == 0)
                {
                    zvukMyacha.GetComponent<AudioSource>().Play();
                    if (SHIT.activeInHierarchy) { SHIT.GetComponent<MeshRenderer>().enabled = false; }
                    otschet = 0.1f;
                    meshRend.enabled = false;
                    halo.enabled = false;
                    Yadro.SetActive(false);
                    stars.startColor = matColor.color;
                    Instantiate(stars, transform.position, transform.rotation);
                    umer = true;
                    DOTRONULSYA = 1;
                }
            }
        }
      
    }


}

using UnityEngine;
using UnityEngine.UI;

public class SHITscript : MonoBehaviour {

    
    public static int KolichestvoShitov;  //используется только тут и в скрипте ScoreTextScript
    public static int KuplenniyeShiti; //тоже самое и еще это нужно для куленых щитов
   // public static int On_SHIT;//нужен для скрипта PlayerPositionScript.Для того что бы проверять включен ли ща щит при столкновении с врагом
    public bool SHITnaIgroke;
    public bool SHITnaKarte;    
    public GameObject SHITigroka;
    Image SHITbuttonImage;
    private GameObject player;
    public GameObject vzrivSHITA;
    public GameObject zvukSHITA;
    void Awake()
    {
        vzrivSHITA = GameObject.Find("взрыв щита");
        SHITigroka = GameObject.Find("SHIT");
        zvukSHITA = GameObject.Find("звук щита");
    }
    void Start()
    {
        player = GameObject.Find("Player 3DS");
        if (SHITnaIgroke) {  SHITigroka.SetActive(false);}
    }

    void Update () {
        if (SHITnaIgroke)
        {
            transform.position = player.transform.position;        
            if (KolichestvoShitov <= 0&&KuplenniyeShiti<=0){gameObject.SetActive(false);}           
        }
    }



void OnTriggerEnter(Collider col)
    {      
        if (SHITnaKarte)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                zvukSHITA.GetComponent<AudioSource>().Play();              
                KolichestvoShitov += 1;               
                SHITigroka.SetActive(true); 
                gameObject.SetActive(false);
            }
        }
        if (col.gameObject.CompareTag("Enemy")){
            vzrivSHITA.GetComponent<AudioSource>().Play();
            if (KolichestvoShitov <= 0 && KuplenniyeShiti > 0) { KuplenniyeShiti -= 1; }
            if (KolichestvoShitov > 0) { KolichestvoShitov -= 1; }
        }
      
    }
    public void ButtonSHIT()
    {
        if (!SHITigroka.activeInHierarchy&&KolichestvoShitov > 0|| !SHITigroka.activeInHierarchy && KuplenniyeShiti > 0)
        {         
            SHITigroka.SetActive(true);return;
        }
        if (SHITigroka.activeInHierarchy)
        {
            SHITigroka.SetActive(false);return;
        }                    
    }
}

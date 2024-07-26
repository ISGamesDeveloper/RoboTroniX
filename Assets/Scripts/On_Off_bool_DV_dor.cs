using UnityEngine;

public class On_Off_bool_DV_dor : MonoBehaviour {

    public GameObject objects;
    public bool FINISH_BOOL;
    public bool Melnica;
    public bool DV_Dorozhka,Gusenica; //Дорожка со скрипта ForBallEnemyScript
    public GameObject[] GUSENICI;
    GameObject FINISH;
     
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        { 
            if (Melnica) { objects.GetComponent<DorozhkaRotate>().On_Melnici = true; }
            if (DV_Dorozhka) { objects.GetComponent<ForBallEnemyScript>().DorozhkaOn = true; }
            if (Gusenica){for (int i = 0; i < GUSENICI.Length; i++){GUSENICI[i].GetComponent<ForBallEnemyScript>().DorozhkaOn = true;}}
            if (FINISH_BOOL) { GameObject.Find("ФИНИШ").GetComponent<FINISH_PORTAL_ROTATE>().On = true; }   
        }     
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (Melnica) { objects.GetComponent<DorozhkaRotate>().On_Melnici = false; }
            if (DV_Dorozhka) { objects.GetComponent<ForBallEnemyScript>().DorozhkaOn = false; }
            if (Gusenica) { for (int i = 1; i < GUSENICI.Length; i++) { GUSENICI[i].GetComponent<ForBallEnemyScript>().DorozhkaOn = false; } }
            if (FINISH_BOOL) { GameObject.Find("ФИНИШ").GetComponent<FINISH_PORTAL_ROTATE>().On = false; }
        }         
    }
}

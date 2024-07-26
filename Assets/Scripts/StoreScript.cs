using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreScript : MonoBehaviour {

    public bool K_Lifes, K_Shit, K_Almaz, K_Players, Open_all,Krestic;
    public GameObject RAMKA, Lifes_Obj, Shit_Obj, Almaz_Obj, Players_Obj, OpenALL_Obj, Krestic_Obj, NAZAD;
    public bool Krestic_V_BLOKE,Krestik_V_IGRE,KrestikMYACHEY;
    public bool OPENokno;
    public Text textEXIT;
    void Start()
    {
        if (Krestik_V_IGRE) { if (SettingsScript.lang == 0) { textEXIT.text = "выйти"; }if (SettingsScript.lang == 1) { textEXIT.text = "exit"; } }
    }
    public void On_Click() {
        if (!Krestik_V_IGRE) { GameObject.Find("щелчек кнопкой").GetComponent<AudioSource>().Play(); }
  
        if (K_Lifes) {
            RAMKA.SetActive(true); Lifes_Obj.SetActive(true); NAZAD.SetActive(false);
        }

        if (K_Shit) {
            RAMKA.SetActive(true); Shit_Obj.SetActive(true); NAZAD.SetActive(false);
        }

        if (K_Almaz) {
            RAMKA.SetActive(true); Almaz_Obj.SetActive(true); NAZAD.SetActive(false);
        }

        if (K_Players) {
            RAMKA.SetActive(true); Players_Obj.SetActive(true); NAZAD.SetActive(false);
        }
        //CompleteProject.Purchaser.kupili_reklamu = PlayerPrefs.GetInt("kupili_reklamu", 0);
        //if (CompleteProject.Purchaser.kupili_reklamu==0&&Open_all) {
        //    RAMKA.SetActive(true); OpenALL_Obj.SetActive(true); NAZAD.SetActive(false);
        //}
        if (Krestic) { RAMKA.SetActive(false); Lifes_Obj.SetActive(false); Shit_Obj.SetActive(false); Almaz_Obj.SetActive(false); Players_Obj.SetActive(false); OpenALL_Obj.SetActive(false); NAZAD.SetActive(true); }
        if (Krestic_V_BLOKE) { RAMKA.SetActive(false); Time.timeScale = 1f; }
        if (Krestik_V_IGRE) { PlayerPositionScript.lifes = 0; SceneManager.LoadScene("Menu"); Time.timeScale = 1f; }
        if (OPENokno) { RAMKA.SetActive(true); }
        if (KrestikMYACHEY) { RAMKA.SetActive(false);NAZAD.SetActive(true); }
    }

}

using UnityEngine;
using System.Collections;
public class LIKEGAME : MonoBehaviour
{
    public int i;
    public int pokazivatOKNO;
    public GameObject OKNOocenitINRU;
    public bool yes, no, Like_Object, ON;
    WWW www;
    void Start()
    {
        if (Like_Object)
        {
            www = new WWW("http://google.com");
            pokazivatOKNO = PlayerPrefs.GetInt("pukazivatOKNO", 0);
            i = PlayerPrefs.GetInt("i", 0);
            StartCoroutine(checkInternetConnection());
      //    i = 0;pokazivatOKNO = 0;
      //    PlayerPrefs.SetInt("i", i);
      //    PlayerPrefs.SetInt("pukazivatOKNO", pokazivatOKNO);
        }
    }

    IEnumerator checkInternetConnection()
    {    
         while (true)
         {
            yield return new WaitForSeconds(3);
            if (Like_Object){             
                if (www.error == null){ ON = true; LIKE();}     
            }
        }
    }

    void LIKE()
    {
        if (Like_Object)
        {
            if (ON)
            {
                i += 1;
                if (pokazivatOKNO != 1) { if (i == 5 || i == 12 || i == 17 || i == 22 || i == 27 || i == 32 || i == 38 || i == 45) { OKNOocenitINRU.SetActive(true); } }
                PlayerPrefs.SetInt("i", i); ON = false; Like_Object = false; StopCoroutine(checkInternetConnection());
            }
        } 
    }

    public void ONCLICK()
    {
		if (yes) {pokazivatOKNO = 1; PlayerPrefs.SetInt("pukazivatOKNO", pokazivatOKNO);Application.OpenURL("https://play.google.com/store/apps/details?id=by.ISGames.RoboTroniX"); OKNOocenitINRU.SetActive(false); }
        if (no) { OKNOocenitINRU.SetActive(false); }
    }
}

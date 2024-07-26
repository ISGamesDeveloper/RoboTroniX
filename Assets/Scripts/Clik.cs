using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clik : MonoBehaviour {
    Image i;
  //  public Material m;
    public GameObject pausePanel;
    public GameObject PAUSEBUTTON;
    public GameObject XbuttonX;
    public GameObject RestartButt;
    public GameObject MenuButt;
    public GameObject NextLevelButt;
    public GameObject PAUSETEXT;
    public GameObject LVLCOMP;
	public GameObject NullALMAZ;
    public bool pauseButton;
    public bool XButton;
    public bool RestartButton;
    public bool MenuButton;
    public bool NextLevel;

    Text t;
    int MATCOUNT;
    void Start(){
    //    if (gameObject.GetComponent<Image>()){i = GetComponent<Image>();i.color = m.color;}
      //  if (gameObject.GetComponent<Text>()) { t = GetComponent<Text>();t.color = m.color; }
       
    }

     void Update()
    { 
          //  if (MATCOUNT != PortalScript.material_count) {MATCOUNT = PortalScript.material_count; if (gameObject.GetComponent<Image>()) { i.color = m.color; }if (gameObject.GetComponent<Text>()) { t.color = m.color; }}     
            if (LevelCompleateScript.LevelCompleate) { pauseButton = true; ON(); LevelCompleateScript.LevelCompleate = false; }
    }

public void ON()
    {      
        if (pauseButton)
        {
            if (SettingsScript.sound == 0) { AudioListener.pause = true; }
           
            PAUSEBUTTON.SetActive(false);
            pausePanel.SetActive(true);
            if (!LevelCompleateScript.LevelCompleate) { XbuttonX.SetActive(true); NextLevelButt.SetActive(false); PAUSETEXT.SetActive(true); LVLCOMP.SetActive(false); }
            if (LevelCompleateScript.LevelCompleate) 
			{
				XbuttonX.SetActive(false); NextLevelButt.SetActive(true); PAUSETEXT.SetActive(false); LVLCOMP.SetActive(true);
				if (AlmazRotate.ALMAZ_COUNT == 0) {					
					NullALMAZ.SetActive (true);
					NextLevelButt.SetActive(false);
					LVLCOMP.SetActive(false);
				}
			}
            RestartButt.SetActive(true);
            MenuButt.SetActive(true);
            Time.timeScale = 0;
        }

        if (XButton)
        {
            Time.timeScale = 1;
            if (SettingsScript.sound == 0) { AudioListener.pause = false; }
            pausePanel.SetActive(false);
            XbuttonX.SetActive(false);
            RestartButt.SetActive(false);
            MenuButt.SetActive(false);
            
            PAUSEBUTTON.SetActive(true);
        }

        if (RestartButton)
        {
            if (SettingsScript.sound == 0) { AudioListener.pause = false; }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
        if (MenuButton)
        {
            
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1;
        }
        if (NextLevel) {
            PlayerPrefs.GetInt("MAX_FULL_LEVELS_ALMAZ", 0);
           // Debug.Log(PlayerPrefs.GetInt("MAX_FULL_LEVELS_ALMAZ", 0));
            if (SceneManager.GetActiveScene().name == "Level1.8") { if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 20) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } if (EXITScript.MAX_FULL_LEVELS_ALMAZ < 20) { SceneManager.LoadScene("Menu"); } }
            if (SceneManager.GetActiveScene().name == "Level2.8") { if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 45) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } if (EXITScript.MAX_FULL_LEVELS_ALMAZ < 45) { SceneManager.LoadScene("Menu"); } }
            if (SceneManager.GetActiveScene().name == "Level3.8") { SceneManager.LoadScene("Menu"); }//óáðàòü ïîòîì êàê ñäåëàþ ñëåäóþçèé áëîê.è ðàñêîìåíòèðîâàòü íèæíþþ ñòðîêó
                //  if (SceneManager.GetActiveScene().name == "Level3.8") { if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 65) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } if (EXITScript.MAX_FULL_LEVELS_ALMAZ < 65) { SceneManager.LoadScene("Menu"); } }
                //  if (SceneManager.GetActiveScene().name == "Level4.8") { if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 90) { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); } if (EXITScript.MAX_FULL_LEVELS_ALMAZ < 90) { SceneManager.LoadScene("Menu"); } }
                // if (SceneManager.GetActiveScene().name == "Level5.8") { SceneManager.LoadScene("Menu"); } //ÂÍÈÌÀÍÈÅ!ÏÐÈÄÓÌÀÒÜ ×ÒÎ ÄÅËÀÒÜ ÏÎÑËÅ ÏßÒÎÃÎ ÏËÎÊÀ!ÇÀÃÐÓÇÈÒÜ ÍÎÂÛÉ ÓÐÎÂÅÍÜ Ñ ÒÈÒÐÀÌÈ ÈËÈ ÏÐÎÑÒÎ ÂÛÊÈÍÓÒÜ Â ÌÅÍÞ ÊÀÊ ÑÅÉ×ÀÑ ÑÄÅËÀÍÎ
                if (SceneManager.GetActiveScene().name != "Level1.8"&& SceneManager.GetActiveScene().name != "Level2.8"&& SceneManager.GetActiveScene().name != "Level3.8"&& SceneManager.GetActiveScene().name != "Level4.8") { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }
            Time.timeScale = 1;if (SettingsScript.sound == 0) { AudioListener.pause = false; }
        }

    }



}

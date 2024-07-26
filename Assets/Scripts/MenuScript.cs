using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public AudioSource shelchek;
	public GameObject LOADING;
    public GameObject START_GAME;
    public GameObject BLOCKS;
	public GameObject ZamokBLOKS2,ZamokBLOKS3,ZamokBLOKS4,ZamokBLOKS5;
	public GameObject ZamokLVL1,ZamokLVL2,ZamokLVL3,ZamokLVL4,ZamokLVL5,ZamokLVL6,ZamokLVL7,ZamokLVL8;
    public GameObject LEVEL;  
	public GameObject LEVEL2;
	public GameObject LEVEL3;
	public GameObject LEVEL4;
	public GameObject LEVEL5;
	public GameObject LEVEL6;  
    public GameObject Back;
    public GameObject Back2;
    public GameObject ExitButton;
    public GameObject STORE;
    public GameObject VIHOD;
    public GameObject[] storeOBJECTS;
    public bool vihod,playLev, Store, Exit;
    public bool backButton,backButton2,backButton3;
   
    public static int i;
    public bool blok1,blok2,blok3,blok4,blok5,blok6;
    public bool lev1, lev2, lev3,lev4,lev5,lev6,lev7,lev8;
	 
    public GameObject Developer; 
    public bool dev;
    public int LVLON;
    public bool gameOBJECT;//обхект в сцене который всегда включен и он контролирует замки блоков!!!

    public GameObject OKNO;//вызывается если кончились жизни
    void Start()
    {
        
        SettingsScript.sound = PlayerPrefs.GetInt("Sound", 0);
        if (SettingsScript.sound == 1) {AudioListener.pause = true; }//звука нет
        if (SettingsScript.sound == 0) {AudioListener.pause = false; }//звук есть
        Time.timeScale = 1;
        EXITScript.NEXTlvlOn = PlayerPrefs.GetInt("NEXTlvlOn", 0);
    }
    void Update()
    {  
        if (gameOBJECT) 
        {
            if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Canvas Start Game")&&!GameObject.Find("настройки")) { vihod = true; OnMouseUp();backButton = false; }
            if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("настройки")) { GameObject.Find("настройки").SetActive(false); }//если глючит удалить нахер
            if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Canvas Block")) { vihod = false; backButton = true; OnMouseUp(); }
            if (Input.GetKeyDown(KeyCode.Escape) && GameObject.Find("Canvas STORE") && !GameObject.Find("фон для мячей") && !GameObject.Find("фон111")) { vihod = false; backButton3 = true; OnMouseUp(); }

            if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 20) { ZamokBLOKS2.SetActive(false); }
            if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 45) { ZamokBLOKS3.SetActive(false); }////////
      //      if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 65) { ZamokBLOKS4.SetActive(false); }////////раскоментировать когда сделаю 4 блок и загянуть в скрипт Click
   //         if (EXITScript.MAX_FULL_LEVELS_ALMAZ >= 90) { ZamokBLOKS5.SetActive(false); }/////////////////////////////////это тоже,если сделаю 5 блок
        }
    }
    public void OnMouseUp()  
    {
        EXITScript.NEXTlvlOn = PlayerPrefs.GetInt("NEXTlvlOn", 0);
        if (vihod) { VIHOD.SetActive(true); }
        PlayerPositionScript.lifes = PlayerPrefs.GetInt("Lifes", 0);
        shelchek.Play();
        if (playLev == true) { START_GAME.SetActive(false); BLOCKS.SetActive(true); Back.SetActive(true); }
        if (Store == true) { START_GAME.SetActive(false); Back.SetActive(true); STORE.SetActive(true);}

        if (backButton == true) { START_GAME.SetActive(true); BLOCKS.SetActive(false); Back.SetActive(false); STORE.SetActive(false); Developer.SetActive(false);}
        if (backButton2) { Back2.SetActive(false); Back.SetActive(true); LEVEL.SetActive(false); BLOCKS.SetActive(true); OKNO.SetActive(false); }
        if (backButton3) { START_GAME.SetActive(true); STORE.SetActive(false); if (GameObject.Find("фон111")) { OKNO.SetActive(false); };
            for (int i = 0; i < storeOBJECTS.Length; i++){storeOBJECTS[i].SetActive(false);}
        }

        if (blok1) { 
			i = 1; BLOCKS.SetActive(false); LEVEL.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
			if (EXITScript.NEXTlvlOn >= 1) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 2) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 3) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 4) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 5) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 6) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 7) {ZamokLVL8.SetActive (false);}
            LVLON = EXITScript.NEXTlvlOn;
		}
		if (blok2) {
			i = 2; BLOCKS.SetActive(false); LEVEL2.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
		//	if (EXITScript.NEXTlvlOn >= 8) {ZamokLVL1.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 9) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 10) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 11) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 12) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 13) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 14) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 15) {ZamokLVL8.SetActive (false);}
		}

		if (blok3) { 
			i = 3; BLOCKS.SetActive(false); LEVEL3.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
	//		if (EXITScript.NEXTlvlOn >= 16) {ZamokLVL1.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 17) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 18) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 19) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 20) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 21) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 22) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 23) {ZamokLVL8.SetActive (false);}
		}

		if (blok4) {
			i = 4; BLOCKS.SetActive(false); LEVEL4.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
		//	if (EXITScript.NEXTlvlOn >= 24) {ZamokLVL1.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 25) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 26) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 27) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 28) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 29) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 30) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 31) {ZamokLVL8.SetActive (false);}
		}

		if (blok5) {
			i = 5; BLOCKS.SetActive(false); LEVEL5.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
		//	if (EXITScript.NEXTlvlOn >= 32) {ZamokLVL1.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 33) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 34) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 35) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 36) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 37) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 38) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 39) {ZamokLVL8.SetActive (false);}
		}

		if (blok6) {
			i = 6; BLOCKS.SetActive(false); LEVEL6.SetActive(true); Back.SetActive(false); Back2.SetActive(true);
		//	if (EXITScript.NEXTlvlOn >= 40) {ZamokLVL1.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 41) {ZamokLVL2.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 42) {ZamokLVL3.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 43) {ZamokLVL4.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 44) {ZamokLVL5.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 45) {ZamokLVL6.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 46) {ZamokLVL7.SetActive (false);}
			if (EXITScript.NEXTlvlOn >= 47) {ZamokLVL8.SetActive (false);}
		}

        
        
        if (dev) { START_GAME.SetActive(false); Back.SetActive(true); Developer.SetActive(true); }
        if (Exit) { Application.Quit(); }



        if (lev1 || lev2 || lev3 || lev4 || lev5 || lev6 || lev7 || lev8)
        {
            if (PlayerPositionScript.lifes > 0)
            {
                if (lev1)
                {
                    if (i == 1) { LOADING.SetActive(true); SceneManager.LoadScene("Level1.1"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.1"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.1"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.1"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.1"); }
                }
                if (lev2)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.2"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.2"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.2"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.2"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.2"); }
                }
                if (lev3)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.3"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.3"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.3"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.3"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.3"); }
                }
                if (lev4)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.4"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.4"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.4"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.4"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.4"); }
                }
                if (lev5)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.5"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.5"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.5"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.5"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.5"); }
                }
                if (lev6)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.6"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.6"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.6"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.6"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.6"); }
                }
                if (lev7)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.7"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.7"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.7"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.7"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.7"); }
                }
                if (lev8)
                {
                    if (i == 1) { SceneManager.LoadScene("Level1.8"); }
                    if (i == 2) { SceneManager.LoadScene("Level2.8"); }
                    if (i == 3) { SceneManager.LoadScene("Level3.8"); }
                    if (i == 4) { SceneManager.LoadScene("Level4.8"); }
                    if (i == 5) { SceneManager.LoadScene("Level5.8"); }
                }
            }
            if (PlayerPositionScript.lifes <= 0) { OKNO.SetActive(true); }
        }

    }
  
}

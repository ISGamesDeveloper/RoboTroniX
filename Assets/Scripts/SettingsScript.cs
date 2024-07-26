using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class SettingsScript : MonoBehaviour {
    public Animator anim;
    public Text textOP;
    public Text textSETTINGSbutton,UVEDOML;
    public bool Sounds,Language,RU_L,ENG_L,OKEY;
    public bool Button_Sound, Button_Language, Button_RU, Button_Eng;
    public Image SOUND, language,controlIMAGE;
    public GameObject RU, ENG;
    public static int lang,sound,control;
    Text text;
    public bool CONTROLbutton,JOY,ACSEL,settings_button,BACKbutton;
    public GameObject joys, acs,OKNO;
    public bool storeZHIZNI, storeSHIT, storeOPENALL, storeALMAZ, storeTRON;
    public bool posmotretREKLAMU,opisaniyeZH,opisaniyeSHIT,opisaniyeOPENALL,opisaniyeALMAZ,voprosHOCHpopZHIZNI,kupitZHiALM,SLOVOkupot,razblokirovat;/////
    public bool textROBO,textFOOT,textBAS,textATOM,textKOL,textVIHODvMENU,textPROPUSKA,
        FONvLEVELzakZH,FONvLEVELzakOB,FONvLEVELstatVIP,vihodizigri,da,net;
    public int perviyZapusk;
    public bool PAUSE_PAUZA;
    public bool LEVELCOMPLETE,COMING_SOON,settingsSLOVO,openURL,ISGAMES,OCENISHigru,YESplusSMILE,devText,uvedomleniya;
    public GameObject DEVTEXTRU,DEVTEXTENG;//ставится только на русский и англ текст в девелопере

    public static int NETreklami;
    void Awake()
    { 
        NETreklami = PlayerPrefs.GetInt("kupili_reklamu", 0);
        lang = PlayerPrefs.GetInt("Language", 0); 
        sound = PlayerPrefs.GetInt("Sound", 0);
        control = PlayerPrefs.GetInt("control", 0); 
        perviyZapusk = PlayerPrefs.GetInt("perviyZapusk", 0);
        if (Application.systemLanguage == SystemLanguage.Russian && perviyZapusk == 0) { lang = 0; PlayerPrefs.SetInt("Language", lang); perviyZapusk = 1; PlayerPrefs.SetInt("perviyZapusk", perviyZapusk); }
        if (Application.systemLanguage != SystemLanguage.Russian && perviyZapusk == 0) { lang = 1; PlayerPrefs.SetInt("Language", lang); perviyZapusk = 1; PlayerPrefs.SetInt("perviyZapusk", perviyZapusk); }

        if (NETreklami != 0) { if (GameObject.Find("купить жизни")) { GameObject.Find("купить жизни").GetComponent<Text>().color = Color.black; GameObject.Find("купить жизни").GetComponent<Outline>().effectColor = Color.black; GameObject.Find("купить жизни").GetComponent<Text>().raycastTarget = false; } }

        if (Sounds)
        {     //есть такая же проверка в скрипте MenuScript!!!!
            if (sound == 1) { SOUND.color = Color.grey; AudioListener.pause = true; }//звука нет
            if (sound == 0) { SOUND.color = Color.white; AudioListener.pause = false; }//звук есть
        }
        if (GetComponent<Text>()) { text = GetComponent<Text>(); }
        StartCoroutine(Updateee());
    }
    IEnumerator Updateee()
    {
        while (true)
        {
            if (lang == 0)  //Русский язык
            {
                if (Button_Sound) { text.text = "звук"; }
                if (Button_Language) { text.text = "язык"; }
                if (Button_RU) { text.text = "русский"; }
                if (Button_Eng) { text.text = "English"; }
                if (OKEY) { text.text = "OKEЙ"; }
                if (CONTROLbutton) { text.text = "управление"; }
                if (JOY) { text.text = "джойстик"; }
                if (ACSEL) { text.text = "акселерометр"; }
                if (BACKbutton) { text.text = "назад"; }
                if (settings_button) { textSETTINGSbutton.text = "настройки"; }

                if (storeZHIZNI) { text.text = "Пополнить жизни"; }
                if (storeSHIT) { text.text = "получить Tronus"; }
                if (storeOPENALL)
                {
                    if (NETreklami == 1) { text.text = "<<<  RoboTroniX Pro  >>>"; gameObject.GetComponent<StoreScript>().enabled = false; GetComponent<Text>().raycastTarget = false; }
                    else { text.text = "получить бесконечные жизни и убрать рекламу"; }
                }
                if (storeALMAZ) { text.text = "получить алмазы"; }
                if (storeTRON) { text.text = "выбрать трон"; }

                if (posmotretREKLAMU) { text.text = "посмотреть видео"; }
                if (opisaniyeZH) { text.text = "Посмотри видео что бы пополнить жизненный запас"; }
                if (opisaniyeSHIT) { text.text = "Посмотри видео что бы получить 1 tronus бесплатно либо купи пакет из 50шт. Они тебе пригодятся !!!"; }
                if (opisaniyeOPENALL) { text.text = "стань крутым игроком"; }
                if (opisaniyeALMAZ) { text.text = "Посмотри видео что бы получить 20 алмазов бесплатно либо купи пакет из 2000 шт. Кроме того, собирать алмазы можно и во время прохождения миссии"; }
                if (voprosHOCHpopZHIZNI) { text.text = "Хочешь пополнить жизни ?"; }
                if (kupitZHiALM) { text.text = "купить"; }
                if (razblokirovat) { text.text = "разблокировать"; }
                if (textROBO) { text.text = "роботроникс"; }
                if (textFOOT) { text.text = "футроникс"; }
                if (textBAS) { text.text = "баскетроникс"; }
                if (textATOM) { text.text = "атомтроникс"; }
                if (textKOL) { text.text = "колтроникс"; }
                if (SLOVOkupot) { text.text = "купить"; }
                if (textVIHODvMENU) { text.text = "выход"; }
                if (textPROPUSKA) { text.text = "Пропуск видео. Я разочарован в тебе"; }
                if (FONvLEVELzakZH) { text.text = "закончились все жизни?"; }
                if (FONvLEVELzakOB) { text.text = "со временем жизни восстанавливаются. посмотри видео что бы пополнить их сразу или стань vip и получи бесконечные жизни"; }
                if (FONvLEVELstatVIP) { text.text = "стать VIP"; }
                if (vihodizigri) { text.text = "выйти из игры ?"; }
                if (da) { text.text = "да"; }
                if (net) { text.text = "нет"; }
                if (PAUSE_PAUZA) { text.text = "пауза"; }
                if (LEVELCOMPLETE) { text.text = "уровень пройден"; }
                if (COMING_SOON) { text.text = "скоро"; }
                if (settingsSLOVO) { text.text = "настройки"; }
                if (OCENISHigru) { text.text = "оценить игру?"; }
                if (YESplusSMILE) { text.text = "ДА :)"; }
                if (uvedomleniya) { text.text = "уведомления"; }
                if (devText) { DEVTEXTRU.SetActive(true); DEVTEXTENG.SetActive(false); }
            }

            if (lang == 1) //Английский язык
            {
                if (Button_Sound) { text.text = "sound"; }
                if (Button_Language) { text.text = "language"; }
                if (Button_RU) { text.text = "русский"; }
                if (Button_Eng) { text.text = "english"; }
                if (OKEY) { text.text = "OK"; }
                if (CONTROLbutton) { text.text = "control"; }
                if (JOY) { text.text = "joystick"; }
                if (ACSEL) { text.text = "Accelerometer"; }
                if (BACKbutton) { text.text = "back"; }
                if (settings_button) { textSETTINGSbutton.text = "settings"; }

                if (storeZHIZNI) { text.text = "Add life"; }
                if (storeSHIT) { text.text = "get the Tronus"; }
                if (storeOPENALL) { if (NETreklami == 1) { text.text = "<<<  RoboTroniX Pro  >>>"; } else { text.text = "unlock all the levels and remove ads"; } }
                if (storeALMAZ) { text.text = "get diamonds"; }
                if (storeTRON) { text.text = "choose trone"; }

                if (posmotretREKLAMU) { text.text = "watch the video"; }
                if (opisaniyeZH) { text.text = "Watch the video to replenish the stock of life"; }
                if (opisaniyeSHIT) { text.text = "Watch the video to get 1 tronus free or buy pack of 50 pcs. They'll come in handy !!!"; }
                if (opisaniyeOPENALL) { text.text = "be cool player"; }
                if (opisaniyeALMAZ) { text.text = "Watch the video to get 20 diamonds for free or buy a package of 2000 pcs. Besides, diamonds you can collect during the mission"; }
                if (voprosHOCHpopZHIZNI) { text.text = "Do you want to add lives?"; }
                if (kupitZHiALM) { text.text = "buy"; }
                if (razblokirovat) { text.text = "unlock"; }

                if (textROBO) { text.text = "robotronix"; }
                if (textFOOT) { text.text = "footronix"; }
                if (textBAS) { text.text = "basketronix"; }
                if (textATOM) { text.text = "atomtronix"; }
                if (textKOL) { text.text = "koltronix"; }
                if (SLOVOkupot) { text.text = "buy"; }
                if (textPROPUSKA) { text.text = "video skipped. I am dissapointed in you"; }
                if (FONvLEVELzakZH) { text.text = "Have all the lives finished ?"; }
                if (FONvLEVELzakOB) { text.text = "with a lifetime of being restored. Watch the video that would replenish them immediately or become vip and get infinite lives"; }
                if (FONvLEVELstatVIP) { text.text = "get vip"; }
                if (vihodizigri) { text.text = "quit the game ?"; }
                if (da) { text.text = "yes"; }
                if (net) { text.text = "no"; }
                if (PAUSE_PAUZA) { text.text = "pause"; }

                if (LEVELCOMPLETE) { text.text = "level complete"; }
                if (COMING_SOON) { text.text = "coming soon"; }
                if (settingsSLOVO) { text.text = "settings"; }
                if (OCENISHigru) { text.text = "Rate game?"; }
                if (YESplusSMILE) { text.text = "YES :)"; }
                if (uvedomleniya) { text.text = "notifications"; }
                if (devText) { DEVTEXTRU.SetActive(false); DEVTEXTENG.SetActive(true); }
            }
            yield return new WaitForSeconds(2f);
        }
    }
    void OnEnable(){ StartCoroutine(Updateee());}

    public void OnMouseUp()
    {
        
        GameObject.Find("щелчек кнопкой").GetComponent<AudioSource>().Play();
        if (Sounds)
        {            
            if (SOUND.color == Color.white) { SOUND.color = Color.grey; AudioListener.pause = true;sound = 1; PlayerPrefs.SetInt("Sound", sound);
                if (lang == 0) { textOP.text = "звук выключен"; }
                if (lang == 1) { textOP.text = "sound off"; }
                anim.enabled = true;

                return; }
            if (SOUND.color == Color.grey) { SOUND.color = Color.white; AudioListener.pause = false; sound = 0; PlayerPrefs.SetInt("Sound", sound);
                if (lang == 0) { textOP.text = "звук включен"; }
                if (lang == 1) { textOP.text = "sound on"; }
                anim.enabled = true;
                return; }//из за return нижние функции могут не работать!
        }
        if (settings_button) { OKNO.SetActive(true); }
        if (Language) 
        {
            if (language.color == Color.white) { language.color = Color.grey;RU.SetActive(true); ENG.SetActive(true); joys.SetActive(false); acs.SetActive(false); controlIMAGE.color = Color.white; return; }
            if (language.color == Color.grey) { language.color = Color.white; RU.SetActive(false); ENG.SetActive(false); return; }//из за return нижние функции могут не работать!

        }

        if (CONTROLbutton) {
            if (controlIMAGE.color == Color.white) { controlIMAGE.color = Color.grey;joys.SetActive(true);acs.SetActive(true); RU.SetActive(false); ENG.SetActive(false); language.color = Color.white; anim.enabled = true;return; }
            if (controlIMAGE.color == Color.grey) { controlIMAGE.color = Color.white; joys.SetActive(false); acs.SetActive(false); anim.enabled = true;return; }
        }
        if (JOY) { control = 0; controlIMAGE.color = Color.white; joys.SetActive(false); acs.SetActive(false); PlayerPrefs.SetInt("control", control); anim.enabled = true;
            if (lang == 0) { textOP.text = "управление: джостик"; }
            if (lang == 1) { textOP.text = "Control: joystick"; }
        }
        if (ACSEL) { control = 1; controlIMAGE.color = Color.white; joys.SetActive(false); acs.SetActive(false); PlayerPrefs.SetInt("control", control); anim.enabled = true;
            if (lang == 0) { textOP.text = "управление: акселерометр"; }
            if (lang == 1) { textOP.text = "Control: Accelerometer"; }
        }

        if (RU_L) { lang = 0; PlayerPrefs.SetInt("Language", lang); RU.SetActive(false); ENG.SetActive(false); language.color = Color.white; anim.enabled = true;
            if (lang == 0) { textOP.text = "язык: русский"; }
        }      
        if (ENG_L) { lang = 1; PlayerPrefs.SetInt("Language", lang); RU.SetActive(false); ENG.SetActive(false); language.color = Color.white; anim.enabled = true;
            if (lang == 1) { textOP.text = "language: English"; }
        }

        if (openURL){Application.OpenURL("https://vk.com/is__games"); }
        if (ISGAMES) { Application.OpenURL("https://www.isgames.ru"); }
    }




}
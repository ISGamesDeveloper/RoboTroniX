using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AdManager : MonoBehaviour
{
    public bool lifes, shit, score,textPROPUSKA;
    public GameObject OKNO,ZHIZNI,SHIT,ALMAZI,MYACHIKI,OTKR_VSE_UROVNI,NAZADvSTORE,PROPUSKVIDEO;
    bool okno;
    public Text text;
    public bool V_STORE;

    [SerializeField]
    string gameID = "1051767";
    int NETreklami;
    void Awake()
    {
            NETreklami = PlayerPrefs.GetInt("kupili_reklamu", 0);
        if (NETreklami == 0) {/* Advertisement.Initialize(gameID, false);*/ }   
    }

//    public void ShowAd(string zone = "rewardedVideo")
//    {
//#if UNITY_EDITOR
//        StartCoroutine(WaitForAd());
//#endif

//        if (string.Equals(zone, ""))
//            zone = null;

//        //ShowOptions options = new ShowOptions();
//        options.resultCallback = AdCallbackhandler;

//        //if (Advertisement.IsReady(zone)) {Advertisement.Show(zone, options); }
//    }
    //void AdCallbackhandler(ShowResult result)  
    //{
    //    switch (result)
    //    {
    //        case ShowResult.Finished:
    //            if (lifes) {PlayerPositionScript.lifes = 5;PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes);if (SceneManager.GetActiveScene().name != "Menu") { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); } }
    //            if (shit)  {SHITscript.KuplenniyeShiti += 1; PlayerPrefs.SetInt("KuplenniyeShiti", SHITscript.KuplenniyeShiti); }
    //            if (score) {EXITScript.MAX_FULL_LEVELS_SCORE += 20; PlayerPrefs.SetInt("MAX_FULL_LEVELS_SCORE", EXITScript.MAX_FULL_LEVELS_SCORE); }             
    //            okno = true;        //нужно
    //            if (okno) { Time.timeScale = 1f; if (V_STORE) { NAZADvSTORE.SetActive(true); ZHIZNI.SetActive(false); SHIT.SetActive(false); ALMAZI.SetActive(false); MYACHIKI.SetActive(false); OTKR_VSE_UROVNI.SetActive(false); } OKNO.SetActive(false); okno = false; }
    //            break;
    //        case ShowResult.Skipped:             
    //            /////объект с надписью что так нельзя.я разочарован в тебе.        
    //            PROPUSKVIDEO.SetActive(true); Time.timeScale = 0f;
    //            break;
    //        //case ShowResult.Failed:
    //        //    Debug.Log("I swear this has never happened to me before");
    //        //    break;
    //    }
    //}
    //IEnumerator WaitForAd()
    //{
    //    float currentTimeScale = Time.timeScale;
    //    Time.timeScale = 0f;
    //    yield return null;

    //    while (Advertisement.isShowing)
    //        yield return null;
    //    Time.timeScale = currentTimeScale;

    //}

}
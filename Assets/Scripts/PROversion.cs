using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PROversion : MonoBehaviour{

    public GameObject panelZHIZNEY, panelZHIZNEYstore, VIP1, VIP2;
    public static int kupili_reklamu;
    void Awake()
    {
      //  CompleteProject.Purchaser.kupili_reklamu = PlayerPrefs.GetInt("kupili_reklamu", 0);
      //  if (CompleteProject.Purchaser.kupili_reklamu == 1)   // не забывать всегда менять название игры с RoboTroniX на RoboTroniX Pro в плеер сеттингс    by.ISGames.RoboTroniXpro    RoboTroniX Pro
      //  {
      //      panelZHIZNEY.SetActive(false); panelZHIZNEYstore.SetActive(false); VIP1.SetActive(true); VIP2.SetActive(true);
      //      PlayerPositionScript.lifes = int.MaxValue; PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes);
      ////      kupili_reklamu = 1; PlayerPrefs.SetInt("kupili_reklamu", kupili_reklamu);

      //   //   SHITscript.KuplenniyeShiti = PlayerPrefs.GetInt("KuplenniyeShiti", 0);
      //    //  SHITscript.KuplenniyeShiti += 10; PlayerPrefs.SetInt("KuplenniyeShiti", SHITscript.KuplenniyeShiti);

      //  //    EXITScript.MAX_FULL_LEVELS_SCORE = PlayerPrefs.GetInt("MAX_FULL_LEVELS_SCORE", 0);    //глючит!каждый раз при входе в меею из уровней,прибавляется шит и алмащы!!!!!!
      //   //   EXITScript.MAX_FULL_LEVELS_SCORE += 100; PlayerPrefs.SetInt("MAX_FULL_LEVELS_SCORE", EXITScript.MAX_FULL_LEVELS_SCORE);
      //  }
    }
}

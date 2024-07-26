using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TIMEscript : MonoBehaviour                                                                                                                                                                                                                                                                                                                                                                                                                       //By ISGames
{
    public int loading_time, cur_time;
    public int minutes;
    public int seconds;
    public bool BUTTON, texts;
    public Text textImageBLOCK;
    public Text textImageSTORE;
    float coroutine;
    public bool Menue, Levels;
    int TIMER;
    int textM, textS;
    DateTime epochStart = new DateTime(2016, 8, 20, 0, 0, 0, DateTimeKind.Utc);
    int proverkaREKLAMI = 1;//если 1, то купили игру
    void Start()
    {

        PlayerPrefs.SetInt("kupili_reklamu", 1);
        PlayerPrefs.SetInt("Lifes", 999);
        proverkaREKLAMI = PlayerPrefs.GetInt("kupili_reklamu", 0);
        if (proverkaREKLAMI == 0)
        {
            PlayerPositionScript.lifes = PlayerPrefs.GetInt("Lifes", 0); TIMER = 1200;//1200
            if (PlayerPositionScript.lifes < 5)
            {
                cur_time = (int)(DateTime.Now - epochStart).TotalSeconds;
                loading_time = PlayerPrefs.GetInt("loading_time", 0);
                seconds = loading_time - cur_time;
                if (seconds <= -TIMER * 5) { PlayerPositionScript.lifes = 5; PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes); }
            }
            BUTTON = false;
            if (Menue) { coroutine = 1f; }
            if (Levels) { coroutine = 10f; }
            TimerMachine(); StartCoroutine(Timer());
        }
    }

    void TimerMachine()
    {
        if (proverkaREKLAMI == 0)
        {
            PlayerPositionScript.lifes = PlayerPrefs.GetInt("Lifes", 0);
            if (PlayerPositionScript.lifes >= 5 || BUTTON)
            {
                if (texts) { textImageBLOCK.text = ""; textImageSTORE.text = ""; }
                cur_time = (int)(DateTime.Now - epochStart).TotalSeconds;
                loading_time = cur_time + TIMER;
                PlayerPrefs.SetInt("loading_time", loading_time);
                BUTTON = false;
            }

            if (PlayerPositionScript.lifes < 5)
            {
                cur_time = (int)(DateTime.Now - epochStart).TotalSeconds;
                loading_time = PlayerPrefs.GetInt("loading_time", 0);
                BUTTON = false;
            }
        }
    }
    IEnumerator Timer()
    {
        while (true)
        {
            if (proverkaREKLAMI == 0)
            {
                if (PlayerPositionScript.lifes < 5)
                {
                    cur_time = (int)(DateTime.Now - epochStart).TotalSeconds;
                    minutes = (loading_time - cur_time) / 60;
                    seconds = loading_time - cur_time;
                    if (seconds < 0)
                    {
                        if (seconds > -TIMER && seconds < 0)
                        {
                            PlayerPositionScript.lifes += 1; loading_time = cur_time + (TIMER + seconds);
                        }
                        seconds = loading_time - cur_time;
                        if (seconds <= -TIMER) { PlayerPositionScript.lifes += 1; loading_time += TIMER; }
                        PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes); PlayerPrefs.SetInt("loading_time", loading_time);
                        if (PlayerPositionScript.lifes >= 5) { TimerMachine(); }
                    }
                    if (seconds == 0)
                    {
                        PlayerPositionScript.lifes += 1; PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes);
                        if (PlayerPositionScript.lifes < 5) { BUTTON = true; TimerMachine(); }
                    }
                    if (texts)
                    {
                        textS = (int)Mathf.Floor(seconds % 60);
                        textM = minutes;
                        if (seconds < 10) { textImageBLOCK.text = textM + ":0" + textS; textImageSTORE.text = textM + ":0" + textS; }
                        if (seconds >= 10) { textImageBLOCK.text = textM + ":" + textS; textImageSTORE.text = textM + ":" + textS; }
                    }
                }
                PlayerPrefs.SetInt("loading_time", loading_time);
                if (PlayerPositionScript.lifes >= 5 || BUTTON) { TimerMachine(); }
                yield return new WaitForSeconds(coroutine);
            }
        }
    }

}
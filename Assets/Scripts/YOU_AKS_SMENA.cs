using UnityEngine;
using System.Collections;

public class YOU_AKS_SMENA : MonoBehaviour {

    bool upravleniye;
    public GameObject joy, speed, strLEFT, strRINGHT, SP, ST, strACSLEFT, strACSRIGHT;
    void Awake()
    {
        joy = GameObject.Find("MobileJoystick");
        speed = GameObject.Find("SpeedButton");
        strLEFT = GameObject.Find("LEFT");
        strRINGHT = GameObject.Find("RIGHT");

        SP = GameObject.Find("SP");
        ST = GameObject.Find("ST");
        strACSLEFT = GameObject.Find("strACSLEFT");
        strACSRIGHT = GameObject.Find("strACSRIGHT");

        SettingsScript.control = PlayerPrefs.GetInt("control", 0);
        if (SettingsScript.control == 0) { joy.SetActive(true);speed.SetActive(true);strLEFT.SetActive(true);strRINGHT.SetActive(true);SP.SetActive(false);ST.SetActive(false);strACSLEFT.SetActive(false);strACSRIGHT.SetActive(false); }
        else { joy.SetActive(false); speed.SetActive(false); strLEFT.SetActive(false); strRINGHT.SetActive(false); SP.SetActive(true); ST.SetActive(true); strACSLEFT.SetActive(true); strACSRIGHT.SetActive(true); }
    }

}

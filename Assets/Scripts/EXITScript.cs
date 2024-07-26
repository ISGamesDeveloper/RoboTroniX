using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EXITScript : MonoBehaviour {
    Text text;
    public bool TextAlmaz,TextScore,TextLifes ,TextSHIT;

	int MAXAlmazL1, MAXAlmazL2, MAXAlmazL3, MAXAlmazL4,MAXAlmazL5,MAXAlmazL6,MAXAlmazL7,MAXAlmazL8;
	int MAXAlmazL2_1, MAXAlmazL2_2, MAXAlmazL2_3, MAXAlmazL2_4,MAXAlmazL2_5,MAXAlmazL2_6,MAXAlmazL2_7,MAXAlmazL2_8;
    int MAXAlmazL3_1, MAXAlmazL3_2, MAXAlmazL3_3, MAXAlmazL3_4, MAXAlmazL3_5, MAXAlmazL3_6, MAXAlmazL3_7, MAXAlmazL3_8;
    int MAXAlmazL4_1, MAXAlmazL4_2, MAXAlmazL4_3, MAXAlmazL4_4, MAXAlmazL4_5, MAXAlmazL4_6, MAXAlmazL4_7, MAXAlmazL4_8;
    int MAXAlmazL5_1, MAXAlmazL5_2, MAXAlmazL5_3, MAXAlmazL5_4, MAXAlmazL5_5, MAXAlmazL5_6, MAXAlmazL5_7, MAXAlmazL5_8;

    public bool L1, L2, L3, L4,L5,L6,L7,L8;
	public bool L2_1, L2_2, L2_3, L2_4,L2_5,L2_6,L2_7,L2_8;
    public bool L3_1, L3_2, L3_3, L3_4, L3_5, L3_6, L3_7, L3_8;
    public bool L4_1, L4_2, L4_3, L4_4, L4_5, L4_6, L4_7, L4_8;
    public bool L5_1, L5_2, L5_3, L5_4, L5_5, L5_6, L5_7, L5_8;

    public static int MAX_FULL_LEVELS_ALMAZ;
    public static int MAX_FULL_LEVELS_SCORE;
    public GameObject almaz1, almaz2, almaz3;
   
	public static int  NEXTlvlOn;
    public bool menue;
	public static bool NullAlmaz;
    bool zaglushka;//заглушка нужна для того что бы плеер случайно не дотронудся два раза до коллайдера со скриптом EXITScript.там maxfullresscore +=ochkirotate стоит.что бы 2 раза не прибавил за уровень.
    int nachalo_igri;
    int NETreklami;
    void Awake() {   //только Awake!!!!
            NETreklami = PlayerPrefs.GetInt("kupili_reklamu", 0);
            //gameObject.AddComponent<GoogleADSmanager>();   //для показа рекламы,там где trigger enter тоже есть строка для рекламы
        zaglushka = true;
        PlayerPositionScript.lifes = PlayerPrefs.GetInt("Lifes", 0);
        nachalo_igri = PlayerPrefs.GetInt("Nachalo_Igri", 0);
        if (PlayerPositionScript.lifes <= 0) { PlayerPositionScript.lifes = 0; }
        if (nachalo_igri == 0) { PlayerPositionScript.lifes = 5; nachalo_igri = 1; PlayerPrefs.SetInt("Nachalo_Igri", nachalo_igri);}
        PlayerPrefs.SetInt("Lifes", PlayerPositionScript.lifes);

        SHITscript.KuplenniyeShiti = PlayerPrefs.GetInt("KuplenniyeShiti", 0);
        SHITscript.KolichestvoShitov = PlayerPrefs.GetInt("KolichestvoShitov", 0);
        MAX_FULL_LEVELS_SCORE = PlayerPrefs.GetInt("MAX_FULL_LEVELS_SCORE", 0);
        NEXTlvlOn = PlayerPrefs.GetInt("NEXTlvlOn", 0);

        MAXAlmazL1 = PlayerPrefs.GetInt("MAXAlmazL1", 0);
        MAXAlmazL2 = PlayerPrefs.GetInt("MAXAlmazL2", 0);
        MAXAlmazL3 = PlayerPrefs.GetInt("MAXAlmazL3", 0);
		MAXAlmazL4 = PlayerPrefs.GetInt("MAXAlmazL4", 0);
    	MAXAlmazL5 = PlayerPrefs.GetInt("MAXAlmazL5", 0);
		MAXAlmazL6 = PlayerPrefs.GetInt("MAXAlmazL6", 0);
		MAXAlmazL7 = PlayerPrefs.GetInt("MAXAlmazL7", 0);
		MAXAlmazL8 = PlayerPrefs.GetInt("MAXAlmazL8", 0);

        MAXAlmazL2_1 = PlayerPrefs.GetInt("MAXAlmazL2_1", 0);
		MAXAlmazL2_2 = PlayerPrefs.GetInt("MAXAlmazL2_2", 0);
		MAXAlmazL2_3 = PlayerPrefs.GetInt("MAXAlmazL2_3", 0);
		MAXAlmazL2_4 = PlayerPrefs.GetInt("MAXAlmazL2_4", 0);
		MAXAlmazL2_5 = PlayerPrefs.GetInt("MAXAlmazL2_5", 0);
		MAXAlmazL2_6 = PlayerPrefs.GetInt("MAXAlmazL2_6", 0);
		MAXAlmazL2_7 = PlayerPrefs.GetInt("MAXAlmazL2_7", 0);
		MAXAlmazL2_8 = PlayerPrefs.GetInt("MAXAlmazL2_8", 0);

        MAXAlmazL3_1 = PlayerPrefs.GetInt("MAXAlmazL3_1", 0);
        MAXAlmazL3_2 = PlayerPrefs.GetInt("MAXAlmazL3_2", 0);
        MAXAlmazL3_3 = PlayerPrefs.GetInt("MAXAlmazL3_3", 0);
        MAXAlmazL3_4 = PlayerPrefs.GetInt("MAXAlmazL3_4", 0);
        MAXAlmazL3_5 = PlayerPrefs.GetInt("MAXAlmazL3_5", 0);
        MAXAlmazL3_6 = PlayerPrefs.GetInt("MAXAlmazL3_6", 0);
        MAXAlmazL3_7 = PlayerPrefs.GetInt("MAXAlmazL3_7", 0);
        MAXAlmazL3_8 = PlayerPrefs.GetInt("MAXAlmazL3_8", 0);

        MAXAlmazL4_1 = PlayerPrefs.GetInt("MAXAlmazL4_1", 0);
        MAXAlmazL4_2 = PlayerPrefs.GetInt("MAXAlmazL4_2", 0);
        MAXAlmazL4_3 = PlayerPrefs.GetInt("MAXAlmazL4_3", 0);
        MAXAlmazL4_4 = PlayerPrefs.GetInt("MAXAlmazL4_4", 0);
        MAXAlmazL4_5 = PlayerPrefs.GetInt("MAXAlmazL4_5", 0);
        MAXAlmazL4_6 = PlayerPrefs.GetInt("MAXAlmazL4_6", 0);
        MAXAlmazL4_7 = PlayerPrefs.GetInt("MAXAlmazL4_7", 0);
        MAXAlmazL4_8 = PlayerPrefs.GetInt("MAXAlmazL4_8", 0);

        MAXAlmazL5_1 = PlayerPrefs.GetInt("MAXAlmazL5_1", 0);
        MAXAlmazL5_2 = PlayerPrefs.GetInt("MAXAlmazL5_2", 0);
        MAXAlmazL5_3 = PlayerPrefs.GetInt("MAXAlmazL5_3", 0);
        MAXAlmazL5_4 = PlayerPrefs.GetInt("MAXAlmazL5_4", 0);
        MAXAlmazL5_5 = PlayerPrefs.GetInt("MAXAlmazL5_5", 0);
        MAXAlmazL5_6 = PlayerPrefs.GetInt("MAXAlmazL5_6", 0);
        MAXAlmazL5_7 = PlayerPrefs.GetInt("MAXAlmazL5_7", 0);
        MAXAlmazL5_8 = PlayerPrefs.GetInt("MAXAlmazL5_8", 0);
       //------------------------------------------------------------------------------------------------
       PlayerPrefs.GetInt("MAX_FULL_LEVELS_ALMAZ", 0);
        if (MAX_FULL_LEVELS_ALMAZ < int.MaxValue)
        {
                 MAX_FULL_LEVELS_ALMAZ = MAXAlmazL1 + MAXAlmazL2 + MAXAlmazL3 + MAXAlmazL4 + MAXAlmazL5 + MAXAlmazL6 + MAXAlmazL7 + MAXAlmazL8 
                + MAXAlmazL2_1 + MAXAlmazL2_2 + MAXAlmazL2_3 + MAXAlmazL2_4 + MAXAlmazL2_5 + MAXAlmazL2_6 + MAXAlmazL2_7 + MAXAlmazL2_8
                + MAXAlmazL3_1 + MAXAlmazL3_2 + MAXAlmazL3_3 + MAXAlmazL3_4 + MAXAlmazL3_5 + MAXAlmazL3_6 + MAXAlmazL3_7 + MAXAlmazL3_8
                + MAXAlmazL4_1 + MAXAlmazL4_2 + MAXAlmazL4_3 + MAXAlmazL4_4 + MAXAlmazL4_5 + MAXAlmazL4_6 + MAXAlmazL4_7 + MAXAlmazL4_8
                + MAXAlmazL5_1 + MAXAlmazL5_2 + MAXAlmazL5_3 + MAXAlmazL5_4 + MAXAlmazL5_5 + MAXAlmazL5_6 + MAXAlmazL5_7 + MAXAlmazL5_8;
        }
        PlayerPrefs.SetInt("MAX_FULL_LEVELS_ALMAZ", MAX_FULL_LEVELS_ALMAZ);
        //------------------------------------------------------------------------------------------------
        if (menue)
        {
            if (gameObject.GetComponent<Text>()) { text = GetComponent<Text>(); }
            if (TextAlmaz) {             
                text.text = "" + MAX_FULL_LEVELS_ALMAZ;
            }
            if (TextScore)
            {          
                text.text = "" + MAX_FULL_LEVELS_SCORE;
            }
            if (TextLifes)
            {
                if (NETreklami == 0)
                {
                    PlayerPositionScript.lifes = PlayerPrefs.GetInt("Lifes", 0);
                    text.text = "" + PlayerPositionScript.lifes;
                }
            }
            if (TextSHIT) { text.text = SHITscript.KuplenniyeShiti + SHITscript.KolichestvoShitov + ""; }
            if (L1){           
                if (MAXAlmazL1 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL1 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL1 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL1 > 0 &&NEXTlvlOn<1) { NEXTlvlOn = 1;} 
            }
            if (L2)
            {
                if (MAXAlmazL2 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL2 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL2 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL2 > 0 &&NEXTlvlOn < 2) { NEXTlvlOn = 2;}
            }
            if (L3)
            {
                if (MAXAlmazL3 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL3 > 0 && NEXTlvlOn < 3) {NEXTlvlOn = 3;}
            }
			if (L4)
			{
				if (MAXAlmazL4 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL4 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL4 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL4 > 0 && NEXTlvlOn < 4) {NEXTlvlOn = 4;}
			}
			if (L5)
			{
				if (MAXAlmazL5 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL5 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL5 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL5 > 0 && NEXTlvlOn < 5) {NEXTlvlOn = 5;}
			}
			if (L6)
			{
				if (MAXAlmazL6 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL6 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL6 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL6 > 0 && NEXTlvlOn < 6) {NEXTlvlOn = 6;}
			}
			if (L7)
			{
				if (MAXAlmazL7 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL7 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL7 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL7 > 0 && NEXTlvlOn < 7) {NEXTlvlOn = 7;}
			}
			if (L8)
			{
				if (MAXAlmazL8 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL8 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL8 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
				if (MAXAlmazL8 > 0 && NEXTlvlOn < 8) {NEXTlvlOn = 8;}
			}

            if (L2_1){           
				if (MAXAlmazL2_1 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_1 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_1 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_1 > 0 && NEXTlvlOn < 9) { NEXTlvlOn = 9; }
			}
			if (L2_2)
			{
				if (MAXAlmazL2_2 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_2 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_2 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_2 > 0 && NEXTlvlOn < 10) { NEXTlvlOn = 10; }
            }
			if (L2_3)
			{
				if (MAXAlmazL2_3 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_3 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_3 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_3 > 0 && NEXTlvlOn < 11) { NEXTlvlOn = 11; }
            }
			if (L2_4)
			{
				if (MAXAlmazL2_4 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_4 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_4 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_4 > 0 && NEXTlvlOn < 12) { NEXTlvlOn = 12; }
            }
			if (L2_5)
			{
				if (MAXAlmazL2_5 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_5 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_5 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_5 > 0 && NEXTlvlOn < 13) { NEXTlvlOn = 13; }
            }
			if (L2_6)
			{
				if (MAXAlmazL2_6 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_6 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_6 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_6 > 0 && NEXTlvlOn < 14) { NEXTlvlOn = 14; }
            }
			if (L2_7)
			{
				if (MAXAlmazL2_7 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_7 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_7 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_7 > 0 && NEXTlvlOn < 15) { NEXTlvlOn = 15; }
            }
			if (L2_8)
			{
				if (MAXAlmazL2_8 == 1) { almaz1.SetActive(true); }
				if (MAXAlmazL2_8 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
				if (MAXAlmazL2_8 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL2_8 > 0 && NEXTlvlOn < 16) { NEXTlvlOn = 16; }
			}




            if (L3_1)
            {
                if (MAXAlmazL3_1 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_1 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_1 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_1 > 0 && NEXTlvlOn < 17) { NEXTlvlOn = 17; }
            }
            if (L3_2)
            {
                if (MAXAlmazL3_2 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_2 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_2 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_2 > 0 && NEXTlvlOn < 18) { NEXTlvlOn = 18; }
            }
            if (L3_3)
            {
                if (MAXAlmazL3_3 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_3 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_3 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_3 > 0 && NEXTlvlOn < 19) { NEXTlvlOn = 19; }
            }
            if (L3_4)
            {
                if (MAXAlmazL3_4 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_4 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_4 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_4 > 0 && NEXTlvlOn < 20) { NEXTlvlOn = 20; }
            }
            if (L3_5)
            {
                if (MAXAlmazL3_5 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_5 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_5 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_5 > 0 && NEXTlvlOn < 21) { NEXTlvlOn = 21; }
            }
            if (L3_6)
            {
                if (MAXAlmazL3_6 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_6 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_6 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_6 > 0 && NEXTlvlOn < 22) { NEXTlvlOn = 22; }
            }
            if (L3_7)
            {
                if (MAXAlmazL3_7 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_7 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_7 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_7 > 0 && NEXTlvlOn < 23) { NEXTlvlOn = 23; }
            }
            if (L3_8)
            {
                if (MAXAlmazL3_8 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL3_8 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL3_8 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL3_8 > 0 && NEXTlvlOn < 24) { NEXTlvlOn = 24; }
            }


            if (L4_1)
            {
                if (MAXAlmazL4_1 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_1 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_1 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_1 > 0 && NEXTlvlOn < 25) { NEXTlvlOn = 25; }
            }
            if (L4_2)
            {
                if (MAXAlmazL4_2 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_2 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_2 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_2 > 0 && NEXTlvlOn < 26) { NEXTlvlOn = 26; }
            }
            if (L4_3)
            {
                if (MAXAlmazL4_3 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_3 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_3 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_3 > 0 && NEXTlvlOn < 27) { NEXTlvlOn = 27; }
            }
            if (L4_4)
            {
                if (MAXAlmazL4_4 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_4 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_4 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_4 > 0 && NEXTlvlOn < 28) { NEXTlvlOn = 28; }
            }
            if (L4_5)
            {
                if (MAXAlmazL4_5 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_5 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_5 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_5 > 0 && NEXTlvlOn < 29) { NEXTlvlOn = 29; }
            }
            if (L4_6)
            {
                if (MAXAlmazL4_6 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_6 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_6 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_6 > 0 && NEXTlvlOn < 30) { NEXTlvlOn = 30; }
            }
            if (L4_7)
            {
                if (MAXAlmazL4_7 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_7 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_7 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_7 > 0 && NEXTlvlOn < 31) { NEXTlvlOn = 31; }
            }
            if (L4_8)
            {
                if (MAXAlmazL4_8 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL4_8 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL4_8 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL4_8 > 0 && NEXTlvlOn < 32) { NEXTlvlOn = 32; }
            }



            if (L5_1)
            {
                if (MAXAlmazL5_1 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_1 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_1 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_1 > 0 && NEXTlvlOn < 33) { NEXTlvlOn = 33; }
            }
            if (L5_2)
            {
                if (MAXAlmazL5_2 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_2 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_2 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_2 > 0 && NEXTlvlOn < 34) { NEXTlvlOn = 34; }
            }
            if (L5_3)
            {
                if (MAXAlmazL5_3 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_3 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_3 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_3 > 0 && NEXTlvlOn < 35) { NEXTlvlOn = 35; }
            }
            if (L5_4)
            {
                if (MAXAlmazL5_4 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_4 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_4 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_4 > 0 && NEXTlvlOn < 36) { NEXTlvlOn = 36; }
            }
            if (L5_5)
            {
                if (MAXAlmazL5_5 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_5 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_5 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_5 > 0 && NEXTlvlOn < 37) { NEXTlvlOn = 37; }
            }
            if (L5_6)
            {
                if (MAXAlmazL5_6 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_6 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_6 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_6 > 0 && NEXTlvlOn < 38) { NEXTlvlOn = 38; }
            }
            if (L5_7)
            {
                if (MAXAlmazL5_7 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_7 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_7 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_7 > 0 && NEXTlvlOn < 39) { NEXTlvlOn = 39; }
            }
            if (L5_8)
            {
                if (MAXAlmazL5_8 == 1) { almaz1.SetActive(true); }
                if (MAXAlmazL5_8 == 2) { almaz1.SetActive(true); almaz2.SetActive(true); }
                if (MAXAlmazL5_8 == 3) { almaz1.SetActive(true); almaz2.SetActive(true); almaz3.SetActive(true); }
                if (MAXAlmazL5_8 > 0 && NEXTlvlOn < 40) { NEXTlvlOn = 40; }
            }
        }
        PlayerPrefs.SetInt("NEXTlvlOn", NEXTlvlOn);
    }
  //  void Update()
  //  {
 //   }
    IEnumerator Updateeee()   //если будет лагать то вернуть обратно
    {
        while (true)
        {
            if (menue)
            {
                if (TextScore)
                {
                    text.text = "" + MAX_FULL_LEVELS_SCORE;
                }
                if (TextLifes) { if (NETreklami == 0) { text.text = "" + PlayerPositionScript.lifes; } else { text.text = ""; } }
                if (TextSHIT) { text.text = SHITscript.KuplenniyeShiti + SHITscript.KolichestvoShitov + ""; }
            }
            yield return new WaitForSeconds(2f);
        }
    }
    void OnEnable() { StartCoroutine(Updateeee()); }



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player")&&zaglushka)
        {
            //  gameObject.GetComponent<GoogleADSmanager>().ClickAD();

            zaglushka = false;
            PlayerPrefs.SetInt("KuplenniyeShiti", SHITscript.KuplenniyeShiti);
            PlayerPrefs.SetInt("KolichestvoShitov", SHITscript.KolichestvoShitov);
           
            if (L1)
            {                                                        
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL1)
                {
                    MAXAlmazL1 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL1", MAXAlmazL1);
                }
            }
            if (L2)
            {   
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2)
                {
                    MAXAlmazL2 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2", MAXAlmazL2);
                }
            }
            if (L3)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3)
                {
                    MAXAlmazL3 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3", MAXAlmazL3);
                }
            }
            if (L4)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4)
                {
                    MAXAlmazL4 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4", MAXAlmazL4);
                }
            }
            if (L5)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5)
                {
                    MAXAlmazL5 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5", MAXAlmazL5);
                }
            }
            if (L6)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL6)
                {
                    MAXAlmazL6 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL6", MAXAlmazL6);
                }
            }
            if (L7)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL7)
                {
                    MAXAlmazL7 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL7", MAXAlmazL7);
                }
            }
            if (L8)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL8)
                {
                    MAXAlmazL8 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL8", MAXAlmazL8);
                }
            }

            if (L2_1)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_1)
                {
                    MAXAlmazL2_1 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_1", MAXAlmazL2_1);
                }
            }
            if (L2_2)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_2)
                {
                    MAXAlmazL2_2 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_2", MAXAlmazL2_2);
                }
            }
            if (L2_3)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_3)
                {
                    MAXAlmazL2_3 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_3", MAXAlmazL2_3);
                }
            }
            if (L2_4)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_4)
                {
                    MAXAlmazL2_4 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_4", MAXAlmazL2_4);
                }
            }
            if (L2_5)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_5)
                {
                    MAXAlmazL2_5 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_5", MAXAlmazL2_5);
                }
            }
            if (L2_6)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_6)
                {
                    MAXAlmazL2_6 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_6", MAXAlmazL2_6);
                }
            }
            if (L2_7)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_7)
                {
                    MAXAlmazL2_7 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_7", MAXAlmazL2_7);
                }
            }
            if (L2_8)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL2_8)
                {
                    MAXAlmazL2_8 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL2_8", MAXAlmazL2_8);
                }
            }




            if (L3_1)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_1)
                {
                    MAXAlmazL3_1 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_1", MAXAlmazL3_1);
                }
            }
            if (L3_2)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_2)
                {
                    MAXAlmazL3_2 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_2", MAXAlmazL3_2);
                }
            }
            if (L3_3)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_3)
                {
                    MAXAlmazL3_3 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_3", MAXAlmazL3_3);
                }
            }
            if (L3_4)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_4)
                {
                    MAXAlmazL3_4 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_4", MAXAlmazL3_4);
                }
            }
            if (L3_5)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_5)
                {
                    MAXAlmazL3_5 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_5", MAXAlmazL3_5);
                }
            }
            if (L3_6)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_6)
                {
                    MAXAlmazL3_6 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_6", MAXAlmazL3_6);
                }
            }
            if (L3_7)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_7)
                {
                    MAXAlmazL3_7 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_7", MAXAlmazL3_7);
                }
            }
            if (L3_8)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL3_8)
                {
                    MAXAlmazL3_8 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL3_8", MAXAlmazL3_8);
                }
            }


            if (L4_1)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_1)
                {
                    MAXAlmazL4_1 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_1", MAXAlmazL4_1);
                }
            }
            if (L4_2)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_2)
                {
                    MAXAlmazL4_2 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_2", MAXAlmazL4_2);
                }
            }
            if (L4_3)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_3)
                {
                    MAXAlmazL4_3 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_3", MAXAlmazL4_3);
                }
            }
            if (L4_4)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_4)
                {
                    MAXAlmazL4_4 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_4", MAXAlmazL4_4);
                }
            }
            if (L4_5)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_5)
                {
                    MAXAlmazL4_5 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_5", MAXAlmazL4_5);
                }
            }
            if (L4_6)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_6)
                {
                    MAXAlmazL4_6 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_6", MAXAlmazL4_6);
                }
            }
            if (L4_7)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_7)
                {
                    MAXAlmazL4_7 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_7", MAXAlmazL4_7);
                }
            }
            if (L4_8)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL4_8)
                {
                    MAXAlmazL4_8 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL4_8", MAXAlmazL4_8);
                }
            }


            if (L5_1)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_1)
                {
                    MAXAlmazL5_1 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_1", MAXAlmazL5_1);
                }
            }
            if (L5_2)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_2)
                {
                    MAXAlmazL5_2 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_2", MAXAlmazL5_2);
                }
            }
            if (L5_3)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_3)
                {
                    MAXAlmazL5_3 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_3", MAXAlmazL5_3);
                }
            }
            if (L5_4)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_4)
                {
                    MAXAlmazL5_4 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_4", MAXAlmazL5_4);
                }
            }
            if (L5_5)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_5)
                {
                    MAXAlmazL5_5 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_5", MAXAlmazL5_5);
                }
            }
            if (L5_6)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_6)
                {
                    MAXAlmazL5_6 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_6", MAXAlmazL5_6);
                }
            }
            if (L5_7)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_7)
                {
                    MAXAlmazL5_7 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_7", MAXAlmazL5_7);
                }
            }
            if (L5_8)
            {
                if (AlmazRotate.ALMAZ_COUNT > MAXAlmazL5_8)
                {
                    MAXAlmazL5_8 = AlmazRotate.ALMAZ_COUNT;
                    PlayerPrefs.SetInt("MAXAlmazL5_8", MAXAlmazL5_8);
                }
            }
            MAX_FULL_LEVELS_SCORE += OchkiRotate.count;  ///////////////////////////////// ВАЖНО ///////////////////////////////////////
            PlayerPrefs.SetInt("MAX_FULL_LEVELS_SCORE", MAX_FULL_LEVELS_SCORE);/////////////////////////////////////////
        }
    }
    
}

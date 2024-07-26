using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_sckin : MonoBehaviour {
    public Mesh player_def;   //внешность стандартного игрока
    public Mesh player_igolki; //колючего игрока
    public Mesh player_footboal; //футбольного игрока
    public Mesh player_backet;//баскетбольный
    public Mesh player_kolca; //кольца
    Mesh mesh;                 //меш данного объекта
    MeshRenderer meshR;        //рендер нашего обхекта
    MeshFilter meshF;
    public Material[] mat;//массив цветов нашего объекта
    public Material M1, M2, M3;
    public GameObject yadro,PLAYER; 
    public static int PLAYER_SCIN,KAKOYmyach;
    public bool MENUE, LEVELS;
    public bool DEF, IGOLKI, FOOT,BASCKET, KOLCA,KUPIT;
    int trueIG, trueFOOT, trueBAS, trueKOL;
    public GameObject GALKA,NOVIYfon,KUPITbutton;
    public Text text,textOPISANIYE,textHVATAYETAL; 
    int podscheti;
    string almazov;
    Outline outline;
    public bool CLOSEALLTRONE;
    void Awake () {
        SettingsScript.lang = PlayerPrefs.GetInt("Language", 0);
        PLAYER_SCIN = PlayerPrefs.GetInt("PLAYER_SCIN", 0);
        if (MENUE) {outline = textOPISANIYE.GetComponent<Outline>();}
        if (LEVELS)
        {
            yadro = GameObject.Find("Ядро");
            if (PLAYER_SCIN != 0 || PLAYER_SCIN != 3||PLAYER_SCIN!=4) { mat = new Material[2];mat[0] = M1;mat[1] = M2; }
            if(PLAYER_SCIN==0||PLAYER_SCIN==4) { mat = new Material[1]; mat[0] = M1; }
            if (PLAYER_SCIN==3) { mat = new Material[2]; mat[0] = M3; mat[1] = M2; }
            mesh = PLAYER.GetComponent<Mesh>();
            meshF = PLAYER.GetComponent<MeshFilter>(); 
            meshR = PLAYER.GetComponent<MeshRenderer>();

            if (PLAYER_SCIN == 0){meshR.materials = new Material[1]; mesh = Instantiate(player_def);  yadro.SetActive(true); }
            if (PLAYER_SCIN == 1){meshR.materials = new Material[2]; mesh = Instantiate(player_igolki); yadro.SetActive(false); }
            if (PLAYER_SCIN == 2){meshR.materials = new Material[2]; mesh = Instantiate(player_footboal); yadro.SetActive(false); }
            if (PLAYER_SCIN == 3){meshR.materials = new Material[1]; mesh = Instantiate(player_backet); yadro.SetActive(false); }
            if (PLAYER_SCIN == 4){meshR.materials = new Material[2]; mesh = Instantiate(player_kolca); yadro.SetActive(true); }
            meshF.mesh = mesh; meshR.materials = mat;         
        }
    }

    void Update()
    {
        if (CLOSEALLTRONE)
        {
            trueFOOT = 0; PlayerPrefs.SetInt("trueFOOT", trueFOOT);
            trueBAS = 0; PlayerPrefs.SetInt("trueBAS", trueBAS);
            trueKOL = 0; PlayerPrefs.SetInt("trueKOL", trueKOL);
            trueIG = 0; PlayerPrefs.SetInt("trueIG", trueIG);
            CLOSEALLTRONE = false;
        }
        if (!KUPIT)
        {
            if (DEF && PLAYER_SCIN == 0) { GALKA.SetActive(true); }
            if (DEF && PLAYER_SCIN != 0) { GALKA.SetActive(false); }
            if (IGOLKI && PLAYER_SCIN == 1) { GALKA.SetActive(true); }
            if (IGOLKI && PLAYER_SCIN != 1) { GALKA.SetActive(false); }
            if (FOOT && PLAYER_SCIN == 2) { GALKA.SetActive(true); }
            if (FOOT && PLAYER_SCIN != 2) { GALKA.SetActive(false); }
            if (BASCKET && PLAYER_SCIN == 3) { GALKA.SetActive(true); }
            if (BASCKET && PLAYER_SCIN != 3) { GALKA.SetActive(false); }
            if (KOLCA && PLAYER_SCIN == 4) { GALKA.SetActive(true); }
            if (KOLCA && PLAYER_SCIN != 4) { GALKA.SetActive(false); }
        }
    }

    public void ONskcin()
    {
        trueFOOT = PlayerPrefs.GetInt("trueFOOT", 0);
        trueBAS = PlayerPrefs.GetInt("trueBAS", 0);
        trueKOL = PlayerPrefs.GetInt("trueKOL", 0);
        trueIG = PlayerPrefs.GetInt("trueIG", 0);

        if (FOOT && trueFOOT == 0){NOVIYfon.SetActive(true);if (SettingsScript.lang == 0){text.text = "футроникс"; textOPISANIYE.text = "для покупки этого трона требуется 150 алмазов";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 150){ podscheti = 150 - EXITScript.MAX_FULL_LEVELS_SCORE;
                    if (podscheti % 10 == 1) { almazov = "алмаз"; }if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = "алмаза"; }if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0) { almazov = "алмазов"; }
                    textHVATAYETAL.text = "вам не хватает " + podscheti + " " + almazov; KUPITbutton.SetActive(false);}}
           
            if (SettingsScript.lang == 1) { text.text = "footronix"; textOPISANIYE.text = "for the purchase of the required 150 diamond"; 
            if (EXITScript.MAX_FULL_LEVELS_SCORE < 150) { podscheti = 150 - EXITScript.MAX_FULL_LEVELS_SCORE; almazov = "diamond"; textHVATAYETAL.text = "you are missing " + podscheti + " " + almazov; KUPITbutton.SetActive(false); }
        }

        if (EXITScript.MAX_FULL_LEVELS_SCORE >= 150) { textHVATAYETAL.text = ""; KUPITbutton.SetActive(true); }
            outline.effectColor = Color.magenta;
            KAKOYmyach = 1;
        }




        if (BASCKET && trueBAS == 0){NOVIYfon.SetActive(true);if (SettingsScript.lang == 0){text.text = "баскетроникс"; textOPISANIYE.text = "для покупки этого трона требуется 250 алмазов";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 250){podscheti = 250 - EXITScript.MAX_FULL_LEVELS_SCORE;
                    if (podscheti % 10 == 1) { almazov = "алмаз"; }if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = "алмаза"; }if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0) { almazov = "алмазов"; }
                    textHVATAYETAL.text = "вам не хватает " + podscheti + " " + almazov; KUPITbutton.SetActive(false);}}
           
            if (SettingsScript.lang == 1) { text.text = "basketronix"; textOPISANIYE.text = "for the purchase of the required 250 diamond";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 250){podscheti = 250 - EXITScript.MAX_FULL_LEVELS_SCORE;almazov = "diamond";textHVATAYETAL.text = "you are missing " + podscheti + " " + almazov; KUPITbutton.SetActive(false);}}

            if (EXITScript.MAX_FULL_LEVELS_SCORE >= 250) { textHVATAYETAL.text = ""; KUPITbutton.SetActive(true); }
            outline.effectColor = Color.green; KAKOYmyach = 2;
        }




        if (KOLCA && trueKOL == 0){NOVIYfon.SetActive(true);if (SettingsScript.lang == 0){text.text = "атомтроникс"; textOPISANIYE.text = "для покупки этого трона требуется 400 алмазов";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 400){podscheti = 400 - EXITScript.MAX_FULL_LEVELS_SCORE;
                    if (podscheti % 10 == 1) { almazov = "алмаз"; }
                    if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = "алмаза"; }
                    if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0) { almazov = "алмазов"; }
                    textHVATAYETAL.text = "вам не хватает " + podscheti + " " + almazov; KUPITbutton.SetActive(false);
                }
            }
            if (EXITScript.MAX_FULL_LEVELS_SCORE >= 400) { textHVATAYETAL.text = ""; KUPITbutton.SetActive(true); }

            if (SettingsScript.lang == 1) { text.text = "atomtronix"; textOPISANIYE.text = "for the purchase of the required 400 diamond"; 
            if (EXITScript.MAX_FULL_LEVELS_SCORE < 400) { podscheti = 400 - EXITScript.MAX_FULL_LEVELS_SCORE; almazov = "diamond"; textHVATAYETAL.text = "you are missing " + podscheti + " " + almazov; KUPITbutton.SetActive(false); }
        }
        outline.effectColor = Color.yellow; KAKOYmyach = 3;
        }



        if (IGOLKI && trueIG == 0)
        {
            NOVIYfon.SetActive(true); if (SettingsScript.lang == 0)
            {
                text.text = "колтроникс"; textOPISANIYE.text = "для покупки этого трона требуется 600 алмазов";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 600)
                {
                    podscheti = 600 - EXITScript.MAX_FULL_LEVELS_SCORE;
                    if (podscheti % 10 == 1) { almazov = "алмаз"; }
                    if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = "алмаза"; }
                    if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0) { almazov = "алмазов"; }
                    textHVATAYETAL.text = "вам не хватает " + podscheti + " " + almazov; KUPITbutton.SetActive(false);
                }
            }
            if (EXITScript.MAX_FULL_LEVELS_SCORE >= 600) { textHVATAYETAL.text = ""; KUPITbutton.SetActive(true); }
            if (SettingsScript.lang == 1) { text.text = "koltronix"; textOPISANIYE.text = "for the purchase of the required 600 diamond";
                if (EXITScript.MAX_FULL_LEVELS_SCORE < 600) { podscheti = 600 - EXITScript.MAX_FULL_LEVELS_SCORE; almazov = "diamond"; textHVATAYETAL.text = "you are missing " + podscheti + " " + almazov; KUPITbutton.SetActive(false); }
            }
            outline.effectColor = Color.red; KAKOYmyach = 4;
        }
       


        if (KUPIT && KAKOYmyach == 1) { EXITScript.MAX_FULL_LEVELS_SCORE -= 150; trueFOOT = 1; PlayerPrefs.SetInt("trueFOOT", trueFOOT); NOVIYfon.SetActive(false); PLAYER_SCIN = 2; FOOT = true; }
        if (KUPIT && KAKOYmyach == 2) { EXITScript.MAX_FULL_LEVELS_SCORE -= 250; trueBAS = 1; PlayerPrefs.SetInt("trueBAS", trueBAS); NOVIYfon.SetActive(false); BASCKET = true; PLAYER_SCIN = 3; }
        if (KUPIT && KAKOYmyach == 3) { EXITScript.MAX_FULL_LEVELS_SCORE -= 400; trueKOL = 1; PlayerPrefs.SetInt("trueKOL", trueKOL); NOVIYfon.SetActive(false); KOLCA = true; PLAYER_SCIN = 4; }
        if (KUPIT && KAKOYmyach == 4) { EXITScript.MAX_FULL_LEVELS_SCORE -= 600; trueIG = 1; PlayerPrefs.SetInt("trueIG", trueIG); NOVIYfon.SetActive(false); IGOLKI = true;PLAYER_SCIN = 1; }

        if (DEF) { PLAYER_SCIN = 0; PlayerPrefs.SetInt("PLAYER_SCIN", PLAYER_SCIN); }
        if (IGOLKI && trueIG == 1) { PLAYER_SCIN = 1; PlayerPrefs.SetInt("PLAYER_SCIN", PLAYER_SCIN); }
        if (FOOT && trueFOOT == 1) { PLAYER_SCIN = 2; PlayerPrefs.SetInt("PLAYER_SCIN", PLAYER_SCIN); }
        if (BASCKET && trueBAS == 1) { PLAYER_SCIN = 3; PlayerPrefs.SetInt("PLAYER_SCIN", PLAYER_SCIN); }
        if (KOLCA && trueKOL == 1) { PLAYER_SCIN = 4; PlayerPrefs.SetInt("PLAYER_SCIN", PLAYER_SCIN); }
        PlayerPrefs.SetInt("MAX_FULL_LEVELS_SCORE", EXITScript.MAX_FULL_LEVELS_SCORE);
    }



    }

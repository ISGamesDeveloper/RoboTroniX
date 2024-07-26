using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ScoreTextScript : MonoBehaviour { 
    Text t;
    public Material m;
    public bool score;
    public bool lifes;
    public bool SHITcount;
    public bool buttons;
    public bool text;  
    public bool LevelComplete;
    public bool speed_text;
    Image i;
    int Almaz;
    string ochki;
    byte matCount;
    int lifecount;
    int ochkiCount;
    public static int KolSHITOV;

    int NETreklami;
    void Awake()
    {
        NETreklami = PlayerPrefs.GetInt("kupili_reklamu", 0);
    }
    void Start()    
    {
        matCount = PortalScript.material_count;
        if (buttons) { i = GetComponent<Image>(); i.color = m.color; }
        if (score) { t = GetComponent<Text>(); if (SettingsScript.lang == 0) { ochki = "алмазы: "; } if (SettingsScript.lang == 1) { ochki = "diamonds: "; }ochkiCount = OchkiRotate.count;  t.text = ochki + OchkiRotate.count;}
        if (SHITcount) { t = GetComponent<Text>(); KolSHITOV = SHITscript.KolichestvoShitov + SHITscript.KuplenniyeShiti; t.color = m.color; t.text = SHITscript.KolichestvoShitov + SHITscript.KuplenniyeShiti + ""; }
        if (lifes) { if(NETreklami == 0) { t = GetComponent<Text>(); lifecount = PlayerPositionScript.lifes; t.color = m.color; t.text = "" + PlayerPositionScript.lifes; } else { t = GetComponent<Text>();t.text = "";if (GameObject.Find("Жизни")) { GameObject.Find("Жизни").GetComponent<Image>().enabled = false; } } }    
        if (LevelComplete) { t = GetComponent<Text>(); t.color = m.color; }
        if (text) { t = GetComponent<Text>(); t.color = m.color; }
        if (speed_text) { t = GetComponent<Text>();  if (SettingsScript.lang == 0) { ochki = "скорость"; } if (SettingsScript.lang == 1) { ochki = "speed"; } t.text = ochki; t.color = m.color; }
       StartCoroutine(Updateeee());
    }

    void Update()
    {
        if (NETreklami == 0)
        {
            if (lifes)
            {
                if (lifecount != PlayerPositionScript.lifes)
                {
                    t.text = "" + PlayerPositionScript.lifes; lifecount = PlayerPositionScript.lifes;
                }
            }
        }
    }
    IEnumerator Updateeee() {     
           while (true)
           {
            if (score)
            {
                    t.text = ochki + OchkiRotate.count; ochkiCount = OchkiRotate.count;
            }
                if (lifes)
                {
                        t.color = m.color; matCount = PortalScript.material_count;
                }

            if (buttons)
            {
                    i.color = m.color; matCount = PortalScript.material_count;
            }

            if (text)
            {
                    t.color = m.color; matCount = PortalScript.material_count;
            }

            if (speed_text)
            {
                    t.color = m.color; t.text = ochki; matCount = PortalScript.material_count;
            }

            if (LevelComplete)
            {
                    t.color = m.color; matCount = PortalScript.material_count;
            }

            if (SHITcount)
            {
                    t.color = m.color; matCount = PortalScript.material_count;
                if (KolSHITOV != SHITscript.KolichestvoShitov + SHITscript.KuplenniyeShiti) { t.text = SHITscript.KolichestvoShitov + SHITscript.KuplenniyeShiti + ""; KolSHITOV = SHITscript.KolichestvoShitov + SHITscript.KuplenniyeShiti; }
            }

        
            yield return new WaitForSeconds(0.4f); 
           }
       }
      

}

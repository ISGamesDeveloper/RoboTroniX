using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZAMOK_BLOCKS_SCRIPT : MonoBehaviour {

    public bool BLOCK2, BLOCK3, BLOCK4, BLOCK5,BLOCK6,OKEY_BUTTON,Message;
    public GameObject BLOCK_IMAGE;
    public GameObject OKEY;
    public GameObject Canvas_Block;
    public Text message;
    public GameObject back_button_block;
    int almaz_count,podscheti;
    string almazov;
    string s;
    
    void Start()
    {
        if (BLOCK2) { almaz_count = 20; }
        if (BLOCK3) { almaz_count = 45; }
        if (BLOCK4) { almaz_count = 65; }
        if (BLOCK5) { almaz_count = 90; }
        if (BLOCK6) { almaz_count = 115; } 
    }
    public void OnMouseUp()
    {
        GameObject.Find("щелчек кнопкой").GetComponent<AudioSource>().Play();
        podscheti = almaz_count - EXITScript.MAX_FULL_LEVELS_ALMAZ;
        if (SettingsScript.lang == 0) {
            if (podscheti % 10 == 1) { almazov = " кристалл"; }
            if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = " кристалла"; }
            if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0 || podscheti >= 11 && podscheti <= 14||podscheti>=1011&&podscheti<=1014 || podscheti >= 2011 && podscheti <= 2014) { almazov = " кристаллов"; }
            s = "Что бы открыть этот блок вам нужно собрать " + almaz_count + " кристаллов.Вам не хватает "+podscheti + almazov;        
        }

        if (SettingsScript.lang == 1) {
            if (podscheti % 10 == 1) { almazov = " crystal"; }
            if (podscheti % 10 >= 2 && podscheti % 10 <= 4) { almazov = " crystals"; }
            if (podscheti % 10 >= 5 && podscheti % 10 <= 9 || podscheti % 10 == 0) { almazov = " crystals"; }
            s = "To open this box you need to collect " + almaz_count + " crystals. you are missing "+ podscheti + almazov;
        }
        if (OKEY_BUTTON) { gameObject.SetActive(false); BLOCK_IMAGE.SetActive(false);back_button_block.SetActive(true); }
        if (BLOCK2||BLOCK3||BLOCK4||BLOCK5||BLOCK6)
        {
            back_button_block.SetActive(false);
            BLOCK_IMAGE.SetActive(true);
            message.text = s;
            message.enabled = true;
            OKEY.SetActive(true);
        }


    }

}

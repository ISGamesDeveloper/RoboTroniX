using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Notif_button : MonoBehaviour {

    public static int ONOFF;
    public Image UVEDOML;
    public Text textOP,text;
    public Animator anim;
    int lang;
    void Awake () {
        ONOFF = PlayerPrefs.GetInt("ONOFF", 0);
        lang = PlayerPrefs.GetInt("Language", 0);
        if (ONOFF == 1) { UVEDOML.color = Color.gray; }
        if (ONOFF == 0) { UVEDOML.color = Color.white; }
      //  StartCoroutine(Updateee());
    }


  //  IEnumerator Updateee()
 //   {
   //     while (true)
    //    {
     //       if (lang == 0){text.text = "уведомления";}
     //       if (lang == 1) { text.text = "notifications"; }
      //   yield return new WaitForSeconds(2f);
       //}
    //}


    public void ON_notif()
    {
        GameObject.Find("щелчек кнопкой").GetComponent<AudioSource>().Play();
        lang = PlayerPrefs.GetInt("Language", 0);
        if (UVEDOML.color == Color.white)
        {
            if (lang == 0) { textOP.text = "уведомления выключены"; }
            if (lang == 1) { textOP.text = "notifications off"; }
            ONOFF = 1; PlayerPrefs.SetInt("ONOFF", ONOFF);
            LocalNotification.CancelNotification(1);
            UVEDOML.color = Color.grey; anim.enabled = true; return;
        }
        if (UVEDOML.color == Color.grey)
        {
            if (lang == 0) { textOP.text = "уведомления включены"; }
            if (lang == 1) { textOP.text = "notifications on"; }
            ONOFF = 0; PlayerPrefs.SetInt("ONOFF", ONOFF);

            UVEDOML.color = Color.white; anim.enabled = true; return;
        }
    }

}

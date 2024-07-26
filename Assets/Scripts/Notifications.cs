using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Notifications : MonoBehaviour {

    public static Transform playerTransform;
  //  float sleepUntil = 0;
    public static int ONOFF;
    int lang;
    int numerator;
    void Awake()
    {
       ONOFF = PlayerPrefs.GetInt("ONOFF", 0);
        lang = PlayerPrefs.GetInt("Language", 0);
        StartCoroutine(Updateeee());
        if (Application.loadedLevelName == "Menu") { numerator = 5; } else { numerator = 180; }
        if (playerTransform != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
        playerTransform = transform;
     

}
    IEnumerator Updateeee()
    {
        while (true)
        {
            yield return new WaitForSeconds(numerator);//300
            ONOFF = PlayerPrefs.GetInt("ONOFF", 0);
          //  Debug.Log(ONOFF);
            if (ONOFF == 0)
            {
                lang = PlayerPrefs.GetInt("Language", 0);
                if (lang == 0){ LocalNotification.SendNotification(1, 25000, "RoboTroniX", "ЭЙ! Вы меня не забыли? ;(", new Color32(0, 0, 0, 0), true, true, true, "app_icon");}
                if (lang == 1){ LocalNotification.SendNotification(1, 25000, "RoboTroniX", "HEY! You have not forgotten about me? ;(", new Color32(0, 0, 0, 0), true, true, true, "app_icon"); }
             //   sleepUntil = Time.time + 14400;  // + 14400;//4 часа
            }          
        }
    }

  
  //  void OnGUI()
  //  {
        //Color is supported only in Android >= 5.0
 //       GUI.enabled = sleepUntil < Time.time;

     //   if (GUILayout.Button("5 SECONDS", GUILayout.Height(Screen.height * 0.2f)))
     //   {
      //      LocalNotification.SendNotification(1, 5, "Title", "Long message text", new Color32(0xff, 0x44, 0x44, 255));
     //       sleepUntil = Time.time + 5;
     //   }

      //  if (GUILayout.Button("5 SECONDS BIG ICON", GUILayout.Height(Screen.height * 0.2f)))
      //  {
     //       LocalNotification.SendNotification(1, 5, "Title", "Long message text with big icon", new Color32(0xff, 0x44, 0x44, 255), true, true, true, "app_icon");
      //      sleepUntil = Time.time + 5;
     //   }

       // if (GUILayout.Button("EVERY 5 SECONDS", GUILayout.Height(Screen.height * 0.2f)))
      //  {
     //       LocalNotification.SendRepeatingNotification(1, 5, 5, "Title", "Long message text", new Color32(0xff, 0x44, 0x44, 255));
     //       sleepUntil = Time.time + 99999;
      //  }

      //  if (GUILayout.Button("10 SECONDS EXACT", GUILayout.Height(Screen.height * 0.2f)))
     //   {
      //      LocalNotification.SendNotification(1, 10, "Title", "Long exact message text", new Color32(0xff, 0x44, 0x44, 255), executeMode: LocalNotification.NotificationExecuteMode.ExactAndAllowWhileIdle);
      //      sleepUntil = Time.time + 10;
      //  }

    //    GUI.enabled = true;

    //    if (GUILayout.Button("STOP", GUILayout.Height(Screen.height * 0.2f)))
      //  {
     //       LocalNotification.CancelNotification(1);
     //       sleepUntil = 0;
    //    }
  //  }
}

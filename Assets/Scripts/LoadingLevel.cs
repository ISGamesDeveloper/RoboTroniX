using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class LoadingLevel : MonoBehaviour
{
    public Texture backgroundBar;
    public Texture lineBar;
    private AsyncOperation async = null;
    private bool isLoading = false;
    public string levelName = "";

    private IEnumerator _Start()
    {
        Debug.Log("Loading... ");
        async = SceneManager.LoadSceneAsync(levelName);
        while (!async.isDone)
        {
            Debug.Log(string.Format("Loading {0}%", async.progress * 100));
            yield return null;
        }
        Debug.Log("Loading complete");
        isLoading = false;
        yield return async; 
    }

    private void OnGUI()
    {
        if (!isLoading)
        {
            if (GUI.Button(new Rect((Screen.width * 0.5f) - 60, Screen.height * 0.6f, 120, 40), "press to continue"))
            {
                isLoading = true;
                StartCoroutine("_Start"); //код согласия
            }
        }
        else
        {
            
          GUI.DrawTexture(new Rect((Screen.width / 2) - 300, (Screen.height / 2) + (Screen.height / 3), 512, 30), backgroundBar, ScaleMode.StretchToFill, true, 1F);//Сдесь выводится текстура полосы, которая будед ПОД полоской загрузки (Фон)
          GUI.DrawTexture(new Rect((Screen.width / 2) - 300, (Screen.height / 2) + (Screen.height / 3), async.progress * 512, 30), lineBar, ScaleMode.StretchToFill, true, 1F);//А тут непосредственно сама полоса загрузки в с координатами такими же как и у фона, но длина расчитивается прогресс загрузки умноженное на длину текстуры
          Debug.Log(string.Format("=> isLoading {0}%", async.progress * 100));
        }
    }
}

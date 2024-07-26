using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorScript : MonoBehaviour {
    Light Light;
    Image img;
	SpriteRenderer sprite;
    Text text;
    public Material material;
	public bool l,Sprite,Image,textTTT;
	public bool Auto_Light,Red,Blue,Yellou,Cyan,Green,Gray,Grey,Magenta,White;
   
    void Start(){
        if (Image){img = GetComponent<Image>();}
        if (l){Light = GetComponent<Light>();}
		if (Sprite) {sprite = GetComponent<SpriteRenderer>();}
        if (textTTT) { text = GetComponent<Text>(); }
      //   StartCoroutine(Updateeee());
    }
   // void OnEnable() { StartCoroutine(Updateeee()); }// так не делать
   // IEnumerator Updateeee()
   // {
    //   while (true)
    //   {
    void Update() { 
            if (Image)
            {
                if (Auto_Light) { img.color = material.color; }
                if (Red) { img.color = Color.red; }
                if (Blue) { img.color = Color.blue; }
                if (Yellou) { img.color = Color.yellow; }
                if (Cyan) { img.color = Color.cyan; }
                if (Green) { img.color = Color.green; }
                if (Gray) { img.color = Color.gray; }
                if (Magenta) { img.color = Color.magenta; }
                if (White) { img.color = Color.white; }
            }
            if (l)
            {
                if (Auto_Light) { Light.color = material.color; }
                if (Red) { Light.color = Color.red; }
                if (Blue) { Light.color = Color.blue; }
                if (Yellou) { Light.color = Color.yellow; }
                if (Cyan) { Light.color = Color.cyan; }
                if (Green) { Light.color = Color.green; }
                if (Gray) { Light.color = Color.gray; }
                if (Magenta) { Light.color = Color.magenta; }
                if (White) { Light.color = Color.white; }
            }
            if (Sprite)
            {
                if (Auto_Light) { sprite.color = material.color; }
                if (Red) { sprite.color = Color.red; }
                if (Blue) { sprite.color = Color.blue; }
                if (Yellou) { sprite.color = Color.yellow; }
                if (Cyan) { sprite.color = Color.cyan; }
                if (Green) { sprite.color = Color.green; }
                if (Gray) { sprite.color = Color.gray; }
                if (Magenta) { sprite.color = Color.magenta; }
                if (White) { sprite.color = Color.white; }
            }
        if (textTTT) { text.color = material.color; }
      //      yield return new WaitForSeconds(0.4f);
      //  }
    }
}

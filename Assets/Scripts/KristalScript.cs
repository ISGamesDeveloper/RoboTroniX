using UnityEngine;
using UnityEngine.UI;

public class KristalScript : MonoBehaviour {
    public bool K1;
    public bool K2;
    public bool K3; 
    
	void Start () {
        GameObject.Find("K1").GetComponent<Image>().color = Color.black;
        GameObject.Find("K2").GetComponent<Image>().color = Color.black;
        GameObject.Find("K3").GetComponent<Image>().color = Color.black;
	}
    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (K1) { GameObject.Find("K1").GetComponent<Image>().color = Color.white; }
            if (K2) { GameObject.Find("K2").GetComponent<Image>().color = Color.white; }
            if (K3) { GameObject.Find("K3").GetComponent<Image>().color = Color.white; }      
        }  
    }
}

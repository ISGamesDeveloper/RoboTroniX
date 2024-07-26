using UnityEngine;

public class AnimationScript : MonoBehaviour {

    Animator anim;
    
	void Start () {anim = GetComponent<Animator>();anim.enabled = false;}
    void OnTriggerEnter(Collider col){if (col.gameObject.CompareTag("Player")){anim.enabled=true;}}
    void OnTriggerExit(Collider col){if (col.gameObject.CompareTag("Player")){anim.enabled = false;}}	
}

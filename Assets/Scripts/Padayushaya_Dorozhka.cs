using UnityEngine;
using System.Collections;

public class Padayushaya_Dorozhka : MonoBehaviour {

    Animator anim;
	void Start () {
        anim = GetComponent<Animator>();
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            anim.enabled = true;
            StartCoroutine(Updateeee());
        }       
    }
    IEnumerator Updateeee()
    {
            yield return new WaitForSeconds(2);
            anim.enabled = false;
        StopCoroutine(Updateeee());
    }
}

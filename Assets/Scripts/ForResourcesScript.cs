using UnityEngine;

public class ForResourcesScript : MonoBehaviour {

    public GameObject LOADING;
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			LOADING.SetActive (false);
        }
	}
}

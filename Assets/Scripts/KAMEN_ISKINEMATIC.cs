using UnityEngine;
using System.Collections;

public class KAMEN_ISKINEMATIC : MonoBehaviour {

	Rigidbody rig;
	void Start()
	{
		rig = GetComponent<Rigidbody> ();
		rig.isKinematic = true;
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.CompareTag ("Player"))
		{
			if (rig.isKinematic) {
				rig.isKinematic = false;
			}
		}
	}
	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.CompareTag ("Player"))
		{
			if (!rig.isKinematic) {
				rig.isKinematic = true;
			}
		}
	}
}

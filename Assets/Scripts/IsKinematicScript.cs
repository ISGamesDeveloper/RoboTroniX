using UnityEngine;

public class IsKinematicScript : MonoBehaviour {

	public GameObject Enemy, E4, E5, E6, E7;
    public bool One_Enemy,E4_E5_E6_E7,massive;
    public GameObject[] Massive_Enemy;
    void Start(){
        if (One_Enemy) {Enemy.GetComponent<Rigidbody>().isKinematic = true;}       
        if (E4_E5_E6_E7) {
            E4.GetComponent<Rigidbody>().isKinematic = true;
            E5.GetComponent<Rigidbody>().isKinematic = true;
            E6.GetComponent<Rigidbody>().isKinematic = true;
            E7.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (massive) { for (int i = 0; i < Massive_Enemy.Length; i++) { Massive_Enemy[i].GetComponent<Rigidbody>().isKinematic = true; } }

    }

    void OnTriggerEnter(Collider col){if (col.gameObject.CompareTag ("Player")) {
            if (One_Enemy){Enemy.GetComponent<Rigidbody>().isKinematic = false;}
            if (E4_E5_E6_E7)
            {
                E4.GetComponent<Rigidbody>().isKinematic = false;
                E5.GetComponent<Rigidbody>().isKinematic = false;
                E6.GetComponent<Rigidbody>().isKinematic = false;
                E7.GetComponent<Rigidbody>().isKinematic = false;
            }
            if (massive){for (int i = 0; i < Massive_Enemy.Length; i++){ if (Massive_Enemy[i] != null){Massive_Enemy[i].GetComponent<Rigidbody>().isKinematic = false; }}}
        }

    }
    void OnTriggerExit(Collider col){if (col.gameObject.CompareTag ("Player")) {
            if (One_Enemy){Enemy.GetComponent<Rigidbody>().isKinematic = true;}
            if (E4_E5_E6_E7)
            {
                E4.GetComponent<Rigidbody>().isKinematic = true;
                E5.GetComponent<Rigidbody>().isKinematic = true;
                E6.GetComponent<Rigidbody>().isKinematic = true;
                E7.GetComponent<Rigidbody>().isKinematic = true;
            }
            if (massive) { for (int i = 0; i < Massive_Enemy.Length; i++) { Massive_Enemy[i].GetComponent<Rigidbody>().isKinematic = true; } }
        }
    }
}

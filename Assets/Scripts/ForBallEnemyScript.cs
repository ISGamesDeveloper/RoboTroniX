using UnityEngine;

public class ForBallEnemyScript : MonoBehaviour {
    //если нужно что бы движущаяся дорожка двигалась то поставить галочку на DV_Dorozhka и галочку в какую сторону она поедит.
    //если это враг то поставить галочку там в какую сторону он пойдет.Коллайлеры для дорожки и врагов одинаковые.
    public AudioSource zvukOGNYA;
	public bool xPlus, xMinus, yPlus, yMinus, zPlus, zMinus,On,DV_Dorozhka;//On - нужно для врагов.Когда прикосаются к земле начинают двигаться.
	Rigidbody rig;
	float X,Y,Z,speed;
    public ParticleSystem stars;
    public bool CYANEnemy;
    public bool ENEMY;//если это враг то пусть играет звук огня.
    public float ENEMY_SPEED,DV_SPEED;
    public bool DorozhkaOn;//управляется со скрипта On_Off_bool_DV_dor
    public bool constraintsY;
    void Start () {      
        if (ENEMY_SPEED == 0) {speed = 35f;}
        if (ENEMY_SPEED != 0) { speed = ENEMY_SPEED; }       
		if (DV_Dorozhka){
        
            if (DV_SPEED == 0) { speed = 1.3f; }
            if (DV_SPEED != 0) { speed = DV_SPEED; }
        }

        rig = GetComponent<Rigidbody>();
        rig.isKinematic = true;
        if (xPlus) {X = speed;rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (xMinus) {X = -speed;rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (yPlus) {Y = speed;rig.constraints = RigidbodyConstraints.FreezePositionX;rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (yMinus) {Y = -speed;rig.constraints = RigidbodyConstraints.FreezePositionX;rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (zPlus) {Z = speed;rig.constraints = RigidbodyConstraints.FreezePositionX;}
		if (zMinus) {Z = -speed;rig.constraints = RigidbodyConstraints.FreezePositionX;} 

	}
	void FixedUpdate () {
        if (DV_Dorozhka) { if (DorozhkaOn) { rig.MovePosition(new Vector3(transform.position.x + X * Time.deltaTime, transform.position.y + Y * Time.deltaTime, transform.position.z + Z * Time.deltaTime)); } }
		if (On){rig.AddForce (X * Time.deltaTime, Y*Time.deltaTime, Z*Time.deltaTime, ForceMode.Impulse);}
	}
	void OnTriggerEnter(Collider col)
	{
        if (!DV_Dorozhka)
        {
            if (col.gameObject.CompareTag("Death") || col.gameObject.CompareTag("SHIT"))
            {
                GameObject.Find("взрыв мяча").GetComponent<AudioSource>().Play();
                if (!CYANEnemy) { stars.startColor = Color.red; }
                if (CYANEnemy) { stars.startColor = Color.cyan; }
                Instantiate(stars, transform.position, transform.rotation);
                gameObject.SetActive(false);//Object.Destroy(this.gameObject);

            }
        }
		if (col.gameObject.CompareTag ("X+")) {Z = 0;X = speed;Y = 0; rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (col.gameObject.CompareTag ("X-")) {Z = 0;X = -speed; Y = 0; rig.constraints = RigidbodyConstraints.FreezePositionZ;}
		if (col.gameObject.CompareTag ("Y+")) {Z = 0;Y = speed;X = 0;rig.constraints = RigidbodyConstraints.FreezePositionZ;rig.constraints = RigidbodyConstraints.FreezePositionX;}
		if (col.gameObject.CompareTag ("Y-")) {Z = 0;Y = -speed;X = 0;rig.constraints = RigidbodyConstraints.FreezePositionZ;rig.constraints = RigidbodyConstraints.FreezePositionX;}
		if (col.gameObject.CompareTag ("Z+")) {X = 0;Z = speed; Y = 0; rig.constraints = RigidbodyConstraints.FreezePositionX;}
		if (col.gameObject.CompareTag ("Z-")) {X = 0;Z = -speed; Y = 0; rig.constraints = RigidbodyConstraints.FreezePositionX;}
        if (constraintsY) { rig.constraints = RigidbodyConstraints.FreezePositionY; }
        if (ENEMY) {
            if (col.gameObject.CompareTag("ZvukOGNYA")) { zvukOGNYA.Play(); }
           
        }
        

    }
   

	void OnCollisionEnter(Collision col){ if (On == false) { On = true; } }
}

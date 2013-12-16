using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	private Turretshoot turretscript;
	// Use this for initialization
	void Start () {
		Turretshoot	turretscript = (Turretshoot)this.GetComponent(typeof(Turretshoot));
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		//transform.LookAt(enemies.transform.position);
		rigidbody.AddRelativeForce(Vector3.forward * 500);
	}
	void OnTriggerEnter (Collider col) {
		if(col.gameObject.name == "EnemyLeft")
		{
			Destroy(col.gameObject);
			turretscript.enemiesInRange.Remove(col.gameObject);

			
		}
	}

}

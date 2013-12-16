using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Turretshoot : MonoBehaviour 
{
	private bool looking;
	private GameObject target;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	public float timer;

	void Start () 
	{

	}
	void FixedUpdate () 
	{
		timer += 1 * Time.deltaTime ;
		//Debug.Log(timer);
		if (target) 
		{
			transform.LookAt(target.transform.position);
		}
		//		vector3 targetdir = new vector3(target.position.x - transform.position.x, 0f,
		//		                                target.position.z - transform.position.z);
		//		vector3 desiredRotation = Vector3.RotateTowards(transform.forward, targetdir,
		//		                                                time.deltatime*turnspeed, 0f
		//		 transform.Rotation(desiredRotation)
	}

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.name == "EnemyLeft")
		{
			enemiesInRange.Add(col.gameObject);
		}
	}

	void OnTriggerStay (Collider col) 
	{
		if(col.gameObject.name == "EnemyLeft")
		{
			target = enemiesInRange[0];
			looking = true;
			if (timer > 5 && looking == true)
			{
				shooting();
				target = enemiesInRange[0];
			}
		}


	}
	void OnTriggerExit (Collider col)
	{
		if(enemiesInRange.Contains(col.gameObject)) 
		{
			enemiesInRange.Remove(col.gameObject);
		}
	}

<<<<<<< HEAD
<<<<<<< HEAD
	void shooting(){
		//Debug.log("boop");
=======
	void shooting()
	{
		Debug.Log("kaas");
>>>>>>> 7f4ed520e1445c82aee3600058c7fdb9cb71bca1
=======
	void shooting()
	{
		Debug.Log("kaas");
>>>>>>> 7f4ed520e1445c82aee3600058c7fdb9cb71bca1
		timer = 0;
		Instantiate(Resources.Load("Bullet"), transform.position, transform.rotation);
	}
}


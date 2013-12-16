using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{

<<<<<<< HEAD
<<<<<<< HEAD
public GameObject leftenemies;
private	bool wave1 = true;
private	bool wave2;
private	bool wave3;
private	bool wave4;
	private Vector3 enemypos = new Vector3(-10,0,0);
=======
=======
>>>>>>> 7f4ed520e1445c82aee3600058c7fdb9cb71bca1
	public GameObject leftenemies;
	private	bool wave1 = true;
	private	bool wave2 = false;
	private	bool wave3;
	private	bool wave4;
	public float timer;
	private Vector3 enemypos = new Vector3(0,0,0);
>>>>>>> 7f4ed520e1445c82aee3600058c7fdb9cb71bca1
	// Use this for initialization
	void Start () 
	{
		//leftenemies = GameObject.FindGameObjectsWithTag("LeftEnemys");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		timer += 1 * Time.deltaTime ;

		if (wave1)
		{
			Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity);
			wave1 = false;
		}
		if (timer > 10)
		{
			wave2 = true;
			Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity);
			timer = -5000;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour 
{

	public GameObject leftenemies;
	private	bool wave1 = true;
	private	bool wave2 = false;
	private	bool wave3;
	private	bool wave4;
	public float timer;
	private Vector3 enemypos = new Vector3(0,0,0);
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

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

public GameObject leftenemies;
private	bool wave1 = true;
private	bool wave2;
private	bool wave3;
private	bool wave4;
	private Vector3 enemypos = new Vector3(0,0,0);
	// Use this for initialization
	void Start () {
		//leftenemies = GameObject.FindGameObjectsWithTag("LeftEnemys");
	}
	
	// Update is called once per frame
	void Update () {
		if (wave1)
		{
			Instantiate(Resources.Load("LeftEnemyz"), enemypos, Quaternion.identity);
			wave1 = false;
		}
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyRightMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.right * Time.deltaTime);
	}
}

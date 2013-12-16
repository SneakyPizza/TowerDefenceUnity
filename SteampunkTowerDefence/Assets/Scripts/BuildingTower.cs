using UnityEngine;
using System.Collections;

public class BuildingTower : MonoBehaviour {

	private bool window1;
	private bool turretbought;
	// Use this for initialization
	void Start () {
		window1 = false;
		turretbought = false;
		renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		if (window1){
		if (GUI.Button(new Rect(10, 10, 150, 100), "Build Turret1"))
				if (!turretbought){
			Instantiate(Resources.Load("Turret"), transform.position, transform.rotation);
			turretbought = true;
				window1 = false;
			}
		}
	}

	void OnMouseDown() {
		if (!turretbought){
		window1 = true;
		}
	}
}

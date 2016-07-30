using UnityEngine;
using System.Collections;

public class LeftClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDrag(){
		GameObject playerbar=GameObject.Find("Player");
		Vector2 Position=playerbar.transform.position;
		Position.x-=0.1f;
		playerbar.transform.position=Position;
	}
}

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	void Move(){//移動関連
		Vector2 Position=transform.position;
		if(Input.GetKey(KeyCode.RightArrow)){
			Position.x+=0.1f;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			Position.x-=0.1f;
		}	
		transform.position=Position;		
	}
}

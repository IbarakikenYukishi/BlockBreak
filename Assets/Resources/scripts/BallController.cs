using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Rigidbody2D rb=GetComponent<Rigidbody2D>();
		Vector2 direction=new Vector2(0.0f,2.0f);
		rb.velocity=direction;
//		Create(Random.Range(45.0f,135.0f),1.0f);
//		GetComponent<Rigidbody2D>().AddForce(direction*rb.mass/Time.fixedDeltaTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Create(float direction,float speed){
		Vector2 v;
		v.x=Mathf.Cos(Mathf.Deg2Rad*direction)*speed;
		v.y=Mathf.Sin(Mathf.Deg2Rad*direction)*speed;
		GetComponent<Rigidbody2D>().velocity=v;
	}
}

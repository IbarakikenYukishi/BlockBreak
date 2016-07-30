using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {
	public Rigidbody2D rb;
	public int remaintime=0;
	public bool remainflag=true;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
		RemainVanish();
		
	}
	void RemainVanish(){
		if(remainflag==false){
			remaintime+=1;
		}
		if(remaintime>300){
			Destroy(gameObject);
		}
	}
/*	void OnTriggerEnter(){
		Destroy(gameObject);
	}
*/	void OnCollisionEnter2D(Collision2D other){
		if(other.collider.tag=="Ball"){
			rb.isKinematic=false;
			Vector2 direction=new Vector2(Random.Range(-0.4f,0.4f),0.0f);
			rb.AddForce(direction*rb.mass/Time.fixedDeltaTime);
			GetComponent<Collider2D>().isTrigger=true;
			remainflag=false;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag=="Player"){
			GameObject prefab=Resources.Load("Prefabs/ball")as GameObject;
			GameObject ball=Instantiate(prefab,transform.position,transform.rotation)as GameObject;
			ball.GetComponent<BallController>().Create(Random.Range(45.0f,135.0f),2.0f);
			ball.GetComponent<SpriteRenderer>().color=GetComponent<SpriteRenderer>().color;
			Destroy(gameObject);
		}
	}
}

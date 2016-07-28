using UnityEngine;
using System.Collections;

public class MainGameController : MonoBehaviour {
	public GameObject blockprefab;
	public const float FrameX=500.0f;
	public const float FrameY=912.0f;
	public const float BlockSize=5.0f;
	public const float RawBlockSize=64.0f;
	// Use this for initialization
	void Start () {
		blockprefab=Resources.Load("Prefabs/block")as GameObject;
		for(int j=0;j<30;j++)for(int i=0;i<FrameX/BlockSize;i++){
			GameObject temporaryblock;
			Vector2 position=new Vector2(-FrameX/2.0f+BlockSize*(float)i+BlockSize/2.0f,+FrameY/2.0f-(float)j*BlockSize)/100.0f;;
			temporaryblock=Instantiate(blockprefab,position,Quaternion.identity)as GameObject;
			temporaryblock.transform.localScale=new Vector3(BlockSize/RawBlockSize,BlockSize/RawBlockSize,1);
			temporaryblock.GetComponent<SpriteRenderer>().color=new Color((float)i*1.0f/(FrameX/BlockSize),0.0f,0.0f,1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

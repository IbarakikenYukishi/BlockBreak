using UnityEngine;
using System.Collections;

public class MainGameController : MonoBehaviour {
	public GameObject blockprefab;
	public const float FrameX=500.0f;//フレームのXの幅
	public const float FrameY=912.0f;//フレームのYの幅
	public const float BlockSize=5.0f;//ブロックの大きさ
	public const float RawBlockSize=64.0f;//ブロックのスプライトの生の大きさ
	// Use this for initialization
	void Start () {
		//プレファブ登録
		blockprefab=Resources.Load("Prefabs/block")as GameObject;
		//(FrameX/BlockSize)*30のブロックを生成
		for(int j=0;j<30;j++)for(int i=0;i<FrameX/BlockSize;i++){
			GameObject temporaryblock;
			Vector2 position=new Vector2(-FrameX/2.0f+BlockSize*(float)i+BlockSize/2.0f,+FrameY/2.0f-(float)j*BlockSize)/100.0f;
			temporaryblock=Instantiate(blockprefab,position,Quaternion.identity)as GameObject;
			//大きさ調節
			temporaryblock.transform.localScale=new Vector3(BlockSize/RawBlockSize,BlockSize/RawBlockSize,1);
			//色変更
			temporaryblock.GetComponent<SpriteRenderer>().color=new Color((float)i*1.0f/(FrameX/BlockSize),0.0f,0.0f,1.0f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

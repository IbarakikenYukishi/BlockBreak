using UnityEngine;
using System.Collections;

public class MainGameController : MonoBehaviour {
	public GameObject blockprefab;
	public float colr=0f,colg=0f,colb=0f;
	public const float FrameX=500.0f;//フレームのXの幅
	public const float FrameY=912.0f;//フレームのYの幅
	public const float BlockSize=8.0f;//ブロックの大きさ
	public const float RawBlockSize=64.0f;//ブロックのスプライトの生の大きさ
	public const int SizeY=20;
	// Use this for initialization
	void Start () {
		//プレファブ登録
		blockprefab=Resources.Load("Prefabs/block")as GameObject;
		ArrangeMent();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ArrangeMent(){
		//(FrameX/BlockSize)*SizeYのブロックを生成
		for(int j=0;j<SizeY;j++)for(int i=2;i<FrameX/BlockSize-2;i++){
			GameObject temporaryblock;
			Vector2 position;
//			if(j<SizeY/2){
				position=new Vector2(-FrameX/2.0f+BlockSize*(float)i+BlockSize/2.0f,+FrameY/2.0f-((float)j*2.5f+1.0f)*BlockSize)/100.0f;
				position=new Vector2(-FrameX/2.0f+BlockSize*(float)i+BlockSize/2.0f,+FrameY/2.0f-(float)j*2.5f*BlockSize)/100.0f;
//			}else {
//				position=new Vector2(-FrameX/2.0f+BlockSize*(float)i+BlockSize/2.0f,+FrameY/2.0f-( ( (float)j-(float)SizeY/2.0f ) * BlockSize+(float)SizeY/2.0f*BlockSize)/100.0f;
//			}
			temporaryblock=Instantiate(blockprefab,position,Quaternion.identity)as GameObject;
			//大きさ調節
			temporaryblock.transform.localScale=new Vector3(BlockSize/RawBlockSize,BlockSize/RawBlockSize,1);
			//色変更
			HsvToRgb(180.0f*((float)j/(float)SizeY)+180.0f*((float)i/(FrameX/BlockSize)));
//			temporaryblock.GetComponent<SpriteRenderer>().color=new Color((float)i*1.0f/(FrameX/BlockSize),0.0f,0.0f,1.0f);
			temporaryblock.GetComponent<SpriteRenderer>().color=new Color(colr,colg,colb,1.0f);
		}		
	}
	void HsvToRgb(float H){
		int Hi=(int)H/60;
		float V=255.0f/255.0f;
		float F=H/60.0f-(float)Hi;
		float M=0.0f;
		float N=255.0f*(1.0f-F)/255.0f;
		float K=255.0f*F/255.0f;
		if(Hi==0){
			colr=V;
			colg=K;
			colb=M;
		}
		if(Hi==1){
			colr=N;
			colg=V;
			colb=M;
		}
		if(Hi==2){
			colr=M;
			colg=V;
			colb=K;
		}
		if(Hi==3){
			colr=M;
			colg=N;
			colb=V;
		}
		if(Hi==4){
			colr=K;
			colg=M;
			colb=V;
		}
		if(Hi==5){
			colr=V;
			colg=M;
			colb=N;
		}
	}

}

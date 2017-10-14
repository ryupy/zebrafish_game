using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : Token {


	public GameObject Ebi; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// エビがいる場合
//		if (Ebi.Count > 0) {
			// "Ebi"と"Fish2"の距離をdisに返す
//			GameObject prefab = (GameObject)Resources.Load ("Prefabs/Ebi");
			Vector2 Ebipos = Ebi.transform.position;
			Vector2 Fish2pos = this.transform.position;
			float dis = Vector2.Distance (Ebipos, Fish2pos);
			Debug.Log ("Distance : " + dis);


			// 条件よりも近かった場合、餌の方へ魚が泳ぐ
			if (dis <= 2f) {
				float dir = Random.Range (0, 359);
				float spd = 10f;
				SetVelocity (dir, spd);
			} 
//		}
	}
}

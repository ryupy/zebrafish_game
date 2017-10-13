using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : Token {


	public GameObject Ebi;
	public GameObject Fish2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// "Ebi"と"Fish2"の距離をdisに返す
		Vector3 Ebipos = Ebi.transform.position;
		Vector3 Fish2pos = Fish2.transform.position;
		float dis = Vector3.Distance (Ebipos, Fish2pos);

		// 条件よりも近かった場合、餌の方へ魚が泳ぐ
		if (dis < 5f) {
			var direction = Ebipos - Fish2pos;
//			floar dir = var direction;
			float speed = 7f;
			Rigidbody.velocity = direction, Speed;

//			SetVelocity (dir, spd);
		} else {
			
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Token {

	// Use this for initialization
	void Start () {

		// サイズを設定
		SetSize (SpriteWidth / 2, SpriteHeight / 2);

		// ランダムな方向に移動する
		// 方向をランダムに決める
		float dir = Random.Range(0, 359);
		float spd = 10;
		SetVelocity (dir, spd);
	}
	
	// Update is called once per frame
	void Update () {
		// カメラの左下座標を取得
		Vector2 min = GetWorldMin ();
		// カメラの右上座標を取得
		Vector2 max = GetWorldMax ();

		if (X < min.x || max.x < X) {
			// 画面外に出たので、X移動量を反転する
			VX *= -1;
			// 画面内に移動する
			ClampScreen ();
		}

		if (Y < min.y || max.y < Y) {
			VY *= -1;
			ClampScreen ();
		}
	}

	public void OnMouseDown(){
		float dir = Random.Range (0, 359);
		float spd = 5;
		SetVelocity(dir, spd);
	}

	
}

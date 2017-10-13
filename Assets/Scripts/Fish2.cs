using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish2 : Token {
	
	// Use this for initialization
	void Start () {

		// サイズを設定
		SetSize (SpriteWidth / 2, SpriteHeight / 2);

		// ランダムな方向に移動する
		// 方向をランダムに決める
		float dir = Random.Range(0, 359);
		float spd = 2;
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

		// 魚を進行方向へ向かせる
		Vector3 scale = transform.localScale;
		if (VX >= 0) {
			scale.x = -1;
		} 
		else {
			scale.x = 1;
		}
		transform.localScale = scale;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish2 : Token {
	
	// Use this for initialization
	void Start () {
		// サイズを設定
		SetSize (SpriteWidth / 2, SpriteHeight / 2);
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
		// Vector3でscaleを取得し、VX(移動量)の向きで場合分け
		Vector3 scale = transform.localScale;
		if (VX > 0) {
			scale.x = -1;
		} else if (VX < 0) {
			scale.x = 1;
		} else {
		}
		// scaleを代入する
		transform.localScale = scale;

		// 魚を減速させる
		VX *= 0.9f;
		VY *= 0.9f;


		// 止まった場合、魚を動かす
		if (VX == 0) {
			// ランダムな方向に移動する
			// 方向をランダムに決める
			float dir = Random.Range (0, 359);
			float spd = Random.Range (0, 10);
			SetVelocity (dir, spd);
		}

	}
}

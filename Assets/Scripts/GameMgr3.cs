using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr3 : MonoBehaviour {

	public GameObject Fish2;
	public GameObject Ebi;
	void OnGUI () {
		if (goalcircle.goal == 0) {
			if (Timer.countTime == 0) {
				Fish2 = GameObject.Find ("Fish2");
				Destroy (Fish2);
				Ebi = GameObject.Find ("Ebi");
				Destroy (Ebi);


				// フォントサイズ
				Util.SetFontSize (32);
				// 中央揃え
				Util.SetFontAlignment (TextAnchor.MiddleCenter);

				// フォントの位置
				float w = 128; // 幅
				float h = 32; // 高さ
				float px = Screen.width / 2 - w / 2;
				float py = Screen.height / 2 - h / 2;

				// フォント描画
				Util.GUILabel (px, py, w, h, "Game Over");



				// ボタンは少し下にずらす
				py += 60;
				if (GUI.Button (new Rect (px, py, w, h), "Back to Title")) {
					// タイトルに戻る
					Application.LoadLevel ("Title");
				}
			}
		} 
		else if (goalcircle.goal == 1) {
			Fish2 = GameObject.Find ("Fish2");
			Destroy (Fish2);
			Ebi = GameObject.Find ("Ebi");
			Destroy (Ebi);

			// フォントサイズ
			Util.SetFontSize (32);
			// 中央揃え
			Util.SetFontAlignment (TextAnchor.MiddleCenter);

			// フォントの位置
			float w = 128; // 幅
			float h = 32; // 高さ
			float px = Screen.width / 2 - w / 2;
			float py = Screen.height / 2 - h / 2;

			// フォント描画
			Util.GUILabel (px, py, w, h, "Game Clear! \n Congraturation!!!");



			// ボタンは少し下にずらす
			py += 60;
			if (GUI.Button (new Rect (px, py, w, h), "Back to Title")) {
				// タイトルに戻る
				Application.LoadLevel ("Title");
			}
		}
	}
}

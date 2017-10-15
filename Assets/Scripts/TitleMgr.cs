﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMgr : MonoBehaviour {
	void OnGUI()
	{
		// フォントサイズ
		Util.SetFontSize(32);
		// 中央揃え
		Util.SetFontAlignment(TextAnchor.MiddleCenter);

		// フォントの位置
		float w = 128; // 幅
		float h = 32; // 高さ
		float px = Screen.width / 2 - w / 2;
		float py = Screen.height / 2 - h / 2;

		// フォント描画
		Util.GUILabel(px, py, w, h, "Fish in the Labyrinth");

		Util.SetFontSize (20);
		py += 60;
		Util.GUILabel (px, py, w, h, "Prodeced by RD, KN");


		// ボタンは少し下にずらす
		py += 60;
		if (GUI.Button(new Rect(px, py, w, h), "START"))
		{
			// メインゲーム開始
			Application.LoadLevel("Main2");
		}
	}

}

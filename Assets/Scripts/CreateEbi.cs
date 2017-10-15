using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEbi : Timer{

	// エビの数の入れ物
	public int ebinumber;

	// エビの数を表示するテキストの名前
	public Text Ebinumbertext;

	// 生成したいPrefab。アタッチをする時は入れる
	public GameObject Ebi;

	// クリックした座標
	private Vector3 clickPosition;

	// Use this for initialization
	void Start () {
		// 最初のエビの数
		Ebinumbertext.text = "Ebi x " + ebinumber;
	}

	// Update is called once per frame
	void Update () {
		countTime -= Time.deltaTime;
		if (countTime > 0) {
			if (goalcircle.goal == 0) {
				// 左クリックをした瞬間,0は左クリック
				if (Input.GetMouseButtonDown (0)) {
					if (ebinumber == 0) {
						return;
					} else {
						clickPosition = Input.mousePosition;
						clickPosition.z = 10f;

						// 一度、"ebi"というなまえにして、"Ebi"に戻すことでcloneを消している
						GameObject ebi = Instantiate (Ebi, Camera.main.ScreenToWorldPoint (clickPosition), new Quaternion ()) as GameObject;
						ebi.name = "Ebi";

						// エビの数を減らす
						ebinumber -= 1;

						// 減ったあとの数を表示する
						Ebinumbertext.text = "Ebi x " + ebinumber;
					}
				}
			}
		}
	}
}

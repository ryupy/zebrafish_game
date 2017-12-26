using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEbi : MonoBehaviour{

	// エビの数の入れ物
	public int ebinumber;

	// エビの数を表示するテキストの名前
	public Text Ebinumbertext;

	// 生成したいPrefab。アタッチをする時は入れる
	public GameObject Ebi;

	// Use this for initialization
	void Start () {
		// 最初のエビの数
		Ebinumbertext.text = "Ebi x " + ebinumber;
	}

	// Update is called once per frame
	void Update () {
		if (Timer.countTime > 0) {
			if (goalcircle.goal == 0) {
				// 左クリックをした瞬間,0は左クリック
				if (Input.GetMouseButtonDown (0)) {
					if (ebinumber == 0) {
						return;
					} else {
						Camera camera = Camera.main;
						Vector2 clickPosition = camera.ScreenToWorldPoint(Input.mousePosition);

						// 一度、"ebi"というなまえにして、"Ebi"に戻すことでcloneを消している
						GameObject ebi = Instantiate (Ebi, clickPosition, Quaternion.identity); //as GameObject;
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

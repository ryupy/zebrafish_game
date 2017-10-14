using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEbi : Token {
	
	// 生成したいPrefab。アタッチをする時は入れる
	public GameObject Ebi;

	// クリックした座標
	private Vector3 clickPosition;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
		// 左クリックをした瞬間,0は左クリック
		if (Input.GetMouseButtonDown (0)) {

			clickPosition = Input.mousePosition;
			clickPosition.z = 10f;

			// アタッチをする場合
			// こちらでもうまくいくが、名前からcloneを消去する処理が分からなかった
//			GameObject.Instantiate(Ebi, Camera.main.ScreenToWorldPoint(clickPosition), new Quaternion());

			// 一度、"ebi"というなまえにして、"Ebi"に戻すことでcloneを消している
			GameObject ebi = Instantiate(Ebi, Camera.main.ScreenToWorldPoint(clickPosition), new Quaternion()) as GameObject;
			ebi.name = "Ebi";

			// インスタンスIDを取得する
//			int number = GetInstanceID();
//			ebi.name =  "Ebi" + number;


			// 名前からcloneを消す。"ebi"から"Ebi"に変更.番号をつける
//			int number = Random.Range (0, 1000);
//			ebi.name = "Ebi" + number;

			// アタッチをしない場合
			// prefabを取得
//			GameObject prefab = (GameObject)Resources.Load ("Prefabs/Ebi");
//			Instantiate (prefab, Camera.main.ScreenToWorldPoint (clickPosition), new Quaternion ());
		}
	}
}

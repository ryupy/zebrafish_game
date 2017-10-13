using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEbi : MonoBehaviour {
	
	// 生成したいPrefab
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

			// こちらでもうまくいくが、名前からcloneを消去する処理が分からなかった
//			GameObject.Instantiate(Ebi, Camera.main.ScreenToWorldPoint(clickPosition), new Quaternion());

			// 一度、"ebi"というなまえにする
			GameObject ebi = Instantiate(Ebi, Camera.main.ScreenToWorldPoint(clickPosition), new Quaternion()) as GameObject;

			// 名前からcloneを消す。"ebi"から"Ebi"に変更
			ebi.name = "Ebi";


		}
	}
}

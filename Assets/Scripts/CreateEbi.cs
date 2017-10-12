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

			GameObject.Instantiate(Ebi, Camera.main.ScreenToWorldPoint(clickPosition), new Quaternion());
		}
	}
}

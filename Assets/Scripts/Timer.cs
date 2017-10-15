using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : goalcircle {

	public float countTime = 10;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = countTime.ToString ("F1");
	}
	
	// Update is called once per frame
	void Update () {
		countTime -= Time.deltaTime;
		if (countTime < 0) {
			countTime = 0;
		} 
		GetComponent<Text> ().text = countTime.ToString ("F1");
	}
}

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static float countTime;

	// Use this for initialization
	void Start () {
		countTime = 10;
		GetComponent<Text> ().text = countTime.ToString ("F1");
	}
	
	// Update is called once per frame
	void Update () {
		if (goalcircle.goal == 0) {
			countTime -= Time.deltaTime;
			if (countTime < 0) {
				countTime = 0;
			} 
			GetComponent<Text> ().text = countTime.ToString ("F1");
		}
		else if (goalcircle.goal == 1) {
			float clearTime = countTime;
			GetComponent<Text> ().text = clearTime.ToString ("F1");
		}
	}
}

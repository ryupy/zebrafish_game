using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private float time = 20;

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = time.ToString ("F1");
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time < 0) {
			time = 0;
		}
		GetComponent<Text> ().text = time.ToString ("F1");
	}
}

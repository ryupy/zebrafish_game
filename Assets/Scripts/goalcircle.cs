using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalcircle : Token {

	public static int goal;

	void Start () {
		goal = 0;
	}


	void OnTriggerEnter2D (Collider2D collision) {
		if (collision.tag == "Player1") {
			goal += 1;
		} else {
			goal += 0;
		}
	}
}

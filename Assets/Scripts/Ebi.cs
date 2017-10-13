using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ebi : Token {

	// Use this for initialization
	void Start () {
		SetSize (SpriteWidth / 2, SpriteHeight / 2);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 min = GetWorldMin ();
		Vector2 max = GetWorldMax ();
		if (X < min.x || max.x < X) {
			VX *= -0.1f;
			ClampScreen ();
		}
		if (Y < min.y || max.y < Y) {
			VY *= -0.1f;
			ClampScreen ();
		}
	}

	void OnTriggerEnter2D(Collider2D c){
		DestroyObj();
	}
}

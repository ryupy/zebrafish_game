using UnityEngine;

//Rigidbody2DとSpriteRenderのアタッチが必要
[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class Ebi : Actor {

	private Rigidbody2D m_Rigidbody;
	private SpriteRenderer m_Render;

	private void Awake(){
		this.m_Rigidbody = GetComponent<Rigidbody2D> ();
		this.m_Render = GetComponent<SpriteRenderer> ();
	}

	private void FixedUpdate(){
		EnsureInScreen (m_Rigidbody, m_Render.bounds.size);
	}

	// 魚と触れたとき
	void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Player1"){
			// 消える
			Destroy(gameObject);
		}
	}
}

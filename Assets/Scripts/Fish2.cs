using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(SpriteRenderer))]
public class Fish2 : Actor {

	private Rigidbody2D m_Rigidbody;
	private SpriteRenderer m_Render;

	private void Awake(){
		this.m_Rigidbody = GetComponent<Rigidbody2D> ();
		this.m_Render = GetComponent<SpriteRenderer> ();
	}

	private void FixedUpdate(){
		EnsureInScreen (m_Rigidbody, m_Render.bounds.size);
		MoveToEbi ();
		UpdateVelocity ();
	}


	// Update is called once per frame
	void Update () {
		UpdateImageDirection ();
		}

	private void MoveToEbi(){
		
		Ebi[] ebilist = FindObjectsOfType<Ebi>(); 
		Ebi nearest = null;
		float minDistance = System.Single.PositiveInfinity;
		foreach (Ebi ebi in ebilist) {
			
			Vector2 ebiPos = ebi.transform.position;
			Vector2 fish2Pos = this.transform.position;
			float distance = Vector2.Distance (ebiPos, fish2Pos);
			Debug.Log ("Distance : " + distance);

			if (distance < minDistance) {
				nearest = ebi;
				minDistance = distance;
			}
		}

		if (minDistance < 8.0f) {
			Vector2 ebiPos = nearest.transform.position;
			Vector2 fish2Pos = this.transform.position;
			Vector2 direction = (ebiPos - fish2Pos).normalized;

			m_Rigidbody.AddForce (direction * 20.0f);
		}
	}

	void UpdateVelocity(){
		m_Rigidbody.velocity *= 0.9f;

		if (Mathf.Approximately (m_Rigidbody.velocity.x, 0.0f)) {
			float angle = Mathf.PI * 2.0f * Random.value;
			Vector2 direction = new Vector2 (Mathf.Cos (angle), Mathf.Sin (angle));
			float speed = 10.0f * Random.value;

			m_Rigidbody.velocity = direction * speed;
		}
	}

	void UpdateImageDirection(){
		float vx = m_Rigidbody.velocity.x;
		if (!Mathf.Approximately (vx, 0.0f)) {
			if (vx < 0.0f) {
				m_Render.flipX = true;
			} else {
				m_Render.flipX = false;
			}
		}
	}

}

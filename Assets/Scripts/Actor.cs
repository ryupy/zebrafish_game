using UnityEngine;

public class Actor : MonoBehaviour {

	protected void EnsureInScreen(Rigidbody2D rigidbody, Vector2 size){
		Camera camera = Camera.main;
		if (camera) {
			Vector2 screenMin = camera.ViewportToWorldPoint (Vector2.zero);
			Vector2 screenMax = camera.ViewportToWorldPoint (Vector2.one);

			Vector2 halfSize = size * 0.5f;
			Vector2 min = screenMin + halfSize;
			Vector2 max = screenMax - halfSize;

			Vector2 position = rigidbody.position;
			Vector2 velocity = rigidbody.velocity;

			if (position.x < min.x) {
				position.x = min.x;
				velocity.x = Mathf.Abs (velocity.x);
			} else if (position.x > max.x) {
				position.x = max.x;
				velocity.x = -Mathf.Abs (velocity.x);
			}

			if (position.y < min.y) {
				position.y = min.y;
				velocity.y = Mathf.Abs (velocity.y);
			} else if (position.y > max.y) {
				position.y = max.y;
				velocity.y = -Mathf.Abs (velocity.y);
			}

			rigidbody.position = position;
			rigidbody.velocity = velocity;
		}
	}
}

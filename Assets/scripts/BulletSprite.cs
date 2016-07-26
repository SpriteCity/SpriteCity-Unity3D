using UnityEngine;
using System.Collections;

public class BulletSprite : Moveable
{
	public void Initialize(Vector3 startPosition, Vector2 direction, float speed) {
		gameObject.transform.position = startPosition;

		Rigidbody2D rigidbody2D = gameObject.GetComponent<Rigidbody2D> ();
		rigidbody2D.velocity = direction * speed;
	}

	new void OnCollisionEnter2D(Collision2D collision2D) {
		Moveable moveable = collision2D.collider.GetComponent<Moveable> ();
		bool isMoveable = (moveable != null);

		WallSprite wall = collision2D.collider.GetComponent<WallSprite> ();
		bool isWall = (wall != null);

		if (isWall) 
		{
			Destroy (gameObject);
		}
		else if (isMoveable) 
		{
			moveable.health = moveable.health - 1;
			health = health - 1;
		}

		base.OnCollisionEnter2D (collision2D);
	}
}
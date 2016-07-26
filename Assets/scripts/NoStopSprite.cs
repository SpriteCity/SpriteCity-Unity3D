using UnityEngine;
using System.Collections;

public class NoStopSprite : Moveable
{
	public int speed = 1;

	Vector2 previousDirection;

	// FixedUpdate should be used instead of Update when dealing with Rigidbody
	new void FixedUpdate()
	{
		Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		if (direction == Vector2.zero) {
			direction = previousDirection;
		} else {
			previousDirection = direction;
		}

		direction.Normalize ();

		Vector2 velocity = direction * speed;

		GetComponent<Rigidbody2D> ().velocity = velocity;

		base.FixedUpdate ();
	}
}

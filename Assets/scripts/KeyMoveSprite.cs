using UnityEngine;
using System.Collections;

public class KeyMoveSprite : Moveable
{
    public int speed = 10;

	// FixedUpdate should be used instead of Update when dealing with Rigidbody
    new void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

		GetComponent<Rigidbody2D>().velocity = direction * speed;

		base.FixedUpdate ();
    }
}

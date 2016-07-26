using UnityEngine;
using System.Collections;

public class WallSprite : Moveable
{
	new void OnCollisionEnter2D(Collision2D collision2D) {
		base.OnCollisionEnter2D(collision2D);
	}
}
using UnityEngine;
using System.Collections;

public class ItemSprite : Moveable
{
	public int healthIncrease = 1;
	public int sizeIncrease = 2;
	
	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		int test = 0;
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		KeyMoveSprite keyMoveSprite = collision2D.collider.GetComponent<KeyMoveSprite> ();

		if (keyMoveSprite != null) 
		{			
			keyMoveSprite.health += healthIncrease;
		}

		ComputerSprite computerSprite = collision2D.collider.GetComponent<ComputerSprite> ();
		
		if (computerSprite != null) 
		{			
			computerSprite.transform.localScale *= 2;
		}
		
		Destroy(gameObject);
	}
}

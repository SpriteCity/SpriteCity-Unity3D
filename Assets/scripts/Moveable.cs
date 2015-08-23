using UnityEngine;
using System.Collections;

public class Moveable : MonoBehaviour
{
	public int health = 1;

	//Whats called when a drawable is created
	public Moveable()
	{

	}
	
	// Use this for initialization
	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		//This doesn't work for some reason :(
		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}

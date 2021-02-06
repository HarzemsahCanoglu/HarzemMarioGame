using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour
{

	private void OnCollisionEnter2D(Collision2D collision)
	{
		
		if (collision.gameObject.tag == "Water")
		{
			Debug.Log("We hit Water! And the tag of the water is: " + collision.gameObject.tag);

			// Kill player
			Destroy(gameObject);

		}
	}
}
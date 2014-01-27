using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour 
{
	public Light playerLight;

	public AudioClip candyEatingSound;
	public AudioClip roofieEatingSound;

	private Candy c;

	private void OnTriggerEnter(Collider collider) 
	{
		if(collider.gameObject.tag=="Candy")
		{ 
			c = collider.gameObject.GetComponent<Candy>();
			audio.Stop();


			if(c.getRoofie())
			{
				audio.PlayOneShot(candyEatingSound);
				if(playerLight.range < 10)
					playerLight.range = playerLight.range + 1.6f;
				if(playerLight.intensity < 1.7)
					playerLight.intensity = playerLight.intensity + 0.4f;
			}
			else
			{
				audio.PlayOneShot(roofieEatingSound);
				if(playerLight.range > 2)
					playerLight.range = playerLight.range - 1.6f;
				if(playerLight.intensity > 0.1)
					playerLight.intensity = playerLight.intensity - 0.38f;
			}
		}
		else if(collider.gameObject.tag=="Finish")
		{
			Application.LoadLevel(2);
		}
		else if(collider.gameObject.tag=="Enemy")
		{
			Application.LoadLevel(3);
		}

		Destroy(collider.gameObject);
 	}
}

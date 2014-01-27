using UnityEngine;
using System.Collections;

public class ReturnMenuButton : MonoBehaviour {

	
	public AudioClip treasurePick;

	void Start()
	{
		audio.PlayOneShot(treasurePick);
	}

	void OnMouseEnter()
	{
		renderer.material.color = Color.green;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}
	
	void OnMouseUp()
	{
		Application.LoadLevel(0);
	}
}

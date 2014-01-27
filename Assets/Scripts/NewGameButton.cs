using UnityEngine;
using System.Collections;

public class NewGameButton : MonoBehaviour {
	
	public bool isQuitButton = false;
	
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
		if(isQuitButton)
		{
			Application.Quit();
		}
		else
		{
			Application.LoadLevel(1);
		}
	}
}

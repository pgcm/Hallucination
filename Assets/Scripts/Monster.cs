using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	private bool rising;
	private double maxHeight = 1.5;
	private double minHeight = -0.5;

	void Start()
	{
		rising = false;
	}

	void Update () 
	{
		if(rising)
		{
			if(transform.position.y < maxHeight)
			{
				transform.Translate(0,3*Time.deltaTime,0);
			}
			else
			{
				rising = false;
			}
		}
		else
		{
			if(transform.position.y > minHeight)
			{
				transform.Translate(0,-3*Time.deltaTime,0);
			}
			else
			{
				rising = true;
			}
		}
	}
}

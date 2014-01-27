using UnityEngine;
using System.Collections;

public class MovementControl : MonoBehaviour 
{

	void Update () 
	{

		if (Input.GetKey(KeyCode.W))
		{
			transform.root.Translate(new Vector3 (0,1*Time.deltaTime,0));
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.root.Translate(new Vector3 (0,-1*Time.deltaTime,0));
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.root.Translate(new Vector3 (1*Time.deltaTime,0,0));

		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.root.Translate(new Vector3 (-1*Time.deltaTime,0,0));
		}
	}
}

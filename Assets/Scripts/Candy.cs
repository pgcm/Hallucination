using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {

	private bool isRoofie;

	public bool getRoofie()
	{
		return isRoofie;
	}

	void Start ()
	{
		if(UnityEngine.Random.Range(0,2) == 0)
			isRoofie = false;
		else
			isRoofie = true;
	}

	void Update () 
	{
		transform.Rotate( new Vector3 (1,1,1));
	}
}

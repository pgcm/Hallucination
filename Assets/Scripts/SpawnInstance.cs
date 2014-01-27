using UnityEngine;
using System.Collections;

public class SpawnInstance : MonoBehaviour {

	public Transform brick;

	// Use this for initialization
	void Start ()
	{
		Instantiate(brick, new Vector3(0, 0, 0), Quaternion.identity);
	}
}

using UnityEngine;
using System.Collections;

public class CameraSizeSetter : MonoBehaviour {

	void Start () 
	{
		Camera.main.orthographic = true;
		Camera.main.orthographicSize = 5;
		camera.orthographic = true;
		camera.orthographicSize = 5;
	}
}

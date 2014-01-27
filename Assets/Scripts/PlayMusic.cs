using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	public AudioClip gameMusic;

	void Start()
	{
		audio.loop = true;
		audio.clip = gameMusic;
		audio.Play();
	}
}

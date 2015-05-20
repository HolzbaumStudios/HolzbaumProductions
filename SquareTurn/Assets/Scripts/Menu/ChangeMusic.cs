using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip selectlevelmusic;

	private AudioSource source;


	// Use this for initialization
	void Awake () 
	{
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded(int scene) 
	{
		if (scene == 2) 
		{
			source.clip = selectlevelmusic;
			source.Play();
		}
	}
}

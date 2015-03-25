using UnityEngine;
using System.Collections;

public class DontDestroyMusic : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

}

﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public void LoadScene(int scene)
	{
        SceneManager.LoadScene(scene);
	}

}

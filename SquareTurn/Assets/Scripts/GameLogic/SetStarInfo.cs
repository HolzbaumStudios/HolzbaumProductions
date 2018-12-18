﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class SetStarInfo : MonoBehaviour {

	public GameObject starInfoBoxPortrait;

	public GameObject threeStarInfoPortrait;
	public GameObject twoStarInfoPortrait;

	// Use this for initialization
	void Start () {

		GameObject userStatistics = GameObject.Find ("UserStatistics");
		int twoStarValue;
		int threeStarValue;

		starInfoBoxPortrait.SetActive(true);

		userStatistics.GetComponent<TreeTable>().GetValuesPro();

		twoStarValue = userStatistics.GetComponent<TreeTable>().twoTrees + 1;
		threeStarValue = userStatistics.GetComponent<TreeTable>().threeTrees + 1;

		string textValue = "<" + twoStarValue.ToString ();
		twoStarInfoPortrait.GetComponent<TextMeshProUGUI>().text = textValue;

		textValue = "<" + threeStarValue.ToString ();
		threeStarInfoPortrait.GetComponent<TextMeshProUGUI>().text = textValue;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public GameObject categoryChoice;
	public GameObject category1;
	public GameObject category2;
	public GameObject category3;
	public GameObject category4;
	public GameObject categorySlider;


	void Start()
	{
		//If the players returns from the level, the correct category should open automatically
		int activeCategory = PlayerPrefs.GetInt ("ActiveCategory");
		if (activeCategory > 0) {
			ChooseCategory (activeCategory);
		}

	/*
		//Set the position of the category slider to the last known position
		int posCategory1 = PlayerPrefs.GetInt ("PosCategory1");
		int posCategory2 = PlayerPrefs.GetInt ("PosCategory2");
		int posCategory3 = PlayerPrefs.GetInt ("PosCategory3");


		if(posCategory1 != 0)
		{
			category1.transform.localPosition = new Vector2 (posCategory1,0);
		}
		if(posCategory2 != 0)
		{
			category2.transform.localPosition = new Vector2 (posCategory2,0);
		}
		if(posCategory3 != 0)
		{
			category3.transform.localPosition = new Vector2 (posCategory3,0);
		}
*/

		float sliderPosition = PlayerPrefs.GetFloat ("SliderPosition");
		categorySlider.GetComponent<Scrollbar> ().value = sliderPosition;

	}

	public IEnumerator StartLevel(){
		yield return new WaitForSeconds(0.1f);
		Application.LoadLevel ("gameScene");
	}

	public void GoBackToMenu(){
		GameObject.Find("UserStatistics").SendMessage ("StoreStatistics");
		Application.LoadLevel ("levelMenu");
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Log ("Pressed");
			if(Application.loadedLevelName == "levelMenu")
			{
				if(categoryChoice.activeSelf)
				{
					Application.LoadLevel("startMenu");
				}
				else
				{
					//Disable the slider
					categorySlider.SetActive(false);

					//Disable the active Category
					if(category1.activeSelf) category1.SetActive(false);
					else if(category2.activeSelf) category2.SetActive(false);
					else if(category3.activeSelf) category3.SetActive(false);
					else if(category4.activeSelf) category4.SetActive(false);

					//Enable category Choice
					categoryChoice.SetActive (true);

				}

			}
			else
			{
				Application.LoadLevel("startMenu");
			}
		}
	}


	//Enable the container for the chosen category
	public void ChooseCategory(int categoryNumber)
	{
		//Disable the categoryChoice
		if(categoryChoice)categoryChoice.SetActive (false);

		//Get levelChoice component
		GameObject levelChoice = GameObject.Find ("LevelChoice").gameObject;

		//Debug.Log (categoryNumber);
		//Set the scrollrect to the correct category
		switch(categoryNumber)
		{
		case 1: category1.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category1.GetComponent<RectTransform>();PlayerPrefs.SetInt ("ActiveCategory", 1); break;
		case 2: category2.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category2.GetComponent<RectTransform>();PlayerPrefs.SetInt ("ActiveCategory", 2); break;
		case 3: category3.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category3.GetComponent<RectTransform>();PlayerPrefs.SetInt ("ActiveCategory", 3); break;
		}

		//Enable the scrollbar;
		categorySlider.SetActive (true);

	}

	//This function saves the current position of the category window, when a level is loaded.
	//The function is accessed by the script ChooseLevelScript.cs
	public void SaveCategoryPosition()
	{
		/*
		PlayerPrefs.SetInt ("PosCategory1", (int)category1.transform.position.x);
		PlayerPrefs.SetInt ("PosCategory2", (int)category2.transform.position.x);
		PlayerPrefs.SetInt ("PosCategory3", (int)category3.transform.position.x);
		*/
		float sliderPosition = categorySlider.GetComponent<Scrollbar> ().value;
		PlayerPrefs.SetFloat ("SliderPosition", sliderPosition);
	}

}

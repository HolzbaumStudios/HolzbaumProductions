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
		categoryChoice.SetActive (false);

		//Get levelChoice component
		GameObject levelChoice = GameObject.Find ("LevelChoice").gameObject;

		//Set the scrollrect to the correct category
		switch(categoryNumber)
		{
			case 1: category1.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category1.GetComponent<RectTransform>(); break;
			case 2: category2.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category2.GetComponent<RectTransform>(); break;
			case 3: category3.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category3.GetComponent<RectTransform>(); break;
			case 4: category4.SetActive(true); levelChoice.GetComponent<ScrollRect>().content = category4.GetComponent<RectTransform>(); break;
		}

		//Enable the scrollbar;
		categorySlider.SetActive (true);

	}

}

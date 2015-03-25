using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickToLoadAsync : MonoBehaviour {

	public Slider Slider_Loading;
	public GameObject Image_Loading;

	private AsyncOperation async;

	public void ClickAsync(int level)
	{
		Image_Loading.SetActive(true);
		StartCoroutine(LoadLevelWithBar(level));
	}

	IEnumerator LoadLevelWithBar (int level)
	{
		async = Application.LoadLevelAsync (level);
		while (!async.isDone) 
		{
			Slider_Loading.value = async.progress;
			yield return null;
		}
	}

}

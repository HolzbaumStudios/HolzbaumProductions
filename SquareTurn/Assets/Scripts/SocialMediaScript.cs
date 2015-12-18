using UnityEngine;
using System.Collections;

public class SocialMediaScript : MonoBehaviour {

	// open up the respective link to our social media platform
	public void OpenUrl(string url)
	{
		Application.OpenURL (url);
	}
}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class musicOnOff : MonoBehaviour {

	// Variablen
	private GameObject squareMusicButton;
	public bool status;
	public bool firststart;


	// Funktionen
	void Update(){
		if (SceneManager.GetActiveScene().name == "startMenu" && firststart == true && PlayerPrefs.GetString("gameMusic")!="Off") {
			this.GetComponent<AudioSource>().Play();
            firststart = false;
        
        
         
		}
	}
    /*
    void CheckFirstStart()
    {
        if (PlayerPrefs.GetInt("firstStart") != 1)
        {
            firststart = true;
            PlayerPrefs.SetInt("firstStart",1);
        }
        else
        {
            firststart = false;
        }
    }
    */
    

	public void TurnButton(GameObject musicButton)
	{
		squareMusicButton = musicButton;
        if (PlayerPrefs.GetString("gameMusic") != "Off")
        {
            status = true;
        }
        else
        {
            status = false;
        }
		if (status == true)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(131, 139, 139, 255);
			squareMusicButton.transform.Find ("DisabledButton").gameObject.SetActive (true);
			this.GetComponent<AudioSource>().Pause();
			status = false;
            PlayerPrefs.SetString("gameMusic","Off");
		}
		else if (status == false)
		{
			squareMusicButton.GetComponent<UnityEngine.UI.Image> ().color = new Color32(72, 120, 168, 255);
			squareMusicButton.transform.Find ("DisabledButton").gameObject.SetActive (false);
			this.GetComponent<AudioSource>().Play();
			status = true;
            PlayerPrefs.SetString("gameMusic", "On");
		}
	}
}

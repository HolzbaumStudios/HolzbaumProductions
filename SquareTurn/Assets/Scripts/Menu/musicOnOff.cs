using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class musicOnOff : MonoBehaviour {

	// Variablen
	private GameObject squareMusicButton;
	public bool status;
	public bool firststart;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "startMenu" && firststart == true && PlayerPrefs.GetString("gameMusic") != "Off")
        {
            this.GetComponent<AudioSource>().Play();
            firststart = false;
        }
    }

    public void TurnButton(GameObject musicButton)
    {
        squareMusicButton = musicButton;
        status = PlayerPrefs.GetString("gameMusic") != "Off";
        if (status)
        {
            squareMusicButton.GetComponent<UnityEngine.UI.Image>().color = new Color32(131, 139, 139, 255);
            squareMusicButton.transform.Find("DisabledButton").gameObject.SetActive(true);
            this.GetComponent<AudioSource>().Pause();
            status = false;
            PlayerPrefs.SetString("gameMusic", "Off");
        }
        else
        {
            squareMusicButton.GetComponent<UnityEngine.UI.Image>().color = new Color32(255, 255, 255, 255);
            squareMusicButton.transform.Find("DisabledButton").gameObject.SetActive(false);
            this.GetComponent<AudioSource>().Play();
            status = true;
            PlayerPrefs.SetString("gameMusic", "On");
        }
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public string LevelToLoad;


    // Use this for initialization
    public void loadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}

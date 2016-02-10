using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {

    // Use this for initialization
    private RectTransform objectRect;
    private float startPositionY;
    private float targetPositionY;
    private float timeParameter = 0;
    private float timeParameter2 = 0;
    private float speed = 0.7f;
    private bool goingDown = true;

    void Start () {
        objectRect = GetComponent<RectTransform>();
        startPositionY = objectRect.anchoredPosition.y;
        targetPositionY = startPositionY - objectRect.sizeDelta.y * 1.2f;
        StartCoroutine(WaitTime());
	}
	
	// Update is called once per frame
	void Update () {
        if (goingDown)
        {
            if (timeParameter < 1)
            {
                timeParameter += Time.deltaTime * speed;
                objectRect.anchoredPosition = new Vector2(0, Mathf.Lerp(startPositionY, targetPositionY, timeParameter));
            }
        }
        else
        {
            if (timeParameter2 < 1)
            {
                timeParameter2 += Time.deltaTime * speed;
                objectRect.anchoredPosition = new Vector2(0, Mathf.Lerp(targetPositionY, startPositionY, timeParameter2));
            }
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(4f);
        goingDown = false;
    }
}

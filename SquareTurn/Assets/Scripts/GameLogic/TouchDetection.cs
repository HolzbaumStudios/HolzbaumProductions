using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchDetection : MonoBehaviour, IPointerClickHandler {

    TurnScript turnScript;


	// Use this for initialization
	void Start () {
        try
        {
            turnScript = this.GetComponent<TurnScript>();
        } catch (Exception e)
        {
            Debug.LogError("Failed to get component <TurnScript>: " + e);
        }
	}

    #region IPointerClickHandler implementation
    public void OnPointerClick(PointerEventData eventData)
    {
        turnScript.StartSquareTurn();
    }
    #endregion
}

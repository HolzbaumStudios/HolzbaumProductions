using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOutline : MonoBehaviour {

	public void EnableOutlineComponent () {
        Component[] components = GetComponentsInChildren<Outline>();
        foreach(Outline outline in components)
        {
            outline.enabled = true;
        }
	}
}

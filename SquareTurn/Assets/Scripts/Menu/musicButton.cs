using UnityEngine;
using System.Collections;

public class musicButton : MonoBehaviour {

	// Find musicOnOff Script
	public void FindScript() {
		MusicManager.GetInstance().TurnButton(this.gameObject);
	}
}

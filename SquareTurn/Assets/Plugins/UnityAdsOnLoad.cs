﻿// UnityAdsOnLoad.cs - Written for Unity Ads Asset Store v1.0.4 (SDK 1.3.10)
	//  by Nikkolai Davenport <nikkolai@unity3d.com>
	//
	// A simple example for showing ads on load using the UnityAdsHelper script.
	
	using UnityEngine;
using System.Collections;

public class UnityAdsOnLoad : MonoBehaviour 
{
	public string zoneID = string.Empty;
	public float timeout = 15f;
	public bool disablePause;
	
	private float _startTime = 0f;
	private float _yieldTime = 1f;
	
	#if UNITY_IOS || UNITY_ANDROID
	// A return type of IEnumerator allows for the use of yield statements.
	//  For more info, see: http://docs.unity3d.com/ScriptReference/YieldInstruction.html
	IEnumerator Start ()
	{
		// Zone name used in debug messages.
		string zoneName = string.IsNullOrEmpty(zoneID) ? "the default ad placement zone" : zoneID;
		
		// Set a start time for the timeout.
		_startTime = Time.timeSinceLevelLoad;
		
		// Check to see if Unity Ads is initialized.
		//  If not, wait a second before trying again.
		while (!UnityAdsHelper.isInitialized)
		{
			if (Time.timeSinceLevelLoad - _startTime > timeout)
			{
				Debug.LogWarning("Unity Ads failed to initialize in a timely manner. Ad will not be shown on load.");
				
				// Break out of both this loop and the Start method; Unity Ads will not
				//  be shown on load since the wait time exceeded the time limit.
				yield break;
			}
			
			yield return new WaitForSeconds(_yieldTime);
		}
		
		Debug.Log("Unity Ads has finished initializing. Waiting for ads to be ready...");
		
		// Set a start time for the timeout.
		_startTime = Time.timeSinceLevelLoad;
		
		// Check to see if Unity Ads are available and ready to be shown. 
		//  If not, wait a second before trying again.
		while (!UnityAdsHelper.isReady(zoneID))
		{
			if (Time.timeSinceLevelLoad - _startTime > timeout)
			{
				Debug.LogWarning(string.Format("The process of showing ads on load for {0} has timed out. Ad was not shown.",zoneName));
				
				// Break out of both this loop and the Start method; Unity Ads will not
				//  be shown on load since the wait time exceeded the time limit.
				yield break;
			}
			
			yield return new WaitForSeconds(_yieldTime);
		}
		
		Debug.Log(string.Format("Ads for {0} are available and ready. Showing ad now...",zoneName));
		
		// Show ad after Unity Ads finishes initializing and ads are ready to show.
		UnityAdsHelper.ShowAd(zoneID,!disablePause);
	}
	#endif
}
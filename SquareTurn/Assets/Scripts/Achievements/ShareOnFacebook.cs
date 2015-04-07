using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Facebook;
using Facebook.MiniJSON;

public class ShareOnFacebook : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		FB.Init(SetInit, OnHideUnity);
	}

	public void ShareAchievement(){

		if (!FB.IsLoggedIn) {
			LoginToFacebook ();
		}

		FB.Feed(                                                                                                                 
	        linkCaption: "I just unlocked the Banana Achievement! Can you do it too?",               
	        picture: "http://www.friendsmash.com/images/logo_large.jpg",                                                     
	        linkName: "Checkout Squared!",                                                                 
	        link: "http://apps.facebook.com/" + FB.AppId + "/?challenge_brag=" + (FB.IsLoggedIn ? FB.UserId : "guest")       
        ); 
	}
	
	private void LoginToFacebook(){
		FB.Login("email,publish_actions", LoginCallback);
	}







	/// <summary>
	/// Facebook sdk relevant functions
	/// </summary>
	
	private void SetInit() {
		enabled = true; 
		// "enabled" is a magic global; this lets us wait for FB before we start rendering
	}
	
	private void OnHideUnity(bool isGameShown) {
		if (!isGameShown) {
			// pause the game - we will need to hide
			Time.timeScale = 0;
		} else {
			// start the game back up - we're getting focus again
			Time.timeScale = 1;
		}
	}

	void LoginCallback(FBResult result)                                                        
	{                                                                                          
		Util.Log("LoginCallback");                                                          
		
		if (FB.IsLoggedIn)                                                                     
		{                                                                                      
			OnLoggedIn();                                                                      
		}
	} 

	void OnLoggedIn()                                                                          
	{                                                                                          
		Util.Log("Logged in. ID: " + FB.UserId);                                            
	}  
	
	
}

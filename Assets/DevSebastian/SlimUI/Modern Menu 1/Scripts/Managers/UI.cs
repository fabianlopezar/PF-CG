using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

namespace SlimUI.ModernMenu{
	public class UI: MonoBehaviour {

		public enum Platform {Desktop, Mobile};
		public Platform platform;
		// toggle buttons
		

		[Header("VIDEO SETTINGS")]
		public GameObject fullscreentext;
		

		[Header("GAME SETTINGS")]
		public GameObject showhudtext;
		

		// sliders
		public GameObject musicSlider;
		public GameObject sensitivityXSlider;
		public GameObject sensitivityYSlider;
		public GameObject mouseSmoothSlider;

		private float sliderValue = 0.0f;
		private float sliderValueXSensitivity = 0.0f;
		private float sliderValueYSensitivity = 0.0f;
		private float sliderValueSmoothing = 0.0f;
		

		public void  Start (){
			
			// check slider values
			musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");
			sensitivityXSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("XSensitivity");
			sensitivityYSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("YSensitivity");
			mouseSmoothSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MouseSmoothing");

			// check full screen
			if(Screen.fullScreen == true){
				fullscreentext.GetComponent<TMP_Text>().text = "on";
			}
			else if(Screen.fullScreen == false){
				fullscreentext.GetComponent<TMP_Text>().text = "off";
			}

			// check hud value
			if(PlayerPrefs.GetInt("ShowHUD")==0){
				showhudtext.GetComponent<TMP_Text>().text = "off";
			}
			else{
				showhudtext.GetComponent<TMP_Text>().text = "on";
			}

			
		}

		public void Update (){
			//sliderValue = musicSlider.GetComponent<Slider>().value;
			sliderValueXSensitivity = sensitivityXSlider.GetComponent<Slider>().value;
			sliderValueYSensitivity = sensitivityYSlider.GetComponent<Slider>().value;
			sliderValueSmoothing = mouseSmoothSlider.GetComponent<Slider>().value;
		}

		public void FullScreen (){
			Screen.fullScreen = !Screen.fullScreen;

			if(Screen.fullScreen == true){
				fullscreentext.GetComponent<TMP_Text>().text = "on";
			}
			else if(Screen.fullScreen == false){
				fullscreentext.GetComponent<TMP_Text>().text = "off";
			}
		}

		public void MusicSlider (){
			//PlayerPrefs.SetFloat("MusicVolume", sliderValue);
			PlayerPrefs.SetFloat("MusicVolume", musicSlider.GetComponent<Slider>().value);
		}

		public void SensitivityXSlider (){
			PlayerPrefs.SetFloat("XSensitivity", sliderValueXSensitivity);
		}

		public void SensitivityYSlider (){
			PlayerPrefs.SetFloat("YSensitivity", sliderValueYSensitivity);
		}

		public void SensitivitySmoothing (){
			PlayerPrefs.SetFloat("MouseSmoothing", sliderValueSmoothing);
			Debug.Log(PlayerPrefs.GetFloat("MouseSmoothing"));
		}

		// the playerprefs variable that is checked to enable hud while in game
		public void ShowHUD (){
			if(PlayerPrefs.GetInt("ShowHUD")==0){
				PlayerPrefs.SetInt("ShowHUD",1);
				showhudtext.GetComponent<TMP_Text>().text = "on";
			}
			else if(PlayerPrefs.GetInt("ShowHUD")==1){
				PlayerPrefs.SetInt("ShowHUD",0);
				showhudtext.GetComponent<TMP_Text>().text = "off";
			}
		}

		
	}
}
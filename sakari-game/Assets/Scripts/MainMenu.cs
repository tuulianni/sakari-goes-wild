using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public string levelName;

	public AudioSource soundPlayer;

		public void playThisSound() {
			soundPlayer.Play();
		}

		public void LoadGame(string levelName)
		{
			//load the game scene

			SceneManager.LoadScene(levelName); //0 = Main Menu 1 = OverWorld
		}

}

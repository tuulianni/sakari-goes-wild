using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public int levelId;

	public AudioSource soundPlayer;

		public void playThisSound() {
			soundPlayer.Play();
		}

		public void LoadGame(int levelId)
		{
			//load the game scene

			SceneManager.LoadScene(levelId); //0 = Main Menu 1 = OverWorld
		}

}

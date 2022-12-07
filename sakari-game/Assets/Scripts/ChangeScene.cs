using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
		//change scene with scenename
		public string sceneName;
		public AudioSource hihi;

		public void testi() {

		}

		public void LoadGame(string sceneName)
		{
		
				hihi.Play();
				StartCoroutine(waiter(sceneName));
			 
		}

		
		IEnumerator waiter(string sceneName) {
			yield return new WaitForSeconds(0.3f);

			//load the game scene
			SceneManager.LoadScene(sceneName);
		}

	
		//change scene with gameObject.tag

		
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.gameObject.tag == "downstairs") {

				SceneManager.LoadScene("Labyrintti");
				
			} 
			else if(collision.gameObject.tag == "outdoor") {

				SceneManager.LoadScene("Overworld");
				
			} 

			else if(collision.gameObject.tag == "SakariHouse") {

				SceneManager.LoadScene("HouseSakari");
				
			} 
			else if(collision.gameObject.tag == "EkiHouse") {

				SceneManager.LoadScene("HouseEki");
				
			} 
			// else if(collision.gameObject.tag == "Rex") {

			// 	SceneManager.LoadScene("Rex");
				
			// } 
			else if(collision.gameObject.tag == "Finish") {

				GameManager.SweaterCounter();
				SceneManager.LoadScene("back-to-ow");
				
				
			}
		}
}

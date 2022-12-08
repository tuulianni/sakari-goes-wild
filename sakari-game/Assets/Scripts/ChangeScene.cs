using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class ChangeScene : MonoBehaviour
{
    //change scene with scenename
    public string sceneName;
    public AudioSource hihi1;
    public AudioSource hihi2;
    public AudioSource hihi3;
    private AudioSource[] _audioSources = new AudioSource[3];
    private readonly Random _gen = new();

    public void LoadGame(string sceneName)
    {    
        _audioSources[0] = hihi1;
        _audioSources[1] = hihi2;
        _audioSources[2] = hihi3;
        var hihiNumber = _gen.Next(0, 3);
        _audioSources[hihiNumber].Play();
        StartCoroutine(waiter(sceneName));
    }
		
		IEnumerator waiter(string sceneName) {
			yield return new WaitForSeconds(0.5f);

			//load the game scene
			SceneManager.LoadScene(sceneName);
		}

		public void Change(string sceneName) {
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

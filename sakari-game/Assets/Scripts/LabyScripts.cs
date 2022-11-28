using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LabyScripts : MonoBehaviour
{
		//koska tä on public niin sitä voi muokata unityssä
		//public float speed = 5.0f;

		public int score = 0;
		public int sweaters = 8;

		public TextMeshProUGUI keyAmount;
		public TextMeshProUGUI winner;

	
		public GameObject stairs;
		public GameObject info;

		public AudioSource EnemySound;
		public AudioSource SweaterSound;
		public AudioSource StairSound;

    // Start is called before the first frame update
    void Start()
    {
        info.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

				if (score == sweaters) {

					StairSound.Play();
					stairs.SetActive(true);
				}
				else {
					stairs.SetActive(false);
				}
    }

		public void CloseInfo() {
			info.SetActive(false);
		}

		public void OpenInfo() {
			info.SetActive(true);
		}

		//tämä on valmis luokka ja tätä tulee käyttää
		private void OnCollisionEnter2D(Collision2D collision) {
			
				//villapaita häviää kun siihen koskee
				//pisteet kasvaa kun siihen koskee
				if(collision.gameObject.tag == "sweaters") {

					Destroy(collision.gameObject);

					SweaterSound.Play();

					score++;

					//keyAmount = FindObjectOfType<TextMeshProUGUI>();
					if (score < sweaters) {
						keyAmount.text = "Pisteitä: " + score;
					}
					else {
						keyAmount.text = "Huh! Äkkiä turvaan ylös";
					}

				}

			if(collision.gameObject.tag == "stairs") {

				//winner = FindObjectOfType<TextMeshProUGUI>();
				//winner.text = "HIHI PELASTIT VILLAPAIDAT";
				GameManager.SweaterCounter();
				SceneManager.LoadScene("back-to-Sakarihouse");
				
			}

				//using UnityEngine.SceneManagement eli tuodaan tuollainen luokka, jossa on tämmöinen toiminto
				//palaa siis aina alkuun jos osuu viholliseen
				if(collision.gameObject.tag == "enemies") {

					EnemySound.Play();

					StartCoroutine(waiter());
					//SceneManager.LoadScene(SceneManager.GetActiveScene().name);				
					
				}

		}

		IEnumerator waiter() 
		{
			yield return new WaitForSeconds(0.5f);
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);				
		}

}

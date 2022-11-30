using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Start is called before the first frame update
    void Start()
    {
        info.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

				if (score == sweaters) {

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

					if(collision.gameObject.tag == "Dog") {

					Destroy(collision.gameObject);

					GameManager.SweaterCounter();
					}
			
				//lankarulla (sweaters siksi kun ennen oli villapaita) häviää kun siihen koskee
				//pisteet kasvaa kun siihen koskee
				if(collision.gameObject.tag == "sweaters") {

					Destroy(collision.gameObject);

					score++;

					//keyAmount = FindObjectOfType<TextMeshProUGUI>();
					if (score < sweaters) {
						keyAmount.text = "Rullia kerätty: " + score;
					}
					else {
						keyAmount.text = "Kaikki rullat kerätty!";
					}

				}

			if(collision.gameObject.tag == "stairs") {

				GameManager.SweaterCounter();
				SceneManager.LoadScene("back-to-Sakarihouse");
				
			}

				//using UnityEngine.SceneManagement eli tuodaan tuollainen luokka, jossa on tämmöinen toiminto
				//palaa siis aina alkuun jos osuu viholliseen
				if(collision.gameObject.tag == "enemies") {

					SceneManager.LoadScene(SceneManager.GetActiveScene().name);				
					
				}

		}

}

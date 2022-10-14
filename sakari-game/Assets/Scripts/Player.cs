using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
		//koska tä on public niin sitä voi muokata unityssä
		//public float speed = 5.0f;

		public int score = 0;
		public int sweaters = 8;

		public TextMeshProUGUI keyAmount;
		public TextMeshProUGUI winner;

	
		public GameObject stairs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
				//nuolinäppäimet
     /*   if(Input.GetKey(KeyCode.LeftArrow)) {
						
					transform.Translate(-speed * Time.deltaTime, 0, 0);

				}

				if(Input.GetKey(KeyCode.RightArrow)) {

					transform.Translate(speed * Time.deltaTime, 0, 0);
					
				}

				if(Input.GetKey(KeyCode.UpArrow)) {

					transform.Translate(0, speed * Time.deltaTime, 0);
					
				}

				if(Input.GetKey(KeyCode.DownArrow)) {

					transform.Translate(0, -speed * Time.deltaTime, 0);
					
				}*/

				if (score == sweaters) {

					stairs.SetActive(true);
				}
				else {
					stairs.SetActive(false);
				}
    }

		//tämä on valmis luokka ja tätä tulee käyttää
		private void OnCollisionEnter2D(Collision2D collision) {
			
				//villapaita häviää kun siihen koskee
				//pisteet kasvaa kun siihen koskee
				if(collision.gameObject.tag == "sweaters") {

					Destroy(collision.gameObject);

					score++;

					//keyAmount = FindObjectOfType<TextMeshProUGUI>();
					if (score < sweaters) {
						keyAmount.text = "Pisteitä: " + score;
					}
					else {
						keyAmount.text = "Voitit!";
					}

				}

			if(collision.gameObject.tag == "stairs") {

				//winner = FindObjectOfType<TextMeshProUGUI>();
				winner.text = "HIHI PELASTIT VILLAPAIDAT";
				
			}

				//using UnityEngine.SceneManagement eli tuodaan tuollainen luokka, jossa on tämmöinen toiminto
				//palaa siis aina alkuun jos osuu viholliseen
				if(collision.gameObject.tag == "enemies") {

					SceneManager.LoadScene(SceneManager.GetActiveScene().name);
					
				}

				//jos osut seinään
				//lisää seinälle ja pelaajalle rigibody2D ja boxcollider2D ja laita rigin gravi 0 ja infosta x,y ja z freeze. Pelaajalla pelkkä z!
				//tässä pomppaa seinästä
				/*if(collision.gameObject.tag == "walls") {

					if(Input.GetKey(KeyCode.LeftArrow)) {
		
						transform.Translate(speed * Time.deltaTime, 0, 0);

					}

					if(Input.GetKey(KeyCode.RightArrow)) {

						transform.Translate(-speed * Time.deltaTime, 0, 0);
					
					}

					if(Input.GetKey(KeyCode.UpArrow)) {

						transform.Translate(0, -speed * Time.deltaTime, 0);
						
					}

					if(Input.GetKey(KeyCode.DownArrow)) {

						transform.Translate(0, speed * Time.deltaTime, 0);
						
					}
				}*/
		}
}

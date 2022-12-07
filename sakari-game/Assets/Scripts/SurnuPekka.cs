using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurnuPekka : MonoBehaviour
{
		//public GameObject hello;
		public GameObject conversation;

		//tässä väliaikaisesti tämä
		public TextMeshProUGUI sweaterAmount;

		//tämä on keskusteluun liittyvä laskuri
		public int x;

		public TextMeshProUGUI conversationTXT;
		public GameObject cont;


    // Start is called before the first frame update
    void Start()
    {

			//hello.SetActive(false);
			conversation.SetActive(false);
			sweaterAmount.text = (GameManager.sweatersFound).ToString();
        
    }

		private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.gameObject.tag == "PekkaHouse") {

				//	hello.SetActive(true);

				StartCoroutine(waiter());

			}
		}

		 IEnumerator waiter() 
		 {
		 	yield return new WaitForSeconds(1);
		 	conversation.SetActive(true);
			Conversation();
		 }

		void Conversation() {

			switch (x)
			{
				case 0:
				conversationTXT.text = "Terve Sakari! Olen täällä puutarhalla!";
				break;

				case 1:
				conversationTXT.text = "Terve Surnu-Pekka! Onkos sinulla huolia?";
				break;

				case 2:
				conversationTXT.text = "Voi kuule, kyllä on! Ne p## myyrät on taas heränneet ja syövät kaikki naurikseni. ";
				break;

				case 3:
				conversationTXT.text = "Voi vitsi, koitappas pärjäillä!";
				cont.SetActive(false);
				break;
				
				default:
				conversationTXT.text = "juupajuu";
				break;
			}
		}

		public void ClickHappened() {
			x++;
			Debug.Log("arvo: " + x);
			Conversation();
		}

		public void Stop() {
			conversation.SetActive(false);
		}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurnuPekka : MonoBehaviour
{
		//public GameObject hello;
		public GameObject conversation;

    // Start is called before the first frame update
    void Start()
    {

			//hello.SetActive(false);
			conversation.SetActive(false);
        
    }

		private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.gameObject.tag == "PekkaHouse") {

				//hello.SetActive(true);

				StartCoroutine(waiter());

			}
		}

		 IEnumerator waiter() 
		 {
		 	yield return new WaitForSeconds(5);
		 	conversation.SetActive(true);
		 }
}

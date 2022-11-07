using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurnuPekka : MonoBehaviour
{
		public GameObject hello;
    // Start is called before the first frame update
    void Start()
    {

			hello.SetActive(false);
        
    }

		private void OnCollisionEnter2D(Collision2D collision) 
    {
      if(collision.gameObject.tag == "PekkaHouse") {

				hello.SetActive(true);

			}
		}
}

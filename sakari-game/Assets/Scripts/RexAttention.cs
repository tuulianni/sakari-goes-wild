using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RexAttention : MonoBehaviour
{
		public GameObject hello;
    // Start is called before the first frame update
    void Start()
    {
        hello.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Rex") {
					hello.SetActive(true);

					StartCoroutine(waiter());
				}
    }

		IEnumerator waiter() 
		 {
		 	yield return new WaitForSeconds(1);
		 	SceneManager.LoadScene("Rex");
		 }
}

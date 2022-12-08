using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopGame : MonoBehaviour
{
		public AudioSource oivoi;
		
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

		public void QuitGame()
		{
			oivoi.Play();
			StartCoroutine(waiter());
			 
		}

		
		IEnumerator waiter() {
			yield return new WaitForSeconds(0.3f);

			Application.Quit();;
		}


				
		

}

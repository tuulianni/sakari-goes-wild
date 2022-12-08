using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backtogame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
					StartCoroutine(waiter());
				}


		IEnumerator waiter() 
		 {
		 	yield return new WaitForSeconds(5);
		 	SceneManager.LoadScene("Rex");
		 }

}

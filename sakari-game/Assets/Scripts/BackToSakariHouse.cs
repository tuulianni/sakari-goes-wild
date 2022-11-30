using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BackToSakariHouse : MonoBehaviour
{
		public TextMeshProUGUI count;
    // Start is called before the first frame update
    void Start()
    {
				for (int i = 0; i <= GameManager.count; i++) {
					StartCoroutine(waiter());
					count.text = "+" + i;
					Debug.Log(i);
				}
				//count.text = "+" + (GameManager.count).ToString();

				Invoke("Action", 8.0f);
    }

		IEnumerator waiter() {
			yield return new WaitForSeconds(2);
		}

		public void Action()
    {
        SceneManager.LoadScene("HouseSakari");
				GameManager.count = 0;

    }


}

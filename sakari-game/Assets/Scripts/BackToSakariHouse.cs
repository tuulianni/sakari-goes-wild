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
				count.text = "+" + (GameManager.count).ToString();
				Invoke("Action", 8.0f);
    }

		public void Action()
    {
        SceneManager.LoadScene("HouseSakari");
				GameManager.count = 0;

    }


}

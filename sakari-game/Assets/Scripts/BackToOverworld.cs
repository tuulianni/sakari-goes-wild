using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BackToOverworld : MonoBehaviour
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
        SceneManager.LoadScene("Overworld");
				GameManager.count = 0;
    }
}

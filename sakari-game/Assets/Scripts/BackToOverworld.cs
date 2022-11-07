using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToOverworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
				Invoke("Action", 10.0f);
    }

		public void Action()
    {
        SceneManager.LoadScene("Overworld");
    }
}

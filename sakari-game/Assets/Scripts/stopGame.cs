using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

		public void QuitGame()
		{
				Application.Quit();
		}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int sweatersFound = 0;
    string[] SceneArr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

		public static void SweaterCounter() {

			sweatersFound++;
			Debug.Log("SweatersFound: " + sweatersFound);
		}
}

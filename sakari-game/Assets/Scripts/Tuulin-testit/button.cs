using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

	/*	public GameObject textBtnIsClicked;
		public GameObject textDelayAction;


    // Start is called before the first frame update

		private void Start() {
			textBtnIsClicked.SetActive(false);
			textDelayAction.SetActive(false);
		}
    public void OnMouseUp()
    {
        textBtnIsClicked.SetActive(true);
				Invoke("Action", 2.0f);
    }

		public void Action()
    {
        textDelayAction.SetActive(true);
    }*/
/*
	public GameObject LoadingScreen;
	public Image LoadingBarFill;
	
	void Start() 
	{
		LoadingScreen.SetActive(false);
	}
	public void LoadScene(int sceneId)
	{
		StartCoroutine(LoadSceneAsync(sceneId));
	}

	IEnumerator LoadSceneAsync(int sceneId)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

		LoadingScreen.SetActive(true);

		while (!operation.isDone)
		{
			float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

			LoadingBarFill.fillAmount = progressValue;

			yield return null;
		}
	}*/

}

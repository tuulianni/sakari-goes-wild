using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

		public GameObject textBtnIsClicked;
		public GameObject textDelayAction;


    // Start is called before the first frame update
    public void OnMouseUp()
    {
        textBtnIsClicked.SetActive(true);
    }

}

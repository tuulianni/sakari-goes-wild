using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Collectibles : MonoBehaviour
{
    private int bottles = 0;
    private int Sweaters = 0;

    public GameObject Flag;

    [SerializeField] private TextMeshProUGUI bottlesText;


void Update()
{
    if(bottles == 1) {
        Flag.SetActive(true);
    } 
    else {
        Flag.SetActive(false);
    }
}

private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bottle"))
            {
                Destroy(collision.gameObject);
                bottles++;
                
                bottlesText.text = "Bottles: " + bottles;
            }
        if (collision.gameObject.CompareTag("sweaters"))
            {
                Destroy(collision.gameObject);
                Sweaters++;

                //laita tämä rivi niihin villapaitoihin
                GameManager.SweaterCounter();
            }

        if (collision.gameObject.CompareTag("Flag"))
            {
                SceneManager.LoadScene("Overworld");
            }
    }
}

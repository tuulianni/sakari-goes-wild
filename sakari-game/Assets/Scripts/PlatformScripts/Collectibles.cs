using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectibles : MonoBehaviour
{
    private int bottles = 0;

    [SerializeField] private TextMeshProUGUI bottlesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bottle"))
            {
                Destroy(collision.gameObject);
                bottles++;

                //laita tämä rivi niihin villapaitoihin
                GameManager.SweaterCounter();
                bottlesText.text = "Bottles: " + bottles;
            }
    }
}

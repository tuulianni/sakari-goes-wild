using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int maxHealth = 10;
    public bool hasDied;

    [SerializeField] public AudioSource playerDeathSound;
    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position. y < -7) {
            hasDied = true;
            Die();
        }
        if (hasDied == true) {
            StartCoroutine ("Die");
        }
    }

    public void TakeDamage(int amount){

        health -= amount;
        if(health <= 0){
            
            hasDied = true;
            Die();
        }

    }

    IEnumerator Die () {

    
       playerDeathSound.Play();
        
        SceneManager.LoadScene("DeathScene");
        yield return null;
    }
}

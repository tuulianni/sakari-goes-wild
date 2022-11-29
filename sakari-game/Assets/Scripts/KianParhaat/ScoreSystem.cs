using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    private float timeLeft = 60;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    [SerializeField] private AudioClip Villis;

    
    void Update(){

        
        timeLeft-= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = ("Time: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = ("Score: " + playerScore);
        //Debug.Log (timeLeft);
        if (timeLeft < 0.1){
            SceneManager.LoadScene("Rex");

        }
    }

    void Start(){
      //  Villis = GetComponent<AudioSource>();
    }

    void CountScore(){
        playerScore = playerScore + (int)(timeLeft * 10);
        Debug.Log (playerScore);
    }
    void OnCollisionEnter2D (Collision2D colt){
       // Debug.Log("Player has collited with " + col.collider.name);
        if(colt.gameObject.tag == "audio"){
          
          SoundManager.instance.PlaySound(Villis);
        }
        
    }
    void OnTriggerEnter2D (Collider2D trig){
        if (trig.gameObject.tag == "Finish"){
        
        Debug.Log("End of Level");
        CountScore();
        }
        // }if(trig.gameObject.tag == "audio"){
            
        //     Villis.Play();
        // }
        
        if(trig.gameObject.tag == "sweaters"){

						GameManager.SweaterCounter();            
            playerScore += 10;
            Destroy(trig.gameObject);
            
        }
        
    }

    
}

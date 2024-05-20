using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class itemcollector : MonoBehaviour
{
    private Animator anim;

    private bool levelcompleted;
    public int points = 8;
    public int Points = 3;

    void Start()
    {
            levelcompleted = false;
        anim = GetComponent<Animator>();
        allTrophiesCollected = false;
    }
    [SerializeField] private TextMeshProUGUI Kiwitext;
    [SerializeField] private TextMeshProUGUI Trophietext;
    [SerializeField] private TextMeshProUGUI Timetext;
    private bool allTrophiesCollected = false;

    private float elapsedTime = 0f;



    /* void Update()
     {
         if (allTrophiesCollected == false)
         {
             elapsedTime += Time.deltaTime; // Uppdatera körtiden varje frame
             int minutes = Mathf.FloorToInt(elapsedTime / 60); // Beräkna minuter
             int seconds = Mathf.FloorToInt(elapsedTime % 60); // Beräkna sekunder
             Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
         }
         if (allTrophiesCollected == true)
         {
             elapsedTime += Time.deltaTime; // Uppdatera körtiden varje frame
             int minutes = Mathf.FloorToInt(elapsedTime / 60); // Beräkna minuter
             int seconds = Mathf.FloorToInt(elapsedTime % 60); // Beräkna sekunder
             Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
         }

     }*/
    void Update()
    {
        if (!allTrophiesCollected)
        {
            elapsedTime += Time.deltaTime; // Uppdatera körtiden varje frame
            int minutes = Mathf.FloorToInt(elapsedTime / 60); // Beräkna minuter
            int seconds = Mathf.FloorToInt(elapsedTime % 60); // Beräkna sekunder
/*            Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
*/        }
    }
    /*  private void time()
      {
          elapsedTime += Time.deltaTime; // Uppdatera körtiden varje frame
          int minutes = Mathf.FloorToInt(elapsedTime / 60); // Beräkna minuter
          int seconds = Mathf.FloorToInt(elapsedTime % 60); // Beräkna sekunder
          Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
      }*/


    private void OnTriggerEnter2D(Collider2D collision)
    {
    

        if (collision.CompareTag("Kiwi"))
        {
            points -= 1;
            Destroy(collision.gameObject);
            Kiwitext.text = "Fruits remaining: " + points;
        }
        else if (collision.CompareTag("Finish"))
        {
            Points -= 1;

            Destroy(collision.gameObject);
            Trophietext.text = "Trophies remaining:" + Points;

            finishSoundEffect.Play();

            if (Points == 0)
            {
                allTrophiesCollected = true;
                Debug.Log("hej");
            }
          
        }
        else if (collision.CompareTag("Fake"))
        {
            Points -= 1;

            Destroy(collision.gameObject);
         

            finishSoundEffect.Play();
         
        }
        {
            
        }
      
    }
    [Header("Audio")]
    [SerializeField] private AudioSource finishSoundEffect;


}






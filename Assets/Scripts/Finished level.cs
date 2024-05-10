using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Finishedlevel : MonoBehaviour

{
    public Animator anim;
    private AudioSource finishSound;
    private bool levelCompleted = true;

    [SerializeField] GameObject player;
    itemcollector itemcollector;


    public int enemyCount = 1;

    [SerializeField] private TextMeshProUGUI Enemytext;

    private float dirX;
    public Animator animator;
    private SpriteRenderer sprite;
    public int points = 8;

    [SerializeField] private TextMeshProUGUI Kiwitext;
  




void Start()
    {
        finishSound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        itemcollector = player.GetComponent<itemcollector>();

    }



        void Update()
        {

            //Debug.Log(enemyCount);
            //Debug.Log(levelCompleted);
            //Debug.Log(points);
            if (enemyCount == 0 && points == 0 && levelCompleted != true)
            {
                anim.SetTrigger("finished");
                finishSound.Play();
                levelCompleted = true;
                Debug.Log("finish");

                Invoke("LoadNxtLevel", 1f);

            }
        }
    /*  void Update()
     {
         // Check if enemyCount and points are 0, and if the level is not already completed
         if (enemyCount == 0 && points == 0 && !levelCompleted)
         {
             // Trigger animation
             if (anim != null)
                 anim.SetTrigger("finished");

             // Play finish sound
             if (finishSound != null)
                 finishSound.Play();

             // Mark level as completed
             levelCompleted = true;

             // Log message
             Debug.Log("Level completed");

             // Load next level after a delay
             Invoke("LoadNxtLevel", 1f);
         }
     }*/

    /* void CompleteLevel()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

     }*/

    /*public void LoadNextLevel()
    {
        // Get the index of the current active scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene, assuming it's the next scene in the build settings
        SceneManager.LoadScene(currentSceneIndex + 1);
    }*/
    public void LoadNextLevel()
    {
        // Get the index of the current active scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Ensure there is a next scene to load
        if (currentSceneIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            // Load the next scene
            Debug.Log("byt scen");
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            // Output a message indicating that there are no more scenes to load
            Debug.LogWarning("No more scenes to load. This might be the last level.");
        }
    }

    public void LoadNxtLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Kiwi"))
        {
            points -= 1;
            Destroy(collision.gameObject);
            Kiwitext.text = "Fruits remaining: " + points;
        }


    }
    void Die()
    {
        player.GetComponent<Finishedlevel>().enemyCount--;

        animator.SetBool("IsDead", true);
        Debug.Log("Died");
        GetComponent<Collider2D>().enabled = false;
/*        this.enabled = false;
*/        
        enemyCount -= 1;
        Enemytext.text = "Enemeis remaining: " + enemyCount;


    }


}


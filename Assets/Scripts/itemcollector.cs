using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;



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
    }
    [SerializeField] private TextMeshProUGUI Kiwitext;
    [SerializeField] private TextMeshProUGUI Trophietext;

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
            /*            anim.SetTrigger("finish");
            */
            /*levelcompleted = true;
            Invoke("Completlevel", 2f);*/
        }
        {
            
        }
       /* void Completlevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
*/
    }
    [Header("Audio")]
    [SerializeField] private AudioSource finishSoundEffect;


}



        
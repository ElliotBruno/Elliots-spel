using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if ((collision.gameObject.CompareTag("Player")))
        {
            Finishing();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void Finishing()
    {

        Debug.Log("Level finished!");


    }
}




//Takes you to the next level
/*using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Finishedlevel : MonoBehaviour

{
    public Animator anim;
    private AudioSource finishSound;
    private bool levelCompleted = false;
    [SerializeField] GameObject player;
    itemcollector itemcollector;
    public int enemyCount = 1;

    [SerializeField] private TextMeshProUGUI Enemytext;

    private float dirX;
    public Animator animator;
    private SpriteRenderer sprite;
    public int points = 6;

    [SerializeField] private TextMeshProUGUI Kiwitext;





    void Start()
    {
        finishSound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        itemcollector = player.GetComponent<itemcollector>();

    }
    void Update()
    {


        if (points == 0 && levelCompleted != true)
        {
            anim.SetTrigger("finished");
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);


        }
    }
    void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.CompareTag("Kiwi"))
        {
            points -= 1;
            Destroy(collision.gameObject);
            Kiwitext.text = "Fruits remaining: " + points;
        }

        if (collision.CompareTag("Player"))
        {
            CompleteLevel();
        }


    }





}

*/
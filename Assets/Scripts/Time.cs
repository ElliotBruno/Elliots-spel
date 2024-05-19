using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Timetext;

/*    public Text runtimeText; // Referens till Text-komponenten
 *    
*/    private float elapsedTime = 0f; // Variabel f�r att h�lla k�rtiden

    void Update()
    {
        elapsedTime += Time.deltaTime; // Uppdatera k�rtiden varje frame
        int minutes = Mathf.FloorToInt(elapsedTime / 60); // Ber�kna minuter
        int seconds = Mathf.FloorToInt(elapsedTime % 60); // Ber�kna sekunder
        Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
    }
}
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Timetext;

/*    public Text runtimeText; // Referens till Text-komponenten
 *    
*/    private float elapsedTime = 0f; // Variabel för att hålla körtiden

    void Update()
    {
        elapsedTime += Time.deltaTime; // Uppdatera körtiden varje frame
        int minutes = Mathf.FloorToInt(elapsedTime / 60); // Beräkna minuter
        int seconds = Mathf.FloorToInt(elapsedTime % 60); // Beräkna sekunder
        Timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Uppdatera texten
    }
}
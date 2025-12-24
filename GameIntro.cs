using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameIntro : MonoBehaviour
{
    // Logo y paneles de UI
    public GameObject logoPanel;
    public GameObject warningPanel;
    public GameObject controlsPanel;
    public float logoTime = 3f; // Duración del logo
    public float warningTime = 3f; // Duración de advertencia
    public float controlsTime = 4f; // Duración de controles

    // Audio
    public AudioSource introMusic;

    // Nombre de la primera escena
    public string firstSceneName = "Level1";

    void Start()
    {
        StartCoroutine(PlayIntro());
    }

    System.Collections.IEnumerator PlayIntro()
    {
        // Mostrar logo
        logoPanel.SetActive(true);
        introMusic?.Play();
        yield return new WaitForSeconds(logoTime);
        logoPanel.SetActive(false);

        // Mostrar advertencia
        warningPanel.SetActive(true);
        yield return new WaitForSeconds(warningTime);
        warningPanel.SetActive(false);

        // Mostrar controles
        controlsPanel.SetActive(true);
        yield return new WaitForSeconds(controlsTime);
        controlsPanel.SetActive(false);

        // Cargar la primera escena del juego
        SceneManager.LoadScene(firstSceneName);
    }
}
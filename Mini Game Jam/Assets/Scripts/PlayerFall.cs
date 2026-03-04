using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{   

    public GameObject pauseScreen;
    public AudioSource audioSource;
    public AudioClip scream;
    public GameObject trigger;
    public FPController fPController;
   

    void Start()
    {
        pauseScreen.SetActive(false);
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   
            pauseScreen.SetActive(true);
            audioSource.PlayOneShot(scream);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            fPController.lookSensitivity = 0f;
            fPController.isGameRunning = false;
           
        }

    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync("Level 1");
        fPController.isGameRunning = true;
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

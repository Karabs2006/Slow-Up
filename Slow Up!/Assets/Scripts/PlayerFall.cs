using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFall : MonoBehaviour
{   

    public GameObject loseScreen;
    public AudioSource audioSource;
    public AudioClip scream;
    public GameObject trigger;
    public FPController fPController;
    public LoadNextLevel loadNextLevel;
    public TimeAbility timeAbility;
    public string levelToRestart;
    public bool isGameResumed;
   
    void Start()
    {
        loseScreen.SetActive(false);
    }

    void Update()
    {
        if(fPController.ammo == 0 && !loadNextLevel.reachedEndPlatform)
        {
            GameLoss();
        }
        if(fPController.isGameRunning)
        {
            ResumeGame();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   
            audioSource.PlayOneShot(scream);
            GameLoss();
        }
    }

    public void Restart()
    {
        SceneManager.LoadSceneAsync(levelToRestart);
        fPController.isGameRunning = true;
        ResumeGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameLoss()
    {   
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        fPController.lookSensitivity = 0f;
        fPController.isGameRunning = false;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



}

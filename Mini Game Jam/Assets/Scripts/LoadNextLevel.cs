using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public string nextLevelName;
    public string levelToRestart;
    public GameObject winningScreen;
    public AudioSource winningAudioSource;
    public AudioClip winSound;
    public AudioSource backgroundAudioSource;
    public AudioClip backgroundAudioClip;

    void Start()
    {
        winningScreen.SetActive(false);
    }

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(nextLevelName);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        SceneManager.LoadSceneAsync(levelToRestart);
        Time.timeScale = 1f;
    }

    public void StopBackgroundMusic()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   
            winningScreen.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            winningAudioSource.PlayOneShot(winSound);
            backgroundAudioSource.Stop();
        
        }

    }



}

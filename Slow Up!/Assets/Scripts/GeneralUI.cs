using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralUI : MonoBehaviour
{
    public string levelName;

    public void LoadLevel()
    {
        SceneManager.LoadSceneAsync(levelName);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        
    }

    public void LoadControls()
    {
        
    }

}

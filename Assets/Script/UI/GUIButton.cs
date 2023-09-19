using UnityEngine.SceneManagement;
using UnityEngine;

public class GUIButton : MonoBehaviour
{
    
    public void Resume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Canceled()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Scene1");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}

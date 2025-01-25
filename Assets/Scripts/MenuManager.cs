using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject creditsWindow;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShowCreditsWindow()
    {
        creditsWindow.SetActive(true);
    }

    public void HideCreditsWindow()
    {
        creditsWindow.SetActive(false);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

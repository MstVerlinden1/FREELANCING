using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuButtons : MonoBehaviour
{
    [Header("References")]
    [SerializeField]private GameObject pauseMenu;
    [SerializeField] private CanvasGroup mainButtons;
    [SerializeField] private CanvasGroup optionsButtons;
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Options()
    {
        if (pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            mainButtons.interactable = true;
            EventSystem.current.firstSelectedGameObject = mainButtons.transform.GetChild(0).gameObject;
        }
        else if (!pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(true);
            mainButtons.interactable = false;
            EventSystem.current.firstSelectedGameObject = optionsButtons.transform.GetChild(0).gameObject;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}

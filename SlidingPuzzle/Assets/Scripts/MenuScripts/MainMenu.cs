using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class MainMenu : MonoBehaviour
{   
    int sceneIndex;
    float temp = 0;
    public string nextLevel;
    public GameObject loading;
    public Slider slider;
    public Text progressText;

    [SerializeField]
    protected PuzzleData puzzleData;
    public UnityEvent OnMainMenu;
    public void GoToLevel(string levelName)
    {
        StartCoroutine(LoadAsynchronously(levelName));
    }
    public void LoadGameLevel()
    {
        StartCoroutine(LoadAsynchronously("Arte1"));
    }
    IEnumerator LoadAsynchronously(string levelName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelName);

        loading.SetActive(true);

        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/0.9f);

            slider.value = progress * 100f;

            temp = progress * 100f;

            progressText.text = (int)temp + "%";

            yield return null;
        }
    }
    public void Menu()
    {
        Invoke("ActivateMainMenuAction", 1f);
    }
    public void IntroToMainMenu()
    {
        Invoke("ActivateMainMenuAction", 6);
    }
    public void ActivateMainMenuAction()
    {
        SceneManager.LoadScene (sceneIndex + 1);
    }
    public void ActivatePlayNextLevelAction()
    {
        StartCoroutine(LoadAsynchronously(nextLevel));
    }
    public void ActivateRestartLevelAction()
    {
        StartCoroutine(LoadAsynchronously(nextLevel));
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

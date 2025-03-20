using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManuManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject LevelsPanel;
    void Start()
    {
        SwitchPanelVisibility(MainMenuPanel, true);
        SwitchPanelVisibility(LevelsPanel, false);
    }


    private void SwitchPanelVisibility(GameObject gameObject, bool state)
    {
        gameObject.SetActive(state);
    }

    public void OnPlayPressed()
    {
        SwitchPanelVisibility(MainMenuPanel, false);
        SwitchPanelVisibility(LevelsPanel, true);
    }

    public void OnLevelOnePressed()
    {
        SceneManager.LoadScene(1);
    }

    public void OnLevelTwoPressed()
    {
        SceneManager.LoadScene(2);
    }

    public void OnBackPressed()
    {
        SwitchPanelVisibility(LevelsPanel, false);
        SwitchPanelVisibility(MainMenuPanel, true);
    }


    public void OnExitPressed()
    {
        Application.Quit();
    }
}

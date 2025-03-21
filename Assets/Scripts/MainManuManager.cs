using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.SceneManagement;

public class MainManuManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuPanel;
    [SerializeField] private GameObject LevelsPanel;

    private int currentLocaleIndex = 0;

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

        public void SwitchLanguage()
    {
        if (!LocalizationSettings.InitializationOperation.IsDone) 
        {
            Debug.LogWarning("Localization not initialized yet.");
            return;
        }

        // Get total number of locales
        int localeCount = LocalizationSettings.AvailableLocales.Locales.Count;
        
        // Cycle through locales (0 → 1 → 2 → 3 → back to 0)
        currentLocaleIndex = (currentLocaleIndex + 1) % localeCount;
        
        // Apply new locale
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLocaleIndex];

        Debug.Log("Switched to: " + LocalizationSettings.SelectedLocale.LocaleName);
    }
}

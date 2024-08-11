using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreenManager : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject tutorialPanel;
    public GameObject matchOptionsPanel;
    
    public void ShowTutorial()
    {
        mainMenuPanel.SetActive(false);
        tutorialPanel.SetActive(true);
    }

    // Method to switch back to the Main Menu screen
    public void ShowMainMenu()
    {
        tutorialPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void ShowMatchOptions() {
        mainMenuPanel.SetActive(false);
        matchOptionsPanel.SetActive(true);
    }
    public void ShowMainMenufromMatchOptions() {
        mainMenuPanel.SetActive(true);
        matchOptionsPanel.SetActive(false);
    }
    void Start()
    {
        mainMenuPanel.SetActive(true);
        tutorialPanel.SetActive(false);
        settingsPanel.SetActive(false);
        matchOptionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

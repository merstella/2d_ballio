using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField usernameInputField;
    public TMP_InputField passwordInputField;
    public TMP_Text loginResultText;
     // Optional: To display login results
    public UIScreenManager screenManager;
    // Method to handle the login process
    public void OnLoginButtonClick()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;

        // Simple check (you can replace this with actual authentication logic)
        if (username == "thangngu" && password == "123")
        {
            Debug.Log("Login Successful!");
            // Proceed to the next screen or game level
            if (screenManager != null) {
                screenManager.ShowMatchOptions();
            }
        }
        else
        {
            loginResultText.text = "Login Failed. Try Again.";
            StartCoroutine(ShowAnnouncement());
            Debug.Log("Login Failed.");
        }
    }
    private IEnumerator ShowAnnouncement()
    {
        loginResultText.gameObject.SetActive(true); // Show the text
        yield return new WaitForSeconds(2f);              // Wait for 10 seconds
        loginResultText.gameObject.SetActive(false); // Hide the text
    }
    // Start is called before the first frame update
    void Start()
    {
        loginResultText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

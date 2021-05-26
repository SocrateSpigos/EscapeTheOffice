using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Server : MonoBehaviour
{
    [SerializeField] GameObject welcomePanel;
    [SerializeField] Text user;

    [SerializeField] InputField username;
    [SerializeField] InputField password;

    [SerializeField] Text errorMesssages;

    [SerializeField] Button loginButton;
    [SerializeField] Button registrationButton;

    [SerializeField] string url;

    WWWForm form;

    public void OnRegistrationButtonClicked()
    {
        registrationButton.interactable = false;
        StartCoroutine(Registration());
    }
    public void OnLoginButtonClicked()
    {
        loginButton.interactable = false;
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        WWW w = new WWW(url, form);
        yield return w;

        if(w.error != null)
        {
            errorMesssages.text = "404 not found!";
        }
        else
        {
            if(w.isDone)
            {
                if(w.text.Contains("error"))
                {
                    errorMesssages.text = "invalid username or password!";
                }
                else
                {
                    welcomePanel.SetActive(true);
                    user.text = username.text;
                }
            }
        }

        loginButton.interactable = true;
        w.Dispose();
    }
    IEnumerator Registration()
    {
        form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);

        WWW w = new WWW(url, form);
        yield return w;

        if (w.error != null)
        {
            errorMesssages.text = "404 not found!";
        }
        else
        {
            if (w.isDone)
            {
                if (w.text.Contains("error"))
                {
                    errorMesssages.text = "invalid username or password!";
                }
                else
                {
                    welcomePanel.SetActive(true);
                    user.text = username.text;
                }
            }
        }

        registrationButton.interactable = true;
        w.Dispose();
    }
}

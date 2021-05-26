﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    public InputField usernameInput;
    public InputField passwordInput;
    public Button loginButton;

    // Start is called before the first frame update
    void Start()
    {
        loginButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.Login(usernameInput.text,passwordInput.text));
        });
    }

   
}

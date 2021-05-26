using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Registration : MonoBehaviour
{

    public InputField usernameInput;
    public InputField passwordInput;
    public Button registrationButton;

    // Start is called before the first frame update
    void Start()
    {
       registrationButton.onClick.AddListener(() =>
        {
            StartCoroutine(Main.Instance.Web.RegisterUser(usernameInput.text, passwordInput.text));
        });
    }
}

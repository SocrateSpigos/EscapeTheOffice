using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInsert : MonoBehaviour
{
    string URL = "http://localhost/escapetheoffice/userInsert.php";
    public string InputUsername, InputEmail, InputPassword;

    [System.Obsolete]
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddUser(InputUsername, InputEmail, InputPassword); 
        }
    }

    [System.Obsolete]
    public void AddUser(string username,string email ,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("addUsername",username);
        form.AddField("addEmail", email);
        form.AddField("addPassword", password);

        WWW www = new WWW(URL,form);
    }
}

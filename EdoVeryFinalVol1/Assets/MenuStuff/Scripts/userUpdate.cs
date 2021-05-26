using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userUpdate : MonoBehaviour
{
    string URL = "http://localhost/escapetheoffice/userUpdate.php";
    public string InputUsername, InputEmail, InputPassword,WhereField,WhereCondition;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            UpdateUser(InputUsername, InputEmail, InputPassword,WhereField,WhereCondition);
        }
    }
    public void UpdateUser(string username,string email,string password,string wF,string wC)
    {
        WWWForm form = new WWWForm();
        form.AddField("editUsername",username);
        form.AddField("editEmail", email);
        form.AddField("editPassword", password);

        form.AddField("whereField", wF);
        form.AddField("whereCondition", wC);

        WWW www = new WWW(URL, form);
    }
}

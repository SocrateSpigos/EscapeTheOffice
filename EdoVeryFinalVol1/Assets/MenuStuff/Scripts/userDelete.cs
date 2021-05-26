using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userDelete : MonoBehaviour
{
    string URL = "http://localhost/escapetheoffice/userDelete.php";
    public string WhereField, WhereCondition;
  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DeleteUser(WhereField, WhereCondition);
        }
    }
    public void DeleteUser(string wF, string wC)
    {
        WWWForm form = new WWWForm();
        
        form.AddField("whereField", wF);
        form.AddField("whereCondition", wC);

        WWW www = new WWW(URL, form);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterBase 
{


    public string UserName { get; set; }

    public string Password { get; set; }

    public  string RepeatPassword { get; set; }

    public string Email { get; set; }
    

    public void Register(Text _resultText)
    {
        PlayerPrefs.SetString("Email", Email);
        PlayerPrefs.SetString("Username", UserName);
        PlayerPrefs.SetString("Password", Password);

       
        _resultText.text = "Kayıt Başarılı";

    }

}

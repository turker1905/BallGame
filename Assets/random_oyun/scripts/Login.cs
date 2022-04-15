using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] InputField _username, _password;
    LoginBase _loginBase = new LoginBase();
    [SerializeField] Text _resultText;
    
    [SerializeField] Button _loginControllerButon;
    public void LoginOnClick()
    {
        _loginBase.Login(_username.text, _password.text, _resultText);
        

    }
    public void InputControllerLogin()
    {
        if (_username.text.Length < 5 || _password.text.Length < 6)
        {
            _loginControllerButon.interactable = false;
        }
        else
        {
            _loginControllerButon.interactable = true;
        }
    }


}

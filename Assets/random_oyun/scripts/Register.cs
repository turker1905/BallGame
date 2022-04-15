using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Register : MonoBehaviour
{
    [SerializeField] InputField _username, _email, _password, _repeatPassword;
    [SerializeField] Text _resultText;
    [SerializeField] Button _registerController;

  
    RegisterBase _registerBase = new RegisterBase();

    public void InputController()
    {
        if(_username.text.Length<5||_password.text!=_repeatPassword.text||_password.text.Length<6||_email.text.IndexOf('@')<0||_email.text.IndexOf('.')<0)
        {
            _registerController.interactable = false;
        }
        else
        {
            _registerController.interactable = true;
        }
    }

    public void RegisterOnClick ()
    {

        _registerBase.UserName = _username.text;
        _registerBase.Email = _email.text;
        _registerBase.Password = _password.text;
        _registerBase.RepeatPassword = _repeatPassword.text;

        _registerBase.Register(_resultText);


    }
    



}

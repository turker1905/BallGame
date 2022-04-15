using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLoginRegiterPanel : MonoBehaviour
{
    [SerializeField] GameObject _loginPanel, _registerPanel;


    private void Start()
    {
        SwicthPanel();
    }


    public void SwicthPanel()
    {
        switch (_registerPanel.activeInHierarchy)
        {
            case true:
                _registerPanel.SetActive(false);
                _loginPanel.SetActive(true);
                break;
            case false:
                _registerPanel.SetActive(true);
                _loginPanel.SetActive(false);
                break;
            default:
        }


    }






}

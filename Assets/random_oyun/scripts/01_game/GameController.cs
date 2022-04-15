using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Text _randomNumberText,_userListText;
    [SerializeField] InputField _username;
    int random;
    Dictionary<string, int> _userList = new Dictionary<string, int>();


    private void Start()
    {
        _username.text = PlayerPrefs.GetString("Username");
    }


    public void RandomTextOnClick()
    {
       random = Random.Range(1,100000);
        _randomNumberText.text = random.ToString();
    }

    public void SaveUserScore()
    {
        _userList.Add(PlayerPrefs.GetString("Username"),random);

    }
    public void GetUserList()
    {
        foreach (var item in _userList)
        {
            Debug.Log(item);
            _userListText.text = item.Key.ToString() + " " + item.Value.ToString();
           

        }

        

    }
    public void ChangeUserOnClick()
    {
        PlayerPrefs.SetString("Username",_username.text);

    }
       


}

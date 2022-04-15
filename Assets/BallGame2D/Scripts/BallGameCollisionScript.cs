using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGameCollisionScript : MonoBehaviour
{

    [SerializeField] GameObject _playerGO, _kol;
    [SerializeField] Rigidbody2D _playerRigid;
    [SerializeField] Text _gameOverText,_scoreText;
    [SerializeField] float _hiz = 10;
    int _score = 0;
    float _currentTime;
    int _random;
    int _saniye = 15;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(collision.gameObject);
            _score += 10;
            _scoreText.text = $"Score = {_score}";
        }


        if (collision.gameObject.CompareTag("sol"))
        {
            _random = Random.Range(2,2);
        }
        else if (collision.gameObject.CompareTag("ust"))
        {
            _random = Random.Range(1, 3);
        }
        else if (collision.gameObject.CompareTag("sag"))
        {
            _random = Random.Range(3,3);
        }
        else if (collision.gameObject.CompareTag("alt"))
        {
            _random = Random.Range(0,0);
        }

      

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Dusman"))
        //{
        //    Time.timeScale = 0;
        //    
        //}
    }

    private void FixedUpdate()
    {
        if (_random==0)
        {
            _playerRigid.velocity += Vector2.up * Time.deltaTime * _hiz;
        }
        else if (_random==1)
        {
            _playerRigid.velocity += Vector2.down * Time.deltaTime * _hiz;
        }
        else if (_random==2)
        {
            _playerRigid.velocity += Vector2.right * Time.deltaTime * _hiz;
        }
        else if (_random==3)
        {
            _playerRigid.velocity += Vector2.left * Time.deltaTime * _hiz;
        }

         _currentTime += Time.deltaTime;

        if (_currentTime > _saniye)
        {
            Time.timeScale = 0;
            _gameOverText.text = "Oyun Bitti" +" "+ _score;
        }

    }




}

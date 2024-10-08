using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : Observer
{

    [SerializeField]
    private Transform _tEnemy;

    float _timeUntilNextMove = 5.0f;
    float _currentTime = 0.0f;

    public float MoveSpeed = 0.25f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_currentTime < _timeUntilNextMove)
        {
            _currentTime += Time.deltaTime;
        }
        else
        {
            _tEnemy.position += new Vector3(0, -0.5f);
            _currentTime = 0.0f;
        }

    }

    public override void Notify(Subject subject)
    {
        if (subject.GetComponent<playerMovement>().isAlive() == false)
        {
            MoveSpeed = 0.0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<playerMovement>().setAlive(false);
        }

        if (collision.gameObject.name == "bullet")
        {
            Destroy(gameObject);
        }
    }
}

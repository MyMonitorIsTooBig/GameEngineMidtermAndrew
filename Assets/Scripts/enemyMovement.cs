using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
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
}

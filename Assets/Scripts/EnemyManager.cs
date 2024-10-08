using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    [SerializeField]

    GameObject[] _enemyArray;


    float _currentTime = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        _enemyArray = (GameObject.FindGameObjectsWithTag("Enemy"));
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        if(_currentTime >= 30.0)
        {
            foreach (GameObject enemy in _enemyArray)
            {
                enemy.GetComponent<enemyMovement>().MoveSpeed += 0.25f;
            }

            _currentTime = 0.0f;
        }
    }
}

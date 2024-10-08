using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : Subject
{

    [SerializeField]
    private Transform _tPlayer;

    public GameObject bulletPrefab;

    bool _isAlive = true;

    private void OnEnable()
    {
        foreach(GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            //Attach(enemy.GetComponent<enemyMovement>());
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isAlive)
        {
            if (Input.GetKeyDown(KeyCode.D) && _tPlayer.position.x > -8)
            {
                _tPlayer.position += new Vector3(1, 0);
            }

            if (Input.GetKeyDown(KeyCode.A) && _tPlayer.position.x < 8)
            {
                _tPlayer.position += new Vector3(-1, 0);
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {

                //firing code
                Instantiate(bulletPrefab, _tPlayer);
            }
        }
            
        
        
    }

    public bool isAlive()
    {
        return _isAlive;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            _isAlive = false;
            NotifyObservers();
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField]
    private Transform _tPlayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}

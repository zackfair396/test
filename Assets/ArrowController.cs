using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
        Destroy(gameObject);

        GameObject director = GameObject.Find("GameDirector");
        director.GetComponent<GameDirector>().DecreaseHP();


    }


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
       /* transform.Translate(0, -0.1f, 0); */

        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}

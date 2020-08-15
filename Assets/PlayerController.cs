using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public void LBottownDown()
    {
        transform.Translate(-3, 0, 0);
    }

    public void RBottownDown()
    {
        transform.Translate(3, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

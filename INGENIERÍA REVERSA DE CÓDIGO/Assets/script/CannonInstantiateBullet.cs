using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonInstantiateBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j"))
        {
            Clone();
        }
        if (Input.GetKey(KeyCode.K))
        {
            Clone();
        }
        if (Input.GetButton("Fire"))
        {

        }
    }
    void Clone()
    {
        Instantiate(bullet);
    }
}
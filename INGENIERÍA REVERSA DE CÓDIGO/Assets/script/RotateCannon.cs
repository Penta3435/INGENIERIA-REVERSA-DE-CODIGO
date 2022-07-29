using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCannon : MonoBehaviour
{
    [SerializeField] GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(center.transform.position, Vector3.right, 20 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(center.transform.position, Vector3.right, -20 * Time.deltaTime);
        }
    }
}

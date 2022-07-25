using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    [SerializeField] float speed = 20;
    float altura;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.forward * speed + Vector3.up * altura) * Time.deltaTime);
        altura = gameObject.transform.localPosition.y / gameObject.transform.localPosition.z;

        Destroy(this.gameObject,3);
    }
}

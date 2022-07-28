using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] float speed = 20;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        Destroy(this.gameObject,3);
    }
}

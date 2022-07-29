using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonInstantiateBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    float tiempo = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        // Puse esto porque no sé qué va a pasar si la variable tiempo no para de sumarse y se vuelve muy muy grande ¿pasaría algo?
        if (tiempo < 1)
        {
            tiempo += Time.deltaTime;
        }
        //

        //¿qué diferencia hay entre  Input.GetKeyDown("j")  y  Input.GetKeyDown(KeyCode.K)?
        //También encontré Input.GetButton(); pero no logré hacerlo funcionar, creo que hay que ir a input manager y hacer algo
        if (Input.GetKeyDown(KeyCode.J) && tiempo >= 1)
        {
            Invoke("Clone", 0f);
            Invoke("Clone", 0.3f);
            Invoke("Tiempo", 0.3f);
        }
        if (Input.GetKeyDown(KeyCode.K) && tiempo >= 1)
        {
            Invoke("Clone", 0f);
            Invoke("Clone", 0.3f);
            Invoke("Clone", 0.6f);
            Invoke("Tiempo", 0.6f);
        }
        if (Input.GetKeyDown(KeyCode.L) && tiempo >= 1)
        {
            Invoke("Clone", 0f);
            Invoke("Clone", 0.3f);
            Invoke("Clone", 0.6f);
            Invoke("Clone", 0.9f);
            Invoke("Tiempo", 0.9f);
        }
    }
    void Tiempo()
    {
        tiempo = 0f;
    }
    void Clone()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}
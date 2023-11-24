using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Vector3 position;
    [SerializeField] int speed;

    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.z -= speed * Time.deltaTime;
        transform.position = position;

        if (transform.position.z < -40)
        {
            Destroy(gameObject);
        }

    }
}

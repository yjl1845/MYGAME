using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YelloTruckSpeed : MonoBehaviour
{
    Vector3 position;
    [SerializeField] int speed;

    void Start()
    {
        position = transform.position;
        transform.rotation = Quaternion.Euler(0, 180, 0);
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

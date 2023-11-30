using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YelloTruck : MonoBehaviour
{
    float currTime;
    [SerializeField] GameObject Cart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        if (currTime > 8)
        {
            Instantiate(Cart, new Vector3((float)-6.380999, (float)0.07599998, (float)22.96), Quaternion.identity);
            currTime = 0;
        }
    }
}

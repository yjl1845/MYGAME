using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCartspawn : MonoBehaviour
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

        if (currTime > 4)
        {
            Instantiate(Cart, new Vector3((float)-1.042, (float)0.27, 40), Quaternion.identity);
            currTime = 0;
        }
    }
}

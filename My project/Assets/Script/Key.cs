using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject Door;

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(item);
            Destroy(Door);
            Debug.Log("USE KEY!");
        }
    }
}

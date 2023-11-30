using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject Final;

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(item);
            Final.SetActive(true);
            Debug.Log("USE KEY!");
        }
    }
}

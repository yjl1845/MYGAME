using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject DeathUI;
    [SerializeField] GameObject ClearUI;

    public float speed = 1f;
    private Rigidbody characterRigidbody;


    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            characterRigidbody.AddForce(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            characterRigidbody.AddForce(speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            characterRigidbody.AddForce(0, 0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            characterRigidbody.AddForce(0, 0, -speed);
        }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Enemy")
        {
            Destroy(player);
            DeathUI.gameObject.SetActive(true);
        }

        if (col.tag == "CartEnemy")
        {
            Destroy(player);
            DeathUI.gameObject.SetActive(true);
        }

        if (transform.position.z > 14)
        {
            Destroy(player);
            DeathUI.gameObject.SetActive(true);
        }

        if (col.tag == "Clear")
        {
            Destroy(player);
            ClearUI.gameObject.SetActive(true);
        }
    }
}

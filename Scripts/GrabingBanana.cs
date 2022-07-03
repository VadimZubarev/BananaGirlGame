using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabingBanana : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Amountcollected.Banana += 1;
            Destroy(gameObject);
        }
    }
}

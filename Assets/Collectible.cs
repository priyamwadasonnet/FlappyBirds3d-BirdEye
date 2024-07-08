using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public PlayerMovement speed;
    public Collision collision;

    private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "berries")
        {
            //player.GetComponent<PlayerMovement>().speed = 15;
            //Destroy(gameObject);
            Debug.Log("Berries");
        }

        if (other.tag == "melon")
        {
            //player.GetComponent<Collision>().increase(10);
            //Destroy(gameObject);
            Debug.Log("melon");
        }
    }
}

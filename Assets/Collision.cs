using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{

    public int maxHealth = 100;
    public HealthBar healthBar;

    private int curhealth;

    private void Start()
    {
        curhealth = maxHealth;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pipes")
        {
            takedamage(25);
        }
    }

    public void takedamage(int damage)
    {
        curhealth -= damage;
        healthBar.UpdateHealth((float)curhealth / (float)maxHealth);
    }

    public void increase(int incease)
    {
        curhealth += incease;
        healthBar.UpdateHealth((float)curhealth / (float)maxHealth);
    }

    private void Update()
    {

        if (curhealth == 0)
        {
            SceneManager.LoadScene(2);
        }
        else { return; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour {
    public GameObject player;
    public int health, maxHealth = 50;
    public Slider hpBar;
    public bool autoHeal = false;
    public float counter;

    // Use this for initialization
    void Start () {
        health = 100;
        player = GameObject.Find("FPSController");
    }
	
	// Update is called once per frame
	void Update () {
        hpBar.value = (float)health / (float)maxHealth;
        CheckEnd();
        CheckFall();
        AutoHeal();
    }

    public void Damage()
    {
        if (health > 0)
        {
            health -= 5;
        }
        else
        {
            health = 0;
        }
        
    }

    public void Heal()
    {
        if(health >= 100)
        {
            health += 10;
            Debug.Log(health);
        }
       else if (health >= 80)
        {
            health += 15;
            Debug.Log(health);
        }
        else if (health >= 60)
        {
            health += 20;
            Debug.Log(health);
        }
        else if (health >= 40)
        {
            health += 25;
            Debug.Log(health);
        }
        else if (health >= 20)
        {
            health += 30;
            Debug.Log(health);
        }
        else if (health <= 10)
        {
            health += 35;
            Debug.Log(health);
        }
    }

    public void AddHeal()
    {
       autoHeal = true;
    }

    public void AutoHeal()
    {
        if (autoHeal)
        {
            counter += Time.deltaTime;
            if (counter > 5)
            {
                if (health < 100)
                {
                    health += 5;
                    counter = 0;
                }
                else
                {
                    counter = 0;
                }
            }     
        } 
    }

    void CheckFall()
    {
        if (player.transform.position.y < -1f)
                {
                    health -= 5;
                }
    }

    void CheckEnd()
    {
       if (health <= 0)
        {
            SceneManager.LoadScene("asg01-gameover");
        }
    }
    public void GameOver()
    {
        health = 0;
    }

}

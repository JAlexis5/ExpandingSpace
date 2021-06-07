using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth;
    [SerializeField] public Image healthImage;


    public void HealingUp(float a)
    {
        if(playerHealth < 1)
        {
            playerHealth += a;
            healthImage.fillAmount = playerHealth;
        }
    }
    public void TakeDamage(float a) 
    {
        playerHealth -= a;
        healthImage.fillAmount = playerHealth;
    }

  

   
   


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth == 0)
        {
            Debug.Log("got put in a pack");
            SceneManager.LoadScene(1);


        }

    }
}
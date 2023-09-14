using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectCollision : MonoBehaviour
{
    private PlayerControll controll;
    // Start is called before the first frame update
    void Start()
    {
        controll = GameObject.Find("Player").GetComponent<PlayerControll>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name != "Player")
        {
           
            Destroy(gameObject);
            Destroy(other.gameObject);
           
            
        }
        if (gameObject.CompareTag("Animal"))
        {
            ScoreCouter();
        }
       
    }
    private void ScoreCouter()
    {
        if (gameObject.name == "Animal_Rooster_Brown(Clone)")
        {
            controll.AddScore(30);
        }
        else if (gameObject.name == "Animal_Horse_Black(Clone)")
        {
            controll.AddScore(15);
        }
        else if (gameObject.name == "Animal_Cow_Brown(Clone)")
        {
            controll.AddScore(10);
        }
        else
        {
            controll.AddScore(5);
        }
         
    }

}

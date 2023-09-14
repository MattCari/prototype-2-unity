using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverCollider : MonoBehaviour
{
    // Start is called before the first frame update
    private int counter;
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.name.Contains("Animal"))
        {
            counter++;
        }
        if (counter == 3)
        {
            Debug.Log("GameOver");
        }
    }
}

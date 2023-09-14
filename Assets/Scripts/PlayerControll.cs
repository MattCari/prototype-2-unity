using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalInput;
    public float verticalInput;
    private float moveSpeed = 20;
    private int score = 0;
    public GameObject projectile;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -24)
        {
            transform.position = new Vector3(-24, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > 24)
        {
            transform.position = new Vector3(24, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * moveSpeed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * moveSpeed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            var clone = Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("score:" + score);
    }
}

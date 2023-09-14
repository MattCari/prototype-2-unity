using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyClones : MonoBehaviour
{
    private float max = 34f;
    private float min = -18f;
    private float minX = -28f;
    private float maxX = 28f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > max || transform.position.x > maxX)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < min || transform.position.x < minX)
        {
;            Destroy(gameObject);
        }
    }
}

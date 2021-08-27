using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightoff : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Light")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Debug.Log("Destroy");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

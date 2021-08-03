using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int ritecont;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Light")
        StartCoroutine(Destroycont());
    }
     IEnumerator Destroycont()
    {
        yield return new WaitForSeconds(ritecont);
        Destroy(this.gameObject);
    }
}

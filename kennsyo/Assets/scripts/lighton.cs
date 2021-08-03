using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lighton : MonoBehaviour
{
    [SerializeField] GameObject raito;
    public GameObject off;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Light")
        {
            Debug.Log("enter");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        raito.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
           if (Input.GetKeyDown("z")) Lighton();                   
        
           if (Input.GetKeyDown("x")) Lightoff();      
    }
    public void Lighton()
    {
        raito.SetActive(true);
    }
    public void Lightoff()
    {
        Debug.Log("off");
        raito.SetActive(false);
    }
}

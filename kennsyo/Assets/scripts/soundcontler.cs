using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcontler : MonoBehaviour
{
    public AudioSource ASBG;
    public AudioSource ASE;
    public AudioClip[] AC;
    // Start is called before the first frame update
    void Start()
    {
        ASE.PlayOneShot(AC[6]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Ac1()
    {
        ASE.PlayOneShot(AC[1]);
    }
    public void Ac2()
    {
        ASE.PlayOneShot(AC[2]);
    }
    public void Ac3()
    {
        ASE.PlayOneShot(AC[3]);
    }
    public void Ac4()
    {
        ASE.PlayOneShot(AC[4]);
    }
    public void Ac5()
    {
        ASE.PlayOneShot(AC[5]);
    }
}

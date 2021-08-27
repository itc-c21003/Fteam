using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tateretu : MonoBehaviour
{
    private int tate;
    public Goll GetGoll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Tateretu()
    {
        tate++;
        if (tate == 5) GetGoll.BINGO();
    }
}

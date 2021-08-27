using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour
{    
    //ghost‚Ì“®‚«‚ðŽ~‚ß‚é
    bool stopped;
    public bool GetStopped()
    {
        return stopped;
    }
    public void OnStopped()
    {
        stopped = !stopped;
        Debug.Log(stopped);
    }


    // Start is called before the first frame update
    void Start()
    {
        stopped = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

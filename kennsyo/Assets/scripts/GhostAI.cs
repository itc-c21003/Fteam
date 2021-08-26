using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAI : MonoBehaviour
{
    public GhostMove Getstop;

    public float speed = 10f;
    float sp;
    private float rotationSmooth = 1f;
    public float levelSize = 55f;

    private Vector3 targetPosition;

    private float changeTargetSqrDistance = 40f;
    // Start is called before the first frame update
    public void Start()
    {
        targetPosition = GetRandomPositionOnLevel();
        Go();
    }
    // Update is called once per frame
    public void Update()
    {
        GhostMove();
    }
    public void GhostMove()
    {         

        // 目標地点との距離が小さければ、次のランダムな目標地点を設定する
        float sqrDistanceToTarget = Vector3.SqrMagnitude(transform.position - targetPosition);
        if (sqrDistanceToTarget < changeTargetSqrDistance)
        {
            targetPosition = GetRandomPositionOnLevel();
        }
       // 目標地点の方向を向く
        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

        // 前方に進む .抽選画面は止まる
        if (Getstop.GetStopped())
        { transform.Translate(Vector3.forward * sp * Time.deltaTime); }
    }
    public void Stop()
    {
        sp = 0;
    }
    public void Go()
    {
        sp = speed;
    }
    public Vector3 GetRandomPositionOnLevel()
    {      
        return new Vector3(Random.Range(-levelSize, levelSize), 0, Random.Range(-levelSize, levelSize)); 
    }
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Light")  Stop();
    }
    private void OnTriggerExit(Collider other)
    {
        Go();
    }
}

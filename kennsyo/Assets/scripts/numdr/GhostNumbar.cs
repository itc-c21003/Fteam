using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostNumbar : MonoBehaviour
{
    [SerializeField] GameObject Nos;

    public int start;
    public int end;

    public int Gnumbar;
    List<int> numbers = new List<int>();

    float BottonCount;

    public int Getnumbar()
    {
        return Gnumbar;
    }

    // Start is called before the first frame update
    void Start()
    {
        Nos.SetActive(false);
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void GhostNum()    
        {
        //ボタンを押したらランダムに数字を抽選、出た数字を消す
            int index = Random.Range(0, numbers.Count);
            Gnumbar = numbers[index];
            numbers.RemoveAt(index);

           Debug.Log(Gnumbar);
        BottonCount--;
        if(BottonCount <= 0) Nos.SetActive(false);

    }
    public void CountBotton()
    {
        BottonCount++;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goll : MonoBehaviour
{
    public GameObject goll;
    int naname1;
    int naname2;
    int Bingo;
    int By;
    int Iy;
    int Ny;
    int Gy;
    int Oy;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Naname()
    {
        naname1++;
        //斜めに揃えたらビンゴカウントを+1
        if (naname1 == 5) BINGO();
    }
    public void Naname2()
    {
        naname2++;
       if(naname2 ==5) BINGO();
    }
    //横に揃えたビンゴカウントを+1
    public void BY()
    {
        By++;
        if (By == 5) BINGO();
    }
    public void IY()
    {
        Iy++;
        if (Iy == 5) BINGO();
    }
    public void NY()
    {
        Ny++;
        if (Ny == 5) BINGO();
    }
    public void GY()
    {
        Gy++;
        if (Gy == 5) BINGO();
    }
    public void OY()
    {
        Oy++;
        if (Oy == 5) BINGO();
    }
    public void BINGO()
    {
        Bingo++;
        Debug.Log(Bingo + "Bingo");
        if (Bingo == 1) Instantiate(goll,transform.position, Quaternion.identity);
    }
    private void OnGUI()
    {
        string label = Bingo + "BINGO";
        GUI.Label(new Rect(50, 80, 100, 60), label);
    }
}

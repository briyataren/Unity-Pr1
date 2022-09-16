using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CommonScript : MonoBehaviour
{
    public Transform k1;
    public Transform k2;
    public Transform k3;
    public Transform k4;
    public Transform k5;
    public Transform k6;
    public Transform k7;
    public Transform k8;
    public Transform k9;
    public Transform k10;
    public Transform k11;
    public Transform k12;
    public Transform k13;
    public Transform k14;
    public Transform k15;
    public Transform k16;

    public string[,] bigArray = new string[4, 4];
    



    void LearnData(Transform a, int i, int h)
    {
        a.transform.position = new Vector3((float)i, (float)h, 0);
        bigArray[i, h] = a.name;
    }
    void CountData(Transform a, int i, List<int> Coord2)
    {
        System.Random rnd = new System.Random();
        int j = Coord2[rnd.Next(0, Coord2.Count - 1)];
        switch (j)
        {
            case 0:
                LearnData(a, i, j);
                Coord2.Remove(j);
                break;
            case 1:
                LearnData(a, i, j);
                Coord2.Remove(j);
                break;
            case 2:
                LearnData(a, i, j);
                Coord2.Remove(j);
                break;
            case 3:
                LearnData(a, i, j);
                Coord2.Remove(j);
                break;
        }
    }

    void FirstDatas()
    {
        List<int> Coord1 = new List<int>()
                  {0,1,2,3};

        for (int o = 0; o < 4; o++)
        {
            System.Random rnd = new System.Random();
            int i = Coord1[rnd.Next(0, Coord1.Count - 1)];
            switch (i)
            {
                case 0:
                    List<int> Coord6 = new List<int>()
                    {0,1,2,3};

                    CountData(k1, i, Coord6);
                    CountData(k2, i, Coord6);
                    CountData(k3, i, Coord6);
                    CountData(k4, i, Coord6);
                    Coord1.Remove(i);
                    break;
                case 1:
                    List<int> Coord3 = new List<int>()
                    {0,1,2,3};

                    CountData(k5, i, Coord3);
                    CountData(k6, i, Coord3);
                    CountData(k7, i, Coord3);
                    CountData(k8, i, Coord3);
                    Coord1.Remove(i);
                    break;
                case 2:
                    List<int> Coord4 = new List<int>()
                    {0,1,2,3};

                    CountData(k9, i, Coord4);
                    CountData(k10, i, Coord4);
                    CountData(k11, i, Coord4);
                    CountData(k12, i, Coord4);
                    Coord1.Remove(i);
                    break;
                case 3:
                    List<int> Coord5 = new List<int>()
                    {0,1,2,3};

                    CountData(k13, i, Coord5);
                    CountData(k14, i, Coord5);
                    CountData(k15, i, Coord5);
                    CountData(k16, i, Coord5);
                    Coord1.Remove(i);
                    break;
            }

        }

        Checking();
    }

    void Checking()
    {
        int[] checkArray = new int[16];
        int sum = 0;
        int ch = 0;
        for (int i = 3; i >= 0; i--)
        {
            for (int j = 0; j < 4; j++)
            {
                char MyChar = 'k' ;
                string arrayVal = bigArray[j,i].TrimStart(MyChar);
                int val = int.Parse(arrayVal);
                if (val>12)
                {
                    val = val - 12;
                } else if (val>8)
                {
                    val = val - 4;
                } else if (val>4)
                {
                    val = val + 4;
                } else
                {
                    val = val + 12;
                }

                int count = 0;

                if (val != 16)
                {

                    checkArray[ch] = val;
                    

                    for (int r = 0; r < 15; r++)
                    {
                        if ((checkArray[r] < val) && (checkArray[r] > 0))
                        {
                            count++;
                        }

                    }
                    sum = sum + val - 1 - count;
                } else
                {
                    switch(i)
                    {
                        case 3: 
                            sum = sum + 1;
                            break;
                        case 2:
                            sum = sum + 2;
                            break;
                        case 1:
                            sum = sum + 3;
                            break;
                        case 0:
                            sum = sum + 4;
                            break;
                    }
                }
                    
                

                
                
                ch++;
            }
        }
        Debug.Log(sum);
        if (sum % 2 != 0)
        {
            FirstDatas();
        }
    }




    void Start()
    {
        FirstDatas();
        
    }
    void Update()
    { 
     if (Input.GetKeyDown(KeyCode.Space))
        {
            FirstDatas();
        }
    }
}


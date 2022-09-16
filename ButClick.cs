using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ButClick : MonoBehaviour
{
    //[SerializeField] private CommonScript commonScript;
    public Transform k;
    [SerializeField] private Transform empty;
    [SerializeField] private CommonScript commonScript;

    public string[,] myArray = new string[4, 4];

    public int list = 1;






    void OnMouseDown()
    {

        
        myArray = commonScript.bigArray;

       
        



        if (k.position.y == empty.position.y)
            {
                if (k.position.x == empty.position.x + 1f)
                {
                    empty.transform.position = empty.transform.position + new Vector3(1f, 0, 0);
                    k.transform.position = k.transform.position + new Vector3(-1f, 0, 0);

                    myArray[(int)k.transform.position.x , (int)k.transform.position.y ] = k.name;
                    myArray[(int)empty.transform.position.x , (int)empty.transform.position.y ] = empty.name;

                   
            }
                else if (k.position.x == empty.position.x - 1f)
                {
                    empty.transform.position = empty.transform.position + new Vector3(-1f, 0, 0);
                    k.transform.position = k.transform.position + new Vector3(1f, 0, 0);

                    myArray[(int)k.transform.position.x, (int)k.transform.position.y] = k.name;
                    myArray[(int)empty.transform.position.x , (int)empty.transform.position.y] = empty.name;
                }

            }

            if (k.position.x == empty.position.x)
            {
                if (k.position.y == empty.position.y + 1f)
                {
                    empty.transform.position = empty.transform.position + new Vector3(0, 1f, 0);
                    k.transform.position = k.transform.position + new Vector3(0, -1f, 0);

                    myArray[(int)k.transform.position.x , (int)k.transform.position.y ] = k.name;
                    myArray[(int)empty.transform.position.x , (int)empty.transform.position.y ] = empty.name;
                }
                else if (k.position.y == empty.position.y - 1f)
                {
                    empty.transform.position = empty.transform.position + new Vector3(0, -1f, 0);
                    k.transform.position = k.transform.position + new Vector3(0, 1f, 0);

                    myArray[(int)k.transform.position.x , (int)k.transform.position.y ] = k.name;
                    myArray[(int)empty.transform.position.x , (int)empty.transform.position.y ] = empty.name;
                }

            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (myArray[j, i] == "k" + list.ToString())
                    {
                        list += 1;
                        if (list == 17)
                        {
                            Debug.Log("онаедю_онаедю_suuuuuuuuuuui");
                        }
                    }
                }
            }

            list = 1;
        }
}

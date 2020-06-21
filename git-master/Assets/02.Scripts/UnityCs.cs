using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnityCs : MonoBehaviour
{
    public int[] arr1;
    public int[] arr2;

    private void Start()
    {
        arr1 = new int[5];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = i;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            Debug.Log($"arr1.i = {arr1[i]}, arr2.i = {arr2[i]}");
        }
    }


}

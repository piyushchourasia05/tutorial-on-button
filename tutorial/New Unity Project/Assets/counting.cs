using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counting : MonoBehaviour
{
   public int n;
    public void OnButtonClick()
    {
        n++;
        Debug.Log("Button clicked " + n + " times.");
    }
}

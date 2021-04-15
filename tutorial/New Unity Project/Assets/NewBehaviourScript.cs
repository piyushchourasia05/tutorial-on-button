using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource Nature;
    public void playClip()
    {
        Nature = GetComponent<AudioSource>();
        Nature.Play(); 
    }
}

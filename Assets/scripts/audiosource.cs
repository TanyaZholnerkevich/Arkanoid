using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosource : MonoBehaviour
{
    public static audiosource Instance;
    [SerializeField] public AudioSource audio_blocks;
    [SerializeField] public AudioSource audio_border;
    [SerializeField] public AudioSource audio_platform;
    
    private void Awake()
    {
        Instance = this;
    }
  
}

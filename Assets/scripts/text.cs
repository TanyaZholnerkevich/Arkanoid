using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public static text Instance;
    [SerializeField] public Text score;
    [SerializeField] public Text result;
    void Awake()
    {
        Instance = this;
    }
}

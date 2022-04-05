using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{ 

    [SerializeField] private AudioClip _clip;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
    }
}

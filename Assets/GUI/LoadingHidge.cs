using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingHidge : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void LoadingHidg()
    {
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void OnEnable()
    {
        Invoke(nameof(LoadingHidg),0.5f);
    }
}

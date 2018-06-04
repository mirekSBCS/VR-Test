using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

    [SerializeField]public bool IsSpinning;

    private void Start()
    {
        IsSpinning = false;
    }

    private void Update()
    {
        if(IsSpinning == true)
        {
            transform.Rotate(new Vector3(0, 60, 0));
        }
    }
    // Use this for initialization
    public void SpinTime()
    {
        IsSpinning = true;
    }

    public void SpinTimeIsOver()
    {
        IsSpinning = false;
    }
}

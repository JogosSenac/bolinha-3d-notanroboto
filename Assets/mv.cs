using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mv : MonoBehaviour
{

    [SerializedField] private float speedY;
    [SerializedField] private float speedX;
    public float velocidade;
    private MeshRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Empezar : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI
        Tiempo;
    public float TiempoAvanza;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiempoAvanza = TiempoAvanza + Time.deltaTime;
        Debug.Log(Tiempo);
        Tiempo.text = TiempoAvanza.ToString("00");
    }
}

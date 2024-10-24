using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Personajes : MonoBehaviour
{
    [SerializeField] GameObject BadGuy;
    [SerializeField] GameObject BadGuy2;
    [SerializeField] GameObject GoodGuy;
    [SerializeField] GameObject Lady;
    [SerializeField] GameObject Sheriff;

    //public BadGuy prefab;
    public bool BadGuyActive;
    public bool BadGuy2Active;
    public bool GoodGuyActive;
    public bool LadyActive;
    public bool SheriffActive;

    [SerializeField]
    TextMeshProUGUI
    Tiempo;
    public float TiempoAvanza;
    // Start is called before the first frame update
    void Start()
    {

        BadGuy.SetActive(false);
        if(TiempoAvanza == 5) 
        {
            BadGuyActive = true;
                if(BadGuyActive == true)
                {
                BadGuy.SetActive(true);
                var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
                }
        }

        BadGuy2.SetActive(false);
        if (TiempoAvanza == 3)
        {
            BadGuy2Active = true;
            if (BadGuy2Active == true)
            {
                BadGuy2.SetActive(true);
                var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            }
        }

        GoodGuy.SetActive(false);
        if (TiempoAvanza == 4)
        {
            GoodGuyActive = true;
            if (GoodGuyActive == true)
            {
                GoodGuy.SetActive(true);
                var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            }
        }

        Lady.SetActive(false);
        if (TiempoAvanza == 8)
        {
            LadyActive = true;
            if (LadyActive == true)
            {
                Lady.SetActive(true);
                var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            }
        }

        Sheriff.SetActive(false);
        if (TiempoAvanza == 10)
        {
            SheriffActive = true;
            if (SheriffActive == true)
            {
                Sheriff.SetActive(true);
                var position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        TiempoAvanza = TiempoAvanza + Time.deltaTime;
        Debug.Log(Tiempo);
        Tiempo.text = TiempoAvanza.ToString("00");
    }
}

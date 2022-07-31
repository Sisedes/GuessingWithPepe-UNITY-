using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class kontrol : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int tahmin;
    [SerializeField] TextMeshProUGUI tahminmetni;
    [SerializeField] int can;
    [SerializeField] TextMeshProUGUI can�;
    
    public void basla()
    {
        max = 1500; min = 0; can = 9;
        can�.text = can.ToString();
        tahmin = Random.Range(0, 1500);
        tahminmetni.text = tahmin.ToString();
    }
    public void SonrakiTahmin()
    {
        tahmin = Random.Range(min,max);
        tahminmetni.text = tahmin.ToString();
    }
    public void artt�r()
    {
        if (max == min)
        {
            SceneManager.LoadScene(2);
        }
        min = tahmin + 1;
        can--;
        can�.text = can.ToString();
        if (can == 0) { SceneManager.LoadScene(3); }
        SonrakiTahmin();
    }
    public void azalt()
    {
        if (max == min)
        {
            SceneManager.LoadScene(2);
        }
        max = tahmin - 1;
        can--;
        can�.text = can.ToString();
        if (can == 0) { SceneManager.LoadScene(3); }
        SonrakiTahmin();
    }
    void Start()
    {
        basla();
        
    }

    
}

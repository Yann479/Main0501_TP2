using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Stockage : MonoBehaviour
{
    public TextMeshPro NbStocke;
    private int NbObjet = 0;

    // Start is called before the first frame update    
    void Start()
    {
        if (NbStocke == null)
        {
            NbStocke = GetComponent<TextMeshPro>();
        }

        if (NbStocke == null)
        {
            NbStocke = transform.Find("TexteCompteur")?.GetComponent<TextMeshPro>();
        }

        UpdateStocke();
    }

    private void OnTriggerEnter(Collider other)
    {
        NbObjet++;
        UpdateStocke();
    }

    private void OnTriggerExit(Collider other)
    {
        NbObjet--;
        UpdateStocke();
    }

    void UpdateStocke()
    {
        if (NbStocke != null)
        {
            NbStocke.text = "Blocs " + NbObjet/2;
        }
    }
}

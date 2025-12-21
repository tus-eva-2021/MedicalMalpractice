using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MM_MainUI : MonoBehaviour
{
    public Image kent;
    public Image markus;
    public Image nikola;
    public TMP_Text kentName;
    public TMP_Text markusName;
    public TMP_Text nikolaName;
    public bool kentON = false;
    public bool markusON = false;
    public bool nikolaON = false;

    void Start()
    {
        markusON = true;
    }

    
    void Update()
    {
        if (kentON == true) 
        {
            markusON = false;
            nikolaON = false;
            kent.enabled = true;
            kentName.enabled = true;
        }
        else
        {
            kent.enabled = false;
            kentName.enabled = false;
        }

        if (markusON == true)
        {
            kentON = false;
            nikolaON = false;
            markus.enabled = true;
            markusName.enabled = true;
        }
        else
        {
            markus.enabled = false;
            markusName.enabled = false;
        }

        if (nikolaON == true)
        {
            kentON = false;
            markusON = false;
            nikola.enabled = true;
            nikolaName.enabled = true;
        }
        else
        {
            nikola.enabled = false;
            nikolaName.enabled = false;
        }
    }
}

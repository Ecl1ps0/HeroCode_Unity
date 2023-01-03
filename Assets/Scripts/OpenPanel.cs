using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void ShowPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
}

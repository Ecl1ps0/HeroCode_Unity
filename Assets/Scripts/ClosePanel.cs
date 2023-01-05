using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    public void HidePanel()
    {
        if(panel != null)
        {
            panel.SetActive(false);
        }
    }
}

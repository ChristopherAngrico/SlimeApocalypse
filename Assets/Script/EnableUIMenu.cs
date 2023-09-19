using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableUIMenu : MonoBehaviour
{
    [SerializeField] private GameObject g_menu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !g_menu.activeSelf)
        {
            Time.timeScale = 0;
            g_menu.SetActive(true);
        }
    }
}

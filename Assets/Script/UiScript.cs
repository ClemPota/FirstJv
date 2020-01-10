using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Life;

    public void DisplayLife()
    {
        PlayerStatsScript playerLifeScript = gameObject.GetComponentInParent<PlayerStatsScript>();
        Debug.Log(playerLifeScript.CurrentLife);
        Life.text = "Life :" + playerLifeScript.CurrentLife + "";
    }
}
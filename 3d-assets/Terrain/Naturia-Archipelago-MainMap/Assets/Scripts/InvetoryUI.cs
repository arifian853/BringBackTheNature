using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvetoryUI : MonoBehaviour
{
    private TextMeshProUGUI seedText;
    // Start is called before the first frame update
    void Start()
    {
        seedText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSeedText(PlayerInventory playerInventory)
    {
        seedText.text = playerInventory.NumberOfSeed.ToString();
    }

}

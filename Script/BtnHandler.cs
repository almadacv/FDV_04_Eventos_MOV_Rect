using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnHandler : MonoBehaviour
{
    public void UpdateBtnTxtColor()
    {
        Button Btn = GetComponent<Button>();
        PlayerMov playercomp = GameObject.Find("Player").GetComponent<PlayerMov>();
        TextMeshProUGUI BtnTxt = Btn.GetComponentInChildren<TextMeshProUGUI>();
        Image imgButton = Btn.GetComponent<Image>();

        if (Btn.GetComponentInChildren<TextMeshProUGUI>().text == "Velocidad Turbo")
        {
            BtnTxt.text = "Velocidad Normal";
            imgButton.color = Color.blue;
            playercomp.SetSpeedMov();
        }
        else
        {
            BtnTxt.text = "Velocidad Turbo";
            imgButton.color = Color.yellow;
            playercomp.SetSpeedMov();
        }
    }


}

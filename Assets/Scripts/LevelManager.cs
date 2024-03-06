using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public TMP_Text waveText;

    public async void Started()
    {
        waveText.text = "Wave started";
        await new WaitForSeconds(2f);
        waveText.text = "";
    }
    public void Ended()
    {
        //print("ended");
    }
}

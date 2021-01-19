using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextReconnaisance : MonoBehaviour
{
    public List<string> textCmd;
    private string playerTextInput;

    public InputField inputField;
    private int actualCode = 0;
    public int codeToReach = 0;

    public Text hackText;



    private void Update()
    {
        if (actualCode < codeToReach)
        {
            hackText.text = textCmd[actualCode];
            if (playerTextInput == textCmd[actualCode])
            {
                Debug.Log("Victoire");
                inputField.text = "";
                actualCode++;
            }
        }
        else
        {
            //Détruit l'inputField
        }
    }

    public void GetTextInput(string texte)
    {
        Debug.Log(texte);
        playerTextInput = texte;

    }



}

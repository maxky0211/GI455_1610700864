using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class word : MonoBehaviour
{
    public GameObject inputField;
    public GameObject textDisplay;
    string inPutkey;

    public void StoreName()
    {

        inPutkey = inputField.GetComponent<Text>().text;
        {
            if (inPutkey == "Red")
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is found ";
            }
            else if (inPutkey == "Blue")
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is found ";
            }
            else if (inPutkey == "Green")
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is found ";
            }
            else if (inPutkey == "Yellow")
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is found ";
            }
            else if (inPutkey == "Black")
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is found ";
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "[" + inPutkey + "]" + " is not found ";
            }



        }
    }
}

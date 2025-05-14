using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParOImpar : MonoBehaviour
{
    public TMP_InputField inputNum1;
    public TextMeshProUGUI txtParOIMpar;
    int num1;
    // Start is called before the first frame update
    void Start()
    {
        txtParOIMpar.text = string.Empty;

    }
    public void ESparONo()
    {
        if (inputNum1.text == "")
        {
            return;
        }

        num1 = int.Parse(inputNum1.text);

        if (num1 <= 0)
        {
            txtParOIMpar.text = "El numero debe ser mayor que cero";
            return;
        }
        if (num1 % 2 == 0)
        {
            txtParOIMpar.text = "El numero es par";

        }

        else
        {
            txtParOIMpar.text = "El numero es impar";
        }
    }
}
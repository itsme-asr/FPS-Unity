using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI prompTXT;
    public void UpdateText(string promptmsg)
    {
        prompTXT.text = promptmsg;
    }
}

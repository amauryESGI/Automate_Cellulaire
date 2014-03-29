using UnityEngine;
using System.Collections;

public class mainInterface : MonoBehaviour
{
    private string affichage;

    private void Start() {
        affichage = "3D";
    }

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(20, 20, Screen.width - 40, Screen.height - 40));
        
        if (GUI.Button(new Rect(0, 0, 35, 25), affichage)) {
            if (affichage == "3D") {
                affichage = "2D";
            } else {
                affichage = "3D";
            }
        }
    }
}

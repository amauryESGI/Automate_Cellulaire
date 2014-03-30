using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.Data;

public class mainInterface : MonoBehaviour {
    public struct plan3D {
        public int x;
        public int y;
        public int z;
    }

    //myGestionaireRegles gestionRegles;
    //DataTable m_dt;

    private string affichagePlan, affichageRegle, affichageCustom;
    private plan3D pos;
    private plan3D sizeMin;

    private List<myRegle> regle2D;

    private void Start() {
        //gestionRegles = new myGestionaireRegles();
        //m_dt = new DataTable();

        affichagePlan = "3D";
        affichageRegle = "Rules";
        affichageCustom = "Custom";

        pos.x = 25;
        pos.y = 25;
        pos.z = 25;

        sizeMin.x = 25;
        sizeMin.y = 25;
        sizeMin.z = 25;

        regle2D = new List<myRegle>();

        #region regle de test
        Color colorMasque = new Color(0, 0, 0, 255);
        Color[] colorTmp = new Color[9];

        colorTmp[0] = Color.black;
        colorTmp[1] = colorMasque;
        colorTmp[2] = colorMasque;
        colorTmp[3] = Color.black;
        colorTmp[4] = Color.black;
        colorTmp[5] = Color.black;
        colorTmp[6] = colorMasque;
        colorTmp[7] = colorMasque;
        colorTmp[8] = colorMasque;
        regle2D.Add(new myRegle(colorTmp));

        colorTmp[0] = colorMasque;
        colorTmp[1] = colorMasque;
        colorTmp[2] = colorMasque;
        colorTmp[3] = Color.black;
        colorTmp[4] = colorMasque;
        colorTmp[5] = Color.black;
        colorTmp[6] = colorMasque;
        colorTmp[7] = colorMasque;
        colorTmp[8] = colorMasque;
        regle2D.Add(new myRegle(colorTmp));
        
        colorTmp[0] = colorMasque;
        colorTmp[1] = colorMasque;
        colorTmp[2] = colorMasque;
        colorTmp[3] = colorMasque;
        colorTmp[4] = Color.white;
        colorTmp[5] = Color.black;
        colorTmp[6] = colorMasque;
        colorTmp[7] = colorMasque;
        colorTmp[8] = colorMasque;
        regle2D.Add(new myRegle(colorTmp));

        colorTmp[0] = Color.black;
        colorTmp[1] = Color.black;
        colorTmp[2] = Color.black;
        colorTmp[3] = Color.black;
        colorTmp[4] = Color.white;
        colorTmp[5] = colorMasque;
        colorTmp[6] = colorMasque;
        colorTmp[7] = colorMasque;
        colorTmp[8] = colorMasque;
        regle2D.Add(new myRegle(colorTmp));
        #endregion regle de test
    }

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(20, 20, Screen.width - 40, Screen.height - 40));

        if (affichageRegle == "Rules")
        {
            if (GUI.Button(new Rect(10, 10, 35, 25), affichagePlan))
            {
                if (affichagePlan == "3D")
                {
                    affichagePlan = "2D";
                }
                else
                {
                    affichagePlan = "3D";
                }
            }

            if (affichagePlan == "2D")
            {
                // Position
                GUI.BeginGroup(new Rect(60, 10, 100, 100));
                GUI.Box(new Rect(0, 0, 100, 100), "SIZE");

                GUI.Label(new Rect(15, 24, 17, 20), "X :");
                pos.x = analiseInteger(myGUI.verifTextIsInteger(GUI.TextArea(new Rect(40, 25, 40, 19), pos.x.ToString()), sizeMin.x, 25), pos.x);

                GUI.Label(new Rect(15, 46, 17, 20), "Y :");
                pos.y = analiseInteger(myGUI.verifTextIsInteger(GUI.TextArea(new Rect(40, 48, 40, 19), pos.y.ToString()), sizeMin.y, 25), pos.y);

                GUI.Label(new Rect(15, 67, 17, 20), "Z :");
                pos.z = analiseInteger(myGUI.verifTextIsInteger(GUI.TextArea(new Rect(40, 70, 40, 19), pos.z.ToString()), sizeMin.z, 25), pos.z);

                GUI.EndGroup();
                
                #region comboBox
                //ComboBox comboBoxControl = new ComboBox();
                //GUIStyle listStyle = new GUIStyle();

                //GUIContent[] comboBoxList = new GUIContent[3];
                //comboBoxList[0] = new GUIContent("Carre");
                //comboBoxList[1] = new GUIContent("Hexagone");
                //comboBoxList[2] = new GUIContent("Image");
                
                //listStyle.normal.textColor = Color.white; 
                //listStyle.onHover.background = 
                //listStyle.hover.background = new Texture2D(2, 2);
                //listStyle.padding.left = 
                //listStyle.padding.right = 
                //listStyle.padding.top = 
                //listStyle.padding.bottom = 4;
                //int selectedItemIndex = comboBoxControl.GetSelectedItemIndex();

                //selectedItemIndex = comboBoxControl.List( 
                //    new Rect(180, 10, 100, 20), comboBoxList[selectedItemIndex].text, comboBoxList, listStyle );
                //GUI.Label(new Rect(50, 70, 400, 21),
                //  "You picked " + comboBoxList[selectedItemIndex].text + "!");
                myComboBox comboBoxControl = new myComboBox(new Rect(180, 10, 100, 20));
                comboBoxControl.addItemToList("Carre");
                comboBoxControl.addItemToList("Hexagone");
                comboBoxControl.addItemToList("Image");
                #endregion comboBox
            }
            else
            {
                // Position
                GUI.BeginGroup(new Rect(60, 10, 100, 80));
                GUI.Box(new Rect(0, 0, 100, 80), "SIZE");

                GUI.Label(new Rect(15, 24, 17, 20), "X :");
                pos.x = analiseInteger(myGUI.verifTextIsInteger(GUI.TextArea(new Rect(40, 25, 40, 19), pos.x.ToString()), sizeMin.x, 25), pos.x);

                GUI.Label(new Rect(15, 46, 17, 20), "Y :");
                pos.y = analiseInteger(myGUI.verifTextIsInteger(GUI.TextArea(new Rect(40, 48, 40, 19), pos.y.ToString()), sizeMin.y, 25), pos.y);

                GUI.EndGroup();
            }
        }
        else
        {
            // !3D = 2D : Affichage du mode 2D
            if (affichagePlan == "3D")
            {
                if (affichageCustom == "Custom")
                {
                    if (GUI.Button(new Rect(Screen.width - 270, Screen.height - 65, 70, 25), "Custom"))
                    {
                        if (affichageCustom == "Custom")
                        {
                            affichageCustom = "Back";
                        }
                        else
                        {
                            affichageCustom = "Custom";
                        }
                    }


                } // !2D = 3D : Affichage du mode 3D
                else { }
            }
            else
            {
            }
        }

        if (GUI.Button(new Rect(Screen.width - 190, Screen.height - 65, 60, 25), affichageRegle))
        {
            if (affichageRegle == "Rules")
            {
                affichageRegle = "Back";
            }
            else if (affichageCustom == "Back")
            {
                affichageCustom = "Custom";
            }
            else
            {
                affichageRegle = "Rules";
            }
        }

        if (GUI.Button(new Rect(Screen.width - 120, Screen.height - 65, 50, 25), "Run")){
            Debug.Log("Run");
        }

        GUI.EndGroup();
    }

    #region Ressource

    private int analiseInteger(int newVal, int OldVal) {
        int valRetour = OldVal;

        if (newVal > 0)
            valRetour = newVal;

        return valRetour;
    }

    #endregion Ressource
}

using UnityEngine;

public static class myGUI {

#region verifTextIsInteger
    
	/// <summary>
	///     Fonction qui permet de déterminer si le text d'entrer peut-être convertie en integer.
	/// </summary>
	/// <param name="text">Un string, élément étudié.</param>
	/// <returns>Retourne si possible un int qui correspond à la string <c>text</c> entrée sinon -1.</returns>
    public static int verifTextIsInteger(string text) {

        foreach (char lettre in text)
            if (lettre < 0x30 || lettre > 0x39)
                return -1;

        return int.Parse(text);
    }
	
	/// <summary>
	///     Fonction qui permet de déterminer si le text d'entrer peut-être convertie en integer.
    /// </summary>
    /// <param name="text">Un string, élément étudié.</param>
    /// <param name="text">Un int permetant de connaitre l'intervale de nombre autorisé.</param>
	/// <returns>Retourne si possible un int qui correspond à la string <c>text</c> entrée sinon -1.</returns>
    public static int verifTextIsInteger(string text, int interval) {

        foreach (char lettre in text)
            if (lettre < 0x30 || lettre > 0x39)
                return -1;

        int valRetour = int.Parse(text);

        if (valRetour > interval)
            valRetour = -1;

        return valRetour;
    }
	
	/// <summary>
	///     Fonction qui permet de déterminer si le text d'entrer peut-être convertie en integer.
	/// </summary>
    /// <param name="text">Un string, élément étudié.</param>
    /// <param name="text">Un int permetant de connaitre la valeur min de nombre autorisé.</param>
    /// <param name="text">Un int permetant de connaitre l'intervale de nombre autorisé.</param>
	/// <returns>Retourne si possible un int qui correspond à la string <c>text</c> entrée sinon -1.</returns>
    public static int verifTextIsInteger(string text, int min, int interval = 0) {

        foreach (char lettre in text)
            if (lettre < 0x30 || lettre > 0x39)
                return -1;

        int valRetour = int.Parse(text);

        if (valRetour < min && valRetour > interval+min)
            valRetour = -1;

        return valRetour;
    }

#endregion verifTextIsInteger

}

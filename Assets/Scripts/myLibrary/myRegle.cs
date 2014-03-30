using UnityEngine;

public class myRegle
{
    private int m_TTL;
    private int m_vieMax;
    private Color[] m_etatColor;
    private Color m_final;

    public myRegle(Color[] etatColor, int vieMax = 1)
    {
        m_vieMax = vieMax;
        m_TTL = vieMax;
        m_etatColor = etatColor;
    }

    public void setVieMax(int vieMax)
    {
        m_vieMax = vieMax;
    }

    public int getVieMax()
    {
        return m_vieMax;
    }

    public void setTTL(int TTL)
    {
        m_TTL = TTL;
    }

    public int getTTL()
    {
        return m_TTL;
    }

    public void setEtatColor(Color[] etatColor)
    {
        m_etatColor = etatColor;
    }

    public Color[] getEtatColor()
    {
        return m_etatColor;
    }

    public void setFinalColor(Color finalColor)
    {
        m_final = finalColor;
    }

    public Color getFinalColor()
    {
        return m_final;
    }

    public void setColor(Color color, int i)
    {
        m_etatColor[i] = color;
    }

    public Color getColor(int i)
    {
        return m_etatColor[i];
    }

    public int getNbColor(Color color){
        int nb = 0;

        for (int i = 0; i<9; i++)
            if (m_etatColor[i]==color && i!=4)
                nb++;

        return nb;
    }

    public int[] getPosColor(Color color){
        int[] pos = new int[8];
        int nb = 0;

        for (int i = 0; i<9; i++)
            if (m_etatColor[i] == color && i != 4){
                pos[nb++] = i;
            }

        return pos;
    }
}

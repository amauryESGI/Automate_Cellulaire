using UnityEngine;

using System.Data;
using System.Collections.Generic;

public class myGestionaireRegles
{
    private int m_TTL;
    private int m_vieMax;
    private Color[] m_etatColor;
    private Color m_final;

    private myGestionaireSQLiteDatabase m_bdd;
//    private DataTable m_dt;
//    private Dictionary<string, string> data;

    public myGestionaireRegles()
    {
        m_bdd = new myGestionaireSQLiteDatabase();
//        m_dt = new DataTable();
//        data = new Dictionary<string, string>();
    }

    public DataTable getLois(string typeRegle)
    {
        return m_bdd.GetDataTable("SELECT id_loi, name FROM lois WHERE id_typeRegle = '" + typeRegle + "' ORDER BY name ASC");
    }

    public DataTable getLoi(int id)
    {
        return m_bdd.GetDataTable("SELECT * FROM lois WHERE id_typeRegle = '" + id + "' ORDER BY name ASC");
    }

    public DataTable getRegles(string typeRegle)
    {
        return m_bdd.GetDataTable("SELECT id_regle, name FROM '" + (m_bdd.GetDataTable("SELECT id_regle FROM typeRegle WHERE name = '" + typeRegle + "' ORDER BY name ASC")).Rows[0][0].ToString() + "' ORDER BY name ASC");
    }

    public DataTable getRegle(int id, string typeRegle)
    {
        return m_bdd.GetDataTable("SELECT * FROM '" + (m_bdd.GetDataTable("SELECT id_regle FROM typeRegle WHERE name = '" + typeRegle + "' ORDER BY name ASC")).Rows[0][0].ToString() + "' WHERE id_Regle = '" + id + "' ORDER BY name ASC");
    }

    public DataTable getColors()
    {
        return m_bdd.GetDataTable("SELECT id_regle, name FROM couleurs ORDER BY name ASC");
    }

    public DataTable getColor(int id)
    {
        return m_bdd.GetDataTable("SELECT id_regle, name FROM couleurs WHERE id_Couleur = '" + id + "' ORDER BY name ASC");
    }

    public DataTable getTypesRegle()
    {
        // app la bonne tab
        return m_bdd.GetDataTable("SELECT id_typeRegle, name FROM typesRegle ORDER BY name ASC");
    }
}

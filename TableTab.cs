using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTab : MonoBehaviour,ITab
{
    public void ShowContent(IDatabase db)
    {
       // db.getData();
       (db as ITDB).GetTables();
       Debug.Log("Showing tables");
    }
}

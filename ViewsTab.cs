using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewsTab : MonoBehaviour,ITab
{
    public void ShowContent(IDatabase db)
    {
        (db as IVDb).GetViews();
        Debug.Log("Showing Views");
    }
}

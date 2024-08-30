using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilesTab : MonoBehaviour, ITab
{
    public void ShowContent(IDatabase db)
    {
        //(db as IFDb).GetFiles();
        (db as IFDb).GetFiles();
        Debug.Log("Showing files");
    }
}

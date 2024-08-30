using UnityEngine;
using UnityEngine.UI;

public class TabsController : MonoBehaviour
{
    [SerializeField] private GameObject _tabPanel;
    [SerializeField] private Toggle _fileTab;
    [SerializeField] private Toggle _viewsTab;
    [SerializeField] private Toggle _tableTab;

    private IDatabase db = new DataBase();
    
    [SerializeField] private FilesTab _filesTab;
    [SerializeField] private ViewsTab _viewTab;
    [SerializeField] private TableTab _tablesTab;
    
    private void Awake()
    {
        db.Connect();
        // _fileTab.onValueChanged.AddListener((arg => ShowTab(_filesTab, db)));
        // _viewsTab.onValueChanged.AddListener((arg => ShowTab(_viewTab, db )));
        // _tableTab.onValueChanged.AddListener((arg => ShowTab(_tablesTab, db)));
        
        _fileTab.onValueChanged.AddListener((check =>
        {
            if(check)
                ShowTab(_filesTab, db);
            else 
                _fileTab.onValueChanged.RemoveAllListeners();
        } ));
        
        _viewsTab.onValueChanged.AddListener((check =>
        {
            if(check)
                ShowTab(_viewTab, db);
            else 
                _viewsTab.onValueChanged.RemoveAllListeners();
        }));
        
        _tableTab.onValueChanged.AddListener((check =>
        {
            if(check)
                ShowTab(_tablesTab, db);
            else 
                _tableTab.onValueChanged.RemoveAllListeners();
        } ));
        
    }

    private void ShowTab(ITab tab, IDatabase db)
    {
        tab.ShowContent(db);
        CheckPanelActivation();    
    }
    
    private void CheckPanelActivation()
    {
        if (_tabPanel.activeInHierarchy)
        {
            _tabPanel.SetActive(false);
        }
        else
        {
            _tabPanel.SetActive(true);
        }
    }
    
    private void OnDestroy()
    {
        db.Close();
    }
}
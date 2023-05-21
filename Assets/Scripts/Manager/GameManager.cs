using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const string DefaultName = "GameManager";
    private static GameManager instance;
    public static DataManager dataManager;

    public static GameManager Instance  { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        InitDataManagers();
        DontDestroyOnLoad(this);
        instance = this;
    }

    private void OnDestroy()
    {
        if(instance == this)
        {
            instance = null;
        }
    }

    private void InitDataManagers()
    {
        GameObject dataManager = new GameObject() { name = "DataManager" };
        dataManager.transform.SetParent(transform);
        GameManager.dataManager = dataManager.AddComponent<DataManager>();
    }
}

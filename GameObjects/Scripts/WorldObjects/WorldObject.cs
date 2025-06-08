using UnityEngine;

public abstract class WorldObject : MonoBehaviour
{
    private static int _currentId = 0;

    [SerializeField] private string _name;
    [SerializeField] private int _id;
    [SerializeField] private GameObject _prefab;

    public string DisplayName => _name;
    public int ID => _id;
    public GameObject Prefab => _prefab;

    protected virtual void Awake()
    {
        _id = ++_currentId;
    }
}


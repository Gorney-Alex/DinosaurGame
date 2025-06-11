using UnityEngine;

public class WorldObject : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _id;
    [SerializeField] private ObjectType _type;

    public string Name => _name;
    public int Id => _id;
    public ObjectType Type => _type;
}
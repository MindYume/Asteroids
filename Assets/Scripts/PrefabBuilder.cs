using UnityEngine;

public class PrefabBuilder
{
    public static GameObject Instantiate(GameObject _prefab, Vector3 position, Quaternion rotation)
    {
        return GameObject.Instantiate(_prefab, position, rotation);
    }
}
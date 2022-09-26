# Kogane Game Object Component Collection Extension Method

GameObject と Component の配列やリストに関する拡張メソッド

## 使用例

```csharp
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    public GameObject[] m_gameObjectArray;
    public Transform[]  m_transformArray;

    private void Awake()
    {
        m_gameObjectArray.DestroyAll();
        m_gameObjectArray.DestroyImmediateAll();
        m_transformArray.DestroyImmediateAll();
        m_transformArray.DestroyImmediateAll();
    }
}
```
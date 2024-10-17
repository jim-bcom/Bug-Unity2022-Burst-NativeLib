using UnityEngine;

#if ENABLE_WINMD_SUPPORT
using TestPlugin;
#endif

public class TestNativePlugin : MonoBehaviour
{
#if ENABLE_WINMD_SUPPORT
        private TestPluginClass testPluginClass;
#endif

    uint cpt = 0;

    void Start()
    {
#if ENABLE_WINMD_SUPPORT
        cpt = testPluginClass.add(1, 2);
#endif
    }

    void Update()
    {
        
    }
}

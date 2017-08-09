/**************************************************
*MonoBehaviour 事件函数执行接口
***************************************************/

using UnityEngine ;
using System.Collections;
public class MonoFuctions : MonoBehaviour
{
    public static void _StartCoroutine(IEnumerator coroutine)
    {
        // StartCoroutine(coroutine);
    }

    public static void _StopCoroutine(string coroutine)
    {
        // StopCoroutine(coroutine);
    }

    
    void Awake()
    {
        
    }
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        
    }

    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    void OnDestroy()
    {
        
    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        
    }
    /// <summary>
    /// Callback sent to all game objects before the application is quit.
    /// </summary>
    void OnApplicationQuit()
    {
        
    }
    /// <summary>
    /// Callback sent to all game objects when the player pauses.
    /// </summary>
    /// <param name="pauseStatus">The pause state of the application.</param>
    void OnApplicationPause(bool pauseStatus)
    {
        
    }
}
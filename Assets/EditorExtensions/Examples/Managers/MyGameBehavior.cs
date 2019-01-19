using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// A MonoBehavior that has caches of the important managers used in the game
/// </summary>
public class MyGameBehavior : MonoBehaviour {

    protected CachedComponent<BlankGameManager> _gameManager = new CachedComponent<BlankGameManager>();
    protected BlankGameManager gameManager
    {
        get
        {
            return _gameManager.instance(this);
        }
    }

    protected CachedComponent<BlankInputManager> _inputManager = new CachedComponent<BlankInputManager>();
    protected BlankInputManager inputManager
    {
        get
        {
            return _inputManager.instance(this);
        }
    }

    protected CachedComponent<BlankNetworkManager> _networkManager = new CachedComponent<BlankNetworkManager>();
    protected BlankNetworkManager networkManager
    {
        get
        {
            return _networkManager.instance(this);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        _gameManager.clear();
        _inputManager.clear();
        _networkManager.clear();
    }
}

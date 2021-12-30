using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AppController : MonoBehaviour
{
    public UIDocument ui;
    private VisualElement _root;
    private void OnEnable()
    {
        _root = ui.rootVisualElement;
        _root.Q<Button>("quit-button").clickable.clicked += () =>
        {

            Debug.Log("Quit button clicked.");
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

// GENERATED AUTOMATICALLY FROM 'Assets/MyFirstInput.inputactions'

[System.Serializable]
public class InputOfTheYear : UnityEngine.Experimental.Input.InputActionWrapper
{
    private bool m_Initialized;
    private void Initialize()
    {
        // HelloActionMap
        m_HelloActionMap = asset.GetActionMap("HelloActionMap");
        m_HelloActionMap__HelloTouchAction = m_HelloActionMap.GetAction("HelloTouchAction");
        m_Initialized = true;
    }
    // HelloActionMap
    private UnityEngine.Experimental.Input.InputActionMap m_HelloActionMap;
    private UnityEngine.Experimental.Input.InputAction m_HelloActionMap__HelloTouchAction;
    public struct HelloActionMapActions
    {
        private InputOfTheYear m_Wrapper;
        public HelloActionMapActions(InputOfTheYear wrapper) { m_Wrapper = wrapper; }
        public UnityEngine.Experimental.Input.InputAction @_HelloTouchAction { get { return m_Wrapper.m_HelloActionMap__HelloTouchAction; } }
        public UnityEngine.Experimental.Input.InputActionMap Get() { return m_Wrapper.m_HelloActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public UnityEngine.Experimental.Input.InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator UnityEngine.Experimental.Input.InputActionMap(HelloActionMapActions set) { return set.Get(); }
    }
    public HelloActionMapActions @HelloActionMap
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new HelloActionMapActions(this);
        }
    }
}

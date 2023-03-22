public interface IInputHandler
{
    float GetAxis(string axisName);
    bool GetButtonDown(string buttonName);
}
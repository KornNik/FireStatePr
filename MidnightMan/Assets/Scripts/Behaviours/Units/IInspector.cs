namespace Behaviours
{
    interface IInspector
    {
        void StartInspection(IInspectable inspectable);
        void StopInspection(IInspectable inspectable);
    }
}

using Behaviours.Units;

namespace Behaviours
{
    sealed class PlayerInspector : IInspector
    {
        public PlayerInspector(UnitModel unitModel)
        {

        }

        public void StartInspection(IInspectable inspectable)
        {
            inspectable.Inspect();
        }

        public void StopInspection(IInspectable inspectable)
        {
            inspectable.StopInspect();
        }
    }
}
